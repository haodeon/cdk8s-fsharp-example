using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ResourceClass is used by administrators to influence how resources are allocated.</summary>
    /// <remarks>
    /// This is an alpha type and requires enabling the DynamicResourceAllocation feature gate.
    ///
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClass
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeResourceClassV1Alpha2Props")]
    public class KubeResourceClassV1Alpha2Props : K8s.IKubeResourceClassV1Alpha2Props
    {
        /// <summary>DriverName defines the name of the dynamic resource driver that is used for allocation of a ResourceClaim that uses this class.</summary>
        /// <remarks>
        /// Resource drivers have a unique name in forward domain order (acme.example.com).
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClass#driverName
        /// </remarks>
        [JsiiProperty(name: "driverName", typeJson: "{\"primitive\":\"string\"}")]
        public string DriverName
        {
            get;
            set;
        }

        /// <summary>Standard object metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClass#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>ParametersRef references an arbitrary separate object that may hold parameters that will be used by the driver when allocating a resource that uses this class.</summary>
        /// <remarks>
        /// A dynamic resource driver can distinguish between parameters stored here and and those stored in ResourceClaimSpec.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClass#parametersRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parametersRef", typeJson: "{\"fqn\":\"k8s.ResourceClassParametersReferenceV1Alpha2\"}", isOptional: true)]
        public K8s.IResourceClassParametersReferenceV1Alpha2? ParametersRef
        {
            get;
            set;
        }

        /// <summary>If and only if allocation of claims using this class is handled via structured parameters, then StructuredParameters must be set to true.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClass#structuredParameters
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "structuredParameters", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? StructuredParameters
        {
            get;
            set;
        }

        /// <summary>Only nodes matching the selector will be considered by the scheduler when trying to find a Node that fits a Pod when that Pod uses a ResourceClaim that has not been allocated yet.</summary>
        /// <remarks>
        /// Setting this field is optional. If null, all nodes are candidates.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClass#suitableNodes
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "suitableNodes", typeJson: "{\"fqn\":\"k8s.NodeSelector\"}", isOptional: true)]
        public K8s.INodeSelector? SuitableNodes
        {
            get;
            set;
        }
    }
}
