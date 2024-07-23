using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ReplicaSetList is a collection of ReplicaSets.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeReplicaSetListProps")]
    public class KubeReplicaSetListProps : K8s.IKubeReplicaSetListProps
    {
        /// <summary>List of ReplicaSets.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeReplicaSetProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeReplicaSetProps[] Items
        {
            get;
            set;
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
            get;
            set;
        }
    }
}
