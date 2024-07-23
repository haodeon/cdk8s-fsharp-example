using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ServiceCIDRList contains a list of ServiceCIDR objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ServiceCIDRList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeServiceCidrListV1Alpha1Props), fullyQualifiedName: "k8s.KubeServiceCidrListV1Alpha1Props")]
    public interface IKubeServiceCidrListV1Alpha1Props
    {
        /// <summary>items is the list of ServiceCIDRs.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ServiceCIDRList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeServiceCidrv1Alpha1Props\"},\"kind\":\"array\"}}")]
        K8s.IKubeServiceCidrv1Alpha1Props[] Items
        {
            get;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ServiceCIDRList#metadata
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

        /// <summary>ServiceCIDRList contains a list of ServiceCIDR objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ServiceCIDRList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeServiceCidrListV1Alpha1Props), fullyQualifiedName: "k8s.KubeServiceCidrListV1Alpha1Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeServiceCidrListV1Alpha1Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is the list of ServiceCIDRs.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ServiceCIDRList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeServiceCidrv1Alpha1Props\"},\"kind\":\"array\"}}")]
            public K8s.IKubeServiceCidrv1Alpha1Props[] Items
            {
                get => GetInstanceProperty<K8s.IKubeServiceCidrv1Alpha1Props[]>()!;
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ServiceCIDRList#metadata
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
