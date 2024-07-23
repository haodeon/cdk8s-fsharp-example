using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>VolumeAttachmentSpec is the specification of a VolumeAttachment request.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IVolumeAttachmentSpec), fullyQualifiedName: "k8s.VolumeAttachmentSpec")]
    public interface IVolumeAttachmentSpec
    {
        /// <summary>attacher indicates the name of the volume driver that MUST handle this request.</summary>
        /// <remarks>
        /// This is the name returned by GetPluginName().
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSpec#attacher
        /// </remarks>
        [JsiiProperty(name: "attacher", typeJson: "{\"primitive\":\"string\"}")]
        string Attacher
        {
            get;
        }

        /// <summary>nodeName represents the node that the volume should be attached to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSpec#nodeName
        /// </remarks>
        [JsiiProperty(name: "nodeName", typeJson: "{\"primitive\":\"string\"}")]
        string NodeName
        {
            get;
        }

        /// <summary>source represents the volume that should be attached.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSpec#source
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"k8s.VolumeAttachmentSource\"}")]
        K8s.IVolumeAttachmentSource Source
        {
            get;
        }

        /// <summary>VolumeAttachmentSpec is the specification of a VolumeAttachment request.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IVolumeAttachmentSpec), fullyQualifiedName: "k8s.VolumeAttachmentSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.IVolumeAttachmentSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>attacher indicates the name of the volume driver that MUST handle this request.</summary>
            /// <remarks>
            /// This is the name returned by GetPluginName().
            ///
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSpec#attacher
            /// </remarks>
            [JsiiProperty(name: "attacher", typeJson: "{\"primitive\":\"string\"}")]
            public string Attacher
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>nodeName represents the node that the volume should be attached to.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSpec#nodeName
            /// </remarks>
            [JsiiProperty(name: "nodeName", typeJson: "{\"primitive\":\"string\"}")]
            public string NodeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>source represents the volume that should be attached.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachmentSpec#source
            /// </remarks>
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"k8s.VolumeAttachmentSource\"}")]
            public K8s.IVolumeAttachmentSource Source
            {
                get => GetInstanceProperty<K8s.IVolumeAttachmentSource>()!;
            }
        }
    }
}
