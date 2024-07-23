using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>DaemonSetSpec is the specification of a daemon set.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IDaemonSetSpec), fullyQualifiedName: "k8s.DaemonSetSpec")]
    public interface IDaemonSetSpec
    {
        /// <summary>A label query over pods that are managed by the daemon set.</summary>
        /// <remarks>
        /// Must match in order to be controlled. It must match the pod template's labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetSpec#selector
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}")]
        K8s.ILabelSelector Selector
        {
            get;
        }

        /// <summary>An object that describes the pod that will be created.</summary>
        /// <remarks>
        /// The DaemonSet will create exactly one copy of this pod on every node that matches the template's node selector (or on every node if no node selector is specified). The only allowed template.spec.restartPolicy value is "Always". More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetSpec#template
        /// </remarks>
        [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"k8s.PodTemplateSpec\"}")]
        K8s.IPodTemplateSpec Template
        {
            get;
        }

        /// <summary>The minimum number of seconds for which a newly created DaemonSet pod should be ready without any of its container crashing, for it to be considered available.</summary>
        /// <remarks>
        /// Defaults to 0 (pod will be considered available as soon as it is ready).
        ///
        /// <strong>Default</strong>: 0 (pod will be considered available as soon as it is ready).
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetSpec#minReadySeconds
        /// </remarks>
        [JsiiProperty(name: "minReadySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? MinReadySeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>The number of old history to retain to allow rollback.</summary>
        /// <remarks>
        /// This is a pointer to distinguish between explicit zero and not specified. Defaults to 10.
        ///
        /// <strong>Default</strong>: 10.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetSpec#revisionHistoryLimit
        /// </remarks>
        [JsiiProperty(name: "revisionHistoryLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? RevisionHistoryLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>An update strategy to replace existing DaemonSet pods with new pods.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetSpec#updateStrategy
        /// </remarks>
        [JsiiProperty(name: "updateStrategy", typeJson: "{\"fqn\":\"k8s.DaemonSetUpdateStrategy\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IDaemonSetUpdateStrategy? UpdateStrategy
        {
            get
            {
                return null;
            }
        }

        /// <summary>DaemonSetSpec is the specification of a daemon set.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IDaemonSetSpec), fullyQualifiedName: "k8s.DaemonSetSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.IDaemonSetSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A label query over pods that are managed by the daemon set.</summary>
            /// <remarks>
            /// Must match in order to be controlled. It must match the pod template's labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetSpec#selector
            /// </remarks>
            [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}")]
            public K8s.ILabelSelector Selector
            {
                get => GetInstanceProperty<K8s.ILabelSelector>()!;
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
                get => GetInstanceProperty<K8s.IPodTemplateSpec>()!;
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
                get => GetInstanceProperty<double?>();
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
                get => GetInstanceProperty<double?>();
            }

            /// <summary>An update strategy to replace existing DaemonSet pods with new pods.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetSpec#updateStrategy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "updateStrategy", typeJson: "{\"fqn\":\"k8s.DaemonSetUpdateStrategy\"}", isOptional: true)]
            public K8s.IDaemonSetUpdateStrategy? UpdateStrategy
            {
                get => GetInstanceProperty<K8s.IDaemonSetUpdateStrategy?>();
            }
        }
    }
}
