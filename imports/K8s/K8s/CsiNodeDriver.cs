using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>CSINodeDriver holds information about the specification of one CSI driver installed on a node.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeDriver
    /// </remarks>
    [JsiiByValue(fqn: "k8s.CsiNodeDriver")]
    public class CsiNodeDriver : K8s.ICsiNodeDriver
    {
        /// <summary>name represents the name of the CSI driver that this object refers to.</summary>
        /// <remarks>
        /// This MUST be the same name returned by the CSI GetPluginName() call for that driver.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeDriver#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>nodeID of the node from the driver point of view.</summary>
        /// <remarks>
        /// This field enables Kubernetes to communicate with storage systems that do not share the same nomenclature for nodes. For example, Kubernetes may refer to a given node as "node1", but the storage system may refer to the same node as "nodeA". When Kubernetes issues a command to the storage system to attach a volume to a specific node, it can use this field to refer to the node name using the ID that the storage system will understand, e.g. "nodeA" instead of "node1". This field is required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeDriver#nodeID
        /// </remarks>
        [JsiiProperty(name: "nodeId", typeJson: "{\"primitive\":\"string\"}")]
        public string NodeId
        {
            get;
            set;
        }

        /// <summary>allocatable represents the volume resources of a node that are available for scheduling.</summary>
        /// <remarks>
        /// This field is beta.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeDriver#allocatable
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allocatable", typeJson: "{\"fqn\":\"k8s.VolumeNodeResources\"}", isOptional: true)]
        public K8s.IVolumeNodeResources? Allocatable
        {
            get;
            set;
        }

        /// <summary>topologyKeys is the list of keys supported by the driver.</summary>
        /// <remarks>
        /// When a driver is initialized on a cluster, it provides a set of topology keys that it understands (e.g. "company.com/zone", "company.com/region"). When a driver is initialized on a node, it provides the same topology keys along with values. Kubelet will expose these topology keys as labels on its own node object. When Kubernetes does topology aware provisioning, it can use this list to determine which labels it should retrieve from the node object and pass back to the driver. It is possible for different nodes to use different topology keys. This can be empty if driver does not support topology.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeDriver#topologyKeys
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "topologyKeys", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? TopologyKeys
        {
            get;
            set;
        }
    }
}
