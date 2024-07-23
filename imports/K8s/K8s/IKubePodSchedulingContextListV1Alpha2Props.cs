using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodSchedulingContextList is a collection of Pod scheduling objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubePodSchedulingContextListV1Alpha2Props), fullyQualifiedName: "k8s.KubePodSchedulingContextListV1Alpha2Props")]
    public interface IKubePodSchedulingContextListV1Alpha2Props
    {
        /// <summary>Items is the list of PodSchedulingContext objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePodSchedulingContextV1Alpha2Props\"},\"kind\":\"array\"}}")]
        K8s.IKubePodSchedulingContextV1Alpha2Props[] Items
        {
            get;
        }

        /// <summary>Standard list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextList#metadata
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

        /// <summary>PodSchedulingContextList is a collection of Pod scheduling objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubePodSchedulingContextListV1Alpha2Props), fullyQualifiedName: "k8s.KubePodSchedulingContextListV1Alpha2Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubePodSchedulingContextListV1Alpha2Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is the list of PodSchedulingContext objects.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePodSchedulingContextV1Alpha2Props\"},\"kind\":\"array\"}}")]
            public K8s.IKubePodSchedulingContextV1Alpha2Props[] Items
            {
                get => GetInstanceProperty<K8s.IKubePodSchedulingContextV1Alpha2Props[]>()!;
            }

            /// <summary>Standard list metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextList#metadata
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
