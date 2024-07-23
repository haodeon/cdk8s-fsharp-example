using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodTemplateList is a list of PodTemplates.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PodTemplateList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubePodTemplateListProps), fullyQualifiedName: "k8s.KubePodTemplateListProps")]
    public interface IKubePodTemplateListProps
    {
        /// <summary>List of pod templates.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodTemplateList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePodTemplateProps\"},\"kind\":\"array\"}}")]
        K8s.IKubePodTemplateProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodTemplateList#metadata
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

        /// <summary>PodTemplateList is a list of PodTemplates.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodTemplateList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubePodTemplateListProps), fullyQualifiedName: "k8s.KubePodTemplateListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubePodTemplateListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of pod templates.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodTemplateList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePodTemplateProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubePodTemplateProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubePodTemplateProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodTemplateList#metadata
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
