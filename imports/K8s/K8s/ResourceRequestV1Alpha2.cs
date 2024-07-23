using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceRequest is a request for resources from one particular driver.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceRequest
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ResourceRequestV1Alpha2")]
    public class ResourceRequestV1Alpha2 : K8s.IResourceRequestV1Alpha2
    {
        /// <summary>NamedResources describes a request for resources with the named resources model.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceRequest#namedResources
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namedResources", typeJson: "{\"fqn\":\"k8s.NamedResourcesRequestV1Alpha2\"}", isOptional: true)]
        public K8s.INamedResourcesRequestV1Alpha2? NamedResources
        {
            get;
            set;
        }

        /// <summary>VendorParameters are arbitrary setup parameters for the requested resource.</summary>
        /// <remarks>
        /// They are ignored while allocating a claim.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceRequest#vendorParameters
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "vendorParameters", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        public object? VendorParameters
        {
            get;
            set;
        }
    }
}
