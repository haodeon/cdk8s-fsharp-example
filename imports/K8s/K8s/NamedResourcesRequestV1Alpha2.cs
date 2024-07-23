using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>NamedResourcesRequest is used in ResourceRequestModel.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesRequest
    /// </remarks>
    [JsiiByValue(fqn: "k8s.NamedResourcesRequestV1Alpha2")]
    public class NamedResourcesRequestV1Alpha2 : K8s.INamedResourcesRequestV1Alpha2
    {
        /// <summary>Selector is a CEL expression which must evaluate to true if a resource instance is suitable.</summary>
        /// <remarks>
        /// The language is as defined in https://kubernetes.io/docs/reference/using-api/cel/
        ///
        /// In addition, for each type NamedResourcesin AttributeValue there is a map that resolves to the corresponding value of the instance under evaluation. For example:
        ///
        /// attributes.quantity["a"].isGreaterThan(quantity("0")) &amp;&amp;
        /// attributes.stringslice["b"].isSorted()
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesRequest#selector
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"primitive\":\"string\"}")]
        public string Selector
        {
            get;
            set;
        }
    }
}
