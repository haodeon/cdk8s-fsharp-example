using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>StatefulSetPersistentVolumeClaimRetentionPolicy describes the policy used for PVCs created from the StatefulSet VolumeClaimTemplates.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetPersistentVolumeClaimRetentionPolicy
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStatefulSetPersistentVolumeClaimRetentionPolicy), fullyQualifiedName: "k8s.StatefulSetPersistentVolumeClaimRetentionPolicy")]
    public interface IStatefulSetPersistentVolumeClaimRetentionPolicy
    {
        /// <summary>WhenDeleted specifies what happens to PVCs created from StatefulSet VolumeClaimTemplates when the StatefulSet is deleted.</summary>
        /// <remarks>
        /// The default policy of <c>Retain</c> causes PVCs to not be affected by StatefulSet deletion. The <c>Delete</c> policy causes those PVCs to be deleted.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetPersistentVolumeClaimRetentionPolicy#whenDeleted
        /// </remarks>
        [JsiiProperty(name: "whenDeleted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WhenDeleted
        {
            get
            {
                return null;
            }
        }

        /// <summary>WhenScaled specifies what happens to PVCs created from StatefulSet VolumeClaimTemplates when the StatefulSet is scaled down.</summary>
        /// <remarks>
        /// The default policy of <c>Retain</c> causes PVCs to not be affected by a scaledown. The <c>Delete</c> policy causes the associated PVCs for any excess pods above the replica count to be deleted.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetPersistentVolumeClaimRetentionPolicy#whenScaled
        /// </remarks>
        [JsiiProperty(name: "whenScaled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? WhenScaled
        {
            get
            {
                return null;
            }
        }

        /// <summary>StatefulSetPersistentVolumeClaimRetentionPolicy describes the policy used for PVCs created from the StatefulSet VolumeClaimTemplates.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetPersistentVolumeClaimRetentionPolicy
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStatefulSetPersistentVolumeClaimRetentionPolicy), fullyQualifiedName: "k8s.StatefulSetPersistentVolumeClaimRetentionPolicy")]
        internal sealed class _Proxy : DeputyBase, K8s.IStatefulSetPersistentVolumeClaimRetentionPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>WhenDeleted specifies what happens to PVCs created from StatefulSet VolumeClaimTemplates when the StatefulSet is deleted.</summary>
            /// <remarks>
            /// The default policy of <c>Retain</c> causes PVCs to not be affected by StatefulSet deletion. The <c>Delete</c> policy causes those PVCs to be deleted.
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetPersistentVolumeClaimRetentionPolicy#whenDeleted
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "whenDeleted", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WhenDeleted
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>WhenScaled specifies what happens to PVCs created from StatefulSet VolumeClaimTemplates when the StatefulSet is scaled down.</summary>
            /// <remarks>
            /// The default policy of <c>Retain</c> causes PVCs to not be affected by a scaledown. The <c>Delete</c> policy causes the associated PVCs for any excess pods above the replica count to be deleted.
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetPersistentVolumeClaimRetentionPolicy#whenScaled
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "whenScaled", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? WhenScaled
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
