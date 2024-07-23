using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>VolumeNodeResources is a set of resource limits for scheduling of volumes.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeNodeResources
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IVolumeNodeResources), fullyQualifiedName: "k8s.VolumeNodeResources")]
    public interface IVolumeNodeResources
    {
        /// <summary>count indicates the maximum number of unique volumes managed by the CSI driver that can be used on a node.</summary>
        /// <remarks>
        /// A volume that is both attached and mounted on a node is considered to be used once, not twice. The same rule applies for a unique volume that is shared among multiple pods on the same node. If this field is not specified, then the supported number of volumes on this node is unbounded.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeNodeResources#count
        /// </remarks>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Count
        {
            get
            {
                return null;
            }
        }

        /// <summary>VolumeNodeResources is a set of resource limits for scheduling of volumes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeNodeResources
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IVolumeNodeResources), fullyQualifiedName: "k8s.VolumeNodeResources")]
        internal sealed class _Proxy : DeputyBase, K8s.IVolumeNodeResources
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>count indicates the maximum number of unique volumes managed by the CSI driver that can be used on a node.</summary>
            /// <remarks>
            /// A volume that is both attached and mounted on a node is considered to be used once, not twice. The same rule applies for a unique volume that is shared among multiple pods on the same node. If this field is not specified, then the supported number of volumes on this node is unbounded.
            ///
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeNodeResources#count
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Count
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
