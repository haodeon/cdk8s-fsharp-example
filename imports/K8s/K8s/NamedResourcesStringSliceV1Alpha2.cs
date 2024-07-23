using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>NamedResourcesStringSlice contains a slice of strings.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesStringSlice
    /// </remarks>
    [JsiiByValue(fqn: "k8s.NamedResourcesStringSliceV1Alpha2")]
    public class NamedResourcesStringSliceV1Alpha2 : K8s.INamedResourcesStringSliceV1Alpha2
    {
        /// <summary>Strings is the slice of strings.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesStringSlice#strings
        /// </remarks>
        [JsiiProperty(name: "strings", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Strings
        {
            get;
            set;
        }
    }
}
