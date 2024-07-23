using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>NamedResourcesResources is used in ResourceModel.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesResources
    /// </remarks>
    [JsiiByValue(fqn: "k8s.NamedResourcesResourcesV1Alpha2")]
    public class NamedResourcesResourcesV1Alpha2 : K8s.INamedResourcesResourcesV1Alpha2
    {
        /// <summary>The list of all individual resources instances currently available.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesResources#instances
        /// </remarks>
        [JsiiProperty(name: "instances", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NamedResourcesInstanceV1Alpha2\"},\"kind\":\"array\"}}")]
        public K8s.INamedResourcesInstanceV1Alpha2[] Instances
        {
            get;
            set;
        }
    }
}
