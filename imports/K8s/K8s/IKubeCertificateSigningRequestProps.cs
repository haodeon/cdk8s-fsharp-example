using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
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
    [JsiiInterface(nativeType: typeof(IKubeCertificateSigningRequestProps), fullyQualifiedName: "k8s.KubeCertificateSigningRequestProps")]
    public interface IKubeCertificateSigningRequestProps
    {
        /// <summary>spec contains the certificate request, and is immutable after creation.</summary>
        /// <remarks>
        /// Only the request, signerName, expirationSeconds, and usages fields can be set on creation. Other fields are derived by Kubernetes and cannot be modified by users.
        ///
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequest#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.CertificateSigningRequestSpec\"}")]
        K8s.ICertificateSigningRequestSpec Spec
        {
            get;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequest#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

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
        [JsiiTypeProxy(nativeType: typeof(IKubeCertificateSigningRequestProps), fullyQualifiedName: "k8s.KubeCertificateSigningRequestProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeCertificateSigningRequestProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>spec contains the certificate request, and is immutable after creation.</summary>
            /// <remarks>
            /// Only the request, signerName, expirationSeconds, and usages fields can be set on creation. Other fields are derived by Kubernetes and cannot be modified by users.
            ///
            /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequest#spec
            /// </remarks>
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.CertificateSigningRequestSpec\"}")]
            public K8s.ICertificateSigningRequestSpec Spec
            {
                get => GetInstanceProperty<K8s.ICertificateSigningRequestSpec>()!;
            }

            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequest#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }
        }
    }
}
