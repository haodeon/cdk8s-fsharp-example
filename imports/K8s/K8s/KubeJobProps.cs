using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Job represents the configuration of a single job.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.Job
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeJobProps")]
    public class KubeJobProps : K8s.IKubeJobProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.Job#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Specification of the desired behavior of a job.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.Job#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.JobSpec\"}", isOptional: true)]
        public K8s.IJobSpec? Spec
        {
            get;
            set;
        }
    }
}
