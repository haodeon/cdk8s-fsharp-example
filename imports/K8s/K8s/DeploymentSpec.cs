using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>DeploymentSpec is the specification of the desired behavior of the Deployment.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.DeploymentSpec")]
    public class DeploymentSpec : K8s.IDeploymentSpec
    {
        /// <summary>Label selector for pods.</summary>
        /// <remarks>
        /// Existing ReplicaSets whose pods are selected by this will be the ones affected by this deployment. It must match the pod template's labels.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentSpec#selector
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}")]
        public K8s.ILabelSelector Selector
        {
            get;
            set;
        }

        /// <summary>Template describes the pods that will be created.</summary>
        /// <remarks>
        /// The only allowed template.spec.restartPolicy value is "Always".
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentSpec#template
        /// </remarks>
        [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"k8s.PodTemplateSpec\"}")]
        public K8s.IPodTemplateSpec Template
        {
            get;
            set;
        }

        /// <summary>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available.</summary>
        /// <remarks>
        /// Defaults to 0 (pod will be considered available as soon as it is ready)
        ///
        /// <strong>Default</strong>: 0 (pod will be considered available as soon as it is ready)
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentSpec#minReadySeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minReadySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinReadySeconds
        {
            get;
            set;
        }

        /// <summary>Indicates that the deployment is paused.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentSpec#paused
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paused", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? Paused
        {
            get;
            set;
        }

        /// <summary>The maximum time in seconds for a deployment to make progress before it is considered to be failed.</summary>
        /// <remarks>
        /// The deployment controller will continue to process failed deployments and a condition with a ProgressDeadlineExceeded reason will be surfaced in the deployment status. Note that progress will not be estimated during the time a deployment is paused. Defaults to 600s.
        ///
        /// <strong>Default</strong>: 600s.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentSpec#progressDeadlineSeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "progressDeadlineSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? ProgressDeadlineSeconds
        {
            get;
            set;
        }

        /// <summary>Number of desired pods.</summary>
        /// <remarks>
        /// This is a pointer to distinguish between explicit zero and not specified. Defaults to 1.
        ///
        /// <strong>Default</strong>: 1.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentSpec#replicas
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "replicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Replicas
        {
            get;
            set;
        }

        /// <summary>The number of old ReplicaSets to retain to allow rollback.</summary>
        /// <remarks>
        /// This is a pointer to distinguish between explicit zero and not specified. Defaults to 10.
        ///
        /// <strong>Default</strong>: 10.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentSpec#revisionHistoryLimit
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "revisionHistoryLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RevisionHistoryLimit
        {
            get;
            set;
        }

        /// <summary>The deployment strategy to use to replace existing pods with new ones.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DeploymentSpec#strategy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "strategy", typeJson: "{\"fqn\":\"k8s.DeploymentStrategy\"}", isOptional: true)]
        public K8s.IDeploymentStrategy? Strategy
        {
            get;
            set;
        }
    }
}
