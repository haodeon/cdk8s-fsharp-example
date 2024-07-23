using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ServiceReference holds a reference to Service.legacy.k8s.io.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ServiceReference
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ServiceReference")]
    public class ServiceReference : K8s.IServiceReference
    {
        /// <summary>`name` is the name of the service.</summary>
        /// <remarks>
        /// Required
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ServiceReference#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>`namespace` is the namespace of the service.</summary>
        /// <remarks>
        /// Required
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ServiceReference#namespace
        /// </remarks>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>`path` is an optional URL path which will be sent in any request to this service.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ServiceReference#path
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Path
        {
            get;
            set;
        }

        /// <summary>If specified, the port on the service that hosting webhook.</summary>
        /// <remarks>
        /// Default to 443 for backward compatibility. <c>port</c> should be a valid port number (1-65535, inclusive).
        ///
        /// <strong>Default</strong>: 443 for backward compatibility. `port` should be a valid port number (1-65535, inclusive).
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ServiceReference#port
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Port
        {
            get;
            set;
        }
    }
}
