// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/location/locations.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Location {

  /// <summary>Holder for reflection information generated from google/cloud/location/locations.proto</summary>
  public static partial class LocationsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/location/locations.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LocationsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVnb29nbGUvY2xvdWQvbG9jYXRpb24vbG9jYXRpb25zLnByb3RvEhVnb29n",
            "bGUuY2xvdWQubG9jYXRpb24aHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMucHJv",
            "dG8aGWdvb2dsZS9wcm90b2J1Zi9hbnkucHJvdG8iWwoUTGlzdExvY2F0aW9u",
            "c1JlcXVlc3QSDAoEbmFtZRgBIAEoCRIOCgZmaWx0ZXIYAiABKAkSEQoJcGFn",
            "ZV9zaXplGAMgASgFEhIKCnBhZ2VfdG9rZW4YBCABKAkiZAoVTGlzdExvY2F0",
            "aW9uc1Jlc3BvbnNlEjIKCWxvY2F0aW9ucxgBIAMoCzIfLmdvb2dsZS5jbG91",
            "ZC5sb2NhdGlvbi5Mb2NhdGlvbhIXCg9uZXh0X3BhZ2VfdG9rZW4YAiABKAki",
            "IgoSR2V0TG9jYXRpb25SZXF1ZXN0EgwKBG5hbWUYASABKAki1wEKCExvY2F0",
            "aW9uEgwKBG5hbWUYASABKAkSEwoLbG9jYXRpb25faWQYBCABKAkSFAoMZGlz",
            "cGxheV9uYW1lGAUgASgJEjsKBmxhYmVscxgCIAMoCzIrLmdvb2dsZS5jbG91",
            "ZC5sb2NhdGlvbi5Mb2NhdGlvbi5MYWJlbHNFbnRyeRImCghtZXRhZGF0YRgD",
            "IAEoCzIULmdvb2dsZS5wcm90b2J1Zi5BbnkaLQoLTGFiZWxzRW50cnkSCwoD",
            "a2V5GAEgASgJEg0KBXZhbHVlGAIgASgJOgI4ATKoAgoJTG9jYXRpb25zEpMB",
            "Cg1MaXN0TG9jYXRpb25zEisuZ29vZ2xlLmNsb3VkLmxvY2F0aW9uLkxpc3RM",
            "b2NhdGlvbnNSZXF1ZXN0GiwuZ29vZ2xlLmNsb3VkLmxvY2F0aW9uLkxpc3RM",
            "b2NhdGlvbnNSZXNwb25zZSIngtPkkwIhEh8vdjEve25hbWU9cHJvamVjdHMv",
            "Kn0vbG9jYXRpb25zEoQBCgtHZXRMb2NhdGlvbhIpLmdvb2dsZS5jbG91ZC5s",
            "b2NhdGlvbi5HZXRMb2NhdGlvblJlcXVlc3QaHy5nb29nbGUuY2xvdWQubG9j",
            "YXRpb24uTG9jYXRpb24iKYLT5JMCIxIhL3YxL3tuYW1lPXByb2plY3RzLyov",
            "bG9jYXRpb25zLyp9Qm8KGWNvbS5nb29nbGUuY2xvdWQubG9jYXRpb25CDkxv",
            "Y2F0aW9uc1Byb3RvUAFaPWdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dv",
            "b2dsZWFwaXMvY2xvdWQvbG9jYXRpb247bG9jYXRpb274AQFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.AnyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Location.ListLocationsRequest), global::Google.Cloud.Location.ListLocationsRequest.Parser, new[]{ "Name", "Filter", "PageSize", "PageToken" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Location.ListLocationsResponse), global::Google.Cloud.Location.ListLocationsResponse.Parser, new[]{ "Locations", "NextPageToken" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Location.GetLocationRequest), global::Google.Cloud.Location.GetLocationRequest.Parser, new[]{ "Name" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Location.Location), global::Google.Cloud.Location.Location.Parser, new[]{ "Name", "LocationId", "DisplayName", "Labels", "Metadata" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The request message for
  /// [Locations.ListLocations][google.cloud.location.Locations.ListLocations].
  /// </summary>
  public sealed partial class ListLocationsRequest : pb::IMessage<ListLocationsRequest> {
    private static readonly pb::MessageParser<ListLocationsRequest> _parser = new pb::MessageParser<ListLocationsRequest>(() => new ListLocationsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListLocationsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Location.LocationsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLocationsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLocationsRequest(ListLocationsRequest other) : this() {
      name_ = other.name_;
      filter_ = other.filter_;
      pageSize_ = other.pageSize_;
      pageToken_ = other.pageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLocationsRequest Clone() {
      return new ListLocationsRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// The resource that owns the locations collection, if applicable.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "filter" field.</summary>
    public const int FilterFieldNumber = 2;
    private string filter_ = "";
    /// <summary>
    /// The standard list filter.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Filter {
      get { return filter_; }
      set {
        filter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 3;
    private int pageSize_;
    /// <summary>
    /// The standard list page size.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int PageSize {
      get { return pageSize_; }
      set {
        pageSize_ = value;
      }
    }

    /// <summary>Field number for the "page_token" field.</summary>
    public const int PageTokenFieldNumber = 4;
    private string pageToken_ = "";
    /// <summary>
    /// The standard list page token.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string PageToken {
      get { return pageToken_; }
      set {
        pageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListLocationsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListLocationsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Filter != other.Filter) return false;
      if (PageSize != other.PageSize) return false;
      if (PageToken != other.PageToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Filter.Length != 0) hash ^= Filter.GetHashCode();
      if (PageSize != 0) hash ^= PageSize.GetHashCode();
      if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Filter);
      }
      if (PageSize != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PageToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (Filter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Filter);
      }
      if (PageSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageSize);
      }
      if (PageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PageToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListLocationsRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Filter.Length != 0) {
        Filter = other.Filter;
      }
      if (other.PageSize != 0) {
        PageSize = other.PageSize;
      }
      if (other.PageToken.Length != 0) {
        PageToken = other.PageToken;
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            Filter = input.ReadString();
            break;
          }
          case 24: {
            PageSize = input.ReadInt32();
            break;
          }
          case 34: {
            PageToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The response message for
  /// [Locations.ListLocations][google.cloud.location.Locations.ListLocations].
  /// </summary>
  public sealed partial class ListLocationsResponse : pb::IMessage<ListLocationsResponse> {
    private static readonly pb::MessageParser<ListLocationsResponse> _parser = new pb::MessageParser<ListLocationsResponse>(() => new ListLocationsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ListLocationsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Location.LocationsReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLocationsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLocationsResponse(ListLocationsResponse other) : this() {
      locations_ = other.locations_.Clone();
      nextPageToken_ = other.nextPageToken_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ListLocationsResponse Clone() {
      return new ListLocationsResponse(this);
    }

    /// <summary>Field number for the "locations" field.</summary>
    public const int LocationsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Cloud.Location.Location> _repeated_locations_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Cloud.Location.Location.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Location.Location> locations_ = new pbc::RepeatedField<global::Google.Cloud.Location.Location>();
    /// <summary>
    /// A list of locations that matches the specified filter in the request.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Location.Location> Locations {
      get { return locations_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    /// <summary>
    /// The standard List next-page token.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string NextPageToken {
      get { return nextPageToken_; }
      set {
        nextPageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ListLocationsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ListLocationsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!locations_.Equals(other.locations_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= locations_.GetHashCode();
      if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
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
      locations_.WriteTo(output, _repeated_locations_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      size += locations_.CalculateSize(_repeated_locations_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ListLocationsResponse other) {
      if (other == null) {
        return;
      }
      locations_.Add(other.locations_);
      if (other.NextPageToken.Length != 0) {
        NextPageToken = other.NextPageToken;
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
            locations_.AddEntriesFrom(input, _repeated_locations_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// The request message for
  /// [Locations.GetLocation][google.cloud.location.Locations.GetLocation].
  /// </summary>
  public sealed partial class GetLocationRequest : pb::IMessage<GetLocationRequest> {
    private static readonly pb::MessageParser<GetLocationRequest> _parser = new pb::MessageParser<GetLocationRequest>(() => new GetLocationRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<GetLocationRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Location.LocationsReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetLocationRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetLocationRequest(GetLocationRequest other) : this() {
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public GetLocationRequest Clone() {
      return new GetLocationRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Resource name for the location.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as GetLocationRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(GetLocationRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(GetLocationRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
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
            Name = input.ReadString();
            break;
          }
        }
      }
    }

  }

  /// <summary>
  /// A resource that represents Google Cloud Platform location.
  /// </summary>
  public sealed partial class Location : pb::IMessage<Location> {
    private static readonly pb::MessageParser<Location> _parser = new pb::MessageParser<Location>(() => new Location());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Location> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Location.LocationsReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Location() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Location(Location other) : this() {
      name_ = other.name_;
      locationId_ = other.locationId_;
      displayName_ = other.displayName_;
      labels_ = other.labels_.Clone();
      metadata_ = other.metadata_ != null ? other.metadata_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Location Clone() {
      return new Location(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Resource name for the location, which may vary between implementations.
    /// For example: `"projects/example-project/locations/us-east1"`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "location_id" field.</summary>
    public const int LocationIdFieldNumber = 4;
    private string locationId_ = "";
    /// <summary>
    /// The canonical id for this location. For example: `"us-east1"`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string LocationId {
      get { return locationId_; }
      set {
        locationId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 5;
    private string displayName_ = "";
    /// <summary>
    /// The friendly name for this location, typically a nearby city name.
    /// For example, "Tokyo".
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "labels" field.</summary>
    public const int LabelsFieldNumber = 2;
    private static readonly pbc::MapField<string, string>.Codec _map_labels_codec
        = new pbc::MapField<string, string>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForString(18), 18);
    private readonly pbc::MapField<string, string> labels_ = new pbc::MapField<string, string>();
    /// <summary>
    /// Cross-service attributes for the location. For example
    ///
    ///     {"cloud.googleapis.com/region": "us-east1"}
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::MapField<string, string> Labels {
      get { return labels_; }
    }

    /// <summary>Field number for the "metadata" field.</summary>
    public const int MetadataFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Any metadata_;
    /// <summary>
    /// Service-specific metadata. For example the available capacity at the given
    /// location.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Protobuf.WellKnownTypes.Any Metadata {
      get { return metadata_; }
      set {
        metadata_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Location);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Location other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (LocationId != other.LocationId) return false;
      if (DisplayName != other.DisplayName) return false;
      if (!Labels.Equals(other.Labels)) return false;
      if (!object.Equals(Metadata, other.Metadata)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (LocationId.Length != 0) hash ^= LocationId.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      hash ^= Labels.GetHashCode();
      if (metadata_ != null) hash ^= Metadata.GetHashCode();
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      labels_.WriteTo(output, _map_labels_codec);
      if (metadata_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(Metadata);
      }
      if (LocationId.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(LocationId);
      }
      if (DisplayName.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(DisplayName);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (LocationId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(LocationId);
      }
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      size += labels_.CalculateSize(_map_labels_codec);
      if (metadata_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metadata);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Location other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.LocationId.Length != 0) {
        LocationId = other.LocationId;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      labels_.Add(other.labels_);
      if (other.metadata_ != null) {
        if (metadata_ == null) {
          metadata_ = new global::Google.Protobuf.WellKnownTypes.Any();
        }
        Metadata.MergeFrom(other.Metadata);
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
            Name = input.ReadString();
            break;
          }
          case 18: {
            labels_.AddEntriesFrom(input, _map_labels_codec);
            break;
          }
          case 26: {
            if (metadata_ == null) {
              metadata_ = new global::Google.Protobuf.WellKnownTypes.Any();
            }
            input.ReadMessage(metadata_);
            break;
          }
          case 34: {
            LocationId = input.ReadString();
            break;
          }
          case 42: {
            DisplayName = input.ReadString();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
