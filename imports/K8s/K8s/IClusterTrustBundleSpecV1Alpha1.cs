using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ClusterTrustBundleSpec contains the signer and trust anchors.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundleSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IClusterTrustBundleSpecV1Alpha1), fullyQualifiedName: "k8s.ClusterTrustBundleSpecV1Alpha1")]
    public interface IClusterTrustBundleSpecV1Alpha1
    {
        /// <summary>trustBundle contains the individual X.509 trust anchors for this bundle, as PEM bundle of PEM-wrapped, DER-formatted X.509 certificates.</summary>
        /// <remarks>
        /// The data must consist only of PEM certificate blocks that parse as valid X.509 certificates.  Each certificate must include a basic constraints extension with the CA bit set.  The API server will reject objects that contain duplicate certificates, or that use PEM block headers.
        ///
        /// Users of ClusterTrustBundles, including Kubelet, are free to reorder and deduplicate certificate blocks in this file according to their own logic, as well as to drop PEM block headers and inter-block data.
        ///
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundleSpec#trustBundle
        /// </remarks>
        [JsiiProperty(name: "trustBundle", typeJson: "{\"primitive\":\"string\"}")]
        string TrustBundle
        {
            get;
        }

        /// <summary>signerName indicates the associated signer, if any.</summary>
        /// <remarks>
        /// In order to create or update a ClusterTrustBundle that sets signerName, you must have the following cluster-scoped permission: group=certificates.k8s.io resource=signers resourceName=<the signer="signer" name="name" xmlns="http://www.w3.org/1999/xhtml"></the> verb=attest.
        ///
        /// If signerName is not empty, then the ClusterTrustBundle object must be named with the signer name as a prefix (translating slashes to colons). For example, for the signer name <c>example.com/foo</c>, valid ClusterTrustBundle object names include <c>example.com:foo:abc</c> and <c>example.com:foo:v1</c>.
        ///
        /// If signerName is empty, then the ClusterTrustBundle object's name must not have such a prefix.
        ///
        /// List/watch requests for ClusterTrustBundles can filter on this field using a <c>spec.signerName=NAME</c> field selector.
        ///
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundleSpec#signerName
        /// </remarks>
        [JsiiProperty(name: "signerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SignerName
        {
            get
            {
                return null;
            }
        }

        /// <summary>ClusterTrustBundleSpec contains the signer and trust anchors.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundleSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IClusterTrustBundleSpecV1Alpha1), fullyQualifiedName: "k8s.ClusterTrustBundleSpecV1Alpha1")]
        internal sealed class _Proxy : DeputyBase, K8s.IClusterTrustBundleSpecV1Alpha1
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>trustBundle contains the individual X.509 trust anchors for this bundle, as PEM bundle of PEM-wrapped, DER-formatted X.509 certificates.</summary>
            /// <remarks>
            /// The data must consist only of PEM certificate blocks that parse as valid X.509 certificates.  Each certificate must include a basic constraints extension with the CA bit set.  The API server will reject objects that contain duplicate certificates, or that use PEM block headers.
            ///
            /// Users of ClusterTrustBundles, including Kubelet, are free to reorder and deduplicate certificate blocks in this file according to their own logic, as well as to drop PEM block headers and inter-block data.
            ///
            /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundleSpec#trustBundle
            /// </remarks>
            [JsiiProperty(name: "trustBundle", typeJson: "{\"primitive\":\"string\"}")]
            public string TrustBundle
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>signerName indicates the associated signer, if any.</summary>
            /// <remarks>
            /// In order to create or update a ClusterTrustBundle that sets signerName, you must have the following cluster-scoped permission: group=certificates.k8s.io resource=signers resourceName=<the signer="signer" name="name" xmlns="http://www.w3.org/1999/xhtml"></the> verb=attest.
            ///
            /// If signerName is not empty, then the ClusterTrustBundle object must be named with the signer name as a prefix (translating slashes to colons). For example, for the signer name <c>example.com/foo</c>, valid ClusterTrustBundle object names include <c>example.com:foo:abc</c> and <c>example.com:foo:v1</c>.
            ///
            /// If signerName is empty, then the ClusterTrustBundle object's name must not have such a prefix.
            ///
            /// List/watch requests for ClusterTrustBundles can filter on this field using a <c>spec.signerName=NAME</c> field selector.
            ///
            /// <strong>Schema</strong>: io.k8s.api.certificates.v1alpha1.ClusterTrustBundleSpec#signerName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "signerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SignerName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
