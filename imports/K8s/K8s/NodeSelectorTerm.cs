using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>A null or empty node selector term matches no objects.</summary>
    /// <remarks>
    /// The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelectorTerm
    /// </remarks>
    [JsiiByValue(fqn: "k8s.NodeSelectorTerm")]
    public class NodeSelectorTerm : K8s.INodeSelectorTerm
    {
        /// <summary>A list of node selector requirements by node's labels.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelectorTerm#matchExpressions
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchExpressions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NodeSelectorRequirement\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.INodeSelectorRequirement[]? MatchExpressions
        {
            get;
            set;
        }

        /// <summary>A list of node selector requirements by node's fields.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelectorTerm#matchFields
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NodeSelectorRequirement\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.INodeSelectorRequirement[]? MatchFields
        {
            get;
            set;
        }
    }
}
