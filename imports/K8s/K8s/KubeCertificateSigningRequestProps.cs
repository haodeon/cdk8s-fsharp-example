using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>CertificateSigningRequest objects provide a mechanism to obtain x509 certificates by submitting a certificate signing request, and having it asynchronously approved and issued.</summary>
    /// <remarks>
    /// Kubelets use this API to obtain:
    ///
    /// <list type="number">
    /// <description>client certificates to authenticate to kube-apiserver (with the "kubernetes.io/kube-apiserver-client-kubelet" signerName).</description>
    /// <description>serving certificates for TLS endpoints kube-apiserver can connect to securely (with the "kubernetes.io/kubelet-serving" signerName).</description>
    /// </list>
    ///
    /// This API can be used to request client certificates to authenticate to kube-apiserver (with the "kubernetes.io/kube-apiserver-client" signerName), or to obtain certificates from custom non-Kubernetes signers.
    ///
    /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequest
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeCertificateSigningRequestProps")]
    public class KubeCertificateSigningRequestProps : K8s.IKubeCertificateSigningRequestProps
    {
        /// <summary>spec contains the certificate request, and is immutable after creation.</summary>
        /// <remarks>
        /// Only the request, signerName, expirationSeconds, and usages fields can be set on creation. Other fields are derived by Kubernetes and cannot be modified by users.
        ///
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequest#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.CertificateSigningRequestSpec\"}")]
        public K8s.ICertificateSigningRequestSpec Spec
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequest#metadata
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
