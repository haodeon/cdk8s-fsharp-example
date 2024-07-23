using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Subject matches the originator of a request, as identified by the request authentication system.</summary>
    /// <remarks>
    /// There are three ways of matching an originator; by user, group, or service account.
    ///
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.Subject
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ISubjectV1Beta3), fullyQualifiedName: "k8s.SubjectV1Beta3")]
    public interface ISubjectV1Beta3
    {
        /// <summary>`kind` indicates which one of the other fields is non-empty.</summary>
        /// <remarks>
        /// Required
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.Subject#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        string Kind
        {
            get;
        }

        /// <summary>`group` matches based on user group name.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.Subject#group
        /// </remarks>
        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"k8s.GroupSubjectV1Beta3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IGroupSubjectV1Beta3? Group
        {
            get
            {
                return null;
            }
        }

        /// <summary>`serviceAccount` matches ServiceAccounts.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.Subject#serviceAccount
        /// </remarks>
        [JsiiProperty(name: "serviceAccount", typeJson: "{\"fqn\":\"k8s.ServiceAccountSubjectV1Beta3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IServiceAccountSubjectV1Beta3? ServiceAccount
        {
            get
            {
                return null;
            }
        }

        /// <summary>`user` matches based on username.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.Subject#user
        /// </remarks>
        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"k8s.UserSubjectV1Beta3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IUserSubjectV1Beta3? User
        {
            get
            {
                return null;
            }
        }

        /// <summary>Subject matches the originator of a request, as identified by the request authentication system.</summary>
        /// <remarks>
        /// There are three ways of matching an originator; by user, group, or service account.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.Subject
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ISubjectV1Beta3), fullyQualifiedName: "k8s.SubjectV1Beta3")]
        internal sealed class _Proxy : DeputyBase, K8s.ISubjectV1Beta3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`kind` indicates which one of the other fields is non-empty.</summary>
            /// <remarks>
            /// Required
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.Subject#kind
            /// </remarks>
            [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
            public string Kind
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>`group` matches based on user group name.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.Subject#group
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"k8s.GroupSubjectV1Beta3\"}", isOptional: true)]
            public K8s.IGroupSubjectV1Beta3? Group
            {
                get => GetInstanceProperty<K8s.IGroupSubjectV1Beta3?>();
            }

            /// <summary>`serviceAccount` matches ServiceAccounts.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.Subject#serviceAccount
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "serviceAccount", typeJson: "{\"fqn\":\"k8s.ServiceAccountSubjectV1Beta3\"}", isOptional: true)]
            public K8s.IServiceAccountSubjectV1Beta3? ServiceAccount
            {
                get => GetInstanceProperty<K8s.IServiceAccountSubjectV1Beta3?>();
            }

            /// <summary>`user` matches based on username.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.Subject#user
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"k8s.UserSubjectV1Beta3\"}", isOptional: true)]
            public K8s.IUserSubjectV1Beta3? User
            {
                get => GetInstanceProperty<K8s.IUserSubjectV1Beta3?>();
            }
        }
    }
}
