// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/dataproc/v1/shared.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Dataproc.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/dataproc/v1/shared.proto</summary>
  public static partial class SharedReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/dataproc/v1/shared.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SharedReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiVnb29nbGUvY2xvdWQvZGF0YXByb2MvdjEvc2hhcmVkLnByb3RvEhhnb29n",
            "bGUuY2xvdWQuZGF0YXByb2MudjEaHGdvb2dsZS9hcGkvYW5ub3RhdGlvbnMu",
            "cHJvdG8qYQoJQ29tcG9uZW50EhkKFUNPTVBPTkVOVF9VTlNQRUNJRklFRBAA",
            "EgwKCEFOQUNPTkRBEAUSEAoMSElWRV9XRUJIQ0FUEAMSCwoHSlVQWVRFUhAB",
            "EgwKCFpFUFBFTElOEARCbwocY29tLmdvb2dsZS5jbG91ZC5kYXRhcHJvYy52",
            "MUILU2hhcmVkUHJvdG9QAVpAZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8v",
            "Z29vZ2xlYXBpcy9jbG91ZC9kYXRhcHJvYy92MTtkYXRhcHJvY2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.AnnotationsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.Dataproc.V1.Component), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Cluster components that can be activated.
  /// </summary>
  public enum Component {
    /// <summary>
    /// Unspecified component.
    /// </summary>
    [pbr::OriginalName("COMPONENT_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// The Anaconda python distribution.
    /// </summary>
    [pbr::OriginalName("ANACONDA")] Anaconda = 5,
    /// <summary>
    /// The Hive Web HCatalog (the REST service for accessing HCatalog).
    /// </summary>
    [pbr::OriginalName("HIVE_WEBHCAT")] HiveWebhcat = 3,
    /// <summary>
    /// The Jupyter Notebook.
    /// </summary>
    [pbr::OriginalName("JUPYTER")] Jupyter = 1,
    /// <summary>
    /// The Zeppelin notebook.
    /// </summary>
    [pbr::OriginalName("ZEPPELIN")] Zeppelin = 4,
  }

  #endregion

}

#endregion Designer generated code
