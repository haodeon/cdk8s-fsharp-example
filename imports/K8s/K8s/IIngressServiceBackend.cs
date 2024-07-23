using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>IngressServiceBackend references a Kubernetes Service as a Backend.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressServiceBackend
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IIngressServiceBackend), fullyQualifiedName: "k8s.IngressServiceBackend")]
    public interface IIngressServiceBackend
    {
        /// <summary>name is the referenced service.</summary>
        /// <remarks>
        /// The service must exist in the same namespace as the Ingress object.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressServiceBackend#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>port of the referenced service.</summary>
        /// <remarks>
        /// A port name or port number is required for a IngressServiceBackend.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressServiceBackend#port
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"fqn\":\"k8s.ServiceBackendPort\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IServiceBackendPort? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>IngressServiceBackend references a Kubernetes Service as a Backend.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressServiceBackend
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IIngressServiceBackend), fullyQualifiedName: "k8s.IngressServiceBackend")]
        internal sealed class _Proxy : DeputyBase, K8s.IIngressServiceBackend
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>name is the referenced service.</summary>
            /// <remarks>
            /// The service must exist in the same namespace as the Ingress object.
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressServiceBackend#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>port of the referenced service.</summary>
            /// <remarks>
            /// A port name or port number is required for a IngressServiceBackend.
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressServiceBackend#port
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "port", typeJson: "{\"fqn\":\"k8s.ServiceBackendPort\"}", isOptional: true)]
            public K8s.IServiceBackendPort? Port
            {
                get => GetInstanceProperty<K8s.IServiceBackendPort?>();
            }
        }
    }
}
