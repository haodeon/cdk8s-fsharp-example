using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodDisruptionBudgetList is a collection of PodDisruptionBudgets.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudgetList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubePodDisruptionBudgetListProps), fullyQualifiedName: "k8s.KubePodDisruptionBudgetListProps")]
    public interface IKubePodDisruptionBudgetListProps
    {
        /// <summary>Items is a list of PodDisruptionBudgets.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudgetList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePodDisruptionBudgetProps\"},\"kind\":\"array\"}}")]
        K8s.IKubePodDisruptionBudgetProps[] Items
        {
            get;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudgetList#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IListMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>PodDisruptionBudgetList is a collection of PodDisruptionBudgets.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudgetList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubePodDisruptionBudgetListProps), fullyQualifiedName: "k8s.KubePodDisruptionBudgetListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubePodDisruptionBudgetListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is a list of PodDisruptionBudgets.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudgetList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePodDisruptionBudgetProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubePodDisruptionBudgetProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubePodDisruptionBudgetProps[]>()!;
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudgetList#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ListMeta\"}", isOptional: true)]
            public K8s.IListMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IListMeta?>();
            }
        }
    }
}
