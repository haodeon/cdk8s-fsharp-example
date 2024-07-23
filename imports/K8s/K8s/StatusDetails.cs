using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>StatusDetails is a set of additional properties that MAY be set by the server to provide additional information about a response.</summary>
    /// <remarks>
    /// The Reason field of a Status object defines what attributes will be set. Clients must ignore fields that do not match the defined type of each attribute, and should assume that any attribute may be empty, invalid, or under defined.
    ///
    /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusDetails
    /// </remarks>
    [JsiiByValue(fqn: "k8s.StatusDetails")]
    public class StatusDetails : K8s.IStatusDetails
    {
        /// <summary>The Causes array includes more details associated with the StatusReason failure.</summary>
        /// <remarks>
        /// Not all StatusReasons may provide detailed causes.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusDetails#causes
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "causes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.StatusCause\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IStatusCause[]? Causes
        {
            get;
            set;
        }

        /// <summary>The group attribute of the resource associated with the status StatusReason.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusDetails#group
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Group
        {
            get;
            set;
        }

        /// <summary>The kind attribute of the resource associated with the status StatusReason.</summary>
        /// <remarks>
        /// On some operations may differ from the requested resource Kind. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusDetails#kind
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Kind
        {
            get;
            set;
        }

        /// <summary>The name attribute of the resource associated with the status StatusReason (when there is a single name which can be described).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusDetails#name
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>If specified, the time in seconds before the operation should be retried.</summary>
        /// <remarks>
        /// Some errors may indicate the client must take an alternate action - for those errors this field may indicate how long to wait before taking the alternate action.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusDetails#retryAfterSeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "retryAfterSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RetryAfterSeconds
        {
            get;
            set;
        }

        /// <summary>UID of the resource.</summary>
        /// <remarks>
        /// (when there is a single resource which can be described). More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names#uids
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusDetails#uid
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
