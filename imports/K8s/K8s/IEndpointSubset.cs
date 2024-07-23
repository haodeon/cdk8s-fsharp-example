using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EndpointSubset is a group of addresses with a common set of ports.</summary>
    /// <remarks>
    /// The expanded set of endpoints is the Cartesian product of Addresses x Ports. For example, given:
    ///
    /// {
    /// Addresses: [{"ip": "10.10.1.1"}, {"ip": "10.10.2.2"}],
    /// Ports:     [{"name": "a", "port": 8675}, {"name": "b", "port": 309}]
    /// }
    ///
    /// The resulting set of endpoints can be viewed as:
    ///
    /// a: [ 10.10.1.1:8675, 10.10.2.2:8675 ],
    /// b: [ 10.10.1.1:309, 10.10.2.2:309 ]
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointSubset
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IEndpointSubset), fullyQualifiedName: "k8s.EndpointSubset")]
    public interface IEndpointSubset
    {
        /// <summary>IP addresses which offer the related ports that are marked as ready.</summary>
        /// <remarks>
        /// These endpoints should be considered safe for load balancers and clients to utilize.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointSubset#addresses
        /// </remarks>
        [JsiiProperty(name: "addresses", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.EndpointAddress\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IEndpointAddress[]? Addresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>IP addresses which offer the related ports but are not currently marked as ready because they have not yet finished starting, have recently failed a readiness check, or have recently failed a liveness check.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointSubset#notReadyAddresses
        /// </remarks>
        [JsiiProperty(name: "notReadyAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.EndpointAddress\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IEndpointAddress[]? NotReadyAddresses
        {
            get
            {
                return null;
            }
        }

        /// <summary>Port numbers available on the related IP addresses.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointSubset#ports
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

        /// <summary>EndpointSubset is a group of addresses with a common set of ports.</summary>
        /// <remarks>
        /// The expanded set of endpoints is the Cartesian product of Addresses x Ports. For example, given:
        ///
        /// {
        /// Addresses: [{"ip": "10.10.1.1"}, {"ip": "10.10.2.2"}],
        /// Ports:     [{"name": "a", "port": 8675}, {"name": "b", "port": 309}]
        /// }
        ///
        /// The resulting set of endpoints can be viewed as:
        ///
        /// a: [ 10.10.1.1:8675, 10.10.2.2:8675 ],
        /// b: [ 10.10.1.1:309, 10.10.2.2:309 ]
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointSubset
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IEndpointSubset), fullyQualifiedName: "k8s.EndpointSubset")]
        internal sealed class _Proxy : DeputyBase, K8s.IEndpointSubset
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>IP addresses which offer the related ports that are marked as ready.</summary>
            /// <remarks>
            /// These endpoints should be considered safe for load balancers and clients to utilize.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointSubset#addresses
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "addresses", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.EndpointAddress\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IEndpointAddress[]? Addresses
            {
                get => GetInstanceProperty<K8s.IEndpointAddress[]?>();
            }

            /// <summary>IP addresses which offer the related ports but are not currently marked as ready because they have not yet finished starting, have recently failed a readiness check, or have recently failed a liveness check.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointSubset#notReadyAddresses
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "notReadyAddresses", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.EndpointAddress\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IEndpointAddress[]? NotReadyAddresses
            {
                get => GetInstanceProperty<K8s.IEndpointAddress[]?>();
            }

            /// <summary>Port numbers available on the related IP addresses.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EndpointSubset#ports
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
