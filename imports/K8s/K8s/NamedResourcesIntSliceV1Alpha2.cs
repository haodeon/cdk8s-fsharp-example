using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>NamedResourcesIntSlice contains a slice of 64-bit integers.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesIntSlice
    /// </remarks>
    [JsiiByValue(fqn: "k8s.NamedResourcesIntSliceV1Alpha2")]
    public class NamedResourcesIntSliceV1Alpha2 : K8s.INamedResourcesIntSliceV1Alpha2
    {
        /// <summary>Ints is the slice of 64-bit integers.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.NamedResourcesIntSlice#ints
        /// </remarks>
        [JsiiProperty(name: "ints", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"number\"},\"kind\":\"array\"}}")]
        public double[] Ints
        {
            get;
            set;
        }
    }
}
