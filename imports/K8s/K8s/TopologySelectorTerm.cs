using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>A topology selector term represents the result of label queries.</summary>
    /// <remarks>
    /// A null or empty topology selector term matches no objects. The requirements of them are ANDed. It provides a subset of functionality as NodeSelectorTerm. This is an alpha feature and may change in the future.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySelectorTerm
    /// </remarks>
    [JsiiByValue(fqn: "k8s.TopologySelectorTerm")]
    public class TopologySelectorTerm : K8s.ITopologySelectorTerm
    {
        /// <summary>A list of topology selector requirements by labels.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySelectorTerm#matchLabelExpressions
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchLabelExpressions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.TopologySelectorLabelRequirement\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.ITopologySelectorLabelRequirement[]? MatchLabelExpressions
        {
            get;
            set;
        }
    }
}
