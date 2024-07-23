using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>CustomResourceDefinitionNames indicates the names to serve this CustomResourceDefinition.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionNames
    /// </remarks>
    [JsiiByValue(fqn: "k8s.CustomResourceDefinitionNames")]
    public class CustomResourceDefinitionNames : K8s.ICustomResourceDefinitionNames
    {
        /// <summary>kind is the serialized kind of the resource.</summary>
        /// <remarks>
        /// It is normally CamelCase and singular. Custom resource instances will use this value as the <c>kind</c> attribute in API calls.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionNames#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <summary>plural is the plural name of the resource to serve.</summary>
        /// <remarks>
        /// The custom resources are served under <c>/apis/&lt;group&gt;/&lt;version&gt;/.../&lt;plural&gt;</c>. Must match the name of the CustomResourceDefinition (in the form <c>&lt;names.plural&gt;.&lt;group&gt;</c>). Must be all lowercase.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionNames#plural
        /// </remarks>
        [JsiiProperty(name: "plural", typeJson: "{\"primitive\":\"string\"}")]
        public string Plural
        {
            get;
            set;
        }

        /// <summary>categories is a list of grouped resources this custom resource belongs to (e.g. 'all'). This is published in API discovery documents, and used by clients to support invocations like `kubectl get all`.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionNames#categories
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "categories", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Categories
        {
            get;
            set;
        }

        /// <summary>listKind is the serialized kind of the list for this resource.</summary>
        /// <remarks>
        /// Defaults to "<c>kind</c>List".
        ///
        /// <strong>Default</strong>: kind`List".
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionNames#listKind
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "listKind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ListKind
        {
            get;
            set;
        }

        /// <summary>shortNames are short names for the resource, exposed in API discovery documents, and used by clients to support invocations like `kubectl get &lt;shortname&gt;`.</summary>
        /// <remarks>
        /// It must be all lowercase.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionNames#shortNames
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "shortNames", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? ShortNames
        {
            get;
            set;
        }

        /// <summary>singular is the singular name of the resource.</summary>
        /// <remarks>
        /// It must be all lowercase. Defaults to lowercased <c>kind</c>.
        ///
        /// <strong>Default</strong>: lowercased `kind`.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionNames#singular
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "singular", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Singular
        {
            get;
            set;
        }
    }
}
