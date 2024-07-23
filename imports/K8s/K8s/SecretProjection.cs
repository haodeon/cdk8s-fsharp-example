using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Adapts a secret into a projected volume.</summary>
    /// <remarks>
    /// The contents of the target Secret's Data field will be presented in a projected volume as files using the keys in the Data field as the file names. Note that this is identical to a secret volume source without the default mode.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretProjection
    /// </remarks>
    [JsiiByValue(fqn: "k8s.SecretProjection")]
    public class SecretProjection : K8s.ISecretProjection
    {
        /// <summary>items if unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value.</summary>
        /// <remarks>
        /// If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretProjection#items
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretProjection#name
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>optional field specify whether the Secret or its key must be defined.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretProjection#optional
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
