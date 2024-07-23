using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>RoleRef contains information that points to the role being used.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleRef
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IRoleRef), fullyQualifiedName: "k8s.RoleRef")]
    public interface IRoleRef
    {
        /// <summary>APIGroup is the group for the resource being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleRef#apiGroup
        /// </remarks>
        [JsiiProperty(name: "apiGroup", typeJson: "{\"primitive\":\"string\"}")]
        string ApiGroup
        {
            get;
        }

        /// <summary>Kind is the type of resource being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleRef#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>Name is the name of resource being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleRef#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>RoleRef contains information that points to the role being used.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleRef
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IRoleRef), fullyQualifiedName: "k8s.RoleRef")]
        internal sealed class _Proxy : DeputyBase, K8s.IRoleRef
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>APIGroup is the group for the resource being referenced.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleRef#apiGroup
            /// </remarks>
            [JsiiProperty(name: "apiGroup", typeJson: "{\"primitive\":\"string\"}")]
            public string ApiGroup
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Kind is the type of resource being referenced.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleRef#kind
            /// </remarks>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name is the name of resource being referenced.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.RoleRef#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
