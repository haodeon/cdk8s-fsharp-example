using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ClusterTrustBundleProjection describes how to select a set of ClusterTrustBundle objects and project their contents into the pod filesystem.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ClusterTrustBundleProjection
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ClusterTrustBundleProjection")]
    public class ClusterTrustBundleProjection : K8s.IClusterTrustBundleProjection
    {
        /// <summary>Relative path from the volume root to write the bundle.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClusterTrustBundleProjection#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }

        /// <summary>Select all ClusterTrustBundles that match this label selector.</summary>
        /// <remarks>
        /// Only has effect if signerName is set.  Mutually-exclusive with name.  If unset, interpreted as "match nothing".  If set but empty, interpreted as "match everything".
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClusterTrustBundleProjection#labelSelector
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "labelSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        public K8s.ILabelSelector? LabelSelector
        {
            get;
            set;
        }

        /// <summary>Select a single ClusterTrustBundle by object name.</summary>
        /// <remarks>
        /// Mutually-exclusive with signerName and labelSelector.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClusterTrustBundleProjection#name
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>If true, don't block pod startup if the referenced ClusterTrustBundle(s) aren't available.</summary>
        /// <remarks>
        /// If using name, then the named ClusterTrustBundle is allowed not to exist.  If using signerName, then the combination of signerName and labelSelector is allowed to match zero ClusterTrustBundles.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClusterTrustBundleProjection#optional
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "optional", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? Optional
        {
            get;
            set;
        }

        /// <summary>Select all ClusterTrustBundles that match this signer name.</summary>
        /// <remarks>
        /// Mutually-exclusive with name.  The contents of all selected ClusterTrustBundles will be unified and deduplicated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClusterTrustBundleProjection#signerName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "signerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SignerName
        {
            get;
            set;
        }
    }
}
