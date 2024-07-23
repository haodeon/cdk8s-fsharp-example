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
    [JsiiInterface(nativeType: typeof(INodeSelectorTerm), fullyQualifiedName: "k8s.NodeSelectorTerm")]
    public interface INodeSelectorTerm
    {
        /// <summary>A list of node selector requirements by node's labels.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelectorTerm#matchExpressions
        /// </remarks>
        [JsiiProperty(name: "matchExpressions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NodeSelectorRequirement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INodeSelectorRequirement[]? MatchExpressions
        {
            get
            {
                return null;
            }
        }

        /// <summary>A list of node selector requirements by node's fields.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelectorTerm#matchFields
        /// </remarks>
        [JsiiProperty(name: "matchFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NodeSelectorRequirement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INodeSelectorRequirement[]? MatchFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>A null or empty node selector term matches no objects.</summary>
        /// <remarks>
        /// The requirements of them are ANDed. The TopologySelectorTerm type implements a subset of the NodeSelectorTerm.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelectorTerm
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(INodeSelectorTerm), fullyQualifiedName: "k8s.NodeSelectorTerm")]
        internal sealed class _Proxy : DeputyBase, K8s.INodeSelectorTerm
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A list of node selector requirements by node's labels.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelectorTerm#matchExpressions
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchExpressions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NodeSelectorRequirement\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.INodeSelectorRequirement[]? MatchExpressions
            {
                get => GetInstanceProperty<K8s.INodeSelectorRequirement[]?>();
            }

            /// <summary>A list of node selector requirements by node's fields.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelectorTerm#matchFields
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NodeSelectorRequirement\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.INodeSelectorRequirement[]? MatchFields
            {
                get => GetInstanceProperty<K8s.INodeSelectorRequirement[]?>();
            }
        }
    }
}
