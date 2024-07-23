using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>TokenRequest contains parameters of a service account token.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.TokenRequest
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ITokenRequest), fullyQualifiedName: "k8s.TokenRequest")]
    public interface ITokenRequest
    {
        /// <summary>audience is the intended audience of the token in "TokenRequestSpec".</summary>
        /// <remarks>
        /// It will default to the audiences of kube apiserver.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.TokenRequest#audience
        /// </remarks>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
        string Audience
        {
            get;
        }

        /// <summary>expirationSeconds is the duration of validity of the token in "TokenRequestSpec".</summary>
        /// <remarks>
        /// It has the same default value of "ExpirationSeconds" in "TokenRequestSpec".
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.TokenRequest#expirationSeconds
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

        /// <summary>TokenRequest contains parameters of a service account token.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.TokenRequest
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ITokenRequest), fullyQualifiedName: "k8s.TokenRequest")]
        internal sealed class _Proxy : DeputyBase, K8s.ITokenRequest
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>audience is the intended audience of the token in "TokenRequestSpec".</summary>
            /// <remarks>
            /// It will default to the audiences of kube apiserver.
            ///
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.TokenRequest#audience
            /// </remarks>
            [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
            public string Audience
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>expirationSeconds is the duration of validity of the token in "TokenRequestSpec".</summary>
            /// <remarks>
            /// It has the same default value of "ExpirationSeconds" in "TokenRequestSpec".
            ///
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.TokenRequest#expirationSeconds
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
