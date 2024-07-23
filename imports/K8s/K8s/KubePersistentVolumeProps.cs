using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PersistentVolume (PV) is a storage resource provisioned by an administrator.</summary>
    /// <remarks>
    /// It is analogous to a node. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolume
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubePersistentVolumeProps")]
    public class KubePersistentVolumeProps : K8s.IKubePersistentVolumeProps
    {
        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolume#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>spec defines a specification of a persistent volume owned by the cluster.</summary>
        /// <remarks>
        /// Provisioned by an administrator. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistent-volumes
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolume#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.PersistentVolumeSpec\"}", isOptional: true)]
        public K8s.IPersistentVolumeSpec? Spec
        {
            get;
            set;
        }
    }
}
