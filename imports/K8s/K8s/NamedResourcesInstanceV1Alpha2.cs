using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>NamedResourcesInstance represents one individual hardware instance that can be selected based on its attributes.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesInstance
    /// </remarks>
    [JsiiByValue(fqn: "k8s.NamedResourcesInstanceV1Alpha2")]
    public class NamedResourcesInstanceV1Alpha2 : K8s.INamedResourcesInstanceV1Alpha2
    {
        /// <summary>Name is unique identifier among all resource instances managed by the driver on the node.</summary>
        /// <remarks>
        /// It must be a DNS subdomain.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesInstance#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Attributes defines the attributes of this resource instance.</summary>
        /// <remarks>
        /// The name of each attribute must be unique.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesInstance#attributes
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attributes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NamedResourcesAttributeV1Alpha2\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.INamedResourcesAttributeV1Alpha2[]? Attributes
        {
            get;
            set;
        }
    }
}
