using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ReplicationControllerList is a collection of replication controllers.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeReplicationControllerListProps), fullyQualifiedName: "k8s.KubeReplicationControllerListProps")]
    public interface IKubeReplicationControllerListProps
    {
        /// <summary>List of replication controllers.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeReplicationControllerProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeReplicationControllerProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerList#metadata
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

        /// <summary>ReplicationControllerList is a collection of replication controllers.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeReplicationControllerListProps), fullyQualifiedName: "k8s.KubeReplicationControllerListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeReplicationControllerListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of replication controllers.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeReplicationControllerProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeReplicationControllerProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeReplicationControllerProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerList#metadata
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
