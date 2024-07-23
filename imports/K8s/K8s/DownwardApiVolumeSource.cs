using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>DownwardAPIVolumeSource represents a volume containing downward API info.</summary>
    /// <remarks>
    /// Downward API volumes support ownership management and SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.DownwardApiVolumeSource")]
    public class DownwardApiVolumeSource : K8s.IDownwardApiVolumeSource
    {
        /// <summary>Optional: mode bits to use on created files by default.</summary>
        /// <remarks>
        /// Must be a Optional: mode bits used to set permissions on created files by default. Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        ///
        /// <strong>Default</strong>: 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIVolumeSource#defaultMode
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultMode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DefaultMode
        {
            get;
            set;
        }

        /// <summary>Items is a list of downward API volume file.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIVolumeSource#items
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.DownwardApiVolumeFile\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IDownwardApiVolumeFile[]? Items
        {
            get;
            set;
        }
    }
}
