using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ServiceCIDRList contains a list of ServiceCIDR objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ServiceCIDRList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeServiceCidrListV1Alpha1Props")]
    public class KubeServiceCidrListV1Alpha1Props : K8s.IKubeServiceCidrListV1Alpha1Props
    {
        /// <summary>items is the list of ServiceCIDRs.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ServiceCIDRList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeServiceCidrv1Alpha1Props\"},\"kind\":\"array\"}}")]
        public K8s.IKubeServiceCidrv1Alpha1Props[] Items
        {
            get;
            set;
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
            get;
            set;
        }
    }
}
