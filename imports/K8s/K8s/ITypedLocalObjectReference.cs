using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>TypedLocalObjectReference contains enough information to let you locate the typed referenced object inside the same namespace.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedLocalObjectReference
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ITypedLocalObjectReference), fullyQualifiedName: "k8s.TypedLocalObjectReference")]
    public interface ITypedLocalObjectReference
    {
        /// <summary>Kind is the type of resource being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedLocalObjectReference#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>Name is the name of resource being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedLocalObjectReference#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>APIGroup is the group for the resource being referenced.</summary>
        /// <remarks>
        /// If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedLocalObjectReference#apiGroup
        /// </remarks>
        [JsiiProperty(name: "apiGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiGroup
        {
            get
            {
                return null;
            }
        }

        /// <summary>TypedLocalObjectReference contains enough information to let you locate the typed referenced object inside the same namespace.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedLocalObjectReference
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ITypedLocalObjectReference), fullyQualifiedName: "k8s.TypedLocalObjectReference")]
        internal sealed class _Proxy : DeputyBase, K8s.ITypedLocalObjectReference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Kind is the type of resource being referenced.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedLocalObjectReference#kind
            /// </remarks>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name is the name of resource being referenced.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedLocalObjectReference#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>APIGroup is the group for the resource being referenced.</summary>
            /// <remarks>
            /// If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedLocalObjectReference#apiGroup
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiGroup
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
