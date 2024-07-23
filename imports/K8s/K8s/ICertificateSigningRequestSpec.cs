using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CertificateSigningRequestSpec contains the certificate request.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ICertificateSigningRequestSpec), fullyQualifiedName: "k8s.CertificateSigningRequestSpec")]
    public interface ICertificateSigningRequestSpec
    {
        /// <summary>request contains an x509 certificate signing request encoded in a "CERTIFICATE REQUEST" PEM block.</summary>
        /// <remarks>
        /// When serialized as JSON or YAML, the data is additionally base64-encoded.
        ///
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec#request
        /// </remarks>
        [JsiiProperty(name: "request", typeJson: "{\"primitive\":\"string\"}")]
        string Request
        {
            get;
        }

        /// <summary>signerName indicates the requested signer, and is a qualified name.</summary>
        /// <remarks>
        /// List/watch requests for CertificateSigningRequests can filter on this field using a "spec.signerName=NAME" fieldSelector.
        ///
        /// Well-known Kubernetes signers are:
        ///
        /// <list type="number">
        /// <description>"kubernetes.io/kube-apiserver-client": issues client certificates that can be used to authenticate to kube-apiserver.
        /// Requests for this signer are never auto-approved by kube-controller-manager, can be issued by the "csrsigning" controller in kube-controller-manager.</description>
        /// <description>"kubernetes.io/kube-apiserver-client-kubelet": issues client certificates that kubelets use to authenticate to kube-apiserver.
        /// Requests for this signer can be auto-approved by the "csrapproving" controller in kube-controller-manager, and can be issued by the "csrsigning" controller in kube-controller-manager.</description>
        /// <description>"kubernetes.io/kubelet-serving" issues serving certificates that kubelets use to serve TLS endpoints, which kube-apiserver can connect to securely.
        /// Requests for this signer are never auto-approved by kube-controller-manager, and can be issued by the "csrsigning" controller in kube-controller-manager.</description>
        /// </list>
        ///
        /// More details are available at https://k8s.io/docs/reference/access-authn-authz/certificate-signing-requests/#kubernetes-signers
        ///
        /// Custom signerNames can also be specified. The signer defines:
        ///
        /// <list type="number">
        /// <description>Trust distribution: how trust (CA bundles) are distributed.</description>
        /// <description>Permitted subjects: and behavior when a disallowed subject is requested.</description>
        /// <description>Required, permitted, or forbidden x509 extensions in the request (including whether subjectAltNames are allowed, which types, restrictions on allowed values) and behavior when a disallowed extension is requested.</description>
        /// <description>Required, permitted, or forbidden key usages / extended key usages.</description>
        /// <description>Expiration/certificate lifetime: whether it is fixed by the signer, configurable by the admin.</description>
        /// <description>Whether or not requests for CA certificates are allowed.</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec#signerName
        /// </remarks>
        [JsiiProperty(name: "signerName", typeJson: "{\"primitive\":\"string\"}")]
        string SignerName
        {
            get;
        }

        /// <summary>expirationSeconds is the requested duration of validity of the issued certificate.</summary>
        /// <remarks>
        /// The certificate signer may issue a certificate with a different validity duration so a client must check the delta between the notBefore and and notAfter fields in the issued certificate to determine the actual duration.
        ///
        /// The v1.22+ in-tree implementations of the well-known Kubernetes signers will honor this field as long as the requested duration is not greater than the maximum duration they will honor per the --cluster-signing-duration CLI flag to the Kubernetes controller manager.
        ///
        /// Certificate signers may not honor this field for various reasons:
        ///
        /// <list type="number">
        /// <description>Old signer that is unaware of the field (such as the in-tree
        /// implementations prior to v1.22)</description>
        /// <description>Signer whose configured maximum is shorter than the requested duration</description>
        /// <description>Signer whose configured minimum is longer than the requested duration</description>
        /// </list>
        ///
        /// The minimum valid value for expirationSeconds is 600, i.e. 10 minutes.
        ///
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec#expirationSeconds
        /// </remarks>
        [JsiiProperty(name: "expirationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? ExpirationSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>extra contains extra attributes of the user that created the CertificateSigningRequest.</summary>
        /// <remarks>
        /// Populated by the API server on creation and immutable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec#extra
        /// </remarks>
        [JsiiProperty(name: "extra", typeJson: "{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string[]>? Extra
        {
            get
            {
                return null;
            }
        }

        /// <summary>groups contains group membership of the user that created the CertificateSigningRequest.</summary>
        /// <remarks>
        /// Populated by the API server on creation and immutable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec#groups
        /// </remarks>
        [JsiiProperty(name: "groups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Groups
        {
            get
            {
                return null;
            }
        }

        /// <summary>uid contains the uid of the user that created the CertificateSigningRequest.</summary>
        /// <remarks>
        /// Populated by the API server on creation and immutable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec#uid
        /// </remarks>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uid
        {
            get
            {
                return null;
            }
        }

        /// <summary>usages specifies a set of key usages requested in the issued certificate.</summary>
        /// <remarks>
        /// Requests for TLS client certificates typically request: "digital signature", "key encipherment", "client auth".
        ///
        /// Requests for TLS serving certificates typically request: "key encipherment", "digital signature", "server auth".
        ///
        /// Valid values are:
        /// "signing", "digital signature", "content commitment",
        /// "key encipherment", "key agreement", "data encipherment",
        /// "cert sign", "crl sign", "encipher only", "decipher only", "any",
        /// "server auth", "client auth",
        /// "code signing", "email protection", "s/mime",
        /// "ipsec end system", "ipsec tunnel", "ipsec user",
        /// "timestamping", "ocsp signing", "microsoft sgc", "netscape sgc"
        ///
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec#usages
        /// </remarks>
        [JsiiProperty(name: "usages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Usages
        {
            get
            {
                return null;
            }
        }

        /// <summary>username contains the name of the user that created the CertificateSigningRequest.</summary>
        /// <remarks>
        /// Populated by the API server on creation and immutable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec#username
        /// </remarks>
        [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Username
        {
            get
            {
                return null;
            }
        }

        /// <summary>CertificateSigningRequestSpec contains the certificate request.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ICertificateSigningRequestSpec), fullyQualifiedName: "k8s.CertificateSigningRequestSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.ICertificateSigningRequestSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>request contains an x509 certificate signing request encoded in a "CERTIFICATE REQUEST" PEM block.</summary>
            /// <remarks>
            /// When serialized as JSON or YAML, the data is additionally base64-encoded.
            ///
            /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec#request
            /// </remarks>
            [JsiiProperty(name: "request", typeJson: "{\"primitive\":\"string\"}")]
            public string Request
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>signerName indicates the requested signer, and is a qualified name.</summary>
            /// <remarks>
            /// List/watch requests for CertificateSigningRequests can filter on this field using a "spec.signerName=NAME" fieldSelector.
            ///
            /// Well-known Kubernetes signers are:
            ///
            /// <list type="number">
            /// <description>"kubernetes.io/kube-apiserver-client": issues client certificates that can be used to authenticate to kube-apiserver.
            /// Requests for this signer are never auto-approved by kube-controller-manager, can be issued by the "csrsigning" controller in kube-controller-manager.</description>
            /// <description>"kubernetes.io/kube-apiserver-client-kubelet": issues client certificates that kubelets use to authenticate to kube-apiserver.
            /// Requests for this signer can be auto-approved by the "csrapproving" controller in kube-controller-manager, and can be issued by the "csrsigning" controller in kube-controller-manager.</description>
            /// <description>"kubernetes.io/kubelet-serving" issues serving certificates that kubelets use to serve TLS endpoints, which kube-apiserver can connect to securely.
            /// Requests for this signer are never auto-approved by kube-controller-manager, and can be issued by the "csrsigning" controller in kube-controller-manager.</description>
            /// </list>
            ///
            /// More details are available at https://k8s.io/docs/reference/access-authn-authz/certificate-signing-requests/#kubernetes-signers
            ///
            /// Custom signerNames can also be specified. The signer defines:
            ///
            /// <list type="number">
            /// <description>Trust distribution: how trust (CA bundles) are distributed.</description>
            /// <description>Permitted subjects: and behavior when a disallowed subject is requested.</description>
            /// <description>Required, permitted, or forbidden x509 extensions in the request (including whether subjectAltNames are allowed, which types, restrictions on allowed values) and behavior when a disallowed extension is requested.</description>
            /// <description>Required, permitted, or forbidden key usages / extended key usages.</description>
            /// <description>Expiration/certificate lifetime: whether it is fixed by the signer, configurable by the admin.</description>
            /// <description>Whether or not requests for CA certificates are allowed.</description>
            /// </list>
            ///
            /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec#signerName
            /// </remarks>
            [JsiiProperty(name: "signerName", typeJson: "{\"primitive\":\"string\"}")]
            public string SignerName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>expirationSeconds is the requested duration of validity of the issued certificate.</summary>
            /// <remarks>
            /// The certificate signer may issue a certificate with a different validity duration so a client must check the delta between the notBefore and and notAfter fields in the issued certificate to determine the actual duration.
            ///
            /// The v1.22+ in-tree implementations of the well-known Kubernetes signers will honor this field as long as the requested duration is not greater than the maximum duration they will honor per the --cluster-signing-duration CLI flag to the Kubernetes controller manager.
            ///
            /// Certificate signers may not honor this field for various reasons:
            ///
            /// <list type="number">
            /// <description>Old signer that is unaware of the field (such as the in-tree
            /// implementations prior to v1.22)</description>
            /// <description>Signer whose configured maximum is shorter than the requested duration</description>
            /// <description>Signer whose configured minimum is longer than the requested duration</description>
            /// </list>
            ///
            /// The minimum valid value for expirationSeconds is 600, i.e. 10 minutes.
            ///
            /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec#expirationSeconds
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "expirationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? ExpirationSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>extra contains extra attributes of the user that created the CertificateSigningRequest.</summary>
            /// <remarks>
            /// Populated by the API server on creation and immutable.
            ///
            /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec#extra
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "extra", typeJson: "{\"collection\":{\"elementtype\":{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string[]>? Extra
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string[]>?>();
            }

            /// <summary>groups contains group membership of the user that created the CertificateSigningRequest.</summary>
            /// <remarks>
            /// Populated by the API server on creation and immutable.
            ///
            /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec#groups
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "groups", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Groups
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>uid contains the uid of the user that created the CertificateSigningRequest.</summary>
            /// <remarks>
            /// Populated by the API server on creation and immutable.
            ///
            /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec#uid
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uid
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>usages specifies a set of key usages requested in the issued certificate.</summary>
            /// <remarks>
            /// Requests for TLS client certificates typically request: "digital signature", "key encipherment", "client auth".
            ///
            /// Requests for TLS serving certificates typically request: "key encipherment", "digital signature", "server auth".
            ///
            /// Valid values are:
            /// "signing", "digital signature", "content commitment",
            /// "key encipherment", "key agreement", "data encipherment",
            /// "cert sign", "crl sign", "encipher only", "decipher only", "any",
            /// "server auth", "client auth",
            /// "code signing", "email protection", "s/mime",
            /// "ipsec end system", "ipsec tunnel", "ipsec user",
            /// "timestamping", "ocsp signing", "microsoft sgc", "netscape sgc"
            ///
            /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec#usages
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "usages", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Usages
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>username contains the name of the user that created the CertificateSigningRequest.</summary>
            /// <remarks>
            /// Populated by the API server on creation and immutable.
            ///
            /// <strong>Schema</strong>: io.k8s.api.certificates.v1.CertificateSigningRequestSpec#username
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "username", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Username
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
