using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PersistentVolumeClaimList is a list of PersistentVolumeClaim items.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubePersistentVolumeClaimListProps")]
    public class KubePersistentVolumeClaimListProps : K8s.IKubePersistentVolumeClaimListProps
    {
        /// <summary>items is a list of persistent volume claims.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePersistentVolumeClaimProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubePersistentVolumeClaimProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimList#metadata
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
