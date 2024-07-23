using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ReplicationControllerList is a collection of replication controllers.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeReplicationControllerListProps")]
    public class KubeReplicationControllerListProps : K8s.IKubeReplicationControllerListProps
    {
        /// <summary>List of replication controllers.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeReplicationControllerProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeReplicationControllerProps[] Items
        {
            get;
            set;
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
            get;
            set;
        }
    }
}
