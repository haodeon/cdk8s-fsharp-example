using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ParentReference describes a reference to a parent object.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ParentReference
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IParentReferenceV1Alpha1), fullyQualifiedName: "k8s.ParentReferenceV1Alpha1")]
    public interface IParentReferenceV1Alpha1
    {
        /// <summary>Name is the name of the object being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ParentReference#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Resource is the resource of the object being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ParentReference#resource
        /// </remarks>
        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}")]
        string Resource
        {
            get;
        }

        /// <summary>Group is the group of the object being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ParentReference#group
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

        /// <summary>Namespace is the namespace of the object being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ParentReference#namespace
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

        /// <summary>ParentReference describes a reference to a parent object.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ParentReference
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IParentReferenceV1Alpha1), fullyQualifiedName: "k8s.ParentReferenceV1Alpha1")]
        internal sealed class _Proxy : DeputyBase, K8s.IParentReferenceV1Alpha1
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name is the name of the object being referenced.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ParentReference#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Resource is the resource of the object being referenced.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ParentReference#resource
            /// </remarks>
            [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}")]
            public string Resource
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Group is the group of the object being referenced.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ParentReference#group
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Group
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Namespace is the namespace of the object being referenced.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ParentReference#namespace
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
