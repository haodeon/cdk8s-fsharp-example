using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Pod anti affinity is a group of inter pod anti affinity scheduling rules.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAntiAffinity
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPodAntiAffinity), fullyQualifiedName: "k8s.PodAntiAffinity")]
    public interface IPodAntiAffinity
    {
        /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions.</summary>
        /// <remarks>
        /// The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAntiAffinity#preferredDuringSchedulingIgnoredDuringExecution
        /// </remarks>
        [JsiiProperty(name: "preferredDuringSchedulingIgnoredDuringExecution", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.WeightedPodAffinityTerm\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IWeightedPodAffinityTerm[]? PreferredDuringSchedulingIgnoredDuringExecution
        {
            get
            {
                return null;
            }
        }

        /// <summary>If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node.</summary>
        /// <remarks>
        /// If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAntiAffinity#requiredDuringSchedulingIgnoredDuringExecution
        /// </remarks>
        [JsiiProperty(name: "requiredDuringSchedulingIgnoredDuringExecution", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.PodAffinityTerm\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPodAffinityTerm[]? RequiredDuringSchedulingIgnoredDuringExecution
        {
            get
            {
                return null;
            }
        }

        /// <summary>Pod anti affinity is a group of inter pod anti affinity scheduling rules.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAntiAffinity
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPodAntiAffinity), fullyQualifiedName: "k8s.PodAntiAffinity")]
        internal sealed class _Proxy : DeputyBase, K8s.IPodAntiAffinity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The scheduler will prefer to schedule pods to nodes that satisfy the anti-affinity expressions specified by this field, but it may choose a node that violates one or more of the expressions.</summary>
            /// <remarks>
            /// The node that is most preferred is the one with the greatest sum of weights, i.e. for each node that meets all of the scheduling requirements (resource request, requiredDuringScheduling anti-affinity expressions, etc.), compute a sum by iterating through the elements of this field and adding "weight" to the sum if the node has pods which matches the corresponding podAffinityTerm; the node(s) with the highest sum are the most preferred.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAntiAffinity#preferredDuringSchedulingIgnoredDuringExecution
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preferredDuringSchedulingIgnoredDuringExecution", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.WeightedPodAffinityTerm\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IWeightedPodAffinityTerm[]? PreferredDuringSchedulingIgnoredDuringExecution
            {
                get => GetInstanceProperty<K8s.IWeightedPodAffinityTerm[]?>();
            }

            /// <summary>If the anti-affinity requirements specified by this field are not met at scheduling time, the pod will not be scheduled onto the node.</summary>
            /// <remarks>
            /// If the anti-affinity requirements specified by this field cease to be met at some point during pod execution (e.g. due to a pod label update), the system may or may not try to eventually evict the pod from its node. When there are multiple elements, the lists of nodes corresponding to each podAffinityTerm are intersected, i.e. all terms must be satisfied.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAntiAffinity#requiredDuringSchedulingIgnoredDuringExecution
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requiredDuringSchedulingIgnoredDuringExecution", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.PodAffinityTerm\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IPodAffinityTerm[]? RequiredDuringSchedulingIgnoredDuringExecution
            {
                get => GetInstanceProperty<K8s.IPodAffinityTerm[]?>();
            }
        }
    }
}
