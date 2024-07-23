using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>LeaseList is a list of Lease objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.coordination.v1.LeaseList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeLeaseListProps")]
    public class KubeLeaseListProps : K8s.IKubeLeaseListProps
    {
        /// <summary>items is a list of schema objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.coordination.v1.LeaseList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeLeaseProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeLeaseProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.coordination.v1.LeaseList#metadata
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
