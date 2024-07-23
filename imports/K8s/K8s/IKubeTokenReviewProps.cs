using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>TokenReview attempts to authenticate a token to a known user.</summary>
    /// <remarks>
    /// Note: TokenReview requests may be cached by the webhook token authenticator plugin in the kube-apiserver.
    ///
    /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenReview
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeTokenReviewProps), fullyQualifiedName: "k8s.KubeTokenReviewProps")]
    public interface IKubeTokenReviewProps
    {
        /// <summary>Spec holds information about the request being evaluated.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenReview#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.TokenReviewSpec\"}")]
        K8s.ITokenReviewSpec Spec
        {
            get;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenReview#metadata
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

        /// <summary>TokenReview attempts to authenticate a token to a known user.</summary>
        /// <remarks>
        /// Note: TokenReview requests may be cached by the webhook token authenticator plugin in the kube-apiserver.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenReview
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeTokenReviewProps), fullyQualifiedName: "k8s.KubeTokenReviewProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeTokenReviewProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Spec holds information about the request being evaluated.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenReview#spec
            /// </remarks>
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.TokenReviewSpec\"}")]
            public K8s.ITokenReviewSpec Spec
            {
                get => GetInstanceProperty<K8s.ITokenReviewSpec>()!;
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenReview#metadata
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
