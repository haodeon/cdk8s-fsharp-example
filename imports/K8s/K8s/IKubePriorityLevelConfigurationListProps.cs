using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PriorityLevelConfigurationList is a list of PriorityLevelConfiguration objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubePriorityLevelConfigurationListProps), fullyQualifiedName: "k8s.KubePriorityLevelConfigurationListProps")]
    public interface IKubePriorityLevelConfigurationListProps
    {
        /// <summary>`items` is a list of request-priorities.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePriorityLevelConfigurationProps\"},\"kind\":\"array\"}}")]
        K8s.IKubePriorityLevelConfigurationProps[] Items
        {
            get;
        }

        /// <summary>`metadata` is the standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationList#metadata
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

        /// <summary>PriorityLevelConfigurationList is a list of PriorityLevelConfiguration objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubePriorityLevelConfigurationListProps), fullyQualifiedName: "k8s.KubePriorityLevelConfigurationListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubePriorityLevelConfigurationListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`items` is a list of request-priorities.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePriorityLevelConfigurationProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubePriorityLevelConfigurationProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubePriorityLevelConfigurationProps[]>()!;
            }

            /// <summary>`metadata` is the standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationList#metadata
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
