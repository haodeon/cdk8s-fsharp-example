using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>APIServiceList is a list of APIService objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeApiServiceListProps), fullyQualifiedName: "k8s.KubeApiServiceListProps")]
    public interface IKubeApiServiceListProps
    {
        /// <summary>Items is the list of APIService.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeApiServiceProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeApiServiceProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceList#metadata
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

        /// <summary>APIServiceList is a list of APIService objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeApiServiceListProps), fullyQualifiedName: "k8s.KubeApiServiceListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeApiServiceListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is the list of APIService.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeApiServiceProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeApiServiceProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeApiServiceProps[]>()!;
            }

            /// <summary>Standard list metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.kube-aggregator.pkg.apis.apiregistration.v1.APIServiceList#metadata
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
