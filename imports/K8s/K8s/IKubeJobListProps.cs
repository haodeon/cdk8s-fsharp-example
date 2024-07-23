using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>JobList is a collection of jobs.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeJobListProps), fullyQualifiedName: "k8s.KubeJobListProps")]
    public interface IKubeJobListProps
    {
        /// <summary>items is the list of Jobs.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeJobProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeJobProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobList#metadata
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

        /// <summary>JobList is a collection of jobs.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeJobListProps), fullyQualifiedName: "k8s.KubeJobListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeJobListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is the list of Jobs.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeJobProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeJobProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeJobProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.JobList#metadata
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
