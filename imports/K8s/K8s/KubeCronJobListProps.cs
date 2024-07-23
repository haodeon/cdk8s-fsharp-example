using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>CronJobList is a collection of cron jobs.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeCronJobListProps")]
    public class KubeCronJobListProps : K8s.IKubeCronJobListProps
    {
        /// <summary>items is the list of CronJobs.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCronJobProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeCronJobProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobList#metadata
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
