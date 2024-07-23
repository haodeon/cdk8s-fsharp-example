using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>HTTPGetAction describes an action based on HTTP Get requests.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.HTTPGetAction
    /// </remarks>
    [JsiiByValue(fqn: "k8s.HttpGetAction")]
    public class HttpGetAction : K8s.IHttpGetAction
    {
        /// <summary>Name or number of the port to access on the container.</summary>
        /// <remarks>
        /// Number must be in the range 1 to 65535. Name must be an IANA_SVC_NAME.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HTTPGetAction#port
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"fqn\":\"k8s.IntOrString\"}")]
        public K8s.IntOrString Port
        {
            get;
            set;
        }

        /// <summary>Host name to connect to, defaults to the pod IP.</summary>
        /// <remarks>
        /// You probably want to set "Host" in httpHeaders instead.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HTTPGetAction#host
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Host
        {
            get;
            set;
        }

        /// <summary>Custom headers to set in the request.</summary>
        /// <remarks>
        /// HTTP allows repeated headers.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HTTPGetAction#httpHeaders
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "httpHeaders", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.HttpHeader\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IHttpHeader[]? HttpHeaders
        {
            get;
            set;
        }

        /// <summary>Path to access on the HTTP server.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HTTPGetAction#path
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        /// <summary>Scheme to use for connecting to the host.</summary>
        /// <remarks>
        /// Defaults to HTTP.
        ///
        /// <strong>Default</strong>: HTTP.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HTTPGetAction#scheme
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scheme", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Scheme
        {
            get;
            set;
        }
    }
}
