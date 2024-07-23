using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceAttributes includes the authorization attributes available for resource requests to the Authorizer interface.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ResourceAttributes")]
    public class ResourceAttributes : K8s.IResourceAttributes
    {
        /// <summary>Group is the API Group of the Resource.</summary>
        /// <remarks>
        /// "*" means all.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes#group
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Group
        {
            get;
            set;
        }

        /// <summary>Name is the name of the resource being requested for a "get" or deleted for a "delete".</summary>
        /// <remarks>
        /// "" (empty) means all.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes#name
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Namespace is the namespace of the action being requested.</summary>
        /// <remarks>
        /// Currently, there is no distinction between no namespace and all namespaces "" (empty) is defaulted for LocalSubjectAccessReviews "" (empty) is empty for cluster-scoped resources "" (empty) means "all" for namespace scoped resources from a SubjectAccessReview or SelfSubjectAccessReview
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes#namespace
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>Resource is one of the existing resource types.</summary>
        /// <remarks>
        /// "*" means all.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes#resource
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Resource
        {
            get;
            set;
        }

        /// <summary>Subresource is one of the existing resource types.</summary>
        /// <remarks>
        /// "" means none.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes#subresource
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subresource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Subresource
        {
            get;
            set;
        }

        /// <summary>Verb is a kubernetes resource API verb, like: get, list, watch, create, update, delete, proxy.</summary>
        /// <remarks>
        /// "*" means all.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes#verb
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "verb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Verb
        {
            get;
            set;
        }

        /// <summary>Version is the API Version of the Resource.</summary>
        /// <remarks>
        /// "*" means all.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes#version
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
