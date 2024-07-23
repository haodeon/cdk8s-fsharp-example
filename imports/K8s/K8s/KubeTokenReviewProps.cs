using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>TokenReview attempts to authenticate a token to a known user.</summary>
    /// <remarks>
    /// Note: TokenReview requests may be cached by the webhook token authenticator plugin in the kube-apiserver.
    ///
    /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenReview
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeTokenReviewProps")]
    public class KubeTokenReviewProps : K8s.IKubeTokenReviewProps
    {
        /// <summary>Spec holds information about the request being evaluated.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenReview#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.TokenReviewSpec\"}")]
        public K8s.ITokenReviewSpec Spec
        {
            get;
            set;
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
            get;
            set;
        }
    }
}
