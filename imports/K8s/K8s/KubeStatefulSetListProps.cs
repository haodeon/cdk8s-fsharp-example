using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>StatefulSetList is a collection of StatefulSets.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeStatefulSetListProps")]
    public class KubeStatefulSetListProps : K8s.IKubeStatefulSetListProps
    {
        /// <summary>Items is the list of stateful sets.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeStatefulSetProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeStatefulSetProps[] Items
        {
            get;
            set;
        }

        /// <summary>Standard list's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetList#metadata
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
