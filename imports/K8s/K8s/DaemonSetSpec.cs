using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>DaemonSetSpec is the specification of a daemon set.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.DaemonSetSpec")]
    public class DaemonSetSpec : K8s.IDaemonSetSpec
    {
        /// <summary>A label query over pods that are managed by the daemon set.</summary>
        /// <remarks>
        /// Must match in order to be controlled. It must match the pod template's labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetSpec#selector
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}")]
        public K8s.ILabelSelector Selector
        {
            get;
            set;
        }

        /// <summary>An object that describes the pod that will be created.</summary>
        /// <remarks>
        /// The DaemonSet will create exactly one copy of this pod on every node that matches the template's node selector (or on every node if no node selector is specified). The only allowed template.spec.restartPolicy value is "Always". More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetSpec#template
        /// </remarks>
        [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"k8s.PodTemplateSpec\"}")]
        public K8s.IPodTemplateSpec Template
        {
            get;
            set;
        }

        /// <summary>The minimum number of seconds for which a newly created DaemonSet pod should be ready without any of its container crashing, for it to be considered available.</summary>
        /// <remarks>
        /// Defaults to 0 (pod will be considered available as soon as it is ready).
        ///
        /// <strong>Default</strong>: 0 (pod will be considered available as soon as it is ready).
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetSpec#minReadySeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minReadySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinReadySeconds
        {
            get;
            set;
        }

        /// <summary>The number of old history to retain to allow rollback.</summary>
        /// <remarks>
        /// This is a pointer to distinguish between explicit zero and not specified. Defaults to 10.
        ///
        /// <strong>Default</strong>: 10.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetSpec#revisionHistoryLimit
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "revisionHistoryLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RevisionHistoryLimit
        {
            get;
            set;
        }

        /// <summary>An update strategy to replace existing DaemonSet pods with new pods.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetSpec#updateStrategy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "updateStrategy", typeJson: "{\"fqn\":\"k8s.DaemonSetUpdateStrategy\"}", isOptional: true)]
        public K8s.IDaemonSetUpdateStrategy? UpdateStrategy
        {
            get;
            set;
        }
    }
}
