using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ServiceAccountList is a list of ServiceAccount objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeServiceAccountListProps")]
    public class KubeServiceAccountListProps : K8s.IKubeServiceAccountListProps
    {
        /// <summary>List of ServiceAccounts.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/tasks/configure-pod-container/configure-service-account/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeServiceAccountProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeServiceAccountProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ServiceAccountList#metadata
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
