using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Adapts a ConfigMap into a volume.</summary>
    /// <remarks>
    /// The contents of the target ConfigMap's Data field will be presented in a volume as files using the keys in the Data field as the file names, unless the items element is populated with specific mappings of keys to paths. ConfigMap volumes support ownership management and SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ConfigMapVolumeSource")]
    public class ConfigMapVolumeSource : K8s.IConfigMapVolumeSource
    {
        /// <summary>defaultMode is optional: mode bits used to set permissions on created files by default.</summary>
        /// <remarks>
        /// Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        ///
        /// <strong>Default</strong>: 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapVolumeSource#defaultMode
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "defaultMode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DefaultMode
        {
            get;
            set;
        }

        /// <summary>items if unspecified, each key-value pair in the Data field of the referenced ConfigMap will be projected into the volume as a file whose name is the key and content is the value.</summary>
        /// <remarks>
        /// If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the ConfigMap, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapVolumeSource#items
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KeyToPath\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IKeyToPath[]? Items
        {
            get;
            set;
        }

        /// <summary>Name of the referent.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapVolumeSource#name
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>optional specify whether the ConfigMap or its keys must be defined.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapVolumeSource#optional
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "optional", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? Optional
        {
            get;
            set;
        }
    }
}
