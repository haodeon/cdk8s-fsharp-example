using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>APIServiceSpec contains information for locating and communicating with a server.</summary>
    /// <remarks>
    /// Only https is supported, though you are able to disable certificate verification.
    ///
    /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ApiServiceSpec")]
    public class ApiServiceSpec : K8s.IApiServiceSpec
    {
        /// <summary>GroupPriorityMinimum is the priority this group should have at least.</summary>
        /// <remarks>
        /// Higher priority means that the group is preferred by clients over lower priority ones. Note that other versions of this group might specify even higher GroupPriorityMinimum values such that the whole group gets a higher priority. The primary sort is based on GroupPriorityMinimum, ordered highest number to lowest (20 before 10). The secondary sort is based on the alphabetical comparison of the name of the object.  (v1.bar before v1.foo) We'd recommend something like: *.k8s.io (except extensions) at 18000 and PaaSes (OpenShift, Deis) are recommended to be in the 2000s
        ///
        /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceSpec#groupPriorityMinimum
        /// </remarks>
        [JsiiProperty(name: "groupPriorityMinimum", typeJson: "{\"primitive\":\"number\"}")]
        public double GroupPriorityMinimum
        {
            get;
            set;
        }

        /// <summary>VersionPriority controls the ordering of this API version inside of its group.</summary>
        /// <remarks>
        /// Must be greater than zero. The primary sort is based on VersionPriority, ordered highest to lowest (20 before 10). Since it's inside of a group, the number can be small, probably in the 10s. In case of equal version priorities, the version string will be used to compute the order inside a group. If the version string is "kube-like", it will sort above non "kube-like" version strings, which are ordered lexicographically. "Kube-like" versions start with a "v", then are followed by a number (the major version), then optionally the string "alpha" or "beta" and another number (the minor version). These are sorted first by GA &gt; beta &gt; alpha (where GA is a version with no suffix such as beta or alpha), and then by comparing major version, then minor version. An example sorted list of versions: v10, v2, v1, v11beta2, v10beta3, v3beta1, v12alpha1, v11alpha2, foo1, foo10.
        ///
        /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceSpec#versionPriority
        /// </remarks>
        [JsiiProperty(name: "versionPriority", typeJson: "{\"primitive\":\"number\"}")]
        public double VersionPriority
        {
            get;
            set;
        }

        /// <summary>CABundle is a PEM encoded CA bundle which will be used to validate an API server's serving certificate.</summary>
        /// <remarks>
        /// If unspecified, system trust roots on the apiserver are used.
        ///
        /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceSpec#caBundle
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "caBundle", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? CaBundle
        {
            get;
            set;
        }

        /// <summary>Group is the API group name this server hosts.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceSpec#group
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Group
        {
            get;
            set;
        }

        /// <summary>InsecureSkipTLSVerify disables TLS certificate verification when communicating with this server.</summary>
        /// <remarks>
        /// This is strongly discouraged.  You should use the CABundle instead.
        ///
        /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceSpec#insecureSkipTLSVerify
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "insecureSkipTlsVerify", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? InsecureSkipTlsVerify
        {
            get;
            set;
        }

        /// <summary>Service is a reference to the service for this API server.</summary>
        /// <remarks>
        /// It must communicate on port 443. If the Service is nil, that means the handling for the API groupversion is handled locally on this server. The call will simply delegate to the normal handler chain to be fulfilled.
        ///
        /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceSpec#service
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "service", typeJson: "{\"fqn\":\"k8s.ServiceReference\"}", isOptional: true)]
        public K8s.IServiceReference? Service
        {
            get;
            set;
        }

        /// <summary>Version is the API version this server hosts.</summary>
        /// <remarks>
        /// For example, "v1"
        ///
        /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceSpec#version
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Version
        {
            get;
            set;
        }
    }
}
