using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>CSIStorageCapacityList is a collection of CSIStorageCapacity objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacityList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeCsiStorageCapacityListProps")]
    public class KubeCsiStorageCapacityListProps : K8s.IKubeCsiStorageCapacityListProps
    {
        /// <summary>items is the list of CSIStorageCapacity objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacityList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCsiStorageCapacityProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeCsiStorageCapacityProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacityList#metadata
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
