using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>IngressServiceBackend references a Kubernetes Service as a Backend.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressServiceBackend
    /// </remarks>
    [JsiiByValue(fqn: "k8s.IngressServiceBackend")]
    public class IngressServiceBackend : K8s.IIngressServiceBackend
    {
        /// <summary>name is the referenced service.</summary>
        /// <remarks>
        /// The service must exist in the same namespace as the Ingress object.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressServiceBackend#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>port of the referenced service.</summary>
        /// <remarks>
        /// A port name or port number is required for a IngressServiceBackend.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressServiceBackend#port
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"fqn\":\"k8s.ServiceBackendPort\"}", isOptional: true)]
        public K8s.IServiceBackendPort? Port
        {
            get;
            set;
        }
    }
}
