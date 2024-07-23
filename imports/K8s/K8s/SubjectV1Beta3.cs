using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Subject matches the originator of a request, as identified by the request authentication system.</summary>
    /// <remarks>
    /// There are three ways of matching an originator; by user, group, or service account.
    ///
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.Subject
    /// </remarks>
    [JsiiByValue(fqn: "k8s.SubjectV1Beta3")]
    public class SubjectV1Beta3 : K8s.ISubjectV1Beta3
    {
        /// <summary>`kind` indicates which one of the other fields is non-empty.</summary>
        /// <remarks>
        /// Required
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.Subject#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <summary>`group` matches based on user group name.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.Subject#group
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"fqn\":\"k8s.GroupSubjectV1Beta3\"}", isOptional: true)]
        public K8s.IGroupSubjectV1Beta3? Group
        {
            get;
            set;
        }

        /// <summary>`serviceAccount` matches ServiceAccounts.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.Subject#serviceAccount
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceAccount", typeJson: "{\"fqn\":\"k8s.ServiceAccountSubjectV1Beta3\"}", isOptional: true)]
        public K8s.IServiceAccountSubjectV1Beta3? ServiceAccount
        {
            get;
            set;
        }

        /// <summary>`user` matches based on username.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.Subject#user
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "user", typeJson: "{\"fqn\":\"k8s.UserSubjectV1Beta3\"}", isOptional: true)]
        public K8s.IUserSubjectV1Beta3? User
        {
            get;
            set;
        }
    }
}
