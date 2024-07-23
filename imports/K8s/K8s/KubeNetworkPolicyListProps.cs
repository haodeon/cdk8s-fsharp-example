using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>NetworkPolicyList is a list of NetworkPolicy objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeNetworkPolicyListProps")]
    public class KubeNetworkPolicyListProps : K8s.IKubeNetworkPolicyListProps
    {
        /// <summary>items is a list of schema objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeNetworkPolicyProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeNetworkPolicyProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.NetworkPolicyList#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
        public K8s.IListMeta? Metadata
        {
            get;
            set;
        }
    }
}
