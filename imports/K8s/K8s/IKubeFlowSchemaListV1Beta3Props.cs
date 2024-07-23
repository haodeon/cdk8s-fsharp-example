using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>FlowSchemaList is a list of FlowSchema objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.FlowSchemaList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeFlowSchemaListV1Beta3Props), fullyQualifiedName: "k8s.KubeFlowSchemaListV1Beta3Props")]
    public interface IKubeFlowSchemaListV1Beta3Props
    {
        /// <summary>`items` is a list of FlowSchemas.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.FlowSchemaList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeFlowSchemaV1Beta3Props\"},\"kind\":\"array\"}}")]
        K8s.IKubeFlowSchemaV1Beta3Props[] Items
        {
            get;
        }

        /// <summary>`metadata` is the standard list metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.FlowSchemaList#metadata
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
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.FlowSchemaList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeFlowSchemaListV1Beta3Props), fullyQualifiedName: "k8s.KubeFlowSchemaListV1Beta3Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeFlowSchemaListV1Beta3Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`items` is a list of FlowSchemas.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.FlowSchemaList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeFlowSchemaV1Beta3Props\"},\"kind\":\"array\"}}")]
            public K8s.IKubeFlowSchemaV1Beta3Props[] Items
            {
                get => GetInstanceProperty<K8s.IKubeFlowSchemaV1Beta3Props[]>()!;
            }

            /// <summary>`metadata` is the standard list metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.FlowSchemaList#metadata
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
