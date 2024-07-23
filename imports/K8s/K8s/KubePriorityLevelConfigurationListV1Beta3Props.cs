using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PriorityLevelConfigurationList is a list of PriorityLevelConfiguration objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PriorityLevelConfigurationList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubePriorityLevelConfigurationListV1Beta3Props")]
    public class KubePriorityLevelConfigurationListV1Beta3Props : K8s.IKubePriorityLevelConfigurationListV1Beta3Props
    {
        /// <summary>`items` is a list of request-priorities.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PriorityLevelConfigurationList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePriorityLevelConfigurationV1Beta3Props\"},\"kind\":\"array\"}}")]
        public K8s.IKubePriorityLevelConfigurationV1Beta3Props[] Items
        {
            get;
            set;
        }

        /// <summary>`metadata` is the standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PriorityLevelConfigurationList#metadata
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
