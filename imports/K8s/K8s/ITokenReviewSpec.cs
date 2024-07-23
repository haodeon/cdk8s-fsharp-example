using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>TokenReviewSpec is a description of the token authentication request.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenReviewSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ITokenReviewSpec), fullyQualifiedName: "k8s.TokenReviewSpec")]
    public interface ITokenReviewSpec
    {
        /// <summary>Audiences is a list of the identifiers that the resource server presented with the token identifies as.</summary>
        /// <remarks>
        /// Audience-aware token authenticators will verify that the token was intended for at least one of the audiences in this list. If no audiences are provided, the audience will default to the audience of the Kubernetes apiserver.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenReviewSpec#audiences
        /// </remarks>
        [JsiiProperty(name: "audiences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Audiences
        {
            get
            {
                return null;
            }
        }

        /// <summary>Token is the opaque bearer token.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenReviewSpec#token
        /// </remarks>
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Token
        {
            get
            {
                return null;
            }
        }

        /// <summary>TokenReviewSpec is a description of the token authentication request.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenReviewSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ITokenReviewSpec), fullyQualifiedName: "k8s.TokenReviewSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.ITokenReviewSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Audiences is a list of the identifiers that the resource server presented with the token identifies as.</summary>
            /// <remarks>
            /// Audience-aware token authenticators will verify that the token was intended for at least one of the audiences in this list. If no audiences are provided, the audience will default to the audience of the Kubernetes apiserver.
            ///
            /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenReviewSpec#audiences
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "audiences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Audiences
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>Token is the opaque bearer token.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenReviewSpec#token
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Token
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
