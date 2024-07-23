using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>StorageClassList is a collection of storage classes.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClassList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeStorageClassListProps")]
    public class KubeStorageClassListProps : K8s.IKubeStorageClassListProps
    {
        /// <summary>items is the list of StorageClasses.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClassList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeStorageClassProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeStorageClassProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClassList#metadata
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
