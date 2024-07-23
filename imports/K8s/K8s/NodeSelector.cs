using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>A node selector represents the union of the results of one or more label queries over a set of nodes;</summary>
    /// <remarks>
    /// that is, it represents the OR of the selectors represented by the node selector terms.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelector
    /// </remarks>
    [JsiiByValue(fqn: "k8s.NodeSelector")]
    public class NodeSelector : K8s.INodeSelector
    {
        /// <summary>Required.</summary>
        /// <remarks>
        /// A list of node selector terms. The terms are ORed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelector#nodeSelectorTerms
        /// </remarks>
        [JsiiProperty(name: "nodeSelectorTerms", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NodeSelectorTerm\"},\"kind\":\"array\"}}")]
        public K8s.INodeSelectorTerm[] NodeSelectorTerms
        {
            get;
            set;
        }
    }
}
