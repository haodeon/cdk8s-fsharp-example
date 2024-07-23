using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects.</summary>
    /// <remarks>
    /// A resource may have only one of {ObjectMeta, ListMeta}.
    ///
    /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ListMeta
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IListMeta), fullyQualifiedName: "k8s.ListMeta")]
    public interface IListMeta
    {
        /// <summary>continue may be set if the user set a limit on the number of items returned, and indicates that the server has more data available.</summary>
        /// <remarks>
        /// The value is opaque and may be used to issue another request to the endpoint that served this list to retrieve the next set of available objects. Continuing a consistent list may not be possible if the server configuration has changed or more than a few minutes have passed. The resourceVersion field returned when using this continue value will be identical to the value in the first response, unless you have received this token from an error message.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ListMeta#continue
        /// </remarks>
        [JsiiProperty(name: "continue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Continue
        {
            get
            {
                return null;
            }
        }

        /// <summary>remainingItemCount is the number of subsequent items in the list which are not included in this list response.</summary>
        /// <remarks>
        /// If the list request contained label or field selectors, then the number of remaining items is unknown and the field will be left unset and omitted during serialization. If the list is complete (either because it is not chunking or because this is the last chunk), then there are no more remaining items and this field will be left unset and omitted during serialization. Servers older than v1.15 do not set this field. The intended use of the remainingItemCount is <em>estimating</em> the size of a collection. Clients should not rely on the remainingItemCount to be set or to be exact.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ListMeta#remainingItemCount
        /// </remarks>
        [JsiiProperty(name: "remainingItemCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RemainingItemCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>String that identifies the server's internal version of this object that can be used by clients to determine when objects have changed.</summary>
        /// <remarks>
        /// Value must be treated as opaque by clients and passed unmodified back to the server. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ListMeta#resourceVersion
        /// </remarks>
        [JsiiProperty(name: "resourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Deprecated: selfLink is a legacy read-only field that is no longer populated by the system.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ListMeta#selfLink
        /// </remarks>
        [JsiiProperty(name: "selfLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SelfLink
        {
            get
            {
                return null;
            }
        }

        /// <summary>ListMeta describes metadata that synthetic resources must have, including lists and various status objects.</summary>
        /// <remarks>
        /// A resource may have only one of {ObjectMeta, ListMeta}.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ListMeta
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IListMeta), fullyQualifiedName: "k8s.ListMeta")]
        internal sealed class _Proxy : DeputyBase, K8s.IListMeta
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>continue may be set if the user set a limit on the number of items returned, and indicates that the server has more data available.</summary>
            /// <remarks>
            /// The value is opaque and may be used to issue another request to the endpoint that served this list to retrieve the next set of available objects. Continuing a consistent list may not be possible if the server configuration has changed or more than a few minutes have passed. The resourceVersion field returned when using this continue value will be identical to the value in the first response, unless you have received this token from an error message.
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ListMeta#continue
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "continue", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Continue
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>remainingItemCount is the number of subsequent items in the list which are not included in this list response.</summary>
            /// <remarks>
            /// If the list request contained label or field selectors, then the number of remaining items is unknown and the field will be left unset and omitted during serialization. If the list is complete (either because it is not chunking or because this is the last chunk), then there are no more remaining items and this field will be left unset and omitted during serialization. Servers older than v1.15 do not set this field. The intended use of the remainingItemCount is <em>estimating</em> the size of a collection. Clients should not rely on the remainingItemCount to be set or to be exact.
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ListMeta#remainingItemCount
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "remainingItemCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? RemainingItemCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>String that identifies the server's internal version of this object that can be used by clients to determine when objects have changed.</summary>
            /// <remarks>
            /// Value must be treated as opaque by clients and passed unmodified back to the server. Populated by the system. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ListMeta#resourceVersion
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Deprecated: selfLink is a legacy read-only field that is no longer populated by the system.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ListMeta#selfLink
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selfLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SelfLink
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
