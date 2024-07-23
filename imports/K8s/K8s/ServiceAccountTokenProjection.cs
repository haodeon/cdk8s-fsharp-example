using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ServiceAccountTokenProjection represents a projected service account token volume.</summary>
    /// <remarks>
    /// This projection can be used to insert a service account token into the pods runtime filesystem for use against APIs (Kubernetes API Server or otherwise).
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountTokenProjection
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ServiceAccountTokenProjection")]
    public class ServiceAccountTokenProjection : K8s.IServiceAccountTokenProjection
    {
        /// <summary>path is the path relative to the mount point of the file to project the token into.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountTokenProjection#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        /// <summary>audience is the intended audience of the token.</summary>
        /// <remarks>
        /// A recipient of a token must identify itself with an identifier specified in the audience of the token, and otherwise should reject the token. The audience defaults to the identifier of the apiserver.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountTokenProjection#audience
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Audience
        {
            get;
            set;
        }

        /// <summary>expirationSeconds is the requested duration of validity of the service account token.</summary>
        /// <remarks>
        /// As the token approaches expiration, the kubelet volume plugin will proactively rotate the service account token. The kubelet will start trying to rotate the token if the token is older than 80 percent of its time to live or if the token is older than 24 hours.Defaults to 1 hour and must be at least 10 minutes.
        ///
        /// <strong>Default</strong>: 1 hour and must be at least 10 minutes.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountTokenProjection#expirationSeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "expirationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ExpirationSeconds
        {
            get;
            set;
        }
    }
}
