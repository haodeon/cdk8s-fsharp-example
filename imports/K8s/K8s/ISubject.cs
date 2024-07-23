using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Subject contains a reference to the object or user identities a role binding applies to.</summary>
    /// <remarks>
    /// This can either hold a direct API object reference, or a value for non-objects such as user and group names.
    ///
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Subject
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ISubject), fullyQualifiedName: "k8s.Subject")]
    public interface ISubject
    {
        /// <summary>Kind of object being referenced.</summary>
        /// <remarks>
        /// Values defined by this API group are "User", "Group", and "ServiceAccount". If the Authorizer does not recognized the kind value, the Authorizer should report an error.
        ///
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Subject#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>Name of the object being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Subject#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>APIGroup holds the API group of the referenced subject.</summary>
        /// <remarks>
        /// Defaults to "" for ServiceAccount subjects. Defaults to "rbac.authorization.k8s.io" for User and Group subjects.
        ///
        /// <strong>Default</strong>: for ServiceAccount subjects. Defaults to "rbac.authorization.k8s.io" for User and Group subjects.
        ///
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Subject#apiGroup
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

        /// <summary>Namespace of the referenced object.</summary>
        /// <remarks>
        /// If the object kind is non-namespace, such as "User" or "Group", and this value is not empty the Authorizer should report an error.
        ///
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Subject#namespace
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

        /// <summary>Subject contains a reference to the object or user identities a role binding applies to.</summary>
        /// <remarks>
        /// This can either hold a direct API object reference, or a value for non-objects such as user and group names.
        ///
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Subject
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ISubject), fullyQualifiedName: "k8s.Subject")]
        internal sealed class _Proxy : DeputyBase, K8s.ISubject
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Kind of object being referenced.</summary>
            /// <remarks>
            /// Values defined by this API group are "User", "Group", and "ServiceAccount". If the Authorizer does not recognized the kind value, the Authorizer should report an error.
            ///
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Subject#kind
            /// </remarks>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name of the object being referenced.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Subject#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>APIGroup holds the API group of the referenced subject.</summary>
            /// <remarks>
            /// Defaults to "" for ServiceAccount subjects. Defaults to "rbac.authorization.k8s.io" for User and Group subjects.
            ///
            /// <strong>Default</strong>: for ServiceAccount subjects. Defaults to "rbac.authorization.k8s.io" for User and Group subjects.
            ///
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Subject#apiGroup
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiGroup
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Namespace of the referenced object.</summary>
            /// <remarks>
            /// If the object kind is non-namespace, such as "User" or "Group", and this value is not empty the Authorizer should report an error.
            ///
            /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Subject#namespace
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
