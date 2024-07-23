using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NodeSpec describes the attributes that a node is created with.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.NodeSpec")]
    public class NodeSpec : K8s.INodeSpec
    {
        /// <summary>Deprecated: Previously used to specify the source of the node's configuration for the DynamicKubeletConfig feature.</summary>
        /// <remarks>
        /// This feature is removed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSpec#configSource
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configSource", typeJson: "{\"fqn\":\"k8s.NodeConfigSource\"}", isOptional: true)]
        public K8s.INodeConfigSource? ConfigSource
        {
            get;
            set;
        }

        /// <summary>Deprecated.</summary>
        /// <remarks>
        /// Not all kubelets will set this field. Remove field after 1.13. see: https://issues.k8s.io/61966
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSpec#externalID
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "externalId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ExternalId
        {
            get;
            set;
        }

        /// <summary>PodCIDR represents the pod IP range assigned to the node.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSpec#podCIDR
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "podCidr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PodCidr
        {
            get;
            set;
        }

        /// <summary>podCIDRs represents the IP ranges assigned to the node for usage by Pods on that node.</summary>
        /// <remarks>
        /// If this field is specified, the 0th entry must match the podCIDR field. It may contain at most 1 value for each of IPv4 and IPv6.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSpec#podCIDRs
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "podCidRs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PodCidRs
        {
            get;
            set;
        }

        /// <summary>ID of the node assigned by the cloud provider in the format: &lt;ProviderName&gt;://&lt;ProviderSpecificNodeID&gt;.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSpec#providerID
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "providerId", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ProviderId
        {
            get;
            set;
        }

        /// <summary>If specified, the node's taints.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSpec#taints
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "taints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Taint\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.ITaint[]? Taints
        {
            get;
            set;
        }

        /// <summary>Unschedulable controls node schedulability of new pods.</summary>
        /// <remarks>
        /// By default, node is schedulable. More info: https://kubernetes.io/docs/concepts/nodes/node/#manual-node-administration
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSpec#unschedulable
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "unschedulable", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? Unschedulable
        {
            get;
            set;
        }
    }
}
