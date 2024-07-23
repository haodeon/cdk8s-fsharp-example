using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PriorityClassList is a collection of priority classes.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClassList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubePriorityClassListProps), fullyQualifiedName: "k8s.KubePriorityClassListProps")]
    public interface IKubePriorityClassListProps
    {
        /// <summary>items is the list of PriorityClasses.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClassList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePriorityClassProps\"},\"kind\":\"array\"}}")]
        K8s.IKubePriorityClassProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClassList#metadata
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

        /// <summary>PriorityClassList is a collection of priority classes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClassList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubePriorityClassListProps), fullyQualifiedName: "k8s.KubePriorityClassListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubePriorityClassListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is the list of PriorityClasses.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClassList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePriorityClassProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubePriorityClassProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubePriorityClassProps[]>()!;
            }

            /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClassList#metadata
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
