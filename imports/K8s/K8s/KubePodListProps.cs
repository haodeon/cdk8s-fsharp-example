using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PodList is a list of Pods.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PodList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubePodListProps")]
    public class KubePodListProps : K8s.IKubePodListProps
    {
        /// <summary>List of pods.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePodProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubePodProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodList#metadata
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
