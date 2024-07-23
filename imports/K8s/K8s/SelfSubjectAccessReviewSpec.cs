using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SelfSubjectAccessReviewSpec is a description of the access request.</summary>
    /// <remarks>
    /// Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set
    ///
    /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectAccessReviewSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.SelfSubjectAccessReviewSpec")]
    public class SelfSubjectAccessReviewSpec : K8s.ISelfSubjectAccessReviewSpec
    {
        /// <summary>NonResourceAttributes describes information for a non-resource access request.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectAccessReviewSpec#nonResourceAttributes
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nonResourceAttributes", typeJson: "{\"fqn\":\"k8s.NonResourceAttributes\"}", isOptional: true)]
        public K8s.INonResourceAttributes? NonResourceAttributes
        {
            get;
            set;
        }

        /// <summary>ResourceAuthorizationAttributes describes information for a resource access request.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SelfSubjectAccessReviewSpec#resourceAttributes
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAttributes", typeJson: "{\"fqn\":\"k8s.ResourceAttributes\"}", isOptional: true)]
        public K8s.IResourceAttributes? ResourceAttributes
        {
            get;
            set;
        }
    }
}
