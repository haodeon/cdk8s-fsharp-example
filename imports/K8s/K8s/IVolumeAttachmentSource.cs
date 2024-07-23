using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>VolumeAttachmentSource represents a volume that should be attached.</summary>
    /// <remarks>
    /// Right now only PersistenVolumes can be attached via external attacher, in future we may allow also inline volumes in pods. Exactly one member can be set.
    ///
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IVolumeAttachmentSource), fullyQualifiedName: "k8s.VolumeAttachmentSource")]
    public interface IVolumeAttachmentSource
    {
        /// <summary>inlineVolumeSpec contains all the information necessary to attach a persistent volume defined by a pod's inline VolumeSource.</summary>
        /// <remarks>
        /// This field is populated only for the CSIMigration feature. It contains translated fields from a pod's inline VolumeSource to a PersistentVolumeSpec. This field is beta-level and is only honored by servers that enabled the CSIMigration feature.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSource#inlineVolumeSpec
        /// </remarks>
        [JsiiProperty(name: "inlineVolumeSpec", typeJson: "{\"fqn\":\"k8s.PersistentVolumeSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPersistentVolumeSpec? InlineVolumeSpec
        {
            get
            {
                return null;
            }
        }

        /// <summary>persistentVolumeName represents the name of the persistent volume to attach.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSource#persistentVolumeName
        /// </remarks>
        [JsiiProperty(name: "persistentVolumeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PersistentVolumeName
        {
            get
            {
                return null;
            }
        }

        /// <summary>VolumeAttachmentSource represents a volume that should be attached.</summary>
        /// <remarks>
        /// Right now only PersistenVolumes can be attached via external attacher, in future we may allow also inline volumes in pods. Exactly one member can be set.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IVolumeAttachmentSource), fullyQualifiedName: "k8s.VolumeAttachmentSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IVolumeAttachmentSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>inlineVolumeSpec contains all the information necessary to attach a persistent volume defined by a pod's inline VolumeSource.</summary>
            /// <remarks>
            /// This field is populated only for the CSIMigration feature. It contains translated fields from a pod's inline VolumeSource to a PersistentVolumeSpec. This field is beta-level and is only honored by servers that enabled the CSIMigration feature.
            ///
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSource#inlineVolumeSpec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "inlineVolumeSpec", typeJson: "{\"fqn\":\"k8s.PersistentVolumeSpec\"}", isOptional: true)]
            public K8s.IPersistentVolumeSpec? InlineVolumeSpec
            {
                get => GetInstanceProperty<K8s.IPersistentVolumeSpec?>();
            }

            /// <summary>persistentVolumeName represents the name of the persistent volume to attach.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSource#persistentVolumeName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "persistentVolumeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PersistentVolumeName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
