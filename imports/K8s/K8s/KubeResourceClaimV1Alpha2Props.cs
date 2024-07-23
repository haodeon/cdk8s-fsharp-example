using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ResourceClaim describes which resources are needed by a resource consumer.</summary>
    /// <remarks>
    /// Its status tracks whether the resource has been allocated and what the resulting attributes are.
    ///
    /// This is an alpha type and requires enabling the DynamicResourceAllocation feature gate.
    ///
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaim
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeResourceClaimV1Alpha2Props")]
    public class KubeResourceClaimV1Alpha2Props : K8s.IKubeResourceClaimV1Alpha2Props
    {
        /// <summary>Spec describes the desired attributes of a resource that then needs to be allocated.</summary>
        /// <remarks>
        /// It can only be set once when creating the ResourceClaim.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaim#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ResourceClaimSpecV1Alpha2\"}")]
        public K8s.IResourceClaimSpecV1Alpha2 Spec
        {
            get;
            set;
        }

        /// <summary>Standard object metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaim#metadata
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
