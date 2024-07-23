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
    [JsiiByValue(fqn: "k8s.DownwardApiProjection")]
    public class DownwardApiProjection : K8s.IDownwardApiProjection
    {
        /// <summary>Items is a list of DownwardAPIVolume file.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIProjection#items
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.DownwardApiVolumeFile\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IDownwardApiVolumeFile[]? Items
        {
            get;
            set;
        }
    }
}
