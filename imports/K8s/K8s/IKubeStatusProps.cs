using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Status is a return value for calls that don't return other objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Status
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeStatusProps), fullyQualifiedName: "k8s.KubeStatusProps")]
    public interface IKubeStatusProps
    {
        /// <summary>Suggested HTTP return code for this status, 0 if not set.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Status#code
        /// </remarks>
        [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Code
        {
            get
            {
                return null;
            }
        }

        /// <summary>Extended data associated with the reason.</summary>
        /// <remarks>
        /// Each reason may define its own extended details. This field is optional and the data returned is not guaranteed to conform to any schema except that defined by the reason type.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Status#details
        /// </remarks>
        [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"k8s.StatusDetails\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IStatusDetails? Details
        {
            get
            {
                return null;
            }
        }

        /// <summary>A human-readable description of the status of this operation.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Status#message
        /// </remarks>
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Message
        {
            get
            {
                return null;
            }
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Status#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IListMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>A machine-readable description of why this operation is in the "Failure" status.</summary>
        /// <remarks>
        /// If this value is empty there is no information available. A Reason clarifies an HTTP status code but does not override it.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Status#reason
        /// </remarks>
        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Reason
        {
            get
            {
                return null;
            }
        }

        /// <summary>Status is a return value for calls that don't return other objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Status
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeStatusProps), fullyQualifiedName: "k8s.KubeStatusProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeStatusProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Suggested HTTP return code for this status, 0 if not set.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Status#code
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "code", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Code
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Extended data associated with the reason.</summary>
            /// <remarks>
            /// Each reason may define its own extended details. This field is optional and the data returned is not guaranteed to conform to any schema except that defined by the reason type.
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Status#details
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "details", typeJson: "{\"fqn\":\"k8s.StatusDetails\"}", isOptional: true)]
            public K8s.IStatusDetails? Details
            {
                get => GetInstanceProperty<K8s.IStatusDetails?>();
            }

            /// <summary>A human-readable description of the status of this operation.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Status#message
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Message
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Status#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
            public K8s.IListMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IListMeta?>();
            }

            /// <summary>A machine-readable description of why this operation is in the "Failure" status.</summary>
            /// <remarks>
            /// If this value is empty there is no information available. A Reason clarifies an HTTP status code but does not override it.
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Status#reason
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Reason
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
