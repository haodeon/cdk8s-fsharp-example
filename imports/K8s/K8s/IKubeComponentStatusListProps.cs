using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Status of all the conditions for the component as a list of ComponentStatus objects.</summary>
    /// <remarks>
    /// Deprecated: This API is deprecated in v1.19+
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatusList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeComponentStatusListProps), fullyQualifiedName: "k8s.KubeComponentStatusListProps")]
    public interface IKubeComponentStatusListProps
    {
        /// <summary>List of ComponentStatus objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatusList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeComponentStatusProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeComponentStatusProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatusList#metadata
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

        /// <summary>Status of all the conditions for the component as a list of ComponentStatus objects.</summary>
        /// <remarks>
        /// Deprecated: This API is deprecated in v1.19+
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatusList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeComponentStatusListProps), fullyQualifiedName: "k8s.KubeComponentStatusListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeComponentStatusListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of ComponentStatus objects.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatusList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeComponentStatusProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeComponentStatusProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeComponentStatusProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatusList#metadata
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
