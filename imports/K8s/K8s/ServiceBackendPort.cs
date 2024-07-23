using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ServiceBackendPort is the service port being referenced.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.ServiceBackendPort
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ServiceBackendPort")]
    public class ServiceBackendPort : K8s.IServiceBackendPort
    {
        /// <summary>name is the name of the port on the Service.</summary>
        /// <remarks>
        /// This is a mutually exclusive setting with "Number".
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.ServiceBackendPort#name
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>number is the numerical port number (e.g. 80) on the Service. This is a mutually exclusive setting with "Name".</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.ServiceBackendPort#number
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "number", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Number
        {
            get;
            set;
        }
    }
}
