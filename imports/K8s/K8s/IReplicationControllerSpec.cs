using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ReplicationControllerSpec is the specification of a replication controller.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IReplicationControllerSpec), fullyQualifiedName: "k8s.ReplicationControllerSpec")]
    public interface IReplicationControllerSpec
    {
        /// <summary>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available.</summary>
        /// <remarks>
        /// Defaults to 0 (pod will be considered available as soon as it is ready)
        ///
        /// <strong>Default</strong>: 0 (pod will be considered available as soon as it is ready)
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerSpec#minReadySeconds
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

        /// <summary>Replicas is the number of desired replicas.</summary>
        /// <remarks>
        /// This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#what-is-a-replicationcontroller
        ///
        /// <strong>Default</strong>: 1. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#what-is-a-replicationcontroller
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerSpec#replicas
        /// </remarks>
        [JsiiProperty(name: "replicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Replicas
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selector is a label query over pods that should match the Replicas count.</summary>
        /// <remarks>
        /// If Selector is empty, it is defaulted to the labels present on the Pod template. Label keys and values that must match in order to be controlled by this replication controller, if empty defaulted to labels on Pod template. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerSpec#selector
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Selector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Template is the object that describes the pod that will be created if insufficient replicas are detected.</summary>
        /// <remarks>
        /// This takes precedence over a TemplateRef. The only allowed template.spec.restartPolicy value is "Always". More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerSpec#template
        /// </remarks>
        [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"k8s.PodTemplateSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPodTemplateSpec? Template
        {
            get
            {
                return null;
            }
        }

        /// <summary>ReplicationControllerSpec is the specification of a replication controller.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IReplicationControllerSpec), fullyQualifiedName: "k8s.ReplicationControllerSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.IReplicationControllerSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available.</summary>
            /// <remarks>
            /// Defaults to 0 (pod will be considered available as soon as it is ready)
            ///
            /// <strong>Default</strong>: 0 (pod will be considered available as soon as it is ready)
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerSpec#minReadySeconds
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minReadySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinReadySeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Replicas is the number of desired replicas.</summary>
            /// <remarks>
            /// This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#what-is-a-replicationcontroller
            ///
            /// <strong>Default</strong>: 1. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#what-is-a-replicationcontroller
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerSpec#replicas
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Replicas
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Selector is a label query over pods that should match the Replicas count.</summary>
            /// <remarks>
            /// If Selector is empty, it is defaulted to the labels present on the Pod template. Label keys and values that must match in order to be controlled by this replication controller, if empty defaulted to labels on Pod template. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerSpec#selector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selector", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Selector
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Template is the object that describes the pod that will be created if insufficient replicas are detected.</summary>
            /// <remarks>
            /// This takes precedence over a TemplateRef. The only allowed template.spec.restartPolicy value is "Always". More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ReplicationControllerSpec#template
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"k8s.PodTemplateSpec\"}", isOptional: true)]
            public K8s.IPodTemplateSpec? Template
            {
                get => GetInstanceProperty<K8s.IPodTemplateSpec?>();
            }
        }
    }
}
