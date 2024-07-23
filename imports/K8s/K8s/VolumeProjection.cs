using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Projection that may be projected along with other supported volume types.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeProjection
    /// </remarks>
    [JsiiByValue(fqn: "k8s.VolumeProjection")]
    public class VolumeProjection : K8s.IVolumeProjection
    {
        /// <summary>ClusterTrustBundle allows a pod to access the `.spec.trustBundle` field of ClusterTrustBundle objects in an auto-updating file.</summary>
        /// <remarks>
        /// Alpha, gated by the ClusterTrustBundleProjection feature gate.
        ///
        /// ClusterTrustBundle objects can either be selected by name, or by the combination of signer name and a label selector.
        ///
        /// Kubelet performs aggressive normalization of the PEM contents written into the pod filesystem.  Esoteric PEM features such as inter-block comments and block headers are stripped.  Certificates are deduplicated. The ordering of certificates within the file is arbitrary, and Kubelet may change the order over time.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeProjection#clusterTrustBundle
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "clusterTrustBundle", typeJson: "{\"fqn\":\"k8s.ClusterTrustBundleProjection\"}", isOptional: true)]
        public K8s.IClusterTrustBundleProjection? ClusterTrustBundle
        {
            get;
            set;
        }

        /// <summary>configMap information about the configMap data to project.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeProjection#configMap
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configMap", typeJson: "{\"fqn\":\"k8s.ConfigMapProjection\"}", isOptional: true)]
        public K8s.IConfigMapProjection? ConfigMap
        {
            get;
            set;
        }

        /// <summary>downwardAPI information about the downwardAPI data to project.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeProjection#downwardAPI
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "downwardApi", typeJson: "{\"fqn\":\"k8s.DownwardApiProjection\"}", isOptional: true)]
        public K8s.IDownwardApiProjection? DownwardApi
        {
            get;
            set;
        }

        /// <summary>secret information about the secret data to project.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeProjection#secret
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"k8s.SecretProjection\"}", isOptional: true)]
        public K8s.ISecretProjection? Secret
        {
            get;
            set;
        }

        /// <summary>serviceAccountToken is information about the serviceAccountToken data to project.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeProjection#serviceAccountToken
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "serviceAccountToken", typeJson: "{\"fqn\":\"k8s.ServiceAccountTokenProjection\"}", isOptional: true)]
        public K8s.IServiceAccountTokenProjection? ServiceAccountToken
        {
            get;
            set;
        }
    }
}
