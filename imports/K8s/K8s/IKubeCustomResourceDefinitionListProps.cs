using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CustomResourceDefinitionList is a list of CustomResourceDefinition objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeCustomResourceDefinitionListProps), fullyQualifiedName: "k8s.KubeCustomResourceDefinitionListProps")]
    public interface IKubeCustomResourceDefinitionListProps
    {
        /// <summary>items list individual CustomResourceDefinition objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCustomResourceDefinitionProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeCustomResourceDefinitionProps[] Items
        {
            get;
        }

        /// <summary>Standard object's metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionList#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IListMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>CustomResourceDefinitionList is a list of CustomResourceDefinition objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeCustomResourceDefinitionListProps), fullyQualifiedName: "k8s.KubeCustomResourceDefinitionListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeCustomResourceDefinitionListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items list individual CustomResourceDefinition objects.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCustomResourceDefinitionProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeCustomResourceDefinitionProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeCustomResourceDefinitionProps[]>()!;
            }

            /// <summary>Standard object's metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinitionList#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
            public K8s.IListMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IListMeta?>();
            }
        }
    }
}
