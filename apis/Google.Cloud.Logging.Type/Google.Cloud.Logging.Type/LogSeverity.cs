// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/logging/type/log_severity.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Logging.Type {

  /// <summary>Holder for reflection information generated from google/logging/type/log_severity.proto</summary>
  public static partial class LogSeverityReflection {

    #region Descriptor
    /// <summary>File descriptor for google/logging/type/log_severity.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LogSeverityReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZnb29nbGUvbG9nZ2luZy90eXBlL2xvZ19zZXZlcml0eS5wcm90bxITZ29v",
            "Z2xlLmxvZ2dpbmcudHlwZRocZ29vZ2xlL2FwaS9hbm5vdGF0aW9ucy5wcm90",
            "byqCAQoLTG9nU2V2ZXJpdHkSCwoHREVGQVVMVBAAEgkKBURFQlVHEGQSCQoE",
            "SU5GTxDIARILCgZOT1RJQ0UQrAISDAoHV0FSTklORxCQAxIKCgVFUlJPUhD0",
            "AxINCghDUklUSUNBTBDYBBIKCgVBTEVSVBC8BRIOCglFTUVSR0VOQ1kQoAZC",
            "nwEKF2NvbS5nb29nbGUubG9nZ2luZy50eXBlQhBMb2dTZXZlcml0eVByb3Rv",
            "UAFaOGdvb2dsZS5nb2xhbmcub3JnL2dlbnByb3RvL2dvb2dsZWFwaXMvbG9n",
            "Z2luZy90eXBlO2x0eXBlqgIZR29vZ2xlLkNsb3VkLkxvZ2dpbmcuVHlwZcoC",
            "GUdvb2dsZVxDbG91ZFxMb2dnaW5nXFR5cGViBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.Logging.Type.LogSeverity), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// The severity of the event described in a log entry, expressed as one of the
  /// standard severity levels listed below.  For your reference, the levels are
  /// assigned the listed numeric values. The effect of using numeric values other
  /// than those listed is undefined.
  ///
  /// You can filter for log entries by severity.  For example, the following
  /// filter expression will match log entries with severities `INFO`, `NOTICE`,
  /// and `WARNING`:
  ///
  ///     severity > DEBUG AND severity &lt;= WARNING
  ///
  /// If you are writing log entries, you should map other severity encodings to
  /// one of these standard levels. For example, you might map all of Java's FINE,
  /// FINER, and FINEST levels to `LogSeverity.DEBUG`. You can preserve the
  /// original severity level in the log entry payload if you wish.
  /// </summary>
  public enum LogSeverity {
    /// <summary>
    /// (0) The log entry has no assigned severity level.
    /// </summary>
    [pbr::OriginalName("DEFAULT")] Default = 0,
    /// <summary>
    /// (100) Debug or trace information.
    /// </summary>
    [pbr::OriginalName("DEBUG")] Debug = 100,
    /// <summary>
    /// (200) Routine information, such as ongoing status or performance.
    /// </summary>
    [pbr::OriginalName("INFO")] Info = 200,
    /// <summary>
    /// (300) Normal but significant events, such as start up, shut down, or
    /// a configuration change.
    /// </summary>
    [pbr::OriginalName("NOTICE")] Notice = 300,
    /// <summary>
    /// (400) Warning events might cause problems.
    /// </summary>
    [pbr::OriginalName("WARNING")] Warning = 400,
    /// <summary>
    /// (500) Error events are likely to cause problems.
    /// </summary>
    [pbr::OriginalName("ERROR")] Error = 500,
    /// <summary>
    /// (600) Critical events cause more severe problems or outages.
    /// </summary>
    [pbr::OriginalName("CRITICAL")] Critical = 600,
    /// <summary>
    /// (700) A person must take an action immediately.
    /// </summary>
    [pbr::OriginalName("ALERT")] Alert = 700,
    /// <summary>
    /// (800) One or more systems are unusable.
    /// </summary>
    [pbr::OriginalName("EMERGENCY")] Emergency = 800,
  }

  #endregion

}

#endregion Designer generated code
