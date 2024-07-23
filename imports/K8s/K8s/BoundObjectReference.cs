using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>BoundObjectReference is a reference to an object that a token is bound to.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.authentication.v1.BoundObjectReference
    /// </remarks>
    [JsiiByValue(fqn: "k8s.BoundObjectReference")]
    public class BoundObjectReference : K8s.IBoundObjectReference
    {
        /// <summary>API version of the referent.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.BoundObjectReference#apiVersion
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiVersion
        {
            get;
            set;
        }

        /// <summary>Kind of the referent.</summary>
        /// <remarks>
        /// Valid kinds are 'Pod' and 'Secret'.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.BoundObjectReference#kind
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Kind
        {
            get;
            set;
        }

        /// <summary>Name of the referent.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.BoundObjectReference#name
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>UID of the referent.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authentication.v1.BoundObjectReference#uid
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uid
        {
            get;
            set;
        }
    }
}
