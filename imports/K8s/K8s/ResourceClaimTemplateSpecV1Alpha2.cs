using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ResourceClaimTemplateSpec contains the metadata and fields for a ResourceClaim.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplateSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ResourceClaimTemplateSpecV1Alpha2")]
    public class ResourceClaimTemplateSpecV1Alpha2 : K8s.IResourceClaimTemplateSpecV1Alpha2
    {
        /// <summary>Spec for the ResourceClaim.</summary>
        /// <remarks>
        /// The entire content is copied unchanged into the ResourceClaim that gets created from this template. The same fields as in a ResourceClaim are also valid here.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplateSpec#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ResourceClaimSpecV1Alpha2\"}")]
        public K8s.IResourceClaimSpecV1Alpha2 Spec
        {
            get;
            set;
        }

        /// <summary>ObjectMeta may contain labels and annotations that will be copied into the PVC when creating it.</summary>
        /// <remarks>
        /// No other fields are allowed and will be rejected during validation.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplateSpec#metadata
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
