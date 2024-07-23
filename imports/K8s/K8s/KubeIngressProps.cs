using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Ingress is a collection of rules that allow inbound connections to reach the endpoints defined by a backend.</summary>
    /// <remarks>
    /// An Ingress can be configured to give services externally-reachable urls, load balance traffic, terminate SSL, offer name based virtual hosting etc.
    ///
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.Ingress
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeIngressProps")]
    public class KubeIngressProps : K8s.IKubeIngressProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.Ingress#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>spec is the desired state of the Ingress.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.Ingress#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.IngressSpec\"}", isOptional: true)]
        public K8s.IIngressSpec? Spec
        {
            get;
            set;
        }
    }
}
