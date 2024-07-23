using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>CertificateSigningRequestList is a collection of CertificateSigningRequest objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestList
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeCertificateSigningRequestListProps")]
    public class KubeCertificateSigningRequestListProps : K8s.IKubeCertificateSigningRequestListProps
    {
        /// <summary>items is a collection of CertificateSigningRequest objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCertificateSigningRequestProps\"},\"kind\":\"array\"}}")]
        public K8s.IKubeCertificateSigningRequestProps[] Items
        {
            get;
            set;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestList#metadata
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
