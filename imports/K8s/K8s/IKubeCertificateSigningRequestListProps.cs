using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CertificateSigningRequestList is a collection of CertificateSigningRequest objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestList
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeCertificateSigningRequestListProps), fullyQualifiedName: "k8s.KubeCertificateSigningRequestListProps")]
    public interface IKubeCertificateSigningRequestListProps
    {
        /// <summary>items is a collection of CertificateSigningRequest objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestList#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCertificateSigningRequestProps\"},\"kind\":\"array\"}}")]
        K8s.IKubeCertificateSigningRequestProps[] Items
        {
            get;
        }

        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestList#metadata
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

        /// <summary>CertificateSigningRequestList is a collection of CertificateSigningRequest objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestList
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeCertificateSigningRequestListProps), fullyQualifiedName: "k8s.KubeCertificateSigningRequestListProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeCertificateSigningRequestListProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>items is a collection of CertificateSigningRequest objects.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestList#items
            /// </remarks>
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubeCertificateSigningRequestProps\"},\"kind\":\"array\"}}")]
            public K8s.IKubeCertificateSigningRequestProps[] Items
            {
                get => GetInstanceProperty<K8s.IKubeCertificateSigningRequestProps[]>()!;
            }

            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestList#metadata
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
