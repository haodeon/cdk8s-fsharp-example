using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Secret holds secret data of a certain type.</summary>
    /// <remarks>
    /// The total bytes of the values in the Data field must be less than MaxSecretSize bytes.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Secret
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeSecretProps")]
    public class KubeSecretProps : K8s.IKubeSecretProps
    {
        /// <summary>Data contains the secret data.</summary>
        /// <remarks>
        /// Each key must consist of alphanumeric characters, '-', '_' or '.'. The serialized form of the secret data is a base64 encoded string, representing the arbitrary (possibly non-string) data value here. Described in https://tools.ietf.org/html/rfc4648#section-4
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Secret#data
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "data", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Data
        {
            get;
            set;
        }

        /// <summary>Immutable, if set to true, ensures that data stored in the Secret cannot be updated (only object metadata can be modified).</summary>
        /// <remarks>
        /// If not set to true, the field can be modified at any time. Defaulted to nil.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Secret#immutable
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "immutable", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? Immutable
        {
            get;
            set;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Secret#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>stringData allows specifying non-binary secret data in string form.</summary>
        /// <remarks>
        /// It is provided as a write-only input field for convenience. All keys and values are merged into the data field on write, overwriting any existing values. The stringData field is never output when reading from the API.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Secret#stringData
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "stringData", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? StringData
        {
            get;
            set;
        }

        /// <summary>Used to facilitate programmatic handling of secret data.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/configuration/secret/#secret-types
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Secret#type
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
