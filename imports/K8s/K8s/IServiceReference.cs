using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ServiceReference holds a reference to Service.legacy.k8s.io.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ServiceReference
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IServiceReference), fullyQualifiedName: "k8s.ServiceReference")]
    public interface IServiceReference
    {
        /// <summary>`name` is the name of the service.</summary>
        /// <remarks>
        /// Required
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ServiceReference#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>`namespace` is the namespace of the service.</summary>
        /// <remarks>
        /// Required
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ServiceReference#namespace
        /// </remarks>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>`path` is an optional URL path which will be sent in any request to this service.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ServiceReference#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Path
        {
            get
            {
                return null;
            }
        }

        /// <summary>If specified, the port on the service that hosting webhook.</summary>
        /// <remarks>
        /// Default to 443 for backward compatibility. <c>port</c> should be a valid port number (1-65535, inclusive).
        ///
        /// <strong>Default</strong>: 443 for backward compatibility. `port` should be a valid port number (1-65535, inclusive).
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ServiceReference#port
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Port
        {
            get
            {
                return null;
            }
        }

        /// <summary>ServiceReference holds a reference to Service.legacy.k8s.io.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ServiceReference
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IServiceReference), fullyQualifiedName: "k8s.ServiceReference")]
        internal sealed class _Proxy : DeputyBase, K8s.IServiceReference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`name` is the name of the service.</summary>
            /// <remarks>
            /// Required
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ServiceReference#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
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
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>`path` is an optional URL path which will be sent in any request to this service.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ServiceReference#path
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Path
            {
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
