using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>NonResourceAttributes includes the authorization attributes available for non-resource requests to the Authorizer interface.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.authorization.v1.NonResourceAttributes
    /// </remarks>
    [JsiiByValue(fqn: "k8s.NonResourceAttributes")]
    public class NonResourceAttributes : K8s.INonResourceAttributes
    {
        /// <summary>Path is the URL path of the request.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.NonResourceAttributes#path
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        /// <summary>Verb is the standard HTTP verb.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.NonResourceAttributes#verb
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Verb
        {
            get;
            set;
        }
    }
}
