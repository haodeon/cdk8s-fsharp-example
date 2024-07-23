using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>EventList is a list of Event objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.events.v1.EventList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeEventListProps")]
    public class KubeEventListProps : K8s.IKubeEventListProps
    {
        /// <summary>items is a list of schema objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.EventList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeEventProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeEventProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.EventList#metadata
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
