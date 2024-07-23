using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Status of all the conditions for the component as a list of ComponentStatus objects.</summary>
    /// <remarks>
    /// Deprecated: This API is deprecated in v1.19+
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatusList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeComponentStatusListProps")]
    public class KubeComponentStatusListProps : K8s.IKubeComponentStatusListProps
    {
        /// <summary>List of ComponentStatus objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatusList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeComponentStatusProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeComponentStatusProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatusList#metadata
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
