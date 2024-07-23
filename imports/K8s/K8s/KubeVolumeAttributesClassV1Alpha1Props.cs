using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>VolumeAttributesClass represents a specification of mutable volume attributes defined by the CSI driver.</summary>
    /// <remarks>
    /// The class can be specified during dynamic provisioning of PersistentVolumeClaims, and changed in the PersistentVolumeClaim spec after provisioning.
    ///
    /// <strong>Schema</strong>: io.k8s.api.storage.v1alpha1.VolumeAttributesClass
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeVolumeAttributesClassV1Alpha1Props")]
    public class KubeVolumeAttributesClassV1Alpha1Props : K8s.IKubeVolumeAttributesClassV1Alpha1Props
    {
        /// <summary>Name of the CSI driver This field is immutable.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1alpha1.VolumeAttributesClass#driverName
        /// </remarks>
        [JsiiProperty(name: "driverName", typeJson: "{\"primitive\":\"string\"}")]
        public string DriverName
        {
            get;
            set;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1alpha1.VolumeAttributesClass#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>parameters hold volume attributes defined by the CSI driver.</summary>
        /// <remarks>
        /// These values are opaque to the Kubernetes and are passed directly to the CSI driver. The underlying storage provider supports changing these attributes on an existing volume, however the parameters field itself is immutable. To invoke a volume update, a new VolumeAttributesClass should be created with new parameters, and the PersistentVolumeClaim should be updated to reference the new VolumeAttributesClass.
        ///
        /// This field is required and must contain at least one key/value pair. The keys cannot be empty, and the maximum number of parameters is 512, with a cumulative max size of 256K. If the CSI driver rejects invalid parameters, the target PersistentVolumeClaim will be set to an "Infeasible" state in the modifyVolumeStatus field.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1alpha1.VolumeAttributesClass#parameters
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get;
            set;
        }
    }
}
