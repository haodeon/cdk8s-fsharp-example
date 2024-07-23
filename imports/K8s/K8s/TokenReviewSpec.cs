using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>TokenReviewSpec is a description of the token authentication request.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenReviewSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.TokenReviewSpec")]
    public class TokenReviewSpec : K8s.ITokenReviewSpec
    {
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
            get;
            set;
        }

        /// <summary>Token is the opaque bearer token.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenReviewSpec#token
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "token", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Token
        {
            get;
            set;
        }
    }
}
