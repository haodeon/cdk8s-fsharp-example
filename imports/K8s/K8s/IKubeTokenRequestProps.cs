using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>TokenRequest requests a token for a given service account.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenRequest
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeTokenRequestProps), fullyQualifiedName: "k8s.KubeTokenRequestProps")]
    public interface IKubeTokenRequestProps
    {
        /// <summary>Spec holds information about the request being evaluated.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenRequest#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.TokenRequestSpec\"}")]
        K8s.ITokenRequestSpec Spec
        {
            get;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenRequest#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>TokenRequest requests a token for a given service account.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenRequest
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeTokenRequestProps), fullyQualifiedName: "k8s.KubeTokenRequestProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeTokenRequestProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Spec holds information about the request being evaluated.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenRequest#spec
            /// </remarks>
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.TokenRequestSpec\"}")]
            public K8s.ITokenRequestSpec Spec
            {
                get => GetInstanceProperty<K8s.ITokenRequestSpec>()!;
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenRequest#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }
        }
    }
}
