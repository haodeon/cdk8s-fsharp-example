using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>CustomResourceDefinitionVersion describes a version for CRD.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionVersion
    /// </remarks>
    [JsiiByValue(fqn: "k8s.CustomResourceDefinitionVersion")]
    public class CustomResourceDefinitionVersion : K8s.ICustomResourceDefinitionVersion
    {
        /// <summary>name is the version name, e.g. “v1”, “v2beta1”, etc. The custom resources are served under this version at `/apis/&lt;group&gt;/&lt;version&gt;/...` if `served` is true.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionVersion#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>served is a flag enabling/disabling this version from being served via REST APIs.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionVersion#served
        /// </remarks>
        [JsiiProperty(name: "served", typeJson: "{\"primitive\":\"boolean\"}")]
        public bool Served
        {
            get;
            set;
        }

        /// <summary>storage indicates this version should be used when persisting custom resources to storage.</summary>
        /// <remarks>
        /// There must be exactly one version with storage=true.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionVersion#storage
        /// </remarks>
        [JsiiProperty(name: "storage", typeJson: "{\"primitive\":\"boolean\"}")]
        public bool Storage
        {
            get;
            set;
        }

        /// <summary>additionalPrinterColumns specifies additional columns returned in Table output.</summary>
        /// <remarks>
        /// See https://kubernetes.io/docs/reference/using-api/api-concepts/#receiving-resources-as-tables for details. If no columns are specified, a single column displaying the age of the custom resource is used.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionVersion#additionalPrinterColumns
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "additionalPrinterColumns", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.CustomResourceColumnDefinition\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.ICustomResourceColumnDefinition[]? AdditionalPrinterColumns
        {
            get;
            set;
        }

        /// <summary>deprecated indicates this version of the custom resource API is deprecated.</summary>
        /// <remarks>
        /// When set to true, API requests to this version receive a warning header in the server response. Defaults to false.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionVersion#deprecated
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deprecated", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? Deprecated
        {
            get;
            set;
        }

        /// <summary>deprecationWarning overrides the default warning returned to API clients.</summary>
        /// <remarks>
        /// May only be set when <c>deprecated</c> is true. The default warning indicates this version is deprecated and recommends use of the newest served version of equal or greater stability, if one exists.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionVersion#deprecationWarning
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deprecationWarning", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? DeprecationWarning
        {
            get;
            set;
        }

        /// <summary>schema describes the schema used for validation, pruning, and defaulting of this version of the custom resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionVersion#schema
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "schema", typeJson: "{\"fqn\":\"k8s.CustomResourceValidation\"}", isOptional: true)]
        public K8s.ICustomResourceValidation? Schema
        {
            get;
            set;
        }

        /// <summary>selectableFields specifies paths to fields that may be used as field selectors.</summary>
        /// <remarks>
        /// A maximum of 8 selectable fields are allowed. See https://kubernetes.io/docs/concepts/overview/working-with-objects/field-selectors
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionVersion#selectableFields
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "selectableFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.SelectableField\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.ISelectableField[]? SelectableFields
        {
            get;
            set;
        }

        /// <summary>subresources specify what subresources this version of the defined custom resource have.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionVersion#subresources
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "subresources", typeJson: "{\"fqn\":\"k8s.CustomResourceSubresources\"}", isOptional: true)]
        public K8s.ICustomResourceSubresources? Subresources
        {
            get;
            set;
        }
    }
}
