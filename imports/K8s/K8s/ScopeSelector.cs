using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>A scope selector represents the AND of the selectors represented by the scoped-resource selector requirements.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ScopeSelector
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ScopeSelector")]
    public class ScopeSelector : K8s.IScopeSelector
    {
        /// <summary>A list of scope selector requirements by scope of the resources.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScopeSelector#matchExpressions
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchExpressions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ScopedResourceSelectorRequirement\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IScopedResourceSelectorRequirement[]? MatchExpressions
        {
            get;
            set;
        }
    }
}
