using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>HTTPIngressPath associates a path with a backend.</summary>
    /// <remarks>
    /// Incoming urls matching the path are forwarded to the backend.
    ///
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.HTTPIngressPath
    /// </remarks>
    [JsiiByValue(fqn: "k8s.HttpIngressPath")]
    public class HttpIngressPath : K8s.IHttpIngressPath
    {
        /// <summary>backend defines the referenced service endpoint to which the traffic will be forwarded to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.HTTPIngressPath#backend
        /// </remarks>
        [JsiiProperty(name: "backend", typeJson: "{\"fqn\":\"k8s.IngressBackend\"}")]
        public K8s.IIngressBackend Backend
        {
            get;
            set;
        }

        /// <summary>pathType determines the interpretation of the path matching.</summary>
        /// <remarks>
        /// PathType can be one of the following values: * Exact: Matches the URL path exactly. * Prefix: Matches based on a URL path prefix split by '/'. Matching is
        /// done on a path element by element basis. A path element refers is the
        /// list of labels in the path split by the '/' separator. A request is a
        /// match for path p if every p is an element-wise prefix of p of the
        /// request path. Note that if the last element of the path is a substring
        /// of the last element in request path, it is not a match (e.g. /foo/bar
        /// matches /foo/bar/baz, but does not match /foo/barbaz).
        ///
        /// <list type="bullet">
        /// <description>ImplementationSpecific: Interpretation of the Path matching is up to
        /// the IngressClass. Implementations can treat this as a separate PathType
        /// or treat it identically to Prefix or Exact path types.
        /// Implementations are required to support all path types.</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.HTTPIngressPath#pathType
        /// </remarks>
        [JsiiProperty(name: "pathType", typeJson: "{\"primitive\":\"string\"}")]
        public string PathType
        {
            get;
            set;
        }

        /// <summary>path is matched against the path of an incoming request.</summary>
        /// <remarks>
        /// Currently it can contain characters disallowed from the conventional "path" part of a URL as defined by RFC 3986. Paths must begin with a '/' and must be present when using PathType with value "Exact" or "Prefix".
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.HTTPIngressPath#path
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }
    }
}
