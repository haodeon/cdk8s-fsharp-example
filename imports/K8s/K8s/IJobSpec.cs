using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>JobSpec describes how the job execution will look like.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IJobSpec), fullyQualifiedName: "k8s.JobSpec")]
    public interface IJobSpec
    {
        /// <summary>Describes the pod that will be created when executing a job.</summary>
        /// <remarks>
        /// The only allowed template.spec.restartPolicy values are "Never" or "OnFailure". More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#template
        /// </remarks>
        [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"k8s.PodTemplateSpec\"}")]
        K8s.IPodTemplateSpec Template
        {
            get;
        }

        /// <summary>Specifies the duration in seconds relative to the startTime that the job may be continuously active before the system tries to terminate it;</summary>
        /// <remarks>
        /// value must be positive integer. If a Job is suspended (at creation or through an update), this timer will effectively be stopped and reset when the Job is resumed again.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#activeDeadlineSeconds
        /// </remarks>
        [JsiiProperty(name: "activeDeadlineSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ActiveDeadlineSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the number of retries before marking this job failed.</summary>
        /// <remarks>
        /// Defaults to 6
        ///
        /// <strong>Default</strong>: 6
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#backoffLimit
        /// </remarks>
        [JsiiProperty(name: "backoffLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackoffLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the limit for the number of retries within an index before marking this index as failed.</summary>
        /// <remarks>
        /// When enabled the number of failures per index is kept in the pod's batch.kubernetes.io/job-index-failure-count annotation. It can only be set when Job's completionMode=Indexed, and the Pod's restart policy is Never. The field is immutable. This field is beta-level. It can be used when the <c>JobBackoffLimitPerIndex</c> feature gate is enabled (enabled by default).
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#backoffLimitPerIndex
        /// </remarks>
        [JsiiProperty(name: "backoffLimitPerIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? BackoffLimitPerIndex
        {
            get
            {
                return null;
            }
        }

        /// <summary>completionMode specifies how Pod completions are tracked. It can be `NonIndexed` (default) or `Indexed`.</summary>
        /// <remarks>
        /// <c>NonIndexed</c> means that the Job is considered complete when there have been .spec.completions successfully completed Pods. Each Pod completion is homologous to each other.
        ///
        /// <c>Indexed</c> means that the Pods of a Job get an associated completion index from 0 to (.spec.completions - 1), available in the annotation batch.kubernetes.io/job-completion-index. The Job is considered complete when there is one successfully completed Pod for each index. When value is <c>Indexed</c>, .spec.completions must be specified and <c>.spec.parallelism</c> must be less than or equal to 10^5. In addition, The Pod name takes the form <c>$(job-name)-$(index)-$(random-string)</c>, the Pod hostname takes the form <c>$(job-name)-$(index)</c>.
        ///
        /// More completion modes can be added in the future. If the Job controller observes a mode that it doesn't recognize, which is possible during upgrades due to version skew, the controller skips updates for the Job.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#completionMode
        /// </remarks>
        [JsiiProperty(name: "completionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? CompletionMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the desired number of successfully finished pods the job should be run with.</summary>
        /// <remarks>
        /// Setting to null means that the success of any pod signals the success of all pods, and allows parallelism to have any positive value.  Setting to 1 means that parallelism is limited to 1 and the success of that pod signals the success of the job. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#completions
        /// </remarks>
        [JsiiProperty(name: "completions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Completions
        {
            get
            {
                return null;
            }
        }

        /// <summary>ManagedBy field indicates the controller that manages a Job.</summary>
        /// <remarks>
        /// The k8s Job controller reconciles jobs which don't have this field at all or the field value is the reserved string <c>kubernetes.io/job-controller</c>, but skips reconciling Jobs with a custom value for this field. The value must be a valid domain-prefixed path (e.g. acme.io/foo) - all characters before the first "/" must be a valid subdomain as defined by RFC 1123. All characters trailing the first "/" must be valid HTTP Path characters as defined by RFC 3986. The value cannot exceed 64 characters.
        ///
        /// This field is alpha-level. The job controller accepts setting the field when the feature gate JobManagedBy is enabled (disabled by default).
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#managedBy
        /// </remarks>
        [JsiiProperty(name: "managedBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ManagedBy
        {
            get
            {
                return null;
            }
        }

        /// <summary>manualSelector controls generation of pod labels and pod selectors.</summary>
        /// <remarks>
        /// Leave <c>manualSelector</c> unset unless you are certain what you are doing. When false or unset, the system pick labels unique to this job and appends those labels to the pod template.  When true, the user is responsible for picking unique labels and specifying the selector.  Failure to pick a unique label may cause this and other jobs to not function correctly.  However, You may see <c>manualSelector=true</c> in jobs that were created with the old <c>extensions/v1beta1</c> API. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/#specifying-your-own-pod-selector
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#manualSelector
        /// </remarks>
        [JsiiProperty(name: "manualSelector", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ManualSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the maximal number of failed indexes before marking the Job as failed, when backoffLimitPerIndex is set.</summary>
        /// <remarks>
        /// Once the number of failed indexes exceeds this number the entire Job is marked as Failed and its execution is terminated. When left as null the job continues execution of all of its indexes and is marked with the <c>Complete</c> Job condition. It can only be specified when backoffLimitPerIndex is set. It can be null or up to completions. It is required and must be less than or equal to 10^4 when is completions greater than 10^5. This field is beta-level. It can be used when the <c>JobBackoffLimitPerIndex</c> feature gate is enabled (enabled by default).
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#maxFailedIndexes
        /// </remarks>
        [JsiiProperty(name: "maxFailedIndexes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MaxFailedIndexes
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the maximum desired number of pods the job should run at any given time.</summary>
        /// <remarks>
        /// The actual number of pods running in steady state will be less than this number when ((.spec.completions - .status.successful) &lt; .spec.parallelism), i.e. when the work left to do is less than max parallelism. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#parallelism
        /// </remarks>
        [JsiiProperty(name: "parallelism", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Parallelism
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specifies the policy of handling failed pods.</summary>
        /// <remarks>
        /// In particular, it allows to specify the set of actions and conditions which need to be satisfied to take the associated action. If empty, the default behaviour applies - the counter of failed pods, represented by the jobs's .status.failed field, is incremented and it is checked against the backoffLimit. This field cannot be used in combination with restartPolicy=OnFailure.
        ///
        /// This field is beta-level. It can be used when the <c>JobPodFailurePolicy</c> feature gate is enabled (enabled by default).
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#podFailurePolicy
        /// </remarks>
        [JsiiProperty(name: "podFailurePolicy", typeJson: "{\"fqn\":\"k8s.PodFailurePolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPodFailurePolicy? PodFailurePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>podReplacementPolicy specifies when to create replacement Pods.</summary>
        /// <remarks>
        /// Possible values are: - TerminatingOrFailed means that we recreate pods
        /// when they are terminating (has a metadata.deletionTimestamp) or failed.
        ///
        /// <list type="bullet">
        /// <description>Failed means to wait until a previously created Pod is fully terminated (has phase
        /// Failed or Succeeded) before creating a replacement Pod.</description>
        /// </list>
        ///
        /// When using podFailurePolicy, Failed is the the only allowed value. TerminatingOrFailed and Failed are allowed values when podFailurePolicy is not in use. This is an beta field. To use this, enable the JobPodReplacementPolicy feature toggle. This is on by default.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#podReplacementPolicy
        /// </remarks>
        [JsiiProperty(name: "podReplacementPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PodReplacementPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>A label query over pods that should match the pod count.</summary>
        /// <remarks>
        /// Normally, the system sets this field for you. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#selector
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILabelSelector? Selector
        {
            get
            {
                return null;
            }
        }

        /// <summary>successPolicy specifies the policy when the Job can be declared as succeeded.</summary>
        /// <remarks>
        /// If empty, the default behavior applies - the Job is declared as succeeded only when the number of succeeded pods equals to the completions. When the field is specified, it must be immutable and works only for the Indexed Jobs. Once the Job meets the SuccessPolicy, the lingering pods are terminated.
        ///
        /// This field  is alpha-level. To use this field, you must enable the <c>JobSuccessPolicy</c> feature gate (disabled by default).
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#successPolicy
        /// </remarks>
        [JsiiProperty(name: "successPolicy", typeJson: "{\"fqn\":\"k8s.SuccessPolicy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISuccessPolicy? SuccessPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>suspend specifies whether the Job controller should create Pods or not.</summary>
        /// <remarks>
        /// If a Job is created with suspend set to true, no Pods are created by the Job controller. If a Job is suspended after creation (i.e. the flag goes from false to true), the Job controller will delete all active Pods associated with this Job. Users must design their workload to gracefully handle this. Suspending a Job will reset the StartTime field of the Job, effectively resetting the ActiveDeadlineSeconds timer too. Defaults to false.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#suspend
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

        /// <summary>ttlSecondsAfterFinished limits the lifetime of a Job that has finished execution (either Complete or Failed).</summary>
        /// <remarks>
        /// If this field is set, ttlSecondsAfterFinished after the Job finishes, it is eligible to be automatically deleted. When the Job is being deleted, its lifecycle guarantees (e.g. finalizers) will be honored. If this field is unset, the Job won't be automatically deleted. If this field is set to zero, the Job becomes eligible to be deleted immediately after it finishes.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#ttlSecondsAfterFinished
        /// </remarks>
        [JsiiProperty(name: "ttlSecondsAfterFinished", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TtlSecondsAfterFinished
        {
            get
            {
                return null;
            }
        }

        /// <summary>JobSpec describes how the job execution will look like.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IJobSpec), fullyQualifiedName: "k8s.JobSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.IJobSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Describes the pod that will be created when executing a job.</summary>
            /// <remarks>
            /// The only allowed template.spec.restartPolicy values are "Never" or "OnFailure". More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#template
            /// </remarks>
            [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"k8s.PodTemplateSpec\"}")]
            public K8s.IPodTemplateSpec Template
            {
                get => GetInstanceProperty<K8s.IPodTemplateSpec>()!;
            }

            /// <summary>Specifies the duration in seconds relative to the startTime that the job may be continuously active before the system tries to terminate it;</summary>
            /// <remarks>
            /// value must be positive integer. If a Job is suspended (at creation or through an update), this timer will effectively be stopped and reset when the Job is resumed again.
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#activeDeadlineSeconds
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "activeDeadlineSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ActiveDeadlineSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Specifies the number of retries before marking this job failed.</summary>
            /// <remarks>
            /// Defaults to 6
            ///
            /// <strong>Default</strong>: 6
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#backoffLimit
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backoffLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackoffLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Specifies the limit for the number of retries within an index before marking this index as failed.</summary>
            /// <remarks>
            /// When enabled the number of failures per index is kept in the pod's batch.kubernetes.io/job-index-failure-count annotation. It can only be set when Job's completionMode=Indexed, and the Pod's restart policy is Never. The field is immutable. This field is beta-level. It can be used when the <c>JobBackoffLimitPerIndex</c> feature gate is enabled (enabled by default).
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#backoffLimitPerIndex
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "backoffLimitPerIndex", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? BackoffLimitPerIndex
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>completionMode specifies how Pod completions are tracked. It can be `NonIndexed` (default) or `Indexed`.</summary>
            /// <remarks>
            /// <c>NonIndexed</c> means that the Job is considered complete when there have been .spec.completions successfully completed Pods. Each Pod completion is homologous to each other.
            ///
            /// <c>Indexed</c> means that the Pods of a Job get an associated completion index from 0 to (.spec.completions - 1), available in the annotation batch.kubernetes.io/job-completion-index. The Job is considered complete when there is one successfully completed Pod for each index. When value is <c>Indexed</c>, .spec.completions must be specified and <c>.spec.parallelism</c> must be less than or equal to 10^5. In addition, The Pod name takes the form <c>$(job-name)-$(index)-$(random-string)</c>, the Pod hostname takes the form <c>$(job-name)-$(index)</c>.
            ///
            /// More completion modes can be added in the future. If the Job controller observes a mode that it doesn't recognize, which is possible during upgrades due to version skew, the controller skips updates for the Job.
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#completionMode
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "completionMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? CompletionMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specifies the desired number of successfully finished pods the job should be run with.</summary>
            /// <remarks>
            /// Setting to null means that the success of any pod signals the success of all pods, and allows parallelism to have any positive value.  Setting to 1 means that parallelism is limited to 1 and the success of that pod signals the success of the job. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#completions
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "completions", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Completions
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>ManagedBy field indicates the controller that manages a Job.</summary>
            /// <remarks>
            /// The k8s Job controller reconciles jobs which don't have this field at all or the field value is the reserved string <c>kubernetes.io/job-controller</c>, but skips reconciling Jobs with a custom value for this field. The value must be a valid domain-prefixed path (e.g. acme.io/foo) - all characters before the first "/" must be a valid subdomain as defined by RFC 1123. All characters trailing the first "/" must be valid HTTP Path characters as defined by RFC 3986. The value cannot exceed 64 characters.
            ///
            /// This field is alpha-level. The job controller accepts setting the field when the feature gate JobManagedBy is enabled (disabled by default).
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#managedBy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedBy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ManagedBy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>manualSelector controls generation of pod labels and pod selectors.</summary>
            /// <remarks>
            /// Leave <c>manualSelector</c> unset unless you are certain what you are doing. When false or unset, the system pick labels unique to this job and appends those labels to the pod template.  When true, the user is responsible for picking unique labels and specifying the selector.  Failure to pick a unique label may cause this and other jobs to not function correctly.  However, You may see <c>manualSelector=true</c> in jobs that were created with the old <c>extensions/v1beta1</c> API. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/#specifying-your-own-pod-selector
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#manualSelector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "manualSelector", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ManualSelector
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>Specifies the maximal number of failed indexes before marking the Job as failed, when backoffLimitPerIndex is set.</summary>
            /// <remarks>
            /// Once the number of failed indexes exceeds this number the entire Job is marked as Failed and its execution is terminated. When left as null the job continues execution of all of its indexes and is marked with the <c>Complete</c> Job condition. It can only be specified when backoffLimitPerIndex is set. It can be null or up to completions. It is required and must be less than or equal to 10^4 when is completions greater than 10^5. This field is beta-level. It can be used when the <c>JobBackoffLimitPerIndex</c> feature gate is enabled (enabled by default).
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#maxFailedIndexes
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maxFailedIndexes", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MaxFailedIndexes
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Specifies the maximum desired number of pods the job should run at any given time.</summary>
            /// <remarks>
            /// The actual number of pods running in steady state will be less than this number when ((.spec.completions - .status.successful) &lt; .spec.parallelism), i.e. when the work left to do is less than max parallelism. More info: https://kubernetes.io/docs/concepts/workloads/controllers/jobs-run-to-completion/
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#parallelism
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parallelism", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Parallelism
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Specifies the policy of handling failed pods.</summary>
            /// <remarks>
            /// In particular, it allows to specify the set of actions and conditions which need to be satisfied to take the associated action. If empty, the default behaviour applies - the counter of failed pods, represented by the jobs's .status.failed field, is incremented and it is checked against the backoffLimit. This field cannot be used in combination with restartPolicy=OnFailure.
            ///
            /// This field is beta-level. It can be used when the <c>JobPodFailurePolicy</c> feature gate is enabled (enabled by default).
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#podFailurePolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "podFailurePolicy", typeJson: "{\"fqn\":\"k8s.PodFailurePolicy\"}", isOptional: true)]
            public K8s.IPodFailurePolicy? PodFailurePolicy
            {
                get => GetInstanceProperty<K8s.IPodFailurePolicy?>();
            }

            /// <summary>podReplacementPolicy specifies when to create replacement Pods.</summary>
            /// <remarks>
            /// Possible values are: - TerminatingOrFailed means that we recreate pods
            /// when they are terminating (has a metadata.deletionTimestamp) or failed.
            ///
            /// <list type="bullet">
            /// <description>Failed means to wait until a previously created Pod is fully terminated (has phase
            /// Failed or Succeeded) before creating a replacement Pod.</description>
            /// </list>
            ///
            /// When using podFailurePolicy, Failed is the the only allowed value. TerminatingOrFailed and Failed are allowed values when podFailurePolicy is not in use. This is an beta field. To use this, enable the JobPodReplacementPolicy feature toggle. This is on by default.
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#podReplacementPolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "podReplacementPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PodReplacementPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A label query over pods that should match the pod count.</summary>
            /// <remarks>
            /// Normally, the system sets this field for you. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#selector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
            public K8s.ILabelSelector? Selector
            {
                get => GetInstanceProperty<K8s.ILabelSelector?>();
            }

            /// <summary>successPolicy specifies the policy when the Job can be declared as succeeded.</summary>
            /// <remarks>
            /// If empty, the default behavior applies - the Job is declared as succeeded only when the number of succeeded pods equals to the completions. When the field is specified, it must be immutable and works only for the Indexed Jobs. Once the Job meets the SuccessPolicy, the lingering pods are terminated.
            ///
            /// This field  is alpha-level. To use this field, you must enable the <c>JobSuccessPolicy</c> feature gate (disabled by default).
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#successPolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "successPolicy", typeJson: "{\"fqn\":\"k8s.SuccessPolicy\"}", isOptional: true)]
            public K8s.ISuccessPolicy? SuccessPolicy
            {
                get => GetInstanceProperty<K8s.ISuccessPolicy?>();
            }

            /// <summary>suspend specifies whether the Job controller should create Pods or not.</summary>
            /// <remarks>
            /// If a Job is created with suspend set to true, no Pods are created by the Job controller. If a Job is suspended after creation (i.e. the flag goes from false to true), the Job controller will delete all active Pods associated with this Job. Users must design their workload to gracefully handle this. Suspending a Job will reset the StartTime field of the Job, effectively resetting the ActiveDeadlineSeconds timer too. Defaults to false.
            ///
            /// <strong>Default</strong>: false.
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#suspend
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "suspend", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Suspend
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>ttlSecondsAfterFinished limits the lifetime of a Job that has finished execution (either Complete or Failed).</summary>
            /// <remarks>
            /// If this field is set, ttlSecondsAfterFinished after the Job finishes, it is eligible to be automatically deleted. When the Job is being deleted, its lifecycle guarantees (e.g. finalizers) will be honored. If this field is unset, the Job won't be automatically deleted. If this field is set to zero, the Job becomes eligible to be deleted immediately after it finishes.
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobSpec#ttlSecondsAfterFinished
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ttlSecondsAfterFinished", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TtlSecondsAfterFinished
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
