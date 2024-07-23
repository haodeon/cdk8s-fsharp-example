using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>SecretList is a list of Secret.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeSecretListProps")]
    public class KubeSecretListProps : K8s.IKubeSecretListProps
    {
        /// <summary>Items is a list of secret objects.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/configuration/secret
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeSecretProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeSecretProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretList#metadata
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
