using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PriorityClassList is a collection of priority classes.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClassList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubePriorityClassListProps")]
    public class KubePriorityClassListProps : K8s.IKubePriorityClassListProps
    {
        /// <summary>items is the list of PriorityClasses.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClassList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePriorityClassProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubePriorityClassProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClassList#metadata
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
