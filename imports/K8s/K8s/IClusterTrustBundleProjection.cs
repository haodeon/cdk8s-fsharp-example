using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ClusterTrustBundleProjection describes how to select a set of ClusterTrustBundle objects and project their contents into the pod filesystem.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ClusterTrustBundleProjection
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IClusterTrustBundleProjection), fullyQualifiedName: "k8s.ClusterTrustBundleProjection")]
    public interface IClusterTrustBundleProjection
    {
        /// <summary>Relative path from the volume root to write the bundle.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClusterTrustBundleProjection#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>Select all ClusterTrustBundles that match this label selector.</summary>
        /// <remarks>
        /// Only has effect if signerName is set.  Mutually-exclusive with name.  If unset, interpreted as "match nothing".  If set but empty, interpreted as "match everything".
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClusterTrustBundleProjection#labelSelector
        /// </remarks>
        [JsiiProperty(name: "labelSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILabelSelector? LabelSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>Select a single ClusterTrustBundle by object name.</summary>
        /// <remarks>
        /// Mutually-exclusive with signerName and labelSelector.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClusterTrustBundleProjection#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>If true, don't block pod startup if the referenced ClusterTrustBundle(s) aren't available.</summary>
        /// <remarks>
        /// If using name, then the named ClusterTrustBundle is allowed not to exist.  If using signerName, then the combination of signerName and labelSelector is allowed to match zero ClusterTrustBundles.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClusterTrustBundleProjection#optional
        /// </remarks>
        [JsiiProperty(name: "optional", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Optional
        {
            get
            {
                return null;
            }
        }

        /// <summary>Select all ClusterTrustBundles that match this signer name.</summary>
        /// <remarks>
        /// Mutually-exclusive with name.  The contents of all selected ClusterTrustBundles will be unified and deduplicated.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClusterTrustBundleProjection#signerName
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

        /// <summary>ClusterTrustBundleProjection describes how to select a set of ClusterTrustBundle objects and project their contents into the pod filesystem.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClusterTrustBundleProjection
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IClusterTrustBundleProjection), fullyQualifiedName: "k8s.ClusterTrustBundleProjection")]
        internal sealed class _Proxy : DeputyBase, K8s.IClusterTrustBundleProjection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Relative path from the volume root to write the bundle.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ClusterTrustBundleProjection#path
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
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
                get => GetInstanceProperty<K8s.ILabelSelector?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<bool?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
