using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>DaemonSetList is a collection of daemon sets.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeDaemonSetListProps")]
    public class KubeDaemonSetListProps : K8s.IKubeDaemonSetListProps
    {
        /// <summary>A list of daemon sets.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeDaemonSetProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeDaemonSetProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetList#metadata
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
