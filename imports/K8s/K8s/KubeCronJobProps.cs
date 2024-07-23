using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CronJob represents the configuration of a single cron job.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJob
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeCronJobProps")]
    public class KubeCronJobProps : K8s.IKubeCronJobProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJob#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Specification of the desired behavior of a cron job, including the schedule.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJob#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.CronJobSpec\"}", isOptional: true)]
        public K8s.ICronJobSpec? Spec
        {
            get;
            set;
        }
    }
}
