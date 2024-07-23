using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Subject contains a reference to the object or user identities a role binding applies to.</summary>
    /// <remarks>
    /// This can either hold a direct API object reference, or a value for non-objects such as user and group names.
    ///
    /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Subject
    /// </remarks>
    [JsiiByValue(fqn: "k8s.Subject")]
    public class Subject : K8s.ISubject
    {
        /// <summary>Kind of object being referenced.</summary>
        /// <remarks>
        /// Values defined by this API group are "User", "Group", and "ServiceAccount". If the Authorizer does not recognized the kind value, the Authorizer should report an error.
        ///
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Subject#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <summary>Name of the object being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.rbac.v1.Subject#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
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
            get;
            set;
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
            get;
            set;
        }
    }
}
