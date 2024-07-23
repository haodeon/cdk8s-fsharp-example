using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>HostAlias holds the mapping between IP and hostnames that will be injected as an entry in the pod's hosts file.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.HostAlias
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IHostAlias), fullyQualifiedName: "k8s.HostAlias")]
    public interface IHostAlias
    {
        /// <summary>Hostnames for the above IP address.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HostAlias#hostnames
        /// </remarks>
        [JsiiProperty(name: "hostnames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Hostnames
        {
            get
            {
                return null;
            }
        }

        /// <summary>IP address of the host file entry.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HostAlias#ip
        /// </remarks>
        [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Ip
        {
            get
            {
                return null;
            }
        }

        /// <summary>HostAlias holds the mapping between IP and hostnames that will be injected as an entry in the pod's hosts file.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HostAlias
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IHostAlias), fullyQualifiedName: "k8s.HostAlias")]
        internal sealed class _Proxy : DeputyBase, K8s.IHostAlias
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Hostnames for the above IP address.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.HostAlias#hostnames
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostnames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Hostnames
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>IP address of the host file entry.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.HostAlias#ip
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ip", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Ip
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
