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
    [JsiiInterface(nativeType: typeof(IStatusDetails), fullyQualifiedName: "k8s.StatusDetails")]
    public interface IStatusDetails
    {
        /// <summary>The Causes array includes more details associated with the StatusReason failure.</summary>
        /// <remarks>
        /// Not all StatusReasons may provide detailed causes.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusDetails#causes
        /// </remarks>
        [JsiiProperty(name: "causes", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.StatusCause\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IStatusCause[]? Causes
        {
            get
            {
                return null;
            }
        }

        /// <summary>The group attribute of the resource associated with the status StatusReason.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusDetails#group
        /// </remarks>
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Group
        {
            get
            {
                return null;
            }
        }

        /// <summary>The kind attribute of the resource associated with the status StatusReason.</summary>
        /// <remarks>
        /// On some operations may differ from the requested resource Kind. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusDetails#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Kind
        {
            get
            {
                return null;
            }
        }

        /// <summary>The name attribute of the resource associated with the status StatusReason (when there is a single name which can be described).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusDetails#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>If specified, the time in seconds before the operation should be retried.</summary>
        /// <remarks>
        /// Some errors may indicate the client must take an alternate action - for those errors this field may indicate how long to wait before taking the alternate action.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusDetails#retryAfterSeconds
        /// </remarks>
        [JsiiProperty(name: "retryAfterSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RetryAfterSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>UID of the resource.</summary>
        /// <remarks>
        /// (when there is a single resource which can be described). More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names#uids
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusDetails#uid
        /// </remarks>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uid
        {
            get
            {
                return null;
            }
        }

        /// <summary>StatusDetails is a set of additional properties that MAY be set by the server to provide additional information about a response.</summary>
        /// <remarks>
        /// The Reason field of a Status object defines what attributes will be set. Clients must ignore fields that do not match the defined type of each attribute, and should assume that any attribute may be empty, invalid, or under defined.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusDetails
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStatusDetails), fullyQualifiedName: "k8s.StatusDetails")]
        internal sealed class _Proxy : DeputyBase, K8s.IStatusDetails
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<K8s.IStatusCause[]?>();
            }

            /// <summary>The group attribute of the resource associated with the status StatusReason.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusDetails#group
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Group
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The name attribute of the resource associated with the status StatusReason (when there is a single name which can be described).</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusDetails#name
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<double?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
