using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Preconditions must be fulfilled before an operation (update, delete, etc.) is carried out.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Preconditions
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPreconditions), fullyQualifiedName: "k8s.Preconditions")]
    public interface IPreconditions
    {
        /// <summary>Specifies the target ResourceVersion.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Preconditions#resourceVersion
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

        /// <summary>Specifies the target UID.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Preconditions#uid
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

        /// <summary>Preconditions must be fulfilled before an operation (update, delete, etc.) is carried out.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Preconditions
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPreconditions), fullyQualifiedName: "k8s.Preconditions")]
        internal sealed class _Proxy : DeputyBase, K8s.IPreconditions
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the target ResourceVersion.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Preconditions#resourceVersion
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the target UID.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.Preconditions#uid
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
