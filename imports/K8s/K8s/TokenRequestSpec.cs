using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>TokenRequestSpec contains client provided parameters of a token request.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenRequestSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.TokenRequestSpec")]
    public class TokenRequestSpec : K8s.ITokenRequestSpec
    {
        /// <summary>Audiences are the intendend audiences of the token.</summary>
        /// <remarks>
        /// A recipient of a token must identify themself with an identifier in the list of audiences of the token, and otherwise should reject the token. A token issued for multiple audiences may be used to authenticate against any of the audiences listed but implies a high degree of trust between the target audiences.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenRequestSpec#audiences
        /// </remarks>
        [JsiiProperty(name: "audiences", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Audiences
        {
            get;
            set;
        }

        /// <summary>BoundObjectRef is a reference to an object that the token will be bound to.</summary>
        /// <remarks>
        /// The token will only be valid for as long as the bound object exists. NOTE: The API server's TokenReview endpoint will validate the BoundObjectRef, but other audiences may not. Keep ExpirationSeconds small if you want prompt revocation.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenRequestSpec#boundObjectRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "boundObjectRef", typeJson: "{\"fqn\":\"k8s.BoundObjectReference\"}", isOptional: true)]
        public K8s.IBoundObjectReference? BoundObjectRef
        {
            get;
            set;
        }

        /// <summary>ExpirationSeconds is the requested duration of validity of the request.</summary>
        /// <remarks>
        /// The token issuer may return a token with a different validity duration so a client needs to check the 'expiration' field in a response.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.TokenRequestSpec#expirationSeconds
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