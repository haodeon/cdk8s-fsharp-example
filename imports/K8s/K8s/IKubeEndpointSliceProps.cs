using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EndpointSlice represents a subset of the endpoints that implement a service.</summary>
    /// <remarks>
    /// For a given service there may be multiple EndpointSlice objects, selected by labels, which must be joined to produce the full set of endpoints.
    ///
    /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointSlice
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeEndpointSliceProps), fullyQualifiedName: "k8s.KubeEndpointSliceProps")]
    public interface IKubeEndpointSliceProps
    {
        /// <summary>addressType specifies the type of address carried by this EndpointSlice.</summary>
        /// <remarks>
        /// All addresses in this slice must be the same type. This field is immutable after creation. The following address types are currently supported: * IPv4: Represents an IPv4 Address. * IPv6: Represents an IPv6 Address. * FQDN: Represents a Fully Qualified Domain Name.
        ///
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointSlice#addressType
        /// </remarks>
        [JsiiProperty(name: "addressType", typeJson: "{\"primitive\":\"string\"}")]
        string AddressType
        {
            get;
        }

        /// <summary>endpoints is a list of unique endpoints in this slice.</summary>
        /// <remarks>
        /// Each slice may include a maximum of 1000 endpoints.
        ///
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointSlice#endpoints
        /// </remarks>
        [JsiiProperty(name: "endpoints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Endpoint\"},\"kind\":\"array\"}}")]
        K8s.IEndpoint[] Endpoints
        {
            get;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointSlice#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>ports specifies the list of network ports exposed by each endpoint in this slice.</summary>
        /// <remarks>
        /// Each port must have a unique name. When ports is empty, it indicates that there are no defined ports. When a port is defined with a nil port value, it indicates "all ports". Each slice may include a maximum of 100 ports.
        ///
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointSlice#ports
        /// </remarks>
        [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.EndpointPort\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IEndpointPort[]? Ports
        {
            get
            {
                return null;
            }
        }

        /// <summary>EndpointSlice represents a subset of the endpoints that implement a service.</summary>
        /// <remarks>
        /// For a given service there may be multiple EndpointSlice objects, selected by labels, which must be joined to produce the full set of endpoints.
        ///
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointSlice
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeEndpointSliceProps), fullyQualifiedName: "k8s.KubeEndpointSliceProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeEndpointSliceProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>addressType specifies the type of address carried by this EndpointSlice.</summary>
            /// <remarks>
            /// All addresses in this slice must be the same type. This field is immutable after creation. The following address types are currently supported: * IPv4: Represents an IPv4 Address. * IPv6: Represents an IPv6 Address. * FQDN: Represents a Fully Qualified Domain Name.
            ///
            /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointSlice#addressType
            /// </remarks>
            [JsiiProperty(name: "addressType", typeJson: "{\"primitive\":\"string\"}")]
            public string AddressType
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>endpoints is a list of unique endpoints in this slice.</summary>
            /// <remarks>
            /// Each slice may include a maximum of 1000 endpoints.
            ///
            /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointSlice#endpoints
            /// </remarks>
            [JsiiProperty(name: "endpoints", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Endpoint\"},\"kind\":\"array\"}}")]
            public K8s.IEndpoint[] Endpoints
            {
                get => GetInstanceProperty<K8s.IEndpoint[]>()!;
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointSlice#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>ports specifies the list of network ports exposed by each endpoint in this slice.</summary>
            /// <remarks>
            /// Each port must have a unique name. When ports is empty, it indicates that there are no defined ports. When a port is defined with a nil port value, it indicates "all ports". Each slice may include a maximum of 100 ports.
            ///
            /// <strong>Schema</strong>: io.k8s.api.discovery.v1.EndpointSlice#ports
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ports", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.EndpointPort\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IEndpointPort[]? Ports
            {
                get => GetInstanceProperty<K8s.IEndpointPort[]?>();
            }
        }
    }
}