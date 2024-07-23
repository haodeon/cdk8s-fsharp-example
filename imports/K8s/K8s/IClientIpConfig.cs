using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ClientIPConfig represents the configurations of Client IP based session affinity.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ClientIPConfig
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IClientIpConfig), fullyQualifiedName: "k8s.ClientIpConfig")]
    public interface IClientIpConfig
    {
        /// <summary>timeoutSeconds specifies the seconds of ClientIP type session sticky time.</summary>
        /// <remarks>
        /// The value must be &gt;0 &amp;&amp; &lt;=86400(for 1 day) if ServiceAffinity == "ClientIP". Default value is 10800(for 3 hours).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClientIPConfig#timeoutSeconds
        /// </remarks>
        [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>ClientIPConfig represents the configurations of Client IP based session affinity.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClientIPConfig
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IClientIpConfig), fullyQualifiedName: "k8s.ClientIpConfig")]
        internal sealed class _Proxy : DeputyBase, K8s.IClientIpConfig
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
