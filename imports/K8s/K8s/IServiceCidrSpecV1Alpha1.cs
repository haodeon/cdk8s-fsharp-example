using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ServiceCIDRSpec define the CIDRs the user wants to use for allocating ClusterIPs for Services.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ServiceCIDRSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IServiceCidrSpecV1Alpha1), fullyQualifiedName: "k8s.ServiceCidrSpecV1Alpha1")]
    public interface IServiceCidrSpecV1Alpha1
    {
        /// <summary>CIDRs defines the IP blocks in CIDR notation (e.g. "192.168.0.0/24" or "2001:db8::/64") from which to assign service cluster IPs. Max of two CIDRs is allowed, one of each IP family. This field is immutable.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ServiceCIDRSpec#cidrs
        /// </remarks>
        [JsiiProperty(name: "cidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Cidrs
        {
            get
            {
                return null;
            }
        }

        /// <summary>ServiceCIDRSpec define the CIDRs the user wants to use for allocating ClusterIPs for Services.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ServiceCIDRSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IServiceCidrSpecV1Alpha1), fullyQualifiedName: "k8s.ServiceCidrSpecV1Alpha1")]
        internal sealed class _Proxy : DeputyBase, K8s.IServiceCidrSpecV1Alpha1
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>CIDRs defines the IP blocks in CIDR notation (e.g. "192.168.0.0/24" or "2001:db8::/64") from which to assign service cluster IPs. Max of two CIDRs is allowed, one of each IP family. This field is immutable.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ServiceCIDRSpec#cidrs
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cidrs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Cidrs
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
