using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ControllerRevisionList is a resource containing a list of ControllerRevision objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevisionList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeControllerRevisionListProps), fullyQualifiedName: "k8s.KubeControllerRevisionListProps")]
    public interface IKubeControllerRevisionListProps
    {
        /// <summary>Items is the list of ControllerRevisions.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevisionList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeControllerRevisionProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeControllerRevisionProps[] Items
        {
            get;
        }

        /// <summary>More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevisionList#metadata
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

        /// <summary>ControllerRevisionList is a resource containing a list of ControllerRevision objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevisionList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeControllerRevisionListProps), fullyQualifiedName: "k8s.KubeControllerRevisionListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeControllerRevisionListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is the list of ControllerRevisions.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevisionList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeControllerRevisionProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeControllerRevisionProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeControllerRevisionProps[]>()!;
            }

            /// <summary>More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevisionList#metadata
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
