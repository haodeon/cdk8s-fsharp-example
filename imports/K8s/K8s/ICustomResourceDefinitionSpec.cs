using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CustomResourceDefinitionSpec describes how a user wants their resource to appear.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ICustomResourceDefinitionSpec), fullyQualifiedName: "k8s.CustomResourceDefinitionSpec")]
    public interface ICustomResourceDefinitionSpec
    {
        /// <summary>group is the API group of the defined custom resource.</summary>
        /// <remarks>
        /// The custom resources are served under <c>/apis/&lt;group&gt;/...</c>. Must match the name of the CustomResourceDefinition (in the form <c>&lt;names.plural&gt;.&lt;group&gt;</c>).
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionSpec#group
        /// </remarks>
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}")]
        string Group
        {
            get;
        }

        /// <summary>names specify the resource and kind names for the custom resource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionSpec#names
        /// </remarks>
        [JsiiProperty(name: "names", typeJson: "{\"fqn\":\"k8s.CustomResourceDefinitionNames\"}")]
        K8s.ICustomResourceDefinitionNames Names
        {
            get;
        }

        /// <summary>scope indicates whether the defined custom resource is cluster- or namespace-scoped.</summary>
        /// <remarks>
        /// Allowed values are <c>Cluster</c> and <c>Namespaced</c>.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionSpec#scope
        /// </remarks>
        [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
        string Scope
        {
            get;
        }

        /// <summary>versions is the list of all API versions of the defined custom resource.</summary>
        /// <remarks>
        /// Version names are used to compute the order in which served versions are listed in API discovery. If the version string is "kube-like", it will sort above non "kube-like" version strings, which are ordered lexicographically. "Kube-like" versions start with a "v", then are followed by a number (the major version), then optionally the string "alpha" or "beta" and another number (the minor version). These are sorted first by GA &gt; beta &gt; alpha (where GA is a version with no suffix such as beta or alpha), and then by comparing major version, then minor version. An example sorted list of versions: v10, v2, v1, v11beta2, v10beta3, v3beta1, v12alpha1, v11alpha2, foo1, foo10.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionSpec#versions
        /// </remarks>
        [JsiiProperty(name: "versions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.CustomResourceDefinitionVersion\"},\"kind\":\"array\"}}")]
        K8s.ICustomResourceDefinitionVersion[] Versions
        {
            get;
        }

        /// <summary>conversion defines conversion settings for the CRD.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionSpec#conversion
        /// </remarks>
        [JsiiProperty(name: "conversion", typeJson: "{\"fqn\":\"k8s.CustomResourceConversion\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ICustomResourceConversion? Conversion
        {
            get
            {
                return null;
            }
        }

        /// <summary>preserveUnknownFields indicates that object fields which are not specified in the OpenAPI schema should be preserved when persisting to storage.</summary>
        /// <remarks>
        /// apiVersion, kind, metadata and known fields inside metadata are always preserved. This field is deprecated in favor of setting <c>x-preserve-unknown-fields</c> to true in <c>spec.versions[*].schema.openAPIV3Schema</c>. See https://kubernetes.io/docs/tasks/extend-kubernetes/custom-resources/custom-resource-definitions/#field-pruning for details.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionSpec#preserveUnknownFields
        /// </remarks>
        [JsiiProperty(name: "preserveUnknownFields", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? PreserveUnknownFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>CustomResourceDefinitionSpec describes how a user wants their resource to appear.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ICustomResourceDefinitionSpec), fullyQualifiedName: "k8s.CustomResourceDefinitionSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.ICustomResourceDefinitionSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>group is the API group of the defined custom resource.</summary>
            /// <remarks>
            /// The custom resources are served under <c>/apis/&lt;group&gt;/...</c>. Must match the name of the CustomResourceDefinition (in the form <c>&lt;names.plural&gt;.&lt;group&gt;</c>).
            ///
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionSpec#group
            /// </remarks>
            [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}")]
            public string Group
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>names specify the resource and kind names for the custom resource.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionSpec#names
            /// </remarks>
            [JsiiProperty(name: "names", typeJson: "{\"fqn\":\"k8s.CustomResourceDefinitionNames\"}")]
            public K8s.ICustomResourceDefinitionNames Names
            {
                get => GetInstanceProperty<K8s.ICustomResourceDefinitionNames>()!;
            }

            /// <summary>scope indicates whether the defined custom resource is cluster- or namespace-scoped.</summary>
            /// <remarks>
            /// Allowed values are <c>Cluster</c> and <c>Namespaced</c>.
            ///
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionSpec#scope
            /// </remarks>
            [JsiiProperty(name: "scope", typeJson: "{\"primitive\":\"string\"}")]
            public string Scope
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>versions is the list of all API versions of the defined custom resource.</summary>
            /// <remarks>
            /// Version names are used to compute the order in which served versions are listed in API discovery. If the version string is "kube-like", it will sort above non "kube-like" version strings, which are ordered lexicographically. "Kube-like" versions start with a "v", then are followed by a number (the major version), then optionally the string "alpha" or "beta" and another number (the minor version). These are sorted first by GA &gt; beta &gt; alpha (where GA is a version with no suffix such as beta or alpha), and then by comparing major version, then minor version. An example sorted list of versions: v10, v2, v1, v11beta2, v10beta3, v3beta1, v12alpha1, v11alpha2, foo1, foo10.
            ///
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionSpec#versions
            /// </remarks>
            [JsiiProperty(name: "versions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.CustomResourceDefinitionVersion\"},\"kind\":\"array\"}}")]
            public K8s.ICustomResourceDefinitionVersion[] Versions
            {
                get => GetInstanceProperty<K8s.ICustomResourceDefinitionVersion[]>()!;
            }

            /// <summary>conversion defines conversion settings for the CRD.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionSpec#conversion
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "conversion", typeJson: "{\"fqn\":\"k8s.CustomResourceConversion\"}", isOptional: true)]
            public K8s.ICustomResourceConversion? Conversion
            {
                get => GetInstanceProperty<K8s.ICustomResourceConversion?>();
            }

            /// <summary>preserveUnknownFields indicates that object fields which are not specified in the OpenAPI schema should be preserved when persisting to storage.</summary>
            /// <remarks>
            /// apiVersion, kind, metadata and known fields inside metadata are always preserved. This field is deprecated in favor of setting <c>x-preserve-unknown-fields</c> to true in <c>spec.versions[*].schema.openAPIV3Schema</c>. See https://kubernetes.io/docs/tasks/extend-kubernetes/custom-resources/custom-resource-definitions/#field-pruning for details.
            ///
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionSpec#preserveUnknownFields
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preserveUnknownFields", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? PreserveUnknownFields
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
