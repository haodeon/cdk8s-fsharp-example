using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>StatusCause provides more information about an api.Status failure, including cases when multiple errors are encountered.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusCause
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStatusCause), fullyQualifiedName: "k8s.StatusCause")]
    public interface IStatusCause
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
        [JsiiProperty(name: "field", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Field
        {
            get
            {
                return null;
            }
        }

        /// <summary>A human-readable description of the cause of the error.</summary>
        /// <remarks>
        /// This field may be presented as-is to a reader.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusCause#message
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

        /// <summary>A machine-readable description of the cause of the error.</summary>
        /// <remarks>
        /// If this value is empty there is no information available.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusCause#reason
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

        /// <summary>StatusCause provides more information about an api.Status failure, including cases when multiple errors are encountered.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.StatusCause
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStatusCause), fullyQualifiedName: "k8s.StatusCause")]
        internal sealed class _Proxy : DeputyBase, K8s.IStatusCause
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
