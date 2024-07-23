using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EventList is a list of Event objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.events.v1.EventList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeEventListProps), fullyQualifiedName: "k8s.KubeEventListProps")]
    public interface IKubeEventListProps
    {
        /// <summary>items is a list of schema objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.EventList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeEventProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeEventProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.EventList#metadata
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

        /// <summary>EventList is a list of Event objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.EventList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeEventListProps), fullyQualifiedName: "k8s.KubeEventListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeEventListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is a list of schema objects.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.events.v1.EventList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeEventProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeEventProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeEventProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.events.v1.EventList#metadata
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
