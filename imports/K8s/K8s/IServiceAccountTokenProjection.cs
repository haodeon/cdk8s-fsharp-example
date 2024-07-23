using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ServiceAccountTokenProjection represents a projected service account token volume.</summary>
    /// <remarks>
    /// This projection can be used to insert a service account token into the pods runtime filesystem for use against APIs (Kubernetes API Server or otherwise).
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountTokenProjection
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IServiceAccountTokenProjection), fullyQualifiedName: "k8s.ServiceAccountTokenProjection")]
    public interface IServiceAccountTokenProjection
    {
        /// <summary>path is the path relative to the mount point of the file to project the token into.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountTokenProjection#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>audience is the intended audience of the token.</summary>
        /// <remarks>
        /// A recipient of a token must identify itself with an identifier specified in the audience of the token, and otherwise should reject the token. The audience defaults to the identifier of the apiserver.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountTokenProjection#audience
        /// </remarks>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Audience
        {
            get
            {
                return null;
            }
        }

        /// <summary>expirationSeconds is the requested duration of validity of the service account token.</summary>
        /// <remarks>
        /// As the token approaches expiration, the kubelet volume plugin will proactively rotate the service account token. The kubelet will start trying to rotate the token if the token is older than 80 percent of its time to live or if the token is older than 24 hours.Defaults to 1 hour and must be at least 10 minutes.
        ///
        /// <strong>Default</strong>: 1 hour and must be at least 10 minutes.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountTokenProjection#expirationSeconds
        /// </remarks>
        [JsiiProperty(name: "expirationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpirationSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>ServiceAccountTokenProjection represents a projected service account token volume.</summary>
        /// <remarks>
        /// This projection can be used to insert a service account token into the pods runtime filesystem for use against APIs (Kubernetes API Server or otherwise).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountTokenProjection
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IServiceAccountTokenProjection), fullyQualifiedName: "k8s.ServiceAccountTokenProjection")]
        internal sealed class _Proxy : DeputyBase, K8s.IServiceAccountTokenProjection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>path is the path relative to the mount point of the file to project the token into.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountTokenProjection#path
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
