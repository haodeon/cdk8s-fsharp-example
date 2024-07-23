using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PersistentVolumeList is a list of PersistentVolume items.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubePersistentVolumeListProps")]
    public class KubePersistentVolumeListProps : K8s.IKubePersistentVolumeListProps
    {
        /// <summary>items is a list of persistent volumes.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePersistentVolumeProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubePersistentVolumeProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeList#metadata
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
