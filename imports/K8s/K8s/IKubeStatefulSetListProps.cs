using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>StatefulSetList is a collection of StatefulSets.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeStatefulSetListProps), fullyQualifiedName: "k8s.KubeStatefulSetListProps")]
    public interface IKubeStatefulSetListProps
    {
        /// <summary>Items is the list of stateful sets.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeStatefulSetProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeStatefulSetProps[] Items
        {
            get;
        }

        /// <summary>Standard list's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetList#metadata
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

        /// <summary>StatefulSetList is a collection of StatefulSets.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeStatefulSetListProps), fullyQualifiedName: "k8s.KubeStatefulSetListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeStatefulSetListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is the list of stateful sets.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeStatefulSetProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeStatefulSetProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeStatefulSetProps[]>()!;
            }

            /// <summary>Standard list's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetList#metadata
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
