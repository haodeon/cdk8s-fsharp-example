using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>HTTPHeader describes a custom header to be used in HTTP probes.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.HTTPHeader
    /// </remarks>
    [JsiiByValue(fqn: "k8s.HttpHeader")]
    public class HttpHeader : K8s.IHttpHeader
    {
        /// <summary>The header field name.</summary>
        /// <remarks>
        /// This will be canonicalized upon output, so case-variant names will be understood as the same header.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HTTPHeader#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>The header field value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.HTTPHeader#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
