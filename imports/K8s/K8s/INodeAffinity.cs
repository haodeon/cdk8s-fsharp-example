using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Node affinity is a group of node affinity scheduling rules.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeAffinity
    /// </remarks>
    [JsiiInterface(nativeType: typeof(INodeAffinity), fullyQualifiedName: "k8s.NodeAffinity")]
    public interface INodeAffinity
    {
        /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions.</summary>
        /// <remarks>
        /// The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeAffinity#preferredDuringSchedulingIgnoredDuringExecution
        /// </remarks>
        [JsiiProperty(name: "preferredDuringSchedulingIgnoredDuringExecution", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.PreferredSchedulingTerm\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPreferredSchedulingTerm[]? PreferredDuringSchedulingIgnoredDuringExecution
        {
            get
            {
                return null;
            }
        }

        /// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node.</summary>
        /// <remarks>
        /// If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeAffinity#requiredDuringSchedulingIgnoredDuringExecution
        /// </remarks>
        [JsiiProperty(name: "requiredDuringSchedulingIgnoredDuringExecution", typeJson: "{\"fqn\":\"k8s.NodeSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INodeSelector? RequiredDuringSchedulingIgnoredDuringExecution
        {
            get
            {
                return null;
            }
        }

        /// <summary>Node affinity is a group of node affinity scheduling rules.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeAffinity
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(INodeAffinity), fullyQualifiedName: "k8s.NodeAffinity")]
        internal sealed class _Proxy : DeputyBase, K8s.INodeAffinity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions.</summary>
            /// <remarks>
            /// The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node matches the corresponding matchExpressions; the node(s) with the highest sum are the most preferred.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeAffinity#preferredDuringSchedulingIgnoredDuringExecution
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferredDuringSchedulingIgnoredDuringExecution", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.PreferredSchedulingTerm\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IPreferredSchedulingTerm[]? PreferredDuringSchedulingIgnoredDuringExecution
            {
                get => GetInstanceProperty<K8s.IPreferredSchedulingTerm[]?>();
            }

            /// <summary>If the affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node.</summary>
            /// <remarks>
            /// If the affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to an update), the system may or may not try to eventually evict the pod from its node.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeAffinity#requiredDuringSchedulingIgnoredDuringExecution
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requiredDuringSchedulingIgnoredDuringExecution", typeJson: "{\"fqn\":\"k8s.NodeSelector\"}", isOptional: true)]
            public K8s.INodeSelector? RequiredDuringSchedulingIgnoredDuringExecution
            {
                get => GetInstanceProperty<K8s.INodeSelector?>();
            }
        }
    }
}
