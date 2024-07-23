using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedObjectReference
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ITypedObjectReference), fullyQualifiedName: "k8s.TypedObjectReference")]
    public interface ITypedObjectReference
    {
        /// <summary>Kind is the type of resource being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedObjectReference#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>Name is the name of resource being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedObjectReference#name
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedObjectReference#apiGroup
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

        /// <summary>Namespace is the namespace of resource being referenced Note that when a namespace is specified, a gateway.networking.k8s.io/ReferenceGrant object is required in the referent namespace to allow that namespace's owner to accept the reference. See the ReferenceGrant documentation for details. (Alpha) This field requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedObjectReference#namespace
        /// </remarks>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedObjectReference
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ITypedObjectReference), fullyQualifiedName: "k8s.TypedObjectReference")]
        internal sealed class _Proxy : DeputyBase, K8s.ITypedObjectReference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Kind is the type of resource being referenced.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedObjectReference#kind
            /// </remarks>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name is the name of resource being referenced.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedObjectReference#name
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
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedObjectReference#apiGroup
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Namespace is the namespace of resource being referenced Note that when a namespace is specified, a gateway.networking.k8s.io/ReferenceGrant object is required in the referent namespace to allow that namespace's owner to accept the reference. See the ReferenceGrant documentation for details. (Alpha) This field requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TypedObjectReference#namespace
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
