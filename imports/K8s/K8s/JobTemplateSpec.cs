using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>JobTemplateSpec describes the data a Job should have when created from a template.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobTemplateSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.JobTemplateSpec")]
    public class JobTemplateSpec : K8s.IJobTemplateSpec
    {
        /// <summary>Standard object's metadata of the jobs created from this template.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobTemplateSpec#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>Specification of the desired behavior of the job.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobTemplateSpec#spec
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
