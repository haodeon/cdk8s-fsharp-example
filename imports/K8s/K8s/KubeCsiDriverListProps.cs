using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>CSIDriverList is a collection of CSIDriver objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeCsiDriverListProps")]
    public class KubeCsiDriverListProps : K8s.IKubeCsiDriverListProps
    {
        /// <summary>items is the list of CSIDriver.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCsiDriverProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeCsiDriverProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverList#metadata
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
