using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>VendorParameters are opaque parameters for one particular driver.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.VendorParameters
    /// </remarks>
    [JsiiByValue(fqn: "k8s.VendorParametersV1Alpha2")]
    public class VendorParametersV1Alpha2 : K8s.IVendorParametersV1Alpha2
    {
        /// <summary>DriverName is the name used by the DRA driver kubelet plugin.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.VendorParameters#driverName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "driverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DriverName
        {
            get;
            set;
        }

        /// <summary>Parameters can be arbitrary setup parameters.</summary>
        /// <remarks>
        /// They are ignored while allocating a claim.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.VendorParameters#parameters
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        public object? Parameters
        {
            get;
            set;
        }
    }
}
