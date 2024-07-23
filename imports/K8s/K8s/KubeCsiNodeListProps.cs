using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>CSINodeList is a collection of CSINode objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeCsiNodeListProps")]
    public class KubeCsiNodeListProps : K8s.IKubeCsiNodeListProps
    {
        /// <summary>items is the list of CSINode.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCsiNodeProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeCsiNodeProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeList#metadata
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
