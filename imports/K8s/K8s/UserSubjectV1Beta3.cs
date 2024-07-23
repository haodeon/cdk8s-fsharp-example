using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>UserSubject holds detailed information for user-kind subject.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.UserSubject
    /// </remarks>
    [JsiiByValue(fqn: "k8s.UserSubjectV1Beta3")]
    public class UserSubjectV1Beta3 : K8s.IUserSubjectV1Beta3
    {
        /// <summary>`name` is the username that matches, or "*" to match all usernames.</summary>
        /// <remarks>
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.UserSubject#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
