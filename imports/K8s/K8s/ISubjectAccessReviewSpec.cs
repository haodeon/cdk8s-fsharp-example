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
    [JsiiInterface(nativeType: typeof(ISubjectAccessReviewSpec), fullyQualifiedName: "k8s.SubjectAccessReviewSpec")]
    public interface ISubjectAccessReviewSpec
    {
        /// <summary>Extra corresponds to the user.Info.GetExtra() method from the authenticator.  Since that is input to the authorizer it needs a reflection here.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#extra
        /// </remarks>
        [JsiiProperty(name: "extra", typeJson: "{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string[]>? Extra
        {
            get
            {
                return null;
            }
        }

        /// <summary>Groups is the groups you're testing for.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#groups
        /// </remarks>
        [JsiiProperty(name: "groups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Groups
        {
            get
            {
                return null;
            }
        }

        /// <summary>NonResourceAttributes describes information for a non-resource access request.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#nonResourceAttributes
        /// </remarks>
        [JsiiProperty(name: "nonResourceAttributes", typeJson: "{\"fqn\":\"k8s.NonResourceAttributes\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INonResourceAttributes? NonResourceAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>ResourceAuthorizationAttributes describes information for a resource access request.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#resourceAttributes
        /// </remarks>
        [JsiiProperty(name: "resourceAttributes", typeJson: "{\"fqn\":\"k8s.ResourceAttributes\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IResourceAttributes? ResourceAttributes
        {
            get
            {
                return null;
            }
        }

        /// <summary>UID information about the requesting user.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#uid
        /// </remarks>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uid
        {
            get
            {
                return null;
            }
        }

        /// <summary>User is the user you're testing for.</summary>
        /// <remarks>
        /// If you specify "User" but not "Groups", then is it interpreted as "What if User were not a member of any groups
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#user
        /// </remarks>
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? User
        {
            get
            {
                return null;
            }
        }

        /// <summary>SubjectAccessReviewSpec is a description of the access request.</summary>
        /// <remarks>
        /// Exactly one of ResourceAuthorizationAttributes and NonResourceAuthorizationAttributes must be set
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ISubjectAccessReviewSpec), fullyQualifiedName: "k8s.SubjectAccessReviewSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.ISubjectAccessReviewSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Extra corresponds to the user.Info.GetExtra() method from the authenticator.  Since that is input to the authorizer it needs a reflection here.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#extra
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extra", typeJson: "{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string[]>? Extra
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string[]>?>();
            }

            /// <summary>Groups is the groups you're testing for.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#groups
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Groups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>NonResourceAttributes describes information for a non-resource access request.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#nonResourceAttributes
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nonResourceAttributes", typeJson: "{\"fqn\":\"k8s.NonResourceAttributes\"}", isOptional: true)]
            public K8s.INonResourceAttributes? NonResourceAttributes
            {
                get => GetInstanceProperty<K8s.INonResourceAttributes?>();
            }

            /// <summary>ResourceAuthorizationAttributes describes information for a resource access request.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#resourceAttributes
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceAttributes", typeJson: "{\"fqn\":\"k8s.ResourceAttributes\"}", isOptional: true)]
            public K8s.IResourceAttributes? ResourceAttributes
            {
                get => GetInstanceProperty<K8s.IResourceAttributes?>();
            }

            /// <summary>UID information about the requesting user.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.authorization.v1.SubjectAccessReviewSpec#uid
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uid
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
