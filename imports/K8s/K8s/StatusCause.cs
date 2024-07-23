using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>StatusCause provides more information about an api.Status failure, including cases when multiple errors are encountered.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusCause
    /// </remarks>
    [JsiiByValue(fqn: "k8s.StatusCause")]
    public class StatusCause : K8s.IStatusCause
    {
        /// <summary>The field of the resource that has caused this error, as named by its JSON serialization.</summary>
        /// <remarks>
        /// May include dot and postfix notation for nested attributes. Arrays are zero-indexed.  Fields may appear more than once in an array of causes due to fields having multiple errors. Optional.
        ///
        /// Examples:
        /// "name" - the field "name" on the current resource
        /// "items[0].name" - the field "name" on the first array entry in "items"
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusCause#field
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Field
        {
            get;
            set;
        }

        /// <summary>A human-readable description of the cause of the error.</summary>
        /// <remarks>
        /// This field may be presented as-is to a reader.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusCause#message
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }

        /// <summary>A machine-readable description of the cause of the error.</summary>
        /// <remarks>
        /// If this value is empty there is no information available.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusCause#reason
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Reason
        {
            get;
            set;
        }
    }
}
