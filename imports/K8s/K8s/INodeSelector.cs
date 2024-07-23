using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>A node selector represents the union of the results of one or more label queries over a set of nodes;</summary>
    /// <remarks>
    /// that is, it represents the OR of the selectors represented by the node selector terms.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelector
    /// </remarks>
    [JsiiInterface(nativeType: typeof(INodeSelector), fullyQualifiedName: "k8s.NodeSelector")]
    public interface INodeSelector
    {
        /// <summary>Required.</summary>
        /// <remarks>
        /// A list of node selector terms. The terms are ORed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelector#nodeSelectorTerms
        /// </remarks>
        [JsiiProperty(name: "nodeSelectorTerms", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NodeSelectorTerm\"},\"kind\":\"array\"}}")]
        K8s.INodeSelectorTerm[] NodeSelectorTerms
        {
            get;
        }

        /// <summary>A node selector represents the union of the results of one or more label queries over a set of nodes;</summary>
        /// <remarks>
        /// that is, it represents the OR of the selectors represented by the node selector terms.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelector
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(INodeSelector), fullyQualifiedName: "k8s.NodeSelector")]
        internal sealed class _Proxy : DeputyBase, K8s.INodeSelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Required.</summary>
            /// <remarks>
            /// A list of node selector terms. The terms are ORed.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelector#nodeSelectorTerms
            /// </remarks>
            [JsiiProperty(name: "nodeSelectorTerms", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NodeSelectorTerm\"},\"kind\":\"array\"}}")]
            public K8s.INodeSelectorTerm[] NodeSelectorTerms
            {
                get => GetInstanceProperty<K8s.INodeSelectorTerm[]>()!;
            }
        }
    }
}
