using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>VolumeNodeAffinity defines constraints that limit what nodes this volume can be accessed from.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeNodeAffinity
    /// </remarks>
    [JsiiByValue(fqn: "k8s.VolumeNodeAffinity")]
    public class VolumeNodeAffinity : K8s.IVolumeNodeAffinity
    {
        /// <summary>required specifies hard node constraints that must be met.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeNodeAffinity#required
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "required", typeJson: "{\"fqn\":\"k8s.NodeSelector\"}", isOptional: true)]
        public K8s.INodeSelector? Required
        {
            get;
            set;
        }
    }
}
