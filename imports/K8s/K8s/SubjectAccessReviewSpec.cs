using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SubjectAccessReviewSpec is a description of the access request.</summary>
    /// <remarks>
    /// Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set
    ///
    /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.SubjectAccessReviewSpec")]
    public class SubjectAccessReviewSpec : K8s.ISubjectAccessReviewSpec
    {
        /// <summary>Extra corresponds to the user.Info.GetExtra() method from the authenticator.  Since that is input to the authorizer it needs a reflection here.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#extra
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "extra", typeJson: "{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string[]>? Extra
        {
            get;
            set;
        }

        /// <summary>Groups is the groups you're testing for.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#groups
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "groups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Groups
        {
            get;
            set;
        }

        /// <summary>NonResourceAttributes describes information for a non-resource access request.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#nonResourceAttributes
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
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#resourceAttributes
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceAttributes", typeJson: "{\"fqn\":\"k8s.ResourceAttributes\"}", isOptional: true)]
        public K8s.IResourceAttributes? ResourceAttributes
        {
            get;
            set;
        }

        /// <summary>UID information about the requesting user.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#uid
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uid
        {
            get;
            set;
        }

        /// <summary>User is the user you're testing for.</summary>
        /// <remarks>
        /// If you specify "User" but not "Groups", then is it interpreted as "What if User were not a member of any groups
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#user
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? User
        {
            get;
            set;
        }
    }
}
