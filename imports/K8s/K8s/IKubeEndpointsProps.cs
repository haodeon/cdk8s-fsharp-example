using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Endpoints is a collection of endpoints that implement the actual service. Example:.</summary>
    /// <remarks>
    /// Name: "mysvc",
    /// Subsets: [
    /// {
    /// Addresses: [{"ip": "10.10.1.1"}, {"ip": "10.10.2.2"}],
    /// Ports: [{"name": "a", "port": 8675}, {"name": "b", "port": 309}]
    /// },
    /// {
    /// Addresses: [{"ip": "10.10.3.3"}],
    /// Ports: [{"name": "a", "port": 93}, {"name": "b", "port": 76}]
    /// },
    /// ]
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Endpoints
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeEndpointsProps), fullyQualifiedName: "k8s.KubeEndpointsProps")]
    public interface IKubeEndpointsProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Endpoints#metadata
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

        /// <summary>The set of all endpoints is the union of all subsets.</summary>
        /// <remarks>
        /// Addresses are placed into subsets according to the IPs they share. A single address with multiple ports, some of which are ready and some of which are not (because they come from different containers) will result in the address being displayed in different subsets for the different ports. No address will appear in both Addresses and NotReadyAddresses in the same subset. Sets of addresses and ports that comprise a service.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Endpoints#subsets
        /// </remarks>
        [JsiiProperty(name: "subsets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.EndpointSubset\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IEndpointSubset[]? Subsets
        {
            get
            {
                return null;
            }
        }

        /// <summary>Endpoints is a collection of endpoints that implement the actual service. Example:.</summary>
        /// <remarks>
        /// Name: "mysvc",
        /// Subsets: [
        /// {
        /// Addresses: [{"ip": "10.10.1.1"}, {"ip": "10.10.2.2"}],
        /// Ports: [{"name": "a", "port": 8675}, {"name": "b", "port": 309}]
        /// },
        /// {
        /// Addresses: [{"ip": "10.10.3.3"}],
        /// Ports: [{"name": "a", "port": 93}, {"name": "b", "port": 76}]
        /// },
        /// ]
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Endpoints
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeEndpointsProps), fullyQualifiedName: "k8s.KubeEndpointsProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeEndpointsProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Endpoints#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>The set of all endpoints is the union of all subsets.</summary>
            /// <remarks>
            /// Addresses are placed into subsets according to the IPs they share. A single address with multiple ports, some of which are ready and some of which are not (because they come from different containers) will result in the address being displayed in different subsets for the different ports. No address will appear in both Addresses and NotReadyAddresses in the same subset. Sets of addresses and ports that comprise a service.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Endpoints#subsets
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subsets", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.EndpointSubset\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IEndpointSubset[]? Subsets
            {
                get => GetInstanceProperty<K8s.IEndpointSubset[]?>();
            }
        }
    }
}
