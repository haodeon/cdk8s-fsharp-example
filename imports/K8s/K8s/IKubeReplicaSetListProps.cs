using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ReplicaSetList is a collection of ReplicaSets.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeReplicaSetListProps), fullyQualifiedName: "k8s.KubeReplicaSetListProps")]
    public interface IKubeReplicaSetListProps
    {
        /// <summary>List of ReplicaSets.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeReplicaSetProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeReplicaSetProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetList#metadata
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

        /// <summary>ReplicaSetList is a collection of ReplicaSets.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeReplicaSetListProps), fullyQualifiedName: "k8s.KubeReplicaSetListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeReplicaSetListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>List of ReplicaSets.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeReplicaSetProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeReplicaSetProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeReplicaSetProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetList#metadata
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
