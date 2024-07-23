using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents a projected volume source.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ProjectedVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IProjectedVolumeSource), fullyQualifiedName: "k8s.ProjectedVolumeSource")]
    public interface IProjectedVolumeSource
    {
        /// <summary>defaultMode are the mode bits used to set permissions on created files by default.</summary>
        /// <remarks>
        /// Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ProjectedVolumeSource#defaultMode
        /// </remarks>
        [JsiiProperty(name: "defaultMode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>sources is the list of volume projections.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ProjectedVolumeSource#sources
        /// </remarks>
        [JsiiProperty(name: "sources", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.VolumeProjection\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IVolumeProjection[]? Sources
        {
            get
            {
                return null;
            }
        }

        /// <summary>Represents a projected volume source.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ProjectedVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IProjectedVolumeSource), fullyQualifiedName: "k8s.ProjectedVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IProjectedVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>defaultMode are the mode bits used to set permissions on created files by default.</summary>
            /// <remarks>
            /// Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ProjectedVolumeSource#defaultMode
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultMode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultMode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>sources is the list of volume projections.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ProjectedVolumeSource#sources
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sources", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.VolumeProjection\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IVolumeProjection[]? Sources
            {
                get => GetInstanceProperty<K8s.IVolumeProjection[]?>();
            }
        }
    }
}
