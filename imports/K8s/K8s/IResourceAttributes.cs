using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceAttributes includes the authorization attributes available for resource requests to the Authorizer interface.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IResourceAttributes), fullyQualifiedName: "k8s.ResourceAttributes")]
    public interface IResourceAttributes
    {
        /// <summary>Group is the API Group of the Resource.</summary>
        /// <remarks>
        /// "*" means all.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes#group
        /// </remarks>
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Group
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name is the name of the resource being requested for a "get" or deleted for a "delete".</summary>
        /// <remarks>
        /// "" (empty) means all.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Namespace is the namespace of the action being requested.</summary>
        /// <remarks>
        /// Currently, there is no distinction between no namespace and all namespaces "" (empty) is defaulted for LocalSubjectAccessReviews "" (empty) is empty for cluster-scoped resources "" (empty) means "all" for namespace scoped resources from a SubjectAccessReview or SelfSubjectAccessReview
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes#namespace
        /// </remarks>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>Resource is one of the existing resource types.</summary>
        /// <remarks>
        /// "*" means all.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes#resource
        /// </remarks>
        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Resource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Subresource is one of the existing resource types.</summary>
        /// <remarks>
        /// "" means none.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes#subresource
        /// </remarks>
        [JsiiProperty(name: "subresource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Subresource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Verb is a kubernetes resource API verb, like: get, list, watch, create, update, delete, proxy.</summary>
        /// <remarks>
        /// "*" means all.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes#verb
        /// </remarks>
        [JsiiProperty(name: "verb", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Verb
        {
            get
            {
                return null;
            }
        }

        /// <summary>Version is the API Version of the Resource.</summary>
        /// <remarks>
        /// "*" means all.
        ///
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes#version
        /// </remarks>
        [JsiiProperty(name: "version", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Version
        {
            get
            {
                return null;
            }
        }

        /// <summary>ResourceAttributes includes the authorization attributes available for resource requests to the Authorizer interface.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.authorization.v1.ResourceAttributes
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IResourceAttributes), fullyQualifiedName: "k8s.ResourceAttributes")]
        internal sealed class _Proxy : DeputyBase, K8s.IResourceAttributes
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
