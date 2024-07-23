using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>CSINode holds information about all CSI drivers installed on a node.</summary>
    /// <remarks>
    /// CSI drivers do not need to create the CSINode object directly. As long as they use the node-driver-registrar sidecar container, the kubelet will automatically populate the CSINode object for the CSI driver as part of kubelet plugin registration. CSINode has the same name as a node. If the object is missing, it means either there are no CSI Drivers available on the node, or the Kubelet version is low enough that it doesn't create this object. CSINode has an OwnerReference that points to the corresponding node object.
    ///
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINode
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeCsiNodeProps")]
    public class KubeCsiNodeProps : K8s.IKubeCsiNodeProps
    {
        /// <summary>spec is the specification of CSINode.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINode#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.CsiNodeSpec\"}")]
        public K8s.ICsiNodeSpec Spec
        {
            get;
            set;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// metadata.name must be the Kubernetes node name.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINode#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }
    }
}
