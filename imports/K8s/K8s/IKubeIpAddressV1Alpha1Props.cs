using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>IPAddress represents a single IP of a single IP Family.</summary>
    /// <remarks>
    /// The object is designed to be used by APIs that operate on IP addresses. The object is used by the Service core API for allocation of IP addresses. An IP address can be represented in different formats, to guarantee the uniqueness of the IP, the name of the object is the IP address in canonical format, four decimal digits separated by dots suppressing leading zeros for IPv4 and the representation defined by RFC 5952 for IPv6. Valid: 192.168.1.5 or 2001:db8::1 or 2001:db8:aaaa:bbbb:cccc:dddd:eeee:1 Invalid: 10.01.2.3 or 2001:db8:0:0:0::1
    ///
    /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.IPAddress
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeIpAddressV1Alpha1Props), fullyQualifiedName: "k8s.KubeIpAddressV1Alpha1Props")]
    public interface IKubeIpAddressV1Alpha1Props
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.IPAddress#metadata
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

        /// <summary>spec is the desired state of the IPAddress.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.IPAddress#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.IpAddressSpecV1Alpha1\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IIpAddressSpecV1Alpha1? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>IPAddress represents a single IP of a single IP Family.</summary>
        /// <remarks>
        /// The object is designed to be used by APIs that operate on IP addresses. The object is used by the Service core API for allocation of IP addresses. An IP address can be represented in different formats, to guarantee the uniqueness of the IP, the name of the object is the IP address in canonical format, four decimal digits separated by dots suppressing leading zeros for IPv4 and the representation defined by RFC 5952 for IPv6. Valid: 192.168.1.5 or 2001:db8::1 or 2001:db8:aaaa:bbbb:cccc:dddd:eeee:1 Invalid: 10.01.2.3 or 2001:db8:0:0:0::1
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.IPAddress
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeIpAddressV1Alpha1Props), fullyQualifiedName: "k8s.KubeIpAddressV1Alpha1Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeIpAddressV1Alpha1Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.IPAddress#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>spec is the desired state of the IPAddress.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.IPAddress#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.IpAddressSpecV1Alpha1\"}", isOptional: true)]
            public K8s.IIpAddressSpecV1Alpha1? Spec
            {
                get => GetInstanceProperty<K8s.IIpAddressSpecV1Alpha1?>();
            }
        }
    }
}
