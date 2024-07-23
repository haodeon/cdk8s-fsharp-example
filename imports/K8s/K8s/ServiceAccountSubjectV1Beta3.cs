using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ServiceAccountSubject holds detailed information for service-account-kind subject.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.ServiceAccountSubject
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ServiceAccountSubjectV1Beta3")]
    public class ServiceAccountSubjectV1Beta3 : K8s.IServiceAccountSubjectV1Beta3
    {
        /// <summary>`name` is the name of matching ServiceAccount objects, or "*" to match regardless of name.</summary>
        /// <remarks>
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.ServiceAccountSubject#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>`namespace` is the namespace of matching ServiceAccount objects.</summary>
        /// <remarks>
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.ServiceAccountSubject#namespace
        /// </remarks>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }
    }
}
