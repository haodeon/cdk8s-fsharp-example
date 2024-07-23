using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents downward API info for projecting into a projected volume.</summary>
    /// <remarks>
    /// Note that this is identical to a downwardAPI volume source without the default mode.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIProjection
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IDownwardApiProjection), fullyQualifiedName: "k8s.DownwardApiProjection")]
    public interface IDownwardApiProjection
    {
        /// <summary>Items is a list of DownwardAPIVolume file.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIProjection#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.DownwardApiVolumeFile\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IDownwardApiVolumeFile[]? Items
        {
            get
            {
                return null;
            }
        }

        /// <summary>Represents downward API info for projecting into a projected volume.</summary>
        /// <remarks>
        /// Note that this is identical to a downwardAPI volume source without the default mode.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIProjection
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IDownwardApiProjection), fullyQualifiedName: "k8s.DownwardApiProjection")]
        internal sealed class _Proxy : DeputyBase, K8s.IDownwardApiProjection
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Items is a list of DownwardAPIVolume file.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIProjection#items
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.DownwardApiVolumeFile\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IDownwardApiVolumeFile[]? Items
            {
                get => GetInstanceProperty<K8s.IDownwardApiVolumeFile[]?>();
            }
        }
    }
}
