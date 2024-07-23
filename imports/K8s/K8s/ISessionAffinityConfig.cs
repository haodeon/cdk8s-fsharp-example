using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SessionAffinityConfig represents the configurations of session affinity.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SessionAffinityConfig
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ISessionAffinityConfig), fullyQualifiedName: "k8s.SessionAffinityConfig")]
    public interface ISessionAffinityConfig
    {
        /// <summary>clientIP contains the configurations of Client IP based session affinity.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SessionAffinityConfig#clientIP
        /// </remarks>
        [JsiiProperty(name: "clientIp", typeJson: "{\"fqn\":\"k8s.ClientIpConfig\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IClientIpConfig? ClientIp
        {
            get
            {
                return null;
            }
        }

        /// <summary>SessionAffinityConfig represents the configurations of session affinity.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SessionAffinityConfig
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ISessionAffinityConfig), fullyQualifiedName: "k8s.SessionAffinityConfig")]
        internal sealed class _Proxy : DeputyBase, K8s.ISessionAffinityConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>clientIP contains the configurations of Client IP based session affinity.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SessionAffinityConfig#clientIP
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "clientIp", typeJson: "{\"fqn\":\"k8s.ClientIpConfig\"}", isOptional: true)]
            public K8s.IClientIpConfig? ClientIp
            {
                get => GetInstanceProperty<K8s.IClientIpConfig?>();
            }
        }
    }
}
