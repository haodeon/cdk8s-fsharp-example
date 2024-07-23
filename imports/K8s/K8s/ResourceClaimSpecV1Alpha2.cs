using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ResourceClaimSpec defines how a resource is to be allocated.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ResourceClaimSpecV1Alpha2")]
    public class ResourceClaimSpecV1Alpha2 : K8s.IResourceClaimSpecV1Alpha2
    {
        /// <summary>ResourceClassName references the driver and additional parameters via the name of a ResourceClass that was created as part of the driver deployment.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimSpec#resourceClassName
        /// </remarks>
        [JsiiProperty(name: "resourceClassName", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceClassName
        {
            get;
            set;
        }

        /// <summary>Allocation can start immediately or when a Pod wants to use the resource.</summary>
        /// <remarks>
        /// "WaitForFirstConsumer" is the default.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimSpec#allocationMode
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allocationMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? AllocationMode
        {
            get;
            set;
        }

        /// <summary>ParametersRef references a separate object with arbitrary parameters that will be used by the driver when allocating a resource for the claim.</summary>
        /// <remarks>
        /// The object must be in the same namespace as the ResourceClaim.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimSpec#parametersRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parametersRef", typeJson: "{\"fqn\":\"k8s.ResourceClaimParametersReferenceV1Alpha2\"}", isOptional: true)]
        public K8s.IResourceClaimParametersReferenceV1Alpha2? ParametersRef
        {
            get;
            set;
        }
    }
}
