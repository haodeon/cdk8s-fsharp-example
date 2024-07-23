using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>SubjectAccessReview checks whether or not a user or group can perform an action.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReview
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeSubjectAccessReviewProps")]
    public class KubeSubjectAccessReviewProps : K8s.IKubeSubjectAccessReviewProps
    {
        /// <summary>Spec holds information about the request being evaluated.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReview#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.SubjectAccessReviewSpec\"}")]
        public K8s.ISubjectAccessReviewSpec Spec
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReview#metadata
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
