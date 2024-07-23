using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>VendorParameters are opaque parameters for one particular driver.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.VendorParameters
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IVendorParametersV1Alpha2), fullyQualifiedName: "k8s.VendorParametersV1Alpha2")]
    public interface IVendorParametersV1Alpha2
    {
        /// <summary>DriverName is the name used by the DRA driver kubelet plugin.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.VendorParameters#driverName
        /// </remarks>
        [JsiiProperty(name: "driverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? DriverName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Parameters can be arbitrary setup parameters.</summary>
        /// <remarks>
        /// They are ignored while allocating a claim.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.VendorParameters#parameters
        /// </remarks>
        [JsiiProperty(name: "parameters", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>VendorParameters are opaque parameters for one particular driver.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.VendorParameters
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IVendorParametersV1Alpha2), fullyQualifiedName: "k8s.VendorParametersV1Alpha2")]
        internal sealed class _Proxy : DeputyBase, K8s.IVendorParametersV1Alpha2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>DriverName is the name used by the DRA driver kubelet plugin.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.VendorParameters#driverName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DriverName
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
