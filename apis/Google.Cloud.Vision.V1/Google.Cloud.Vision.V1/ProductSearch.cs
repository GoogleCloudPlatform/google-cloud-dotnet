// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/vision/v1/product_search.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Vision.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/vision/v1/product_search.proto</summary>
  public static partial class ProductSearchReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/vision/v1/product_search.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ProductSearchReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Citnb29nbGUvY2xvdWQvdmlzaW9uL3YxL3Byb2R1Y3Rfc2VhcmNoLnByb3Rv",
            "EhZnb29nbGUuY2xvdWQudmlzaW9uLnYxGhxnb29nbGUvYXBpL2Fubm90YXRp",
            "b25zLnByb3RvGiVnb29nbGUvY2xvdWQvdmlzaW9uL3YxL2dlb21ldHJ5LnBy",
            "b3RvGjNnb29nbGUvY2xvdWQvdmlzaW9uL3YxL3Byb2R1Y3Rfc2VhcmNoX3Nl",
            "cnZpY2UucHJvdG8aH2dvb2dsZS9wcm90b2J1Zi90aW1lc3RhbXAucHJvdG8i",
            "kwEKE1Byb2R1Y3RTZWFyY2hQYXJhbXMSOwoNYm91bmRpbmdfcG9seRgJIAEo",
            "CzIkLmdvb2dsZS5jbG91ZC52aXNpb24udjEuQm91bmRpbmdQb2x5EhMKC3By",
            "b2R1Y3Rfc2V0GAYgASgJEhoKEnByb2R1Y3RfY2F0ZWdvcmllcxgHIAMoCRIO",
            "CgZmaWx0ZXIYCCABKAki2AMKFFByb2R1Y3RTZWFyY2hSZXN1bHRzEi4KCmlu",
            "ZGV4X3RpbWUYAiABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0YW1wEkQK",
            "B3Jlc3VsdHMYBSADKAsyMy5nb29nbGUuY2xvdWQudmlzaW9uLnYxLlByb2R1",
            "Y3RTZWFyY2hSZXN1bHRzLlJlc3VsdBJbChdwcm9kdWN0X2dyb3VwZWRfcmVz",
            "dWx0cxgGIAMoCzI6Lmdvb2dsZS5jbG91ZC52aXNpb24udjEuUHJvZHVjdFNl",
            "YXJjaFJlc3VsdHMuR3JvdXBlZFJlc3VsdBpYCgZSZXN1bHQSMAoHcHJvZHVj",
            "dBgBIAEoCzIfLmdvb2dsZS5jbG91ZC52aXNpb24udjEuUHJvZHVjdBINCgVz",
            "Y29yZRgCIAEoAhINCgVpbWFnZRgDIAEoCRqSAQoNR3JvdXBlZFJlc3VsdBI7",
            "Cg1ib3VuZGluZ19wb2x5GAEgASgLMiQuZ29vZ2xlLmNsb3VkLnZpc2lvbi52",
            "MS5Cb3VuZGluZ1BvbHkSRAoHcmVzdWx0cxgCIAMoCzIzLmdvb2dsZS5jbG91",
            "ZC52aXNpb24udjEuUHJvZHVjdFNlYXJjaFJlc3VsdHMuUmVzdWx0QnoKGmNv",
            "bS5nb29nbGUuY2xvdWQudmlzaW9uLnYxQhJQcm9kdWN0U2VhcmNoUHJvdG9Q",
            "AVo8Z29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xlYXBpcy9jbG91",
            "ZC92aXNpb24vdjE7dmlzaW9u+AEBogIER0NWTmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Cloud.Vision.V1.GeometryReflection.Descriptor, global::Google.Cloud.Vision.V1.ProductSearchServiceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Vision.V1.ProductSearchParams), global::Google.Cloud.Vision.V1.ProductSearchParams.Parser, new[]{ "BoundingPoly", "ProductSet", "ProductCategories", "Filter" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Vision.V1.ProductSearchResults), global::Google.Cloud.Vision.V1.ProductSearchResults.Parser, new[]{ "IndexTime", "Results", "ProductGroupedResults" }, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Vision.V1.ProductSearchResults.Types.Result), global::Google.Cloud.Vision.V1.ProductSearchResults.Types.Result.Parser, new[]{ "Product", "Score", "Image" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Vision.V1.ProductSearchResults.Types.GroupedResult), global::Google.Cloud.Vision.V1.ProductSearchResults.Types.GroupedResult.Parser, new[]{ "BoundingPoly", "Results" }, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Parameters for a product search request.
  /// </summary>
  public sealed partial class ProductSearchParams : pb::IMessage<ProductSearchParams> {
    private static readonly pb::MessageParser<ProductSearchParams> _parser = new pb::MessageParser<ProductSearchParams>(() => new ProductSearchParams());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProductSearchParams> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Vision.V1.ProductSearchReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductSearchParams() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductSearchParams(ProductSearchParams other) : this() {
      boundingPoly_ = other.boundingPoly_ != null ? other.boundingPoly_.Clone() : null;
      productSet_ = other.productSet_;
      productCategories_ = other.productCategories_.Clone();
      filter_ = other.filter_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductSearchParams Clone() {
      return new ProductSearchParams(this);
    }

    /// <summary>Field number for the "bounding_poly" field.</summary>
    public const int BoundingPolyFieldNumber = 9;
    private global::Google.Cloud.Vision.V1.BoundingPoly boundingPoly_;
    /// <summary>
    /// The bounding polygon around the area of interest in the image.
    /// Optional. If it is not specified, system discretion will be applied.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Vision.V1.BoundingPoly BoundingPoly {
      get { return boundingPoly_; }
      set {
        boundingPoly_ = value;
      }
    }

    /// <summary>Field number for the "product_set" field.</summary>
    public const int ProductSetFieldNumber = 6;
    private string productSet_ = "";
    /// <summary>
    /// The resource name of a [ProductSet][google.cloud.vision.v1.ProductSet] to
    /// be searched for similar images.
    ///
    /// Format is:
    /// `projects/PROJECT_ID/locations/LOC_ID/productSets/PRODUCT_SET_ID`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string ProductSet {
      get { return productSet_; }
      set {
        productSet_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "product_categories" field.</summary>
    public const int ProductCategoriesFieldNumber = 7;
    private static readonly pb::FieldCodec<string> _repeated_productCategories_codec
        = pb::FieldCodec.ForString(58);
    private readonly pbc::RepeatedField<string> productCategories_ = new pbc::RepeatedField<string>();
    /// <summary>
    /// The list of product categories to search in. Currently, we only consider
    /// the first category, and either "homegoods", "apparel", or "toys" should be
    /// specified.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> ProductCategories {
      get { return productCategories_; }
    }

    /// <summary>Field number for the "filter" field.</summary>
    public const int FilterFieldNumber = 8;
    private string filter_ = "";
    /// <summary>
    /// The filtering expression. This can be used to restrict search results based
    /// on Product labels. We currently support an AND of OR of key-value
    /// expressions, where each expression within an OR must have the same key. An
    /// '=' should be used to connect the key and value.
    ///
    /// For example, "(color = red OR color = blue) AND brand = Google" is
    /// acceptable, but "(color = red OR brand = Google)" is not acceptable.
    /// "color: red" is not acceptable because it uses a ':' instead of an '='.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Filter {
      get { return filter_; }
      set {
        filter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProductSearchParams);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProductSearchParams other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(BoundingPoly, other.BoundingPoly)) return false;
      if (ProductSet != other.ProductSet) return false;
      if(!productCategories_.Equals(other.productCategories_)) return false;
      if (Filter != other.Filter) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (boundingPoly_ != null) hash ^= BoundingPoly.GetHashCode();
      if (ProductSet.Length != 0) hash ^= ProductSet.GetHashCode();
      hash ^= productCategories_.GetHashCode();
      if (Filter.Length != 0) hash ^= Filter.GetHashCode();
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
      if (ProductSet.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(ProductSet);
      }
      productCategories_.WriteTo(output, _repeated_productCategories_codec);
      if (Filter.Length != 0) {
        output.WriteRawTag(66);
        output.WriteString(Filter);
      }
      if (boundingPoly_ != null) {
        output.WriteRawTag(74);
        output.WriteMessage(BoundingPoly);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (boundingPoly_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(BoundingPoly);
      }
      if (ProductSet.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ProductSet);
      }
      size += productCategories_.CalculateSize(_repeated_productCategories_codec);
      if (Filter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Filter);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProductSearchParams other) {
      if (other == null) {
        return;
      }
      if (other.boundingPoly_ != null) {
        if (boundingPoly_ == null) {
          boundingPoly_ = new global::Google.Cloud.Vision.V1.BoundingPoly();
        }
        BoundingPoly.MergeFrom(other.BoundingPoly);
      }
      if (other.ProductSet.Length != 0) {
        ProductSet = other.ProductSet;
      }
      productCategories_.Add(other.productCategories_);
      if (other.Filter.Length != 0) {
        Filter = other.Filter;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 50: {
            ProductSet = input.ReadString();
            break;
          }
          case 58: {
            productCategories_.AddEntriesFrom(input, _repeated_productCategories_codec);
            break;
          }
          case 66: {
            Filter = input.ReadString();
            break;
          }
          case 74: {
            if (boundingPoly_ == null) {
              boundingPoly_ = new global::Google.Cloud.Vision.V1.BoundingPoly();
            }
            input.ReadMessage(boundingPoly_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// Results for a product search request.
  /// </summary>
  public sealed partial class ProductSearchResults : pb::IMessage<ProductSearchResults> {
    private static readonly pb::MessageParser<ProductSearchResults> _parser = new pb::MessageParser<ProductSearchResults>(() => new ProductSearchResults());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ProductSearchResults> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Vision.V1.ProductSearchReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductSearchResults() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductSearchResults(ProductSearchResults other) : this() {
      indexTime_ = other.indexTime_ != null ? other.indexTime_.Clone() : null;
      results_ = other.results_.Clone();
      productGroupedResults_ = other.productGroupedResults_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ProductSearchResults Clone() {
      return new ProductSearchResults(this);
    }

    /// <summary>Field number for the "index_time" field.</summary>
    public const int IndexTimeFieldNumber = 2;
    private global::Google.Protobuf.WellKnownTypes.Timestamp indexTime_;
    /// <summary>
    /// Timestamp of the index which provided these results. Products added to the
    /// product set and products removed from the product set after this time are
    /// not reflected in the current results.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Timestamp IndexTime {
      get { return indexTime_; }
      set {
        indexTime_ = value;
      }
    }

    /// <summary>Field number for the "results" field.</summary>
    public const int ResultsFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Google.Cloud.Vision.V1.ProductSearchResults.Types.Result> _repeated_results_codec
        = pb::FieldCodec.ForMessage(42, global::Google.Cloud.Vision.V1.ProductSearchResults.Types.Result.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Vision.V1.ProductSearchResults.Types.Result> results_ = new pbc::RepeatedField<global::Google.Cloud.Vision.V1.ProductSearchResults.Types.Result>();
    /// <summary>
    /// List of results, one for each product match.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Vision.V1.ProductSearchResults.Types.Result> Results {
      get { return results_; }
    }

    /// <summary>Field number for the "product_grouped_results" field.</summary>
    public const int ProductGroupedResultsFieldNumber = 6;
    private static readonly pb::FieldCodec<global::Google.Cloud.Vision.V1.ProductSearchResults.Types.GroupedResult> _repeated_productGroupedResults_codec
        = pb::FieldCodec.ForMessage(50, global::Google.Cloud.Vision.V1.ProductSearchResults.Types.GroupedResult.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Vision.V1.ProductSearchResults.Types.GroupedResult> productGroupedResults_ = new pbc::RepeatedField<global::Google.Cloud.Vision.V1.ProductSearchResults.Types.GroupedResult>();
    /// <summary>
    /// List of results grouped by products detected in the query image. Each entry
    /// corresponds to one bounding polygon in the query image, and contains the
    /// matching products specific to that region. There may be duplicate product
    /// matches in the union of all the per-product results.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Vision.V1.ProductSearchResults.Types.GroupedResult> ProductGroupedResults {
      get { return productGroupedResults_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ProductSearchResults);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ProductSearchResults other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(IndexTime, other.IndexTime)) return false;
      if(!results_.Equals(other.results_)) return false;
      if(!productGroupedResults_.Equals(other.productGroupedResults_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (indexTime_ != null) hash ^= IndexTime.GetHashCode();
      hash ^= results_.GetHashCode();
      hash ^= productGroupedResults_.GetHashCode();
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
      if (indexTime_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(IndexTime);
      }
      results_.WriteTo(output, _repeated_results_codec);
      productGroupedResults_.WriteTo(output, _repeated_productGroupedResults_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (indexTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(IndexTime);
      }
      size += results_.CalculateSize(_repeated_results_codec);
      size += productGroupedResults_.CalculateSize(_repeated_productGroupedResults_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ProductSearchResults other) {
      if (other == null) {
        return;
      }
      if (other.indexTime_ != null) {
        if (indexTime_ == null) {
          indexTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        IndexTime.MergeFrom(other.IndexTime);
      }
      results_.Add(other.results_);
      productGroupedResults_.Add(other.productGroupedResults_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 18: {
            if (indexTime_ == null) {
              indexTime_ = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(indexTime_);
            break;
          }
          case 42: {
            results_.AddEntriesFrom(input, _repeated_results_codec);
            break;
          }
          case 50: {
            productGroupedResults_.AddEntriesFrom(input, _repeated_productGroupedResults_codec);
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the ProductSearchResults message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static partial class Types {
      /// <summary>
      /// Information about a product.
      /// </summary>
      public sealed partial class Result : pb::IMessage<Result> {
        private static readonly pb::MessageParser<Result> _parser = new pb::MessageParser<Result>(() => new Result());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<Result> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Vision.V1.ProductSearchResults.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Result() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Result(Result other) : this() {
          product_ = other.product_ != null ? other.product_.Clone() : null;
          score_ = other.score_;
          image_ = other.image_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public Result Clone() {
          return new Result(this);
        }

        /// <summary>Field number for the "product" field.</summary>
        public const int ProductFieldNumber = 1;
        private global::Google.Cloud.Vision.V1.Product product_;
        /// <summary>
        /// The Product.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Cloud.Vision.V1.Product Product {
          get { return product_; }
          set {
            product_ = value;
          }
        }

        /// <summary>Field number for the "score" field.</summary>
        public const int ScoreFieldNumber = 2;
        private float score_;
        /// <summary>
        /// A confidence level on the match, ranging from 0 (no confidence) to
        /// 1 (full confidence).
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public float Score {
          get { return score_; }
          set {
            score_ = value;
          }
        }

        /// <summary>Field number for the "image" field.</summary>
        public const int ImageFieldNumber = 3;
        private string image_ = "";
        /// <summary>
        /// The resource name of the image from the product that is the closest match
        /// to the query.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public string Image {
          get { return image_; }
          set {
            image_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as Result);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(Result other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(Product, other.Product)) return false;
          if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(Score, other.Score)) return false;
          if (Image != other.Image) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (product_ != null) hash ^= Product.GetHashCode();
          if (Score != 0F) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(Score);
          if (Image.Length != 0) hash ^= Image.GetHashCode();
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
          if (product_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(Product);
          }
          if (Score != 0F) {
            output.WriteRawTag(21);
            output.WriteFloat(Score);
          }
          if (Image.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(Image);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (product_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(Product);
          }
          if (Score != 0F) {
            size += 1 + 4;
          }
          if (Image.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Image);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(Result other) {
          if (other == null) {
            return;
          }
          if (other.product_ != null) {
            if (product_ == null) {
              product_ = new global::Google.Cloud.Vision.V1.Product();
            }
            Product.MergeFrom(other.Product);
          }
          if (other.Score != 0F) {
            Score = other.Score;
          }
          if (other.Image.Length != 0) {
            Image = other.Image;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                if (product_ == null) {
                  product_ = new global::Google.Cloud.Vision.V1.Product();
                }
                input.ReadMessage(product_);
                break;
              }
              case 21: {
                Score = input.ReadFloat();
                break;
              }
              case 26: {
                Image = input.ReadString();
                break;
              }
            }
          }
        }

      }

      /// <summary>
      /// Information about the products similar to a single product in a query
      /// image.
      /// </summary>
      public sealed partial class GroupedResult : pb::IMessage<GroupedResult> {
        private static readonly pb::MessageParser<GroupedResult> _parser = new pb::MessageParser<GroupedResult>(() => new GroupedResult());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<GroupedResult> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Vision.V1.ProductSearchResults.Descriptor.NestedTypes[1]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GroupedResult() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GroupedResult(GroupedResult other) : this() {
          boundingPoly_ = other.boundingPoly_ != null ? other.boundingPoly_.Clone() : null;
          results_ = other.results_.Clone();
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public GroupedResult Clone() {
          return new GroupedResult(this);
        }

        /// <summary>Field number for the "bounding_poly" field.</summary>
        public const int BoundingPolyFieldNumber = 1;
        private global::Google.Cloud.Vision.V1.BoundingPoly boundingPoly_;
        /// <summary>
        /// The bounding polygon around the product detected in the query image.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public global::Google.Cloud.Vision.V1.BoundingPoly BoundingPoly {
          get { return boundingPoly_; }
          set {
            boundingPoly_ = value;
          }
        }

        /// <summary>Field number for the "results" field.</summary>
        public const int ResultsFieldNumber = 2;
        private static readonly pb::FieldCodec<global::Google.Cloud.Vision.V1.ProductSearchResults.Types.Result> _repeated_results_codec
            = pb::FieldCodec.ForMessage(18, global::Google.Cloud.Vision.V1.ProductSearchResults.Types.Result.Parser);
        private readonly pbc::RepeatedField<global::Google.Cloud.Vision.V1.ProductSearchResults.Types.Result> results_ = new pbc::RepeatedField<global::Google.Cloud.Vision.V1.ProductSearchResults.Types.Result>();
        /// <summary>
        /// List of results, one for each product match.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::Google.Cloud.Vision.V1.ProductSearchResults.Types.Result> Results {
          get { return results_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other) {
          return Equals(other as GroupedResult);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(GroupedResult other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (!object.Equals(BoundingPoly, other.BoundingPoly)) return false;
          if(!results_.Equals(other.results_)) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode() {
          int hash = 1;
          if (boundingPoly_ != null) hash ^= BoundingPoly.GetHashCode();
          hash ^= results_.GetHashCode();
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
          if (boundingPoly_ != null) {
            output.WriteRawTag(10);
            output.WriteMessage(BoundingPoly);
          }
          results_.WriteTo(output, _repeated_results_codec);
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize() {
          int size = 0;
          if (boundingPoly_ != null) {
            size += 1 + pb::CodedOutputStream.ComputeMessageSize(BoundingPoly);
          }
          size += results_.CalculateSize(_repeated_results_codec);
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(GroupedResult other) {
          if (other == null) {
            return;
          }
          if (other.boundingPoly_ != null) {
            if (boundingPoly_ == null) {
              boundingPoly_ = new global::Google.Cloud.Vision.V1.BoundingPoly();
            }
            BoundingPoly.MergeFrom(other.BoundingPoly);
          }
          results_.Add(other.results_);
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                if (boundingPoly_ == null) {
                  boundingPoly_ = new global::Google.Cloud.Vision.V1.BoundingPoly();
                }
                input.ReadMessage(boundingPoly_);
                break;
              }
              case 18: {
                results_.AddEntriesFrom(input, _repeated_results_codec);
                break;
              }
            }
          }
        }

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
