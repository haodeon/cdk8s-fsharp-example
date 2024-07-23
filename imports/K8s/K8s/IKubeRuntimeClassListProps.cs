using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>RuntimeClassList is a list of RuntimeClass objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.node.v1.RuntimeClassList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeRuntimeClassListProps), fullyQualifiedName: "k8s.KubeRuntimeClassListProps")]
    public interface IKubeRuntimeClassListProps
    {
        /// <summary>items is a list of schema objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.node.v1.RuntimeClassList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeRuntimeClassProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeRuntimeClassProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.node.v1.RuntimeClassList#metadata
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

        /// <summary>RuntimeClassList is a list of RuntimeClass objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.node.v1.RuntimeClassList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeRuntimeClassListProps), fullyQualifiedName: "k8s.KubeRuntimeClassListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeRuntimeClassListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is a list of schema objects.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.node.v1.RuntimeClassList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeRuntimeClassProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeRuntimeClassProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeRuntimeClassProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.node.v1.RuntimeClassList#metadata
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
