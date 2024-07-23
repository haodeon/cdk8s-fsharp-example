using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PodDisruptionBudgetList is a collection of PodDisruptionBudgets.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudgetList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubePodDisruptionBudgetListProps")]
    public class KubePodDisruptionBudgetListProps : K8s.IKubePodDisruptionBudgetListProps
    {
        /// <summary>Items is a list of PodDisruptionBudgets.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.policy.v1.PodDisruptionBudgetList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePodDisruptionBudgetProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubePodDisruptionBudgetProps[] Items
        {
            get;
            set;
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
            get;
            set;
        }
    }
}
