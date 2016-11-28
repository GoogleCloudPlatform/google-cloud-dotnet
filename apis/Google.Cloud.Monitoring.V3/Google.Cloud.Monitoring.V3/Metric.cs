// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: google/monitoring/v3/metric.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Monitoring.V3 {

  /// <summary>Holder for reflection information generated from google/monitoring/v3/metric.proto</summary>
  public static partial class MetricReflection {

    #region Descriptor
    /// <summary>File descriptor for google/monitoring/v3/metric.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MetricReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiFnb29nbGUvbW9uaXRvcmluZy92My9tZXRyaWMucHJvdG8SFGdvb2dsZS5t",
            "b25pdG9yaW5nLnYzGhdnb29nbGUvYXBpL21ldHJpYy5wcm90bxojZ29vZ2xl",
            "L2FwaS9tb25pdG9yZWRfcmVzb3VyY2UucHJvdG8aIWdvb2dsZS9tb25pdG9y",
            "aW5nL3YzL2NvbW1vbi5wcm90byJuCgVQb2ludBI0CghpbnRlcnZhbBgBIAEo",
            "CzIiLmdvb2dsZS5tb25pdG9yaW5nLnYzLlRpbWVJbnRlcnZhbBIvCgV2YWx1",
            "ZRgCIAEoCzIgLmdvb2dsZS5tb25pdG9yaW5nLnYzLlR5cGVkVmFsdWUiiAIK",
            "ClRpbWVTZXJpZXMSIgoGbWV0cmljGAEgASgLMhIuZ29vZ2xlLmFwaS5NZXRy",
            "aWMSLwoIcmVzb3VyY2UYAiABKAsyHS5nb29nbGUuYXBpLk1vbml0b3JlZFJl",
            "c291cmNlEjwKC21ldHJpY19raW5kGAMgASgOMicuZ29vZ2xlLmFwaS5NZXRy",
            "aWNEZXNjcmlwdG9yLk1ldHJpY0tpbmQSOgoKdmFsdWVfdHlwZRgEIAEoDjIm",
            "Lmdvb2dsZS5hcGkuTWV0cmljRGVzY3JpcHRvci5WYWx1ZVR5cGUSKwoGcG9p",
            "bnRzGAUgAygLMhsuZ29vZ2xlLm1vbml0b3JpbmcudjMuUG9pbnRCRgoYY29t",
            "Lmdvb2dsZS5tb25pdG9yaW5nLnYzQgtNZXRyaWNQcm90b1ABqgIaR29vZ2xl",
            "LkNsb3VkLk1vbml0b3JpbmcuVjNiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.MetricReflection.Descriptor, global::Google.Api.MonitoredResourceReflection.Descriptor, global::Google.Cloud.Monitoring.V3.CommonReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Monitoring.V3.Point), global::Google.Cloud.Monitoring.V3.Point.Parser, new[]{ "Interval", "Value" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Monitoring.V3.TimeSeries), global::Google.Cloud.Monitoring.V3.TimeSeries.Parser, new[]{ "Metric", "Resource", "MetricKind", "ValueType", "Points" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  ///  A single data point in a time series.
  /// </summary>
  public sealed partial class Point : pb::IMessage<Point> {
    private static readonly pb::MessageParser<Point> _parser = new pb::MessageParser<Point>(() => new Point());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Point> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Monitoring.V3.MetricReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Point() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Point(Point other) : this() {
      Interval = other.interval_ != null ? other.Interval.Clone() : null;
      Value = other.value_ != null ? other.Value.Clone() : null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Point Clone() {
      return new Point(this);
    }

    /// <summary>Field number for the "interval" field.</summary>
    public const int IntervalFieldNumber = 1;
    private global::Google.Cloud.Monitoring.V3.TimeInterval interval_;
    /// <summary>
    ///  The time interval to which the data point applies.  For GAUGE metrics, only
    ///  the end time of the interval is used.  For DELTA metrics, the start and end
    ///  time should specify a non-zero interval, with subsequent points specifying
    ///  contiguous and non-overlapping intervals.  For CUMULATIVE metrics, the
    ///  start and end time should specify a non-zero interval, with subsequent
    ///  points specifying the same start time and increasing end times, until an
    ///  event resets the cumulative value to zero and sets a new start time for the
    ///  following points.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Monitoring.V3.TimeInterval Interval {
      get { return interval_; }
      set {
        interval_ = value;
      }
    }

    /// <summary>Field number for the "value" field.</summary>
    public const int ValueFieldNumber = 2;
    private global::Google.Cloud.Monitoring.V3.TypedValue value_;
    /// <summary>
    ///  The value of the data point.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Cloud.Monitoring.V3.TypedValue Value {
      get { return value_; }
      set {
        value_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Point);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Point other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Interval, other.Interval)) return false;
      if (!object.Equals(Value, other.Value)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (interval_ != null) hash ^= Interval.GetHashCode();
      if (value_ != null) hash ^= Value.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (interval_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Interval);
      }
      if (value_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Value);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (interval_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Interval);
      }
      if (value_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Value);
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Point other) {
      if (other == null) {
        return;
      }
      if (other.interval_ != null) {
        if (interval_ == null) {
          interval_ = new global::Google.Cloud.Monitoring.V3.TimeInterval();
        }
        Interval.MergeFrom(other.Interval);
      }
      if (other.value_ != null) {
        if (value_ == null) {
          value_ = new global::Google.Cloud.Monitoring.V3.TypedValue();
        }
        Value.MergeFrom(other.Value);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (interval_ == null) {
              interval_ = new global::Google.Cloud.Monitoring.V3.TimeInterval();
            }
            input.ReadMessage(interval_);
            break;
          }
          case 18: {
            if (value_ == null) {
              value_ = new global::Google.Cloud.Monitoring.V3.TypedValue();
            }
            input.ReadMessage(value_);
            break;
          }
        }
      }
    }

  }

  /// <summary>
  ///  A collection of data points that describes the time-varying values
  ///  of a metric. A time series is identified by a combination of a
  ///  fully-specified monitored resource and a fully-specified metric.
  ///  This type is used for both listing and creating time series.
  /// </summary>
  public sealed partial class TimeSeries : pb::IMessage<TimeSeries> {
    private static readonly pb::MessageParser<TimeSeries> _parser = new pb::MessageParser<TimeSeries>(() => new TimeSeries());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<TimeSeries> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Monitoring.V3.MetricReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeSeries() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeSeries(TimeSeries other) : this() {
      Metric = other.metric_ != null ? other.Metric.Clone() : null;
      Resource = other.resource_ != null ? other.Resource.Clone() : null;
      metricKind_ = other.metricKind_;
      valueType_ = other.valueType_;
      points_ = other.points_.Clone();
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public TimeSeries Clone() {
      return new TimeSeries(this);
    }

    /// <summary>Field number for the "metric" field.</summary>
    public const int MetricFieldNumber = 1;
    private global::Google.Api.Metric metric_;
    /// <summary>
    ///  The associated metric. A fully-specified metric used to identify the time
    ///  series.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.Metric Metric {
      get { return metric_; }
      set {
        metric_ = value;
      }
    }

    /// <summary>Field number for the "resource" field.</summary>
    public const int ResourceFieldNumber = 2;
    private global::Google.Api.MonitoredResource resource_;
    /// <summary>
    ///  The associated resource. A fully-specified monitored resource used to
    ///  identify the time series.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.MonitoredResource Resource {
      get { return resource_; }
      set {
        resource_ = value;
      }
    }

    /// <summary>Field number for the "metric_kind" field.</summary>
    public const int MetricKindFieldNumber = 3;
    private global::Google.Api.MetricDescriptor.Types.MetricKind metricKind_ = 0;
    /// <summary>
    ///  The metric kind of the time series. When listing time series, this metric
    ///  kind might be different from the metric kind of the associated metric if
    ///  this time series is an alignment or reduction of other time series.
    ///
    ///  When creating a time series, this field is optional. If present, it must be
    ///  the same as the metric kind of the associated metric. If the associated
    ///  metric's descriptor must be auto-created, then this field specifies the
    ///  metric kind of the new descriptor and must be either `GAUGE` (the default)
    ///  or `CUMULATIVE`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.MetricDescriptor.Types.MetricKind MetricKind {
      get { return metricKind_; }
      set {
        metricKind_ = value;
      }
    }

    /// <summary>Field number for the "value_type" field.</summary>
    public const int ValueTypeFieldNumber = 4;
    private global::Google.Api.MetricDescriptor.Types.ValueType valueType_ = 0;
    /// <summary>
    ///  The value type of the time series. When listing time series, this value
    ///  type might be different from the value type of the associated metric if
    ///  this time series is an alignment or reduction of other time series.
    ///
    ///  When creating a time series, this field is optional. If present, it must be
    ///  the same as the type of the data in the `points` field.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::Google.Api.MetricDescriptor.Types.ValueType ValueType {
      get { return valueType_; }
      set {
        valueType_ = value;
      }
    }

    /// <summary>Field number for the "points" field.</summary>
    public const int PointsFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Google.Cloud.Monitoring.V3.Point> _repeated_points_codec
        = pb::FieldCodec.ForMessage(42, global::Google.Cloud.Monitoring.V3.Point.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.Monitoring.V3.Point> points_ = new pbc::RepeatedField<global::Google.Cloud.Monitoring.V3.Point>();
    /// <summary>
    ///  The data points of this time series. When listing time series, the order of
    ///  the points is specified by the list method.
    ///
    ///  When creating a time series, this field must contain exactly one point and
    ///  the point's type must be the same as the value type of the associated
    ///  metric. If the associated metric's descriptor must be auto-created, then
    ///  the value type of the descriptor is determined by the point's type, which
    ///  must be `BOOL`, `INT64`, `DOUBLE`, or `DISTRIBUTION`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::Google.Cloud.Monitoring.V3.Point> Points {
      get { return points_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as TimeSeries);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(TimeSeries other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(Metric, other.Metric)) return false;
      if (!object.Equals(Resource, other.Resource)) return false;
      if (MetricKind != other.MetricKind) return false;
      if (ValueType != other.ValueType) return false;
      if(!points_.Equals(other.points_)) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (metric_ != null) hash ^= Metric.GetHashCode();
      if (resource_ != null) hash ^= Resource.GetHashCode();
      if (MetricKind != 0) hash ^= MetricKind.GetHashCode();
      if (ValueType != 0) hash ^= ValueType.GetHashCode();
      hash ^= points_.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (metric_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(Metric);
      }
      if (resource_ != null) {
        output.WriteRawTag(18);
        output.WriteMessage(Resource);
      }
      if (MetricKind != 0) {
        output.WriteRawTag(24);
        output.WriteEnum((int) MetricKind);
      }
      if (ValueType != 0) {
        output.WriteRawTag(32);
        output.WriteEnum((int) ValueType);
      }
      points_.WriteTo(output, _repeated_points_codec);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (metric_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Metric);
      }
      if (resource_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Resource);
      }
      if (MetricKind != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) MetricKind);
      }
      if (ValueType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ValueType);
      }
      size += points_.CalculateSize(_repeated_points_codec);
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(TimeSeries other) {
      if (other == null) {
        return;
      }
      if (other.metric_ != null) {
        if (metric_ == null) {
          metric_ = new global::Google.Api.Metric();
        }
        Metric.MergeFrom(other.Metric);
      }
      if (other.resource_ != null) {
        if (resource_ == null) {
          resource_ = new global::Google.Api.MonitoredResource();
        }
        Resource.MergeFrom(other.Resource);
      }
      if (other.MetricKind != 0) {
        MetricKind = other.MetricKind;
      }
      if (other.ValueType != 0) {
        ValueType = other.ValueType;
      }
      points_.Add(other.points_);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (metric_ == null) {
              metric_ = new global::Google.Api.Metric();
            }
            input.ReadMessage(metric_);
            break;
          }
          case 18: {
            if (resource_ == null) {
              resource_ = new global::Google.Api.MonitoredResource();
            }
            input.ReadMessage(resource_);
            break;
          }
          case 24: {
            metricKind_ = (global::Google.Api.MetricDescriptor.Types.MetricKind) input.ReadEnum();
            break;
          }
          case 32: {
            valueType_ = (global::Google.Api.MetricDescriptor.Types.ValueType) input.ReadEnum();
            break;
          }
          case 42: {
            points_.AddEntriesFrom(input, _repeated_points_codec);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
