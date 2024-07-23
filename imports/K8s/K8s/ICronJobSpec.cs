using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CronJobSpec describes how the job execution will look like and when it will actually run.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ICronJobSpec), fullyQualifiedName: "k8s.CronJobSpec")]
    public interface ICronJobSpec
    {
        /// <summary>Specifies the job that will be created when executing a CronJob.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec#jobTemplate
        /// </remarks>
        [JsiiProperty(name: "jobTemplate", typeJson: "{\"fqn\":\"k8s.JobTemplateSpec\"}")]
        K8s.IJobTemplateSpec JobTemplate
        {
            get;
        }

        /// <summary>The schedule in Cron format, see https://en.wikipedia.org/wiki/Cron.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec#schedule
        /// </remarks>
        [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
        string Schedule
        {
            get;
        }

        /// <summary>Specifies how to treat concurrent executions of a Job. Valid values are:.</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description>"Allow" (default): allows CronJobs to run concurrently; - "Forbid": forbids concurrent runs, skipping next run if previous run hasn't finished yet; - "Replace": cancels currently running job and replaces it with a new one</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec#concurrencyPolicy
        /// </remarks>
        [JsiiProperty(name: "concurrencyPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ConcurrencyPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of failed finished jobs to retain.</summary>
        /// <remarks>
        /// Value must be non-negative integer. Defaults to 1.
        ///
        /// <strong>Default</strong>: 1.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec#failedJobsHistoryLimit
        /// </remarks>
        [JsiiProperty(name: "failedJobsHistoryLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? FailedJobsHistoryLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Optional deadline in seconds for starting the job if it misses scheduled time for any reason.</summary>
        /// <remarks>
        /// Missed jobs executions will be counted as failed ones.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec#startingDeadlineSeconds
        /// </remarks>
        [JsiiProperty(name: "startingDeadlineSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? StartingDeadlineSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of successful finished jobs to retain.</summary>
        /// <remarks>
        /// Value must be non-negative integer. Defaults to 3.
        ///
        /// <strong>Default</strong>: 3.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec#successfulJobsHistoryLimit
        /// </remarks>
        [JsiiProperty(name: "successfulJobsHistoryLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SuccessfulJobsHistoryLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>This flag tells the controller to suspend subsequent executions, it does not apply to already started executions.</summary>
        /// <remarks>
        /// Defaults to false.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec#suspend
        /// </remarks>
        [JsiiProperty(name: "suspend", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Suspend
        {
            get
            {
                return null;
            }
        }

        /// <summary>The time zone name for the given schedule, see https://en.wikipedia.org/wiki/List_of_tz_database_time_zones. If not specified, this will default to the time zone of the kube-controller-manager process. The set of valid time zone names and the time zone offset is loaded from the system-wide time zone database by the API server during CronJob validation and the controller manager during execution. If no system-wide time zone database can be found a bundled version of the database is used instead. If the time zone name becomes invalid during the lifetime of a CronJob or due to a change in host configuration, the controller will stop creating new new Jobs and will create a system event with the reason UnknownTimeZone. More information can be found in https://kubernetes.io/docs/concepts/workloads/controllers/cron-jobs/#time-zones.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec#timeZone
        /// </remarks>
        [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? TimeZone
        {
            get
            {
                return null;
            }
        }

        /// <summary>CronJobSpec describes how the job execution will look like and when it will actually run.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ICronJobSpec), fullyQualifiedName: "k8s.CronJobSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.ICronJobSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the job that will be created when executing a CronJob.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec#jobTemplate
            /// </remarks>
            [JsiiProperty(name: "jobTemplate", typeJson: "{\"fqn\":\"k8s.JobTemplateSpec\"}")]
            public K8s.IJobTemplateSpec JobTemplate
            {
                get => GetInstanceProperty<K8s.IJobTemplateSpec>()!;
            }

            /// <summary>The schedule in Cron format, see https://en.wikipedia.org/wiki/Cron.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec#schedule
            /// </remarks>
            [JsiiProperty(name: "schedule", typeJson: "{\"primitive\":\"string\"}")]
            public string Schedule
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies how to treat concurrent executions of a Job. Valid values are:.</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description>"Allow" (default): allows CronJobs to run concurrently; - "Forbid": forbids concurrent runs, skipping next run if previous run hasn't finished yet; - "Replace": cancels currently running job and replaces it with a new one</description>
            /// </list>
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec#concurrencyPolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "concurrencyPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ConcurrencyPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The number of failed finished jobs to retain.</summary>
            /// <remarks>
            /// Value must be non-negative integer. Defaults to 1.
            ///
            /// <strong>Default</strong>: 1.
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec#failedJobsHistoryLimit
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failedJobsHistoryLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? FailedJobsHistoryLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Optional deadline in seconds for starting the job if it misses scheduled time for any reason.</summary>
            /// <remarks>
            /// Missed jobs executions will be counted as failed ones.
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec#startingDeadlineSeconds
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "startingDeadlineSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? StartingDeadlineSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>The number of successful finished jobs to retain.</summary>
            /// <remarks>
            /// Value must be non-negative integer. Defaults to 3.
            ///
            /// <strong>Default</strong>: 3.
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec#successfulJobsHistoryLimit
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "successfulJobsHistoryLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SuccessfulJobsHistoryLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>This flag tells the controller to suspend subsequent executions, it does not apply to already started executions.</summary>
            /// <remarks>
            /// Defaults to false.
            ///
            /// <strong>Default</strong>: false.
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec#suspend
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "suspend", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Suspend
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>The time zone name for the given schedule, see https://en.wikipedia.org/wiki/List_of_tz_database_time_zones. If not specified, this will default to the time zone of the kube-controller-manager process. The set of valid time zone names and the time zone offset is loaded from the system-wide time zone database by the API server during CronJob validation and the controller manager during execution. If no system-wide time zone database can be found a bundled version of the database is used instead. If the time zone name becomes invalid during the lifetime of a CronJob or due to a change in host configuration, the controller will stop creating new new Jobs and will create a system event with the reason UnknownTimeZone. More information can be found in https://kubernetes.io/docs/concepts/workloads/controllers/cron-jobs/#time-zones.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobSpec#timeZone
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeZone", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? TimeZone
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
