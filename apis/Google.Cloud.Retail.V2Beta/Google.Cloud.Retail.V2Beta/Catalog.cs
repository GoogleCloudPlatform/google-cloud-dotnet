// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/retail/v2beta/catalog.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Retail.V2Beta {

  /// <summary>Holder for reflection information generated from google/cloud/retail/v2beta/catalog.proto</summary>
  public static partial class CatalogReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/retail/v2beta/catalog.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CatalogReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvY2xvdWQvcmV0YWlsL3YyYmV0YS9jYXRhbG9nLnByb3RvEhpn",
            "b29nbGUuY2xvdWQucmV0YWlsLnYyYmV0YRocZ29vZ2xlL2FwaS9hbm5vdGF0",
            "aW9ucy5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90bxoZ",
            "Z29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byJQChJQcm9kdWN0TGV2ZWxDb25m",
            "aWcSGwoTZXZlbnRfcHJvZHVjdF9sZXZlbBgBIAEoCRIdChVwcmVkaWN0X3By",
            "b2R1Y3RfbGV2ZWwYAiABKAki8AEKB0NhdGFsb2cSFAoEbmFtZRgBIAEoCUIG",
            "4EEC4EEFEhwKDGRpc3BsYXlfbmFtZRgCIAEoCUIG4EEC4EEFElEKFHByb2R1",
            "Y3RfbGV2ZWxfY29uZmlnGAQgASgLMi4uZ29vZ2xlLmNsb3VkLnJldGFpbC52",
            "MmJldGEuUHJvZHVjdExldmVsQ29uZmlnQgPgQQI6XupBWwodcmV0YWlsLmdv",
            "b2dsZWFwaXMuY29tL0NhdGFsb2cSOnByb2plY3RzL3twcm9qZWN0fS9sb2Nh",
            "dGlvbnMve2xvY2F0aW9ufS9jYXRhbG9ncy97Y2F0YWxvZ31C1QEKHmNvbS5n",
            "b29nbGUuY2xvdWQucmV0YWlsLnYyYmV0YUIMQ2F0YWxvZ1Byb3RvUAFaQGdv",
            "b2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvY2xvdWQvcmV0",
            "YWlsL3YyYmV0YTtyZXRhaWyiAgZSRVRBSUyqAhpHb29nbGUuQ2xvdWQuUmV0",
            "YWlsLlYyQmV0YcoCGkdvb2dsZVxDbG91ZFxSZXRhaWxcVjJiZXRh6gIdR29v",
            "Z2xlOjpDbG91ZDo6UmV0YWlsOjpWMmJldGFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Retail.V2Beta.ProductLevelConfig), global::Google.Cloud.Retail.V2Beta.ProductLevelConfig.Parser, new[]{ "EventProductLevel", "PredictProductLevel" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Retail.V2Beta.Catalog), global::Google.Cloud.Retail.V2Beta.Catalog.Parser, new[]{ "Name", "DisplayName", "ProductLevelConfig" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Configures what level the product should be uploaded with regards to
  /// how users will be send events and how predictions will be made.
  /// </summary>
  public sealed partial class ProductLevelConfig : pb::IMessage<ProductLevelConfig>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ProductLevelConfig> _parser = new pb::MessageParser<ProductLevelConfig>(() => new ProductLevelConfig());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProductLevelConfig> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Retail.V2Beta.CatalogReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductLevelConfig() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductLevelConfig(ProductLevelConfig other) : this() {
      eventProductLevel_ = other.eventProductLevel_;
      predictProductLevel_ = other.predictProductLevel_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductLevelConfig Clone() {
      return new ProductLevelConfig(this);
    }

    /// <summary>Field number for the "event_product_level" field.</summary>
    public const int EventProductLevelFieldNumber = 1;
    private string eventProductLevel_ = "";
    /// <summary>
    /// The level of a [Catalog][google.cloud.retail.v2beta.Catalog] at which the
    /// [UserEvent][google.cloud.retail.v2beta.UserEvent]s are uploaded. Acceptable
    /// values are:
    ///   * `primary`
    ///   * `variant`
    ///
    /// If this field is set to an invalid value other than these, an
    /// INVALID_ARGUMENT error is returned.
    ///
    /// If this field is `primary` and
    /// [predict_product_level][google.cloud.retail.v2beta.ProductLevelConfig.predict_product_level]
    /// is `variant`, an INVALID_ARGUMENT error is returned.
    ///
    /// See
    /// https://cloud.google.com/recommendations-ai/docs/catalog#catalog-levels
    /// for more details.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string EventProductLevel {
      get { return eventProductLevel_; }
      set {
        eventProductLevel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "predict_product_level" field.</summary>
    public const int PredictProductLevelFieldNumber = 2;
    private string predictProductLevel_ = "";
    /// <summary>
    /// The level of a [Catalog][google.cloud.retail.v2beta.Catalog] at which the
    /// [PredictionService.Predict][google.cloud.retail.v2beta.PredictionService.Predict]
    /// is called. Acceptable values are:
    ///   * `primary`
    ///   * `variant`
    ///
    /// If this field is set to an invalid value other than these, an
    /// INVALID_ARGUMENT error is returned.
    ///
    /// If this field is `variant` and
    /// [event_product_level][google.cloud.retail.v2beta.ProductLevelConfig.event_product_level]
    /// is `primary`, an INVALID_ARGUMENT error is returned.
    ///
    /// See
    /// https://cloud.google.com/recommendations-ai/docs/catalog#catalog-levels
    /// for more details.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PredictProductLevel {
      get { return predictProductLevel_; }
      set {
        predictProductLevel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProductLevelConfig);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProductLevelConfig other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (EventProductLevel != other.EventProductLevel) return false;
      if (PredictProductLevel != other.PredictProductLevel) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (EventProductLevel.Length != 0) hash ^= EventProductLevel.GetHashCode();
      if (PredictProductLevel.Length != 0) hash ^= PredictProductLevel.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (EventProductLevel.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(EventProductLevel);
      }
      if (PredictProductLevel.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PredictProductLevel);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (EventProductLevel.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(EventProductLevel);
      }
      if (PredictProductLevel.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(PredictProductLevel);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (EventProductLevel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EventProductLevel);
      }
      if (PredictProductLevel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PredictProductLevel);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProductLevelConfig other) {
      if (other == null) {
        return;
      }
      if (other.EventProductLevel.Length != 0) {
        EventProductLevel = other.EventProductLevel;
      }
      if (other.PredictProductLevel.Length != 0) {
        PredictProductLevel = other.PredictProductLevel;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            EventProductLevel = input.ReadString();
            break;
          }
          case 18: {
            PredictProductLevel = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            EventProductLevel = input.ReadString();
            break;
          }
          case 18: {
            PredictProductLevel = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// The catalog configuration.
  /// Next ID: 5.
  /// </summary>
  public sealed partial class Catalog : pb::IMessage<Catalog>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Catalog> _parser = new pb::MessageParser<Catalog>(() => new Catalog());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Catalog> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Retail.V2Beta.CatalogReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Catalog() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Catalog(Catalog other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      productLevelConfig_ = other.productLevelConfig_ != null ? other.productLevelConfig_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Catalog Clone() {
      return new Catalog(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Required. Immutable. The fully qualified resource name of the catalog.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// Required. Immutable. The catalog display name.
    ///
    /// This field must be a UTF-8 encoded string with a length limit of 128
    /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "product_level_config" field.</summary>
    public const int ProductLevelConfigFieldNumber = 4;
    private global::Google.Cloud.Retail.V2Beta.ProductLevelConfig productLevelConfig_;
    /// <summary>
    /// Required. The product level configuration.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Retail.V2Beta.ProductLevelConfig ProductLevelConfig {
      get { return productLevelConfig_; }
      set {
        productLevelConfig_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Catalog);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Catalog other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (!object.Equals(ProductLevelConfig, other.ProductLevelConfig)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (productLevelConfig_ != null) hash ^= ProductLevelConfig.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (productLevelConfig_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ProductLevelConfig);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (productLevelConfig_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ProductLevelConfig);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (productLevelConfig_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ProductLevelConfig);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Catalog other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.productLevelConfig_ != null) {
        if (productLevelConfig_ == null) {
          ProductLevelConfig = new global::Google.Cloud.Retail.V2Beta.ProductLevelConfig();
        }
        ProductLevelConfig.MergeFrom(other.ProductLevelConfig);
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 34: {
            if (productLevelConfig_ == null) {
              ProductLevelConfig = new global::Google.Cloud.Retail.V2Beta.ProductLevelConfig();
            }
            input.ReadMessage(ProductLevelConfig);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 34: {
            if (productLevelConfig_ == null) {
              ProductLevelConfig = new global::Google.Cloud.Retail.V2Beta.ProductLevelConfig();
            }
            input.ReadMessage(ProductLevelConfig);
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
