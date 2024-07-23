using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>SelfSubjectAccessReview checks whether or the current user can perform an action.</summary>
    /// <remarks>
    /// Not filling in a spec.namespace means "in all namespaces".  Self is a special case, because users should always be able to check whether they can perform an action
    ///
    /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectAccessReview
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeSelfSubjectAccessReviewProps")]
    public class KubeSelfSubjectAccessReviewProps : K8s.IKubeSelfSubjectAccessReviewProps
    {
        /// <summary>Spec holds information about the request being evaluated.</summary>
        /// <remarks>
        /// user and groups must be empty
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectAccessReview#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.SelfSubjectAccessReviewSpec\"}")]
        public K8s.ISelfSubjectAccessReviewSpec Spec
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectAccessReview#metadata
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
