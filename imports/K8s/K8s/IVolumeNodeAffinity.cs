using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>VolumeNodeAffinity defines constraints that limit what nodes this volume can be accessed from.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeNodeAffinity
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IVolumeNodeAffinity), fullyQualifiedName: "k8s.VolumeNodeAffinity")]
    public interface IVolumeNodeAffinity
    {
        /// <summary>required specifies hard node constraints that must be met.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeNodeAffinity#required
        /// </remarks>
        [JsiiProperty(name: "required", typeJson: "{\"fqn\":\"k8s.NodeSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INodeSelector? Required
        {
            get
            {
                return null;
            }
        }

        /// <summary>VolumeNodeAffinity defines constraints that limit what nodes this volume can be accessed from.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeNodeAffinity
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IVolumeNodeAffinity), fullyQualifiedName: "k8s.VolumeNodeAffinity")]
        internal sealed class _Proxy : DeputyBase, K8s.IVolumeNodeAffinity
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>required specifies hard node constraints that must be met.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeNodeAffinity#required
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "required", typeJson: "{\"fqn\":\"k8s.NodeSelector\"}", isOptional: true)]
            public K8s.INodeSelector? Required
            {
                get => GetInstanceProperty<K8s.INodeSelector?>();
            }
        }
    }
}
