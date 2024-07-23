using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ServiceList holds a list of services.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeServiceListProps")]
    public class KubeServiceListProps : K8s.IKubeServiceListProps
    {
        /// <summary>List of services.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeServiceProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeServiceProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceList#metadata
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
