using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>StorageClass describes the parameters for a class of storage for which PersistentVolumes can be dynamically provisioned.</summary>
    /// <remarks>
    /// StorageClasses are non-namespaced; the name of the storage class according to etcd is in ObjectMeta.Name.
    ///
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeStorageClassProps), fullyQualifiedName: "k8s.KubeStorageClassProps")]
    public interface IKubeStorageClassProps
    {
        /// <summary>provisioner indicates the type of the provisioner.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#provisioner
        /// </remarks>
        [JsiiProperty(name: "provisioner", typeJson: "{\"primitive\":\"string\"}")]
        string Provisioner
        {
            get;
        }

        /// <summary>allowedTopologies restrict the node topologies where volumes can be dynamically provisioned.</summary>
        /// <remarks>
        /// Each volume plugin defines its own supported topology specifications. An empty TopologySelectorTerm list means there is no topology restriction. This field is only honored by servers that enable the VolumeScheduling feature.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#allowedTopologies
        /// </remarks>
        [JsiiProperty(name: "allowedTopologies", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.TopologySelectorTerm\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ITopologySelectorTerm[]? AllowedTopologies
        {
            get
            {
                return null;
            }
        }

        /// <summary>allowVolumeExpansion shows whether the storage class allow volume expand.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#allowVolumeExpansion
        /// </remarks>
        [JsiiProperty(name: "allowVolumeExpansion", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? AllowVolumeExpansion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#metadata
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

        /// <summary>mountOptions controls the mountOptions for dynamically provisioned PersistentVolumes of this storage class.</summary>
        /// <remarks>
        /// e.g. ["ro", "soft"]. Not validated - mount of the PVs will simply fail if one is invalid.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#mountOptions
        /// </remarks>
        [JsiiProperty(name: "mountOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? MountOptions
        {
            get
            {
                return null;
            }
        }

        /// <summary>parameters holds the parameters for the provisioner that should create volumes of this storage class.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#parameters
        /// </remarks>
        [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Parameters
        {
            get
            {
                return null;
            }
        }

        /// <summary>reclaimPolicy controls the reclaimPolicy for dynamically provisioned PersistentVolumes of this storage class.</summary>
        /// <remarks>
        /// Defaults to Delete.
        ///
        /// <strong>Default</strong>: Delete.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#reclaimPolicy
        /// </remarks>
        [JsiiProperty(name: "reclaimPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReclaimPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>volumeBindingMode indicates how PersistentVolumeClaims should be provisioned and bound.</summary>
        /// <remarks>
        /// When unset, VolumeBindingImmediate is used. This field is only honored by servers that enable the VolumeScheduling feature.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#volumeBindingMode
        /// </remarks>
        [JsiiProperty(name: "volumeBindingMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeBindingMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>StorageClass describes the parameters for a class of storage for which PersistentVolumes can be dynamically provisioned.</summary>
        /// <remarks>
        /// StorageClasses are non-namespaced; the name of the storage class according to etcd is in ObjectMeta.Name.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeStorageClassProps), fullyQualifiedName: "k8s.KubeStorageClassProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeStorageClassProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>provisioner indicates the type of the provisioner.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#provisioner
            /// </remarks>
            [JsiiProperty(name: "provisioner", typeJson: "{\"primitive\":\"string\"}")]
            public string Provisioner
            {
                get => GetInstanceProperty<string>()!;
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
                get => GetInstanceProperty<K8s.ITopologySelectorTerm[]?>();
            }

            /// <summary>allowVolumeExpansion shows whether the storage class allow volume expand.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#allowVolumeExpansion
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "allowVolumeExpansion", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? AllowVolumeExpansion
            {
                get => GetInstanceProperty<bool?>();
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
                get => GetInstanceProperty<K8s.IObjectMeta?>();
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
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>parameters holds the parameters for the provisioner that should create volumes of this storage class.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.StorageClass#parameters
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "parameters", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Parameters
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
