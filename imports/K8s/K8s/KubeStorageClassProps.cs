using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>StorageClass describes the parameters for a class of storage for which PersistentVolumes can be dynamically provisioned.</summary>
    /// <remarks>
    /// StorageClasses are non-namespaced; the name of the storage class according to etcd is in ObjectMeta.Name.
    ///
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeStorageClassProps")]
    public class KubeStorageClassProps : K8s.IKubeStorageClassProps
    {
        /// <summary>provisioner indicates the type of the provisioner.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#provisioner
        /// </remarks>
        [JsiiProperty(name: "provisioner", typeJson: "{\"primitive\":\"string\"}")]
        public string Provisioner
        {
            get;
            set;
        }

        /// <summary>allowedTopologies restrict the node topologies where volumes can be dynamically provisioned.</summary>
        /// <remarks>
        /// Each volume plugin defines its own supported topology specifications. An empty TopologySelectorTerm list means there is no topology restriction. This field is only honored by servers that enable the VolumeScheduling feature.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#allowedTopologies
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowedTopologies", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.TopologySelectorTerm\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.ITopologySelectorTerm[]? AllowedTopologies
        {
            get;
            set;
        }

        /// <summary>allowVolumeExpansion shows whether the storage class allow volume expand.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#allowVolumeExpansion
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "allowVolumeExpansion", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? AllowVolumeExpansion
        {
            get;
            set;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>mountOptions controls the mountOptions for dynamically provisioned PersistentVolumes of this storage class.</summary>
        /// <remarks>
        /// e.g. ["ro", "soft"]. Not validated - mount of the PVs will simply fail if one is invalid.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#mountOptions
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "mountOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? MountOptions
        {
            get;
            set;
        }

        /// <summary>parameters holds the parameters for the provisioner that should create volumes of this storage class.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#parameters
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get;
            set;
        }

        /// <summary>reclaimPolicy controls the reclaimPolicy for dynamically provisioned PersistentVolumes of this storage class.</summary>
        /// <remarks>
        /// Defaults to Delete.
        ///
        /// <strong>Default</strong>: Delete.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#reclaimPolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reclaimPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReclaimPolicy
        {
            get;
            set;
        }

        /// <summary>volumeBindingMode indicates how PersistentVolumeClaims should be provisioned and bound.</summary>
        /// <remarks>
        /// When unset, VolumeBindingImmediate is used. This field is only honored by servers that enable the VolumeScheduling feature.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#volumeBindingMode
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volumeBindingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? VolumeBindingMode
        {
            get;
            set;
        }
    }
}
