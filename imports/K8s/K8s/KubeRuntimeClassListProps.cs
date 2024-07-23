using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>RuntimeClassList is a list of RuntimeClass objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.node.v1.RuntimeClassList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeRuntimeClassListProps")]
    public class KubeRuntimeClassListProps : K8s.IKubeRuntimeClassListProps
    {
        /// <summary>items is a list of schema objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.node.v1.RuntimeClassList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeRuntimeClassProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeRuntimeClassProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.node.v1.RuntimeClassList#metadata
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
