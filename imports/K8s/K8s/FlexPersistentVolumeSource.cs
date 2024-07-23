using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>FlexPersistentVolumeSource represents a generic persistent volume resource that is provisioned/attached using an exec based plugin.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexPersistentVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.FlexPersistentVolumeSource")]
    public class FlexPersistentVolumeSource : K8s.IFlexPersistentVolumeSource
    {
        /// <summary>driver is the name of the driver to use for this volume.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexPersistentVolumeSource#driver
        /// </remarks>
        [JsiiProperty(name: "driver", typeJson: "{\"primitive\":\"string\"}")]
        public string Driver
        {
            get;
            set;
        }

        /// <summary>fsType is the Filesystem type to mount.</summary>
        /// <remarks>
        /// Must be a filesystem type supported by the host operating system. Ex. "ext4", "xfs", "ntfs". The default filesystem depends on FlexVolume script.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexPersistentVolumeSource#fsType
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FsType
        {
            get;
            set;
        }

        /// <summary>options is Optional: this field holds extra command options if any.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexPersistentVolumeSource#options
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "options", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Options
        {
            get;
            set;
        }

        /// <summary>readOnly is Optional: defaults to false (read/write).</summary>
        /// <remarks>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexPersistentVolumeSource#readOnly
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ReadOnly
        {
            get;
            set;
        }

        /// <summary>secretRef is Optional: SecretRef is reference to the secret object containing sensitive information to pass to the plugin scripts.</summary>
        /// <remarks>
        /// This may be empty if no secret object is specified. If the secret object contains more than one secret, all secrets are passed to the plugin scripts.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.FlexPersistentVolumeSource#secretRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretRef", typeJson: "{\"fqn\":\"k8s.SecretReference\"}", isOptional: true)]
        public K8s.ISecretReference? SecretRef
        {
            get;
            set;
        }
    }
}
