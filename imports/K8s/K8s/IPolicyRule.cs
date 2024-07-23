using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PolicyRule holds information that describes a policy rule, but does not contain information about who the rule applies to or which namespace the rule applies to.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.PolicyRule
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPolicyRule), fullyQualifiedName: "k8s.PolicyRule")]
    public interface IPolicyRule
    {
        /// <summary>Verbs is a list of Verbs that apply to ALL the ResourceKinds contained in this rule.</summary>
        /// <remarks>
        /// '*' represents all verbs.
        ///
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.PolicyRule#verbs
        /// </remarks>
        [JsiiProperty(name: "verbs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Verbs
        {
            get;
        }

        /// <summary>APIGroups is the name of the APIGroup that contains the resources.</summary>
        /// <remarks>
        /// If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed. "" represents the core API group and "*" represents all API groups.
        ///
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.PolicyRule#apiGroups
        /// </remarks>
        [JsiiProperty(name: "apiGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ApiGroups
        {
            get
            {
                return null;
            }
        }

        /// <summary>NonResourceURLs is a set of partial urls that a user should have access to.</summary>
        /// <remarks>
        /// *s are allowed, but only as the full, final step in the path Since non-resource URLs are not namespaced, this field is only applicable for ClusterRoles referenced from a ClusterRoleBinding. Rules can either apply to API resources (such as "pods" or "secrets") or non-resource URL paths (such as "/api"),  but not both.
        ///
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.PolicyRule#nonResourceURLs
        /// </remarks>
        [JsiiProperty(name: "nonResourceUrLs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? NonResourceUrLs
        {
            get
            {
                return null;
            }
        }

        /// <summary>ResourceNames is an optional white list of names that the rule applies to.</summary>
        /// <remarks>
        /// An empty set means that everything is allowed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.PolicyRule#resourceNames
        /// </remarks>
        [JsiiProperty(name: "resourceNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? ResourceNames
        {
            get
            {
                return null;
            }
        }

        /// <summary>Resources is a list of resources this rule applies to.</summary>
        /// <remarks>
        /// '*' represents all resources.
        ///
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.PolicyRule#resources
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Resources
        {
            get
            {
                return null;
            }
        }

        /// <summary>PolicyRule holds information that describes a policy rule, but does not contain information about who the rule applies to or which namespace the rule applies to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.PolicyRule
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPolicyRule), fullyQualifiedName: "k8s.PolicyRule")]
        internal sealed class _Proxy : DeputyBase, K8s.IPolicyRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Verbs is a list of Verbs that apply to ALL the ResourceKinds contained in this rule.</summary>
            /// <remarks>
            /// '*' represents all verbs.
            ///
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.PolicyRule#verbs
            /// </remarks>
            [JsiiProperty(name: "verbs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Verbs
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>APIGroups is the name of the APIGroup that contains the resources.</summary>
            /// <remarks>
            /// If multiple API groups are specified, any action requested against one of the enumerated resources in any API group will be allowed. "" represents the core API group and "*" represents all API groups.
            ///
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.PolicyRule#apiGroups
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiGroups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ApiGroups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>NonResourceURLs is a set of partial urls that a user should have access to.</summary>
            /// <remarks>
            /// *s are allowed, but only as the full, final step in the path Since non-resource URLs are not namespaced, this field is only applicable for ClusterRoles referenced from a ClusterRoleBinding. Rules can either apply to API resources (such as "pods" or "secrets") or non-resource URL paths (such as "/api"),  but not both.
            ///
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.PolicyRule#nonResourceURLs
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nonResourceUrLs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? NonResourceUrLs
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>ResourceNames is an optional white list of names that the rule applies to.</summary>
            /// <remarks>
            /// An empty set means that everything is allowed.
            ///
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.PolicyRule#resourceNames
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? ResourceNames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Resources is a list of resources this rule applies to.</summary>
            /// <remarks>
            /// '*' represents all resources.
            ///
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.PolicyRule#resources
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resources", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Resources
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
