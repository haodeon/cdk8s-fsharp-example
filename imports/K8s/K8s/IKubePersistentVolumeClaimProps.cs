using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PersistentVolumeClaim is a user's request for and claim to a persistent volume.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaim
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubePersistentVolumeClaimProps), fullyQualifiedName: "k8s.KubePersistentVolumeClaimProps")]
    public interface IKubePersistentVolumeClaimProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaim#metadata
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

        /// <summary>spec defines the desired characteristics of a volume requested by a pod author.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaim#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.PersistentVolumeClaimSpec\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPersistentVolumeClaimSpec? Spec
        {
            get
            {
                return null;
            }
        }

        /// <summary>PersistentVolumeClaim is a user's request for and claim to a persistent volume.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaim
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubePersistentVolumeClaimProps), fullyQualifiedName: "k8s.KubePersistentVolumeClaimProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubePersistentVolumeClaimProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaim#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>spec defines the desired characteristics of a volume requested by a pod author.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaim#spec
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.PersistentVolumeClaimSpec\"}", isOptional: true)]
            public K8s.IPersistentVolumeClaimSpec? Spec
            {
                get => GetInstanceProperty<K8s.IPersistentVolumeClaimSpec?>();
            }
        }
    }
}
