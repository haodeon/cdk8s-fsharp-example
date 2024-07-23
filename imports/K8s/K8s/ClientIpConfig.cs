using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ClientIPConfig represents the configurations of Client IP based session affinity.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ClientIPConfig
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ClientIpConfig")]
    public class ClientIpConfig : K8s.IClientIpConfig
    {
        /// <summary>timeoutSeconds specifies the seconds of ClientIP type session sticky time.</summary>
        /// <remarks>
        /// The value must be &gt;0 &amp;&amp; &lt;=86400(for 1 day) if ServiceAffinity == "ClientIP". Default value is 10800(for 3 hours).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClientIPConfig#timeoutSeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutSeconds
        {
            get;
            set;
        }
    }
}
