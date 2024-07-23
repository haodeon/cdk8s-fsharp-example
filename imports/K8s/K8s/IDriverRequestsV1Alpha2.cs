using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>DriverRequests describes all resources that are needed from one particular driver.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.DriverRequests
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IDriverRequestsV1Alpha2), fullyQualifiedName: "k8s.DriverRequestsV1Alpha2")]
    public interface IDriverRequestsV1Alpha2
    {
        /// <summary>DriverName is the name used by the DRA driver kubelet plugin.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.DriverRequests#driverName
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

        /// <summary>Requests describes all resources that are needed from the driver.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.DriverRequests#requests
        /// </remarks>
        [JsiiProperty(name: "requests", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ResourceRequestV1Alpha2\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IResourceRequestV1Alpha2[]? Requests
        {
            get
            {
                return null;
            }
        }

        /// <summary>VendorParameters are arbitrary setup parameters for all requests of the claim.</summary>
        /// <remarks>
        /// They are ignored while allocating the claim.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.DriverRequests#vendorParameters
        /// </remarks>
        [JsiiProperty(name: "vendorParameters", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? VendorParameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>DriverRequests describes all resources that are needed from one particular driver.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.DriverRequests
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IDriverRequestsV1Alpha2), fullyQualifiedName: "k8s.DriverRequestsV1Alpha2")]
        internal sealed class _Proxy : DeputyBase, K8s.IDriverRequestsV1Alpha2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>DriverName is the name used by the DRA driver kubelet plugin.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.DriverRequests#driverName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "driverName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? DriverName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Requests describes all resources that are needed from the driver.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.DriverRequests#requests
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requests", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ResourceRequestV1Alpha2\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IResourceRequestV1Alpha2[]? Requests
            {
                get => GetInstanceProperty<K8s.IResourceRequestV1Alpha2[]?>();
            }

            /// <summary>VendorParameters are arbitrary setup parameters for all requests of the claim.</summary>
            /// <remarks>
            /// They are ignored while allocating the claim.
            ///
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.DriverRequests#vendorParameters
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vendorParameters", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
            public object? VendorParameters
            {
                get => GetInstanceProperty<object?>();
            }
        }
    }
}
