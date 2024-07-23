using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SessionAffinityConfig represents the configurations of session affinity.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SessionAffinityConfig
    /// </remarks>
    [JsiiByValue(fqn: "k8s.SessionAffinityConfig")]
    public class SessionAffinityConfig : K8s.ISessionAffinityConfig
    {
        /// <summary>clientIP contains the configurations of Client IP based session affinity.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SessionAffinityConfig#clientIP
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clientIp", typeJson: "{\"fqn\":\"k8s.ClientIpConfig\"}", isOptional: true)]
        public K8s.IClientIpConfig? ClientIp
        {
            get;
            set;
        }
    }
}
