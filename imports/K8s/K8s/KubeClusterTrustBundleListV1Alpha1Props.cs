using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ClusterTrustBundleList is a collection of ClusterTrustBundle objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundleList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeClusterTrustBundleListV1Alpha1Props")]
    public class KubeClusterTrustBundleListV1Alpha1Props : K8s.IKubeClusterTrustBundleListV1Alpha1Props
    {
        /// <summary>items is a collection of ClusterTrustBundle objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundleList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeClusterTrustBundleV1Alpha1Props\"},\"kind\":\"array\"}}")]
        public K8s.IKubeClusterTrustBundleV1Alpha1Props[] Items
        {
            get;
            set;
        }

        /// <summary>metadata contains the list metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundleList#metadata
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
