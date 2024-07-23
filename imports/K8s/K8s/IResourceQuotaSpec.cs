using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceQuotaSpec defines the desired hard limits to enforce for Quota.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuotaSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IResourceQuotaSpec), fullyQualifiedName: "k8s.ResourceQuotaSpec")]
    public interface IResourceQuotaSpec
    {
        /// <summary>hard is the set of desired hard limits for each named resource.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuotaSpec#hard
        /// </remarks>
        [JsiiProperty(name: "hard", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, K8s.Quantity>? Hard
        {
            get
            {
                return null;
            }
        }

        /// <summary>A collection of filters that must match each object tracked by a quota.</summary>
        /// <remarks>
        /// If not specified, the quota matches all objects.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuotaSpec#scopes
        /// </remarks>
        [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Scopes
        {
            get
            {
                return null;
            }
        }

        /// <summary>scopeSelector is also a collection of filters like scopes that must match each object tracked by a quota but expressed using ScopeSelectorOperator in combination with possible values.</summary>
        /// <remarks>
        /// For a resource to match, both scopes AND scopeSelector (if specified in spec), must be matched.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuotaSpec#scopeSelector
        /// </remarks>
        [JsiiProperty(name: "scopeSelector", typeJson: "{\"fqn\":\"k8s.ScopeSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IScopeSelector? ScopeSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>ResourceQuotaSpec defines the desired hard limits to enforce for Quota.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuotaSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IResourceQuotaSpec), fullyQualifiedName: "k8s.ResourceQuotaSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.IResourceQuotaSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>hard is the set of desired hard limits for each named resource.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/policy/resource-quotas/
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuotaSpec#hard
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hard", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, K8s.Quantity>? Hard
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, K8s.Quantity>?>();
            }

            /// <summary>A collection of filters that must match each object tracked by a quota.</summary>
            /// <remarks>
            /// If not specified, the quota matches all objects.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuotaSpec#scopes
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scopes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Scopes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>scopeSelector is also a collection of filters like scopes that must match each object tracked by a quota but expressed using ScopeSelectorOperator in combination with possible values.</summary>
            /// <remarks>
            /// For a resource to match, both scopes AND scopeSelector (if specified in spec), must be matched.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceQuotaSpec#scopeSelector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scopeSelector", typeJson: "{\"fqn\":\"k8s.ScopeSelector\"}", isOptional: true)]
            public K8s.IScopeSelector? ScopeSelector
            {
                get => GetInstanceProperty<K8s.IScopeSelector?>();
            }
        }
    }
}
