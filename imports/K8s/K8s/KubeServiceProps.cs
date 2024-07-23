using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Service is a named abstraction of software service (for example, mysql) consisting of local port (for example 3306) that the proxy listens on, and the selector that determines which pods will answer requests sent through the proxy.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Service
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeServiceProps")]
    public class KubeServiceProps : K8s.IKubeServiceProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Service#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Spec defines the behavior of a service.</summary>
        /// <remarks>
        /// https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Service#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ServiceSpec\"}", isOptional: true)]
        public K8s.IServiceSpec? Spec
        {
            get;
            set;
        }
    }
}
