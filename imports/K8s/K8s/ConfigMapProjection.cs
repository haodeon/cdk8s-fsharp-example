using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Adapts a ConfigMap into a projected volume.</summary>
    /// <remarks>
    /// The contents of the target ConfigMap's Data field will be presented in a projected volume as files using the keys in the Data field as the file names, unless the items element is populated with specific mappings of keys to paths. Note that this is identical to a configmap volume source without the default mode.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapProjection
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ConfigMapProjection")]
    public class ConfigMapProjection : K8s.IConfigMapProjection
    {
        /// <summary>items if unspecified, each key-value pair in the Data field of the referenced ConfigMap will be projected into the volume as a file whose name is the key and content is the value.</summary>
        /// <remarks>
        /// If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the ConfigMap, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapProjection#items
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapProjection#name
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapProjection#optional
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
