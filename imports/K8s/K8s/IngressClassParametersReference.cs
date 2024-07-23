using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>IngressClassParametersReference identifies an API object.</summary>
    /// <remarks>
    /// This can be used to specify a cluster or namespace-scoped resource.
    ///
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassParametersReference
    /// </remarks>
    [JsiiByValue(fqn: "k8s.IngressClassParametersReference")]
    public class IngressClassParametersReference : K8s.IIngressClassParametersReference
    {
        /// <summary>kind is the type of resource being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassParametersReference#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <summary>name is the name of resource being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassParametersReference#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>apiGroup is the group for the resource being referenced.</summary>
        /// <remarks>
        /// If APIGroup is not specified, the specified Kind must be in the core API group. For any other third-party types, APIGroup is required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassParametersReference#apiGroup
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiGroup
        {
            get;
            set;
        }

        /// <summary>namespace is the namespace of the resource being referenced.</summary>
        /// <remarks>
        /// This field is required when scope is set to "Namespace" and must be unset when scope is set to "Cluster".
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassParametersReference#namespace
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>scope represents if this refers to a cluster or namespace scoped resource.</summary>
        /// <remarks>
        /// This may be set to "Cluster" (default) or "Namespace".
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.IngressClassParametersReference#scope
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Scope
        {
            get;
            set;
        }
    }
}
