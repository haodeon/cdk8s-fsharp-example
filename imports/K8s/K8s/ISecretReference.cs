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
    [JsiiInterface(nativeType: typeof(ISecretReference), fullyQualifiedName: "k8s.SecretReference")]
    public interface ISecretReference
    {
        /// <summary>name is unique within a namespace to reference a secret resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretReference#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>namespace defines the space within which the secret name must be unique.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretReference#namespace
        /// </remarks>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>SecretReference represents a Secret Reference.</summary>
        /// <remarks>
        /// It has enough information to retrieve secret in any namespace
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretReference
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ISecretReference), fullyQualifiedName: "k8s.SecretReference")]
        internal sealed class _Proxy : DeputyBase, K8s.ISecretReference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>name is unique within a namespace to reference a secret resource.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretReference#name
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>namespace defines the space within which the secret name must be unique.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretReference#namespace
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
