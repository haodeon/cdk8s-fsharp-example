using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents an ephemeral volume that is handled by a normal storage driver.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IEphemeralVolumeSource), fullyQualifiedName: "k8s.EphemeralVolumeSource")]
    public interface IEphemeralVolumeSource
    {
        /// <summary>Will be used to create a stand-alone PVC to provision the volume.</summary>
        /// <remarks>
        /// The pod in which this EphemeralVolumeSource is embedded will be the owner of the PVC, i.e. the PVC will be deleted together with the pod.  The name of the PVC will be <c>&lt;pod name&gt;-&lt;volume name&gt;</c> where <c>&lt;volume name&gt;</c> is the name from the <c>PodSpec.Volumes</c> array entry. Pod validation will reject the pod if the concatenated name is not valid for a PVC (for example, too long).
        ///
        /// An existing PVC with that name that is not owned by the pod will <em>not</em> be used for the pod to avoid using an unrelated volume by mistake. Starting the pod is then blocked until the unrelated PVC is removed. If such a pre-created PVC is meant to be used by the pod, the PVC has to updated with an owner reference to the pod once the pod exists. Normally this should not be necessary, but it may be useful when manually reconstructing a broken cluster.
        ///
        /// This field is read-only and no changes will be made by Kubernetes to the PVC after it has been created.
        ///
        /// Required, must not be nil.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralVolumeSource#volumeClaimTemplate
        /// </remarks>
        [JsiiProperty(name: "volumeClaimTemplate", typeJson: "{\"fqn\":\"k8s.PersistentVolumeClaimTemplate\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPersistentVolumeClaimTemplate? VolumeClaimTemplate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Represents an ephemeral volume that is handled by a normal storage driver.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IEphemeralVolumeSource), fullyQualifiedName: "k8s.EphemeralVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IEphemeralVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Will be used to create a stand-alone PVC to provision the volume.</summary>
            /// <remarks>
            /// The pod in which this EphemeralVolumeSource is embedded will be the owner of the PVC, i.e. the PVC will be deleted together with the pod.  The name of the PVC will be <c>&lt;pod name&gt;-&lt;volume name&gt;</c> where <c>&lt;volume name&gt;</c> is the name from the <c>PodSpec.Volumes</c> array entry. Pod validation will reject the pod if the concatenated name is not valid for a PVC (for example, too long).
            ///
            /// An existing PVC with that name that is not owned by the pod will <em>not</em> be used for the pod to avoid using an unrelated volume by mistake. Starting the pod is then blocked until the unrelated PVC is removed. If such a pre-created PVC is meant to be used by the pod, the PVC has to updated with an owner reference to the pod once the pod exists. Normally this should not be necessary, but it may be useful when manually reconstructing a broken cluster.
            ///
            /// This field is read-only and no changes will be made by Kubernetes to the PVC after it has been created.
            ///
            /// Required, must not be nil.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EphemeralVolumeSource#volumeClaimTemplate
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeClaimTemplate", typeJson: "{\"fqn\":\"k8s.PersistentVolumeClaimTemplate\"}", isOptional: true)]
            public K8s.IPersistentVolumeClaimTemplate? VolumeClaimTemplate
            {
                get => GetInstanceProperty<K8s.IPersistentVolumeClaimTemplate?>();
            }
        }
    }
}
