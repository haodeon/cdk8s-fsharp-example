using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAffinityTerm
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPodAffinityTerm), fullyQualifiedName: "k8s.PodAffinityTerm")]
    public interface IPodAffinityTerm
    {
        /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running.</summary>
        /// <remarks>
        /// Empty topologyKey is not allowed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAffinityTerm#topologyKey
        /// </remarks>
        [JsiiProperty(name: "topologyKey", typeJson: "{\"primitive\":\"string\"}")]
        string TopologyKey
        {
            get;
        }

        /// <summary>A label query over a set of resources, in this case pods.</summary>
        /// <remarks>
        /// If it's null, this PodAffinityTerm matches with no Pods.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAffinityTerm#labelSelector
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

        /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration.</summary>
        /// <remarks>
        /// The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with <c>labelSelector</c> as <c>key in (value)</c> to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAffinityTerm#matchLabelKeys
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

        /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration.</summary>
        /// <remarks>
        /// The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with <c>labelSelector</c> as <c>key notin (value)</c> to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAffinityTerm#mismatchLabelKeys
        /// </remarks>
        [JsiiProperty(name: "mismatchLabelKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MismatchLabelKeys
        {
            get
            {
                return null;
            }
        }

        /// <summary>namespaces specifies a static list of namespace names that the term applies to.</summary>
        /// <remarks>
        /// The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAffinityTerm#namespaces
        /// </remarks>
        [JsiiProperty(name: "namespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Namespaces
        {
            get
            {
                return null;
            }
        }

        /// <summary>A label query over the set of namespaces that the term applies to.</summary>
        /// <remarks>
        /// The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAffinityTerm#namespaceSelector
        /// </remarks>
        [JsiiProperty(name: "namespaceSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILabelSelector? NamespaceSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Defines a set of pods (namely those matching the labelSelector relative to the given namespace(s)) that this pod should be co-located (affinity) or not co-located (anti-affinity) with, where co-located is defined as running on a node whose value of the label with key &lt;topologyKey&gt; matches that of any node on which a pod of the set of pods is running.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAffinityTerm
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPodAffinityTerm), fullyQualifiedName: "k8s.PodAffinityTerm")]
        internal sealed class _Proxy : DeputyBase, K8s.IPodAffinityTerm
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>This pod should be co-located (affinity) or not co-located (anti-affinity) with the pods matching the labelSelector in the specified namespaces, where co-located is defined as running on a node whose value of the label with key topologyKey matches that of any node on which any of the selected pods is running.</summary>
            /// <remarks>
            /// Empty topologyKey is not allowed.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAffinityTerm#topologyKey
            /// </remarks>
            [JsiiProperty(name: "topologyKey", typeJson: "{\"primitive\":\"string\"}")]
            public string TopologyKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>A label query over a set of resources, in this case pods.</summary>
            /// <remarks>
            /// If it's null, this PodAffinityTerm matches with no Pods.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAffinityTerm#labelSelector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "labelSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
            public K8s.ILabelSelector? LabelSelector
            {
                get => GetInstanceProperty<K8s.ILabelSelector?>();
            }

            /// <summary>MatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration.</summary>
            /// <remarks>
            /// The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with <c>labelSelector</c> as <c>key in (value)</c> to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both matchLabelKeys and labelSelector. Also, matchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAffinityTerm#matchLabelKeys
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchLabelKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MatchLabelKeys
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>MismatchLabelKeys is a set of pod label keys to select which pods will be taken into consideration.</summary>
            /// <remarks>
            /// The keys are used to lookup values from the incoming pod labels, those key-value labels are merged with <c>labelSelector</c> as <c>key notin (value)</c> to select the group of existing pods which pods will be taken into consideration for the incoming pod's pod (anti) affinity. Keys that don't exist in the incoming pod labels will be ignored. The default value is empty. The same key is forbidden to exist in both mismatchLabelKeys and labelSelector. Also, mismatchLabelKeys cannot be set when labelSelector isn't set. This is an alpha field and requires enabling MatchLabelKeysInPodAffinity feature gate.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAffinityTerm#mismatchLabelKeys
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mismatchLabelKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MismatchLabelKeys
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>namespaces specifies a static list of namespace names that the term applies to.</summary>
            /// <remarks>
            /// The term is applied to the union of the namespaces listed in this field and the ones selected by namespaceSelector. null or empty namespaces list and null namespaceSelector means "this pod's namespace".
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAffinityTerm#namespaces
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespaces", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Namespaces
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>A label query over the set of namespaces that the term applies to.</summary>
            /// <remarks>
            /// The term is applied to the union of the namespaces selected by this field and the ones listed in the namespaces field. null selector and null or empty namespaces list means "this pod's namespace". An empty selector ({}) matches all namespaces.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodAffinityTerm#namespaceSelector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespaceSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
            public K8s.ILabelSelector? NamespaceSelector
            {
                get => GetInstanceProperty<K8s.ILabelSelector?>();
            }
        }
    }
}
