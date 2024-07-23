using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>TokenRequest contains parameters of a service account token.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.TokenRequest
    /// </remarks>
    [JsiiByValue(fqn: "k8s.TokenRequest")]
    public class TokenRequest : K8s.ITokenRequest
    {
        /// <summary>audience is the intended audience of the token in "TokenRequestSpec".</summary>
        /// <remarks>
        /// It will default to the audiences of kube apiserver.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.TokenRequest#audience
        /// </remarks>
        [JsiiProperty(name: "audience", typeJson: "{\"primitive\":\"string\"}")]
        public string Audience
        {
            get;
            set;
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
            get;
            set;
        }
    }
}
