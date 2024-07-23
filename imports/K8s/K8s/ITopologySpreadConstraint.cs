using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>TopologySpreadConstraint specifies how to spread matching pods among the given topology.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ITopologySpreadConstraint), fullyQualifiedName: "k8s.TopologySpreadConstraint")]
    public interface ITopologySpreadConstraint
    {
        /// <summary>MaxSkew describes the degree to which pods may be unevenly distributed.</summary>
        /// <remarks>
        /// When <c>whenUnsatisfiable=DoNotSchedule</c>, it is the maximum permitted difference between the number of matching pods in the target topology and the global minimum. The global minimum is the minimum number of matching pods in an eligible domain or zero if the number of eligible domains is less than MinDomains. For example, in a 3-zone cluster, MaxSkew is set to 1, and pods with the same labelSelector spread as 2/2/1: In this case, the global minimum is 1. | zone1 | zone2 | zone3 | |  P P  |  P P  |   P   | - if MaxSkew is 1, incoming pod can only be scheduled to zone3 to become 2/2/2; scheduling it onto zone1(zone2) would make the ActualSkew(3-1) on zone1(zone2) violate MaxSkew(1). - if MaxSkew is 2, incoming pod can be scheduled onto any zone. When <c>whenUnsatisfiable=ScheduleAnyway</c>, it is used to give higher precedence to topologies that satisfy it. It's a required field. Default value is 1 and 0 is not allowed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint#maxSkew
        /// </remarks>
        [JsiiProperty(name: "maxSkew", typeJson: "{\"primitive\":\"number\"}")]
        double MaxSkew
        {
            get;
        }

        /// <summary>TopologyKey is the key of node labels.</summary>
        /// <remarks>
        /// Nodes that have a label with this key and identical values are considered to be in the same topology. We consider each &lt;key, value&gt; as a "bucket", and try to put balanced number of pods into each bucket. We define a domain as a particular instance of a topology. Also, we define an eligible domain as a domain whose nodes meet the requirements of nodeAffinityPolicy and nodeTaintsPolicy. e.g. If TopologyKey is "kubernetes.io/hostname", each Node is a domain of that topology. And, if TopologyKey is "topology.kubernetes.io/zone", each zone is a domain of that topology. It's a required field.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint#topologyKey
        /// </remarks>
        [JsiiProperty(name: "topologyKey", typeJson: "{\"primitive\":\"string\"}")]
        string TopologyKey
        {
            get;
        }

        /// <summary>WhenUnsatisfiable indicates how to deal with a pod if it doesn't satisfy the spread constraint.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description>DoNotSchedule (default) tells the scheduler not to schedule it. - ScheduleAnyway tells the scheduler to schedule the pod in any location,
        /// but giving higher precedence to topologies that would help reduce the
        /// skew.
        /// A constraint is considered "Unsatisfiable" for an incoming pod if and only if every possible node assignment for that pod would violate "MaxSkew" on some topology. For example, in a 3-zone cluster, MaxSkew is set to 1, and pods with the same labelSelector spread as 3/1/1: | zone1 | zone2 | zone3 | | P P P |   P   |   P   | If WhenUnsatisfiable is set to DoNotSchedule, incoming pod can only be scheduled to zone2(zone3) to become 3/2/1(3/1/2) as ActualSkew(2-1) on zone2(zone3) satisfies MaxSkew(1). In other words, the cluster can still be imbalanced, but scheduler won't make it <em>more</em> imbalanced. It's a required field.</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint#whenUnsatisfiable
        /// </remarks>
        [JsiiProperty(name: "whenUnsatisfiable", typeJson: "{\"primitive\":\"string\"}")]
        string WhenUnsatisfiable
        {
            get;
        }

        /// <summary>LabelSelector is used to find matching pods.</summary>
        /// <remarks>
        /// Pods that match this label selector are counted to determine the number of pods in their corresponding topology domain.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint#labelSelector
        /// </remarks>
        [JsiiProperty(name: "labelSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILabelSelector? LabelSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>MatchLabelKeys is a set of pod label keys to select the pods over which spreading will be calculated.</summary>
        /// <remarks>
        /// The keys are used to lookup values from the incoming pod labels, those key-value labels are ANDed with labelSelector to select the group of existing pods over which spreading will be calculated for the incoming pod. The same key is forbidden to exist in both MatchLabelKeys and LabelSelector. MatchLabelKeys cannot be set when LabelSelector isn't set. Keys that don't exist in the incoming pod labels will be ignored. A null or empty list means only match against labelSelector.
        ///
        /// This is a beta field and requires the MatchLabelKeysInPodTopologySpread feature gate to be enabled (enabled by default).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint#matchLabelKeys
        /// </remarks>
        [JsiiProperty(name: "matchLabelKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MatchLabelKeys
        {
            get
            {
                return null;
            }
        }

        /// <summary>MinDomains indicates a minimum number of eligible domains.</summary>
        /// <remarks>
        /// When the number of eligible domains with matching topology keys is less than minDomains, Pod Topology Spread treats "global minimum" as 0, and then the calculation of Skew is performed. And when the number of eligible domains with matching topology keys equals or greater than minDomains, this value has no effect on scheduling. As a result, when the number of eligible domains is less than minDomains, scheduler won't schedule more than maxSkew Pods to those domains. If value is nil, the constraint behaves as if MinDomains is equal to 1. Valid values are integers greater than 0. When value is not nil, WhenUnsatisfiable must be DoNotSchedule.
        ///
        /// For example, in a 3-zone cluster, MaxSkew is set to 2, MinDomains is set to 5 and pods with the same labelSelector spread as 2/2/2: | zone1 | zone2 | zone3 | |  P P  |  P P  |  P P  | The number of domains is less than 5(MinDomains), so "global minimum" is treated as 0. In this situation, new pod with the same labelSelector cannot be scheduled, because computed skew will be 3(3 - 0) if new Pod is scheduled to any of the three zones, it will violate MaxSkew.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint#minDomains
        /// </remarks>
        [JsiiProperty(name: "minDomains", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinDomains
        {
            get
            {
                return null;
            }
        }

        /// <summary>NodeAffinityPolicy indicates how we will treat Pod's nodeAffinity/nodeSelector when calculating pod topology spread skew.</summary>
        /// <remarks>
        /// Options are: - Honor: only nodes matching nodeAffinity/nodeSelector are included in the calculations. - Ignore: nodeAffinity/nodeSelector are ignored. All nodes are included in the calculations.
        ///
        /// If this value is nil, the behavior is equivalent to the Honor policy. This is a beta-level feature default enabled by the NodeInclusionPolicyInPodTopologySpread feature flag.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint#nodeAffinityPolicy
        /// </remarks>
        [JsiiProperty(name: "nodeAffinityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeAffinityPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>NodeTaintsPolicy indicates how we will treat node taints when calculating pod topology spread skew.</summary>
        /// <remarks>
        /// Options are: - Honor: nodes without taints, along with tainted nodes for which the incoming pod has a toleration, are included. - Ignore: node taints are ignored. All nodes are included.
        ///
        /// If this value is nil, the behavior is equivalent to the Ignore policy. This is a beta-level feature default enabled by the NodeInclusionPolicyInPodTopologySpread feature flag.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint#nodeTaintsPolicy
        /// </remarks>
        [JsiiProperty(name: "nodeTaintsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? NodeTaintsPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>TopologySpreadConstraint specifies how to spread matching pods among the given topology.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ITopologySpreadConstraint), fullyQualifiedName: "k8s.TopologySpreadConstraint")]
        internal sealed class _Proxy : DeputyBase, K8s.ITopologySpreadConstraint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>MaxSkew describes the degree to which pods may be unevenly distributed.</summary>
            /// <remarks>
            /// When <c>whenUnsatisfiable=DoNotSchedule</c>, it is the maximum permitted difference between the number of matching pods in the target topology and the global minimum. The global minimum is the minimum number of matching pods in an eligible domain or zero if the number of eligible domains is less than MinDomains. For example, in a 3-zone cluster, MaxSkew is set to 1, and pods with the same labelSelector spread as 2/2/1: In this case, the global minimum is 1. | zone1 | zone2 | zone3 | |  P P  |  P P  |   P   | - if MaxSkew is 1, incoming pod can only be scheduled to zone3 to become 2/2/2; scheduling it onto zone1(zone2) would make the ActualSkew(3-1) on zone1(zone2) violate MaxSkew(1). - if MaxSkew is 2, incoming pod can be scheduled onto any zone. When <c>whenUnsatisfiable=ScheduleAnyway</c>, it is used to give higher precedence to topologies that satisfy it. It's a required field. Default value is 1 and 0 is not allowed.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint#maxSkew
            /// </remarks>
            [JsiiProperty(name: "maxSkew", typeJson: "{\"primitive\":\"number\"}")]
            public double MaxSkew
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>TopologyKey is the key of node labels.</summary>
            /// <remarks>
            /// Nodes that have a label with this key and identical values are considered to be in the same topology. We consider each &lt;key, value&gt; as a "bucket", and try to put balanced number of pods into each bucket. We define a domain as a particular instance of a topology. Also, we define an eligible domain as a domain whose nodes meet the requirements of nodeAffinityPolicy and nodeTaintsPolicy. e.g. If TopologyKey is "kubernetes.io/hostname", each Node is a domain of that topology. And, if TopologyKey is "topology.kubernetes.io/zone", each zone is a domain of that topology. It's a required field.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint#topologyKey
            /// </remarks>
            [JsiiProperty(name: "topologyKey", typeJson: "{\"primitive\":\"string\"}")]
            public string TopologyKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>WhenUnsatisfiable indicates how to deal with a pod if it doesn't satisfy the spread constraint.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description>DoNotSchedule (default) tells the scheduler not to schedule it. - ScheduleAnyway tells the scheduler to schedule the pod in any location,
            /// but giving higher precedence to topologies that would help reduce the
            /// skew.
            /// A constraint is considered "Unsatisfiable" for an incoming pod if and only if every possible node assignment for that pod would violate "MaxSkew" on some topology. For example, in a 3-zone cluster, MaxSkew is set to 1, and pods with the same labelSelector spread as 3/1/1: | zone1 | zone2 | zone3 | | P P P |   P   |   P   | If WhenUnsatisfiable is set to DoNotSchedule, incoming pod can only be scheduled to zone2(zone3) to become 3/2/1(3/1/2) as ActualSkew(2-1) on zone2(zone3) satisfies MaxSkew(1). In other words, the cluster can still be imbalanced, but scheduler won't make it <em>more</em> imbalanced. It's a required field.</description>
            /// </list>
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint#whenUnsatisfiable
            /// </remarks>
            [JsiiProperty(name: "whenUnsatisfiable", typeJson: "{\"primitive\":\"string\"}")]
            public string WhenUnsatisfiable
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>LabelSelector is used to find matching pods.</summary>
            /// <remarks>
            /// Pods that match this label selector are counted to determine the number of pods in their corresponding topology domain.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint#labelSelector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "labelSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
            public K8s.ILabelSelector? LabelSelector
            {
                get => GetInstanceProperty<K8s.ILabelSelector?>();
            }

            /// <summary>MatchLabelKeys is a set of pod label keys to select the pods over which spreading will be calculated.</summary>
            /// <remarks>
            /// The keys are used to lookup values from the incoming pod labels, those key-value labels are ANDed with labelSelector to select the group of existing pods over which spreading will be calculated for the incoming pod. The same key is forbidden to exist in both MatchLabelKeys and LabelSelector. MatchLabelKeys cannot be set when LabelSelector isn't set. Keys that don't exist in the incoming pod labels will be ignored. A null or empty list means only match against labelSelector.
            ///
            /// This is a beta field and requires the MatchLabelKeysInPodTopologySpread feature gate to be enabled (enabled by default).
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint#matchLabelKeys
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchLabelKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MatchLabelKeys
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>MinDomains indicates a minimum number of eligible domains.</summary>
            /// <remarks>
            /// When the number of eligible domains with matching topology keys is less than minDomains, Pod Topology Spread treats "global minimum" as 0, and then the calculation of Skew is performed. And when the number of eligible domains with matching topology keys equals or greater than minDomains, this value has no effect on scheduling. As a result, when the number of eligible domains is less than minDomains, scheduler won't schedule more than maxSkew Pods to those domains. If value is nil, the constraint behaves as if MinDomains is equal to 1. Valid values are integers greater than 0. When value is not nil, WhenUnsatisfiable must be DoNotSchedule.
            ///
            /// For example, in a 3-zone cluster, MaxSkew is set to 2, MinDomains is set to 5 and pods with the same labelSelector spread as 2/2/2: | zone1 | zone2 | zone3 | |  P P  |  P P  |  P P  | The number of domains is less than 5(MinDomains), so "global minimum" is treated as 0. In this situation, new pod with the same labelSelector cannot be scheduled, because computed skew will be 3(3 - 0) if new Pod is scheduled to any of the three zones, it will violate MaxSkew.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint#minDomains
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minDomains", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinDomains
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>NodeAffinityPolicy indicates how we will treat Pod's nodeAffinity/nodeSelector when calculating pod topology spread skew.</summary>
            /// <remarks>
            /// Options are: - Honor: only nodes matching nodeAffinity/nodeSelector are included in the calculations. - Ignore: nodeAffinity/nodeSelector are ignored. All nodes are included in the calculations.
            ///
            /// If this value is nil, the behavior is equivalent to the Honor policy. This is a beta-level feature default enabled by the NodeInclusionPolicyInPodTopologySpread feature flag.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint#nodeAffinityPolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeAffinityPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeAffinityPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>NodeTaintsPolicy indicates how we will treat node taints when calculating pod topology spread skew.</summary>
            /// <remarks>
            /// Options are: - Honor: nodes without taints, along with tainted nodes for which the incoming pod has a toleration, are included. - Ignore: node taints are ignored. All nodes are included.
            ///
            /// If this value is nil, the behavior is equivalent to the Ignore policy. This is a beta-level feature default enabled by the NodeInclusionPolicyInPodTopologySpread feature flag.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySpreadConstraint#nodeTaintsPolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeTaintsPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? NodeTaintsPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
