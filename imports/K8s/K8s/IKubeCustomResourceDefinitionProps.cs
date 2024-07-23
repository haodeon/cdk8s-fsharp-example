using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CustomResourceDefinition represents a resource that should be exposed on the API server.</summary>
    /// <remarks>
    /// Its name MUST be in the format &lt;.spec.name&gt;.&lt;.spec.group&gt;.
    ///
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinition
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeCustomResourceDefinitionProps), fullyQualifiedName: "k8s.KubeCustomResourceDefinitionProps")]
    public interface IKubeCustomResourceDefinitionProps
    {
        /// <summary>spec describes how the user wants the resources to appear.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinition#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.CustomResourceDefinitionSpec\"}")]
        K8s.ICustomResourceDefinitionSpec Spec
        {
            get;
        }

        /// <summary>Standard object's metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinition#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>CustomResourceDefinition represents a resource that should be exposed on the API server.</summary>
        /// <remarks>
        /// Its name MUST be in the format &lt;.spec.name&gt;.&lt;.spec.group&gt;.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinition
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeCustomResourceDefinitionProps), fullyQualifiedName: "k8s.KubeCustomResourceDefinitionProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeCustomResourceDefinitionProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>spec describes how the user wants the resources to appear.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinition#spec
            /// </remarks>
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.CustomResourceDefinitionSpec\"}")]
            public K8s.ICustomResourceDefinitionSpec Spec
            {
                get => GetInstanceProperty<K8s.ICustomResourceDefinitionSpec>()!;
            }

            /// <summary>Standard object's metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinition#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }
        }
    }
}
