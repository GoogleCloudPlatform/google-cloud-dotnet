﻿/*
    MIT License

    Copyright(c) 2014-2018 Infragistics, Inc.

    Permission is hereby granted, free of charge, to any person obtaining a copy
    of this software and associated documentation files (the "Software"), to deal
    in the Software without restriction, including without limitation the rights
    to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
    copies of the Software, and to permit persons to whom the Software is
    furnished to do so, subject to the following conditions:

    The above copyright notice and this permission notice shall be included in all
    copies or substantial portions of the Software.

    THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
    IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
    FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
    AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
    LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
    OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
    SOFTWARE.
*/

using Mono.Cecil;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BreakingChangesDetector.MetadataItems
{
	/// <summary>
	/// Represents the metadata for an externally visible constant field.
	/// </summary>
	public sealed class ConstantData : TypedMemberDataBase
	{
		#region Constructors

		internal ConstantData(string name, MemberAccessibility accessibility, MemberFlags memberFlags, TypeData type, bool isTypeDynamic, object value)
			: base(name, accessibility, memberFlags, type, isTypeDynamic)
		{
			this.Value = value;
		}

		private ConstantData(FieldDefinition fieldDefinition, MemberAccessibility accessibility, DeclaringTypeData declaringType)
			: base(fieldDefinition, accessibility, fieldDefinition.FieldType, fieldDefinition.IsDynamicType(), MemberFlags.Static, declaringType)
		{
			this.Value = Utilities.PreprocessConstantValue(fieldDefinition.FieldType, fieldDefinition.Constant);
		}

		#endregion // Constructors

		#region Base Class Overrides

		#region Accept

		/// <summary>
		/// Performs the specified visitor's functionality on this instance.
		/// </summary>
		/// <param name="visitor">The visitor whose functionality should be performed on the instance.</param>
		public override void Accept(MetadataItemVisitor visitor)
		{
			visitor.VisitConstantData(this);
		}

		#endregion // Accept

		#region CanOverrideMember

#if DEBUG
		/// <summary>
		/// Indicates whether the current member can override the specified member from a base type.
		/// </summary>
		/// <param name="baseMember">The member from the base type.</param>
		/// <returns>True if the current member can override the base member; False otherwise.</returns> 
#endif
		internal override bool CanOverrideMember(MemberDataBase baseMember)
		{
			Debug.Fail("Constants cannot be overridden.");
			return false;
		}

		#endregion // CanOverrideMember

		#region DoesMatch

		internal override bool DoesMatch(MetadataItemBase other)
		{
			if (base.DoesMatch(other) == false)
				return false;

			var otherTyped = other as ConstantData;
			if (otherTyped == null)
				return false;

			if (Object.Equals(this.Value, otherTyped.Value))
				return false;

			return true;
		}

		#endregion // DoesMatch

		#region MetadataItemKind

		/// <summary>
		/// Gets the type of item the instance represents.
		/// </summary>
		public override MetadataItemKinds MetadataItemKind
		{
			get { return MetadataItemKinds.Constant; }
		}

		#endregion // MetadataItemKind

		#region ReplaceGenericTypeParameters

#if DEBUG
		/// <summary>
		/// Replaces all type parameters used by the member with their associated generic arguments specified in a constructed generic type.
		/// </summary>
		/// <param name="genericParameters">The generic parameters being replaced.</param>
		/// <param name="genericArguments">The generic arguments replacing the parameters.</param>
		/// <returns>A new member with the replaced type parameters or the current instance if the member does not use any of the generic parameters.</returns> 
#endif
		internal override MemberDataBase ReplaceGenericTypeParameters(GenericTypeParameterCollection genericParameters, GenericTypeArgumentCollection genericArguments)
		{
			var replacedType = (TypeData)this.Type.ReplaceGenericTypeParameters(genericParameters, genericArguments);
			if (replacedType == this.Type)
				return this;

			Debug.Fail("It was assumed that constants cannot be generic");
			return new ConstantData(this.Name, this.Accessibility, this.MemberFlags, replacedType, this.IsTypeDynamic, this.Value);
		}

		#endregion // ReplaceGenericTypeParameters

		#endregion // Base Class Overrides

		#region Methods

		internal static MemberDataBase ConstantDataFromReflection(FieldDefinition fieldDefinition, DeclaringTypeData declaringType)
		{
			var accessibility = fieldDefinition.GetAccessibility();
			if (accessibility == null)
				return null;

			return new ConstantData(fieldDefinition, accessibility.Value, declaringType);
		}

		#endregion // Methods

		#region Properties

		/// <summary>
		/// Gets the compiled constant value.
		/// </summary>
		public object Value { get; private set; } // TODO_Serialize: Round trip and unit test

		#endregion // Properties
	}
}
