using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>GroupSubject holds detailed information for group-kind subject.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.GroupSubject
    /// </remarks>
    [JsiiByValue(fqn: "k8s.GroupSubjectV1Beta3")]
    public class GroupSubjectV1Beta3 : K8s.IGroupSubjectV1Beta3
    {
        /// <summary>name is the user group that matches, or "*" to match all user groups.</summary>
        /// <remarks>
        /// See https://github.com/kubernetes/apiserver/blob/master/pkg/authentication/user/user.go for some well-known group names. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.GroupSubject#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
