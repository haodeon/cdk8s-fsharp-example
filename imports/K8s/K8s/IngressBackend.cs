using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>IngressBackend describes all endpoints for a given service and port.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressBackend
    /// </remarks>
    [JsiiByValue(fqn: "k8s.IngressBackend")]
    public class IngressBackend : K8s.IIngressBackend
    {
        /// <summary>resource is an ObjectRef to another Kubernetes resource in the namespace of the Ingress object.</summary>
        /// <remarks>
        /// If resource is specified, a service.Name and service.Port must not be specified. This is a mutually exclusive setting with "Service".
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressBackend#resource
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resource", typeJson: "{\"fqn\":\"k8s.TypedLocalObjectReference\"}", isOptional: true)]
        public K8s.ITypedLocalObjectReference? Resource
        {
            get;
            set;
        }

        /// <summary>service references a service as a backend.</summary>
        /// <remarks>
        /// This is a mutually exclusive setting with "Resource".
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressBackend#service
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "service", typeJson: "{\"fqn\":\"k8s.IngressServiceBackend\"}", isOptional: true)]
        public K8s.IIngressServiceBackend? Service
        {
            get;
            set;
        }
    }
}
