using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SelfSubjectReview contains the user information that the kube-apiserver has about the user making this request.</summary>
    /// <remarks>
    /// When using impersonation, users will receive the user info of the user being impersonated.  If impersonation or request header authentication is used, any extra keys will have their case ignored and returned as lowercase.
    ///
    /// <strong>Schema</strong>: io.k8s.api.authentication.v1.SelfSubjectReview
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeSelfSubjectReviewProps")]
    public class KubeSelfSubjectReviewProps : K8s.IKubeSelfSubjectReviewProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.SelfSubjectReview#metadata
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
