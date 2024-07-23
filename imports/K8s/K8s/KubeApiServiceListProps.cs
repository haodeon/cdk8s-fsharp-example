using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>APIServiceList is a list of APIService objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeApiServiceListProps")]
    public class KubeApiServiceListProps : K8s.IKubeApiServiceListProps
    {
        /// <summary>Items is the list of APIService.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeApiServiceProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeApiServiceProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceList#metadata
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
