using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>LimitRangeList is a list of LimitRange items.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeLimitRangeListProps")]
    public class KubeLimitRangeListProps : K8s.IKubeLimitRangeListProps
    {
        /// <summary>Items is a list of LimitRange objects.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeLimitRangeProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeLimitRangeProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeList#metadata
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
