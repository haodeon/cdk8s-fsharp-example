using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>JobTemplateSpec describes the data a Job should have when created from a template.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobTemplateSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IJobTemplateSpec), fullyQualifiedName: "k8s.JobTemplateSpec")]
    public interface IJobTemplateSpec
    {
        /// <summary>Standard object's metadata of the jobs created from this template.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobTemplateSpec#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specification of the desired behavior of the job.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobTemplateSpec#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.JobSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IJobSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>JobTemplateSpec describes the data a Job should have when created from a template.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobTemplateSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IJobTemplateSpec), fullyQualifiedName: "k8s.JobTemplateSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.IJobTemplateSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<K8s.IObjectMeta?>();
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
                get => GetInstanceProperty<K8s.IJobSpec?>();
            }
        }
    }
}
