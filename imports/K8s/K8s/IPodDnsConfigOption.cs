using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodDNSConfigOption defines DNS resolver options of a pod.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PodDNSConfigOption
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPodDnsConfigOption), fullyQualifiedName: "k8s.PodDnsConfigOption")]
    public interface IPodDnsConfigOption
    {
        /// <summary>Required.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodDNSConfigOption#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodDNSConfigOption#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        /// <summary>PodDNSConfigOption defines DNS resolver options of a pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodDNSConfigOption
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPodDnsConfigOption), fullyQualifiedName: "k8s.PodDnsConfigOption")]
        internal sealed class _Proxy : DeputyBase, K8s.IPodDnsConfigOption
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Required.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodDNSConfigOption#name
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodDNSConfigOption#value
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
