using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>A scope selector represents the AND of the selectors represented by the scoped-resource selector requirements.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ScopeSelector
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IScopeSelector), fullyQualifiedName: "k8s.ScopeSelector")]
    public interface IScopeSelector
    {
        /// <summary>A list of scope selector requirements by scope of the resources.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScopeSelector#matchExpressions
        /// </remarks>
        [JsiiProperty(name: "matchExpressions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ScopedResourceSelectorRequirement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IScopedResourceSelectorRequirement[]? MatchExpressions
        {
            get
            {
                return null;
            }
        }

        /// <summary>A scope selector represents the AND of the selectors represented by the scoped-resource selector requirements.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScopeSelector
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IScopeSelector), fullyQualifiedName: "k8s.ScopeSelector")]
        internal sealed class _Proxy : DeputyBase, K8s.IScopeSelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A list of scope selector requirements by scope of the resources.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ScopeSelector#matchExpressions
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchExpressions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ScopedResourceSelectorRequirement\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IScopedResourceSelectorRequirement[]? MatchExpressions
            {
                get => GetInstanceProperty<K8s.IScopedResourceSelectorRequirement[]?>();
            }
        }
    }
}
