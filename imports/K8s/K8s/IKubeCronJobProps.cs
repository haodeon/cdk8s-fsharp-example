using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CronJob represents the configuration of a single cron job.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJob
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeCronJobProps), fullyQualifiedName: "k8s.KubeCronJobProps")]
    public interface IKubeCronJobProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJob#metadata
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

        /// <summary>Specification of the desired behavior of a cron job, including the schedule.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJob#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.CronJobSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ICronJobSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>CronJob represents the configuration of a single cron job.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJob
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeCronJobProps), fullyQualifiedName: "k8s.KubeCronJobProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeCronJobProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<K8s.IObjectMeta?>();
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
                get => GetInstanceProperty<K8s.ICronJobSpec?>();
            }
        }
    }
}
