using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ReplicaSetSpec is the specification of a ReplicaSet.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IReplicaSetSpec), fullyQualifiedName: "k8s.ReplicaSetSpec")]
    public interface IReplicaSetSpec
    {
        /// <summary>Selector is a label query over pods that should match the replica count.</summary>
        /// <remarks>
        /// Label keys and values that must match in order to be controlled by this replica set. It must match the pod template's labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetSpec#selector
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}")]
        K8s.ILabelSelector Selector
        {
            get;
        }

        /// <summary>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available.</summary>
        /// <remarks>
        /// Defaults to 0 (pod will be considered available as soon as it is ready)
        ///
        /// <strong>Default</strong>: 0 (pod will be considered available as soon as it is ready)
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetSpec#minReadySeconds
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
        /// This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller
        ///
        /// <strong>Default</strong>: 1. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetSpec#replicas
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

        /// <summary>Template is the object that describes the pod that will be created if insufficient replicas are detected.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetSpec#template
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

        /// <summary>ReplicaSetSpec is the specification of a ReplicaSet.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IReplicaSetSpec), fullyQualifiedName: "k8s.ReplicaSetSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.IReplicaSetSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Selector is a label query over pods that should match the replica count.</summary>
            /// <remarks>
            /// Label keys and values that must match in order to be controlled by this replica set. It must match the pod template's labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetSpec#selector
            /// </remarks>
            [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}")]
            public K8s.ILabelSelector Selector
            {
                get => GetInstanceProperty<K8s.ILabelSelector>()!;
            }

            /// <summary>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing, for it to be considered available.</summary>
            /// <remarks>
            /// Defaults to 0 (pod will be considered available as soon as it is ready)
            ///
            /// <strong>Default</strong>: 0 (pod will be considered available as soon as it is ready)
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetSpec#minReadySeconds
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "minReadySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? MinReadySeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Replicas is the number of desired replicas.</summary>
            /// <remarks>
            /// This is a pointer to distinguish between explicit zero and unspecified. Defaults to 1. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller
            ///
            /// <strong>Default</strong>: 1. More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller/#what-is-a-replicationcontroller
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetSpec#replicas
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "replicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Replicas
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Template is the object that describes the pod that will be created if insufficient replicas are detected.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/workloads/controllers/replicationcontroller#pod-template
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.ReplicaSetSpec#template
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