using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ClusterTrustBundle is a cluster-scoped container for X.509 trust anchors (root certificates).</summary>
    /// <remarks>
    /// ClusterTrustBundle objects are considered to be readable by any authenticated user in the cluster, because they can be mounted by pods using the <c>clusterTrustBundle</c> projection.  All service accounts have read access to ClusterTrustBundles by default.  Users who only have namespace-level access to a cluster can read ClusterTrustBundles by impersonating a serviceaccount that they have access to.
    ///
    /// It can be optionally associated with a particular assigner, in which case it contains one valid set of trust anchors for that signer. Signers may have multiple associated ClusterTrustBundles; each is an independent set of trust anchors for that signer. Admission control is used to enforce that only users with permissions on the signer can create or modify the corresponding bundle.
    ///
    /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundle
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeClusterTrustBundleV1Alpha1Props")]
    public class KubeClusterTrustBundleV1Alpha1Props : K8s.IKubeClusterTrustBundleV1Alpha1Props
    {
        /// <summary>spec contains the signer (if any) and trust anchors.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundle#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ClusterTrustBundleSpecV1Alpha1\"}")]
        public K8s.IClusterTrustBundleSpecV1Alpha1 Spec
        {
            get;
            set;
        }

        /// <summary>metadata contains the object metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundle#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }
    }
}
