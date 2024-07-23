using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodDisruptionBudget is an object to define the max disruption that can be caused to a collection of pods.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudget
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubePodDisruptionBudgetProps), fullyQualifiedName: "k8s.KubePodDisruptionBudgetProps")]
    public interface IKubePodDisruptionBudgetProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudget#metadata
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

        /// <summary>Specification of the desired behavior of the PodDisruptionBudget.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudget#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.PodDisruptionBudgetSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPodDisruptionBudgetSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>PodDisruptionBudget is an object to define the max disruption that can be caused to a collection of pods.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudget
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubePodDisruptionBudgetProps), fullyQualifiedName: "k8s.KubePodDisruptionBudgetProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubePodDisruptionBudgetProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudget#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>Specification of the desired behavior of the PodDisruptionBudget.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudget#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.PodDisruptionBudgetSpec\"}", isOptional: true)]
            public K8s.IPodDisruptionBudgetSpec? Spec
            {
                get => GetInstanceProperty<K8s.IPodDisruptionBudgetSpec?>();
            }
        }
    }
}
