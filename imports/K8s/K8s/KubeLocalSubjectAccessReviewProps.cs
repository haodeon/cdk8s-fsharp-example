using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>LocalSubjectAccessReview checks whether or not a user or group can perform an action in a given namespace.</summary>
    /// <remarks>
    /// Having a namespace scoped resource makes it much easier to grant namespace scoped policy that includes permissions checking.
    ///
    /// <strong>Schema</strong>: io.k8s.api.authorization.v1.LocalSubjectAccessReview
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeLocalSubjectAccessReviewProps")]
    public class KubeLocalSubjectAccessReviewProps : K8s.IKubeLocalSubjectAccessReviewProps
    {
        /// <summary>Spec holds information about the request being evaluated.</summary>
        /// <remarks>
        /// spec.namespace must be equal to the namespace you made the request against.  If empty, it is defaulted.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.LocalSubjectAccessReview#spec
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
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.LocalSubjectAccessReview#metadata
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
