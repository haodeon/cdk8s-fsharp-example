using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ConfigMapList is a resource containing a list of ConfigMap objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeConfigMapListProps")]
    public class KubeConfigMapListProps : K8s.IKubeConfigMapListProps
    {
        /// <summary>Items is the list of ConfigMaps.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeConfigMapProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeConfigMapProps[] Items
        {
            get;
            set;
        }

        /// <summary>More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapList#metadata
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
