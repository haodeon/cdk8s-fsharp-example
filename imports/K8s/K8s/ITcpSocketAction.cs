using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>TCPSocketAction describes an action based on opening a socket.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.TCPSocketAction
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ITcpSocketAction), fullyQualifiedName: "k8s.TcpSocketAction")]
    public interface ITcpSocketAction
    {
        /// <summary>Number or name of the port to access on the container.</summary>
        /// <remarks>
        /// Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TCPSocketAction#port
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"fqn\":\"k8s.IntOrString\"}")]
        K8s.IntOrString Port
        {
            get;
        }

        /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TCPSocketAction#host
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Host
        {
            get
            {
                return null;
            }
        }

        /// <summary>TCPSocketAction describes an action based on opening a socket.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TCPSocketAction
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ITcpSocketAction), fullyQualifiedName: "k8s.TcpSocketAction")]
        internal sealed class _Proxy : DeputyBase, K8s.ITcpSocketAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Number or name of the port to access on the container.</summary>
            /// <remarks>
            /// Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TCPSocketAction#port
            /// </remarks>
            [JsiiProperty(name: "port", typeJson: "{\"fqn\":\"k8s.IntOrString\"}")]
            public K8s.IntOrString Port
            {
                get => GetInstanceProperty<K8s.IntOrString>()!;
            }

            /// <summary>Optional: Host name to connect to, defaults to the pod IP.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TCPSocketAction#host
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Host
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
