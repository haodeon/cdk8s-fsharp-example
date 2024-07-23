using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CronJobList is a collection of cron jobs.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeCronJobListProps), fullyQualifiedName: "k8s.KubeCronJobListProps")]
    public interface IKubeCronJobListProps
    {
        /// <summary>items is the list of CronJobs.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCronJobProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeCronJobProps[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobList#metadata
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

        /// <summary>CronJobList is a collection of cron jobs.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeCronJobListProps), fullyQualifiedName: "k8s.KubeCronJobListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeCronJobListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is the list of CronJobs.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCronJobProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeCronJobProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeCronJobProps[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.CronJobList#metadata
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
