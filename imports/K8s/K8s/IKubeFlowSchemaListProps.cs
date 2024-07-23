using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>FlowSchemaList is a list of FlowSchema objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.FlowSchemaList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeFlowSchemaListProps), fullyQualifiedName: "k8s.KubeFlowSchemaListProps")]
    public interface IKubeFlowSchemaListProps
    {
        /// <summary>`items` is a list of FlowSchemas.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.FlowSchemaList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeFlowSchemaProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeFlowSchemaProps[] Items
        {
            get;
        }

        /// <summary>`metadata` is the standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.FlowSchemaList#metadata
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

        /// <summary>FlowSchemaList is a list of FlowSchema objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.FlowSchemaList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeFlowSchemaListProps), fullyQualifiedName: "k8s.KubeFlowSchemaListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeFlowSchemaListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`items` is a list of FlowSchemas.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.FlowSchemaList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeFlowSchemaProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeFlowSchemaProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeFlowSchemaProps[]>()!;
            }

            /// <summary>`metadata` is the standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.FlowSchemaList#metadata
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
