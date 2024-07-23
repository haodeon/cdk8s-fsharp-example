using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>VolumeAttachment captures the intent to attach or detach the specified volume to/from the specified node.</summary>
    /// <remarks>
    /// VolumeAttachment objects are non-namespaced.
    ///
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachment
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeVolumeAttachmentProps), fullyQualifiedName: "k8s.KubeVolumeAttachmentProps")]
    public interface IKubeVolumeAttachmentProps
    {
        /// <summary>spec represents specification of the desired attach/detach volume behavior.</summary>
        /// <remarks>
        /// Populated by the Kubernetes system.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachment#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.VolumeAttachmentSpec\"}")]
        K8s.IVolumeAttachmentSpec Spec
        {
            get;
        }

        /// <summary>Standard object metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachment#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>VolumeAttachment captures the intent to attach or detach the specified volume to/from the specified node.</summary>
        /// <remarks>
        /// VolumeAttachment objects are non-namespaced.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachment
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeVolumeAttachmentProps), fullyQualifiedName: "k8s.KubeVolumeAttachmentProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeVolumeAttachmentProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>spec represents specification of the desired attach/detach volume behavior.</summary>
            /// <remarks>
            /// Populated by the Kubernetes system.
            ///
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachment#spec
            /// </remarks>
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.VolumeAttachmentSpec\"}")]
            public K8s.IVolumeAttachmentSpec Spec
            {
                get => GetInstanceProperty<K8s.IVolumeAttachmentSpec>()!;
            }

            /// <summary>Standard object metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.VolumeAttachment#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }
        }
    }
}
