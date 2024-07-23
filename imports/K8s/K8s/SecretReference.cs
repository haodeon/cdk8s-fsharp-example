using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SecretReference represents a Secret Reference.</summary>
    /// <remarks>
    /// It has enough information to retrieve secret in any namespace
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretReference
    /// </remarks>
    [JsiiByValue(fqn: "k8s.SecretReference")]
    public class SecretReference : K8s.ISecretReference
    {
        /// <summary>name is unique within a namespace to reference a secret resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretReference#name
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>namespace defines the space within which the secret name must be unique.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretReference#namespace
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }
    }
}
