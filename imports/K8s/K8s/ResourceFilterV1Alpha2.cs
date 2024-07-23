using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceFilter is a filter for resources from one particular driver.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceFilter
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ResourceFilterV1Alpha2")]
    public class ResourceFilterV1Alpha2 : K8s.IResourceFilterV1Alpha2
    {
        /// <summary>DriverName is the name used by the DRA driver kubelet plugin.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceFilter#driverName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DriverName
        {
            get;
            set;
        }

        /// <summary>NamedResources describes a resource filter using the named resources model.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceFilter#namedResources
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namedResources", typeJson: "{\"fqn\":\"k8s.NamedResourcesFilterV1Alpha2\"}", isOptional: true)]
        public K8s.INamedResourcesFilterV1Alpha2? NamedResources
        {
            get;
            set;
        }
    }
}
