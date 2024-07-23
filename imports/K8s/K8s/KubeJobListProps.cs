using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>JobList is a collection of jobs.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeJobListProps")]
    public class KubeJobListProps : K8s.IKubeJobListProps
    {
        /// <summary>items is the list of Jobs.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeJobProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeJobProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobList#metadata
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
