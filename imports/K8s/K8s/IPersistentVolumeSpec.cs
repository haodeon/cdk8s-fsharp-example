using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PersistentVolumeSpec is the specification of a persistent volume.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPersistentVolumeSpec), fullyQualifiedName: "k8s.PersistentVolumeSpec")]
    public interface IPersistentVolumeSpec
    {
        /// <summary>accessModes contains all ways the volume can be mounted.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#accessModes
        /// </remarks>
        [JsiiProperty(name: "accessModes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? AccessModes
        {
            get
            {
                return null;
            }
        }

        /// <summary>awsElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#awsElasticBlockStore
        /// </remarks>
        [JsiiProperty(name: "awsElasticBlockStore", typeJson: "{\"fqn\":\"k8s.AwsElasticBlockStoreVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IAwsElasticBlockStoreVolumeSource? AwsElasticBlockStore
        {
            get
            {
                return null;
            }
        }

        /// <summary>azureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#azureDisk
        /// </remarks>
        [JsiiProperty(name: "azureDisk", typeJson: "{\"fqn\":\"k8s.AzureDiskVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IAzureDiskVolumeSource? AzureDisk
        {
            get
            {
                return null;
            }
        }

        /// <summary>azureFile represents an Azure File Service mount on the host and bind mount to the pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#azureFile
        /// </remarks>
        [JsiiProperty(name: "azureFile", typeJson: "{\"fqn\":\"k8s.AzureFilePersistentVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IAzureFilePersistentVolumeSource? AzureFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>capacity is the description of the persistent volume's resources and capacity.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#capacity
        /// </remarks>
        [JsiiProperty(name: "capacity", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, K8s.Quantity>? Capacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>cephFS represents a Ceph FS mount on the host that shares a pod's lifetime.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#cephfs
        /// </remarks>
        [JsiiProperty(name: "cephfs", typeJson: "{\"fqn\":\"k8s.CephFsPersistentVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ICephFsPersistentVolumeSource? Cephfs
        {
            get
            {
                return null;
            }
        }

        /// <summary>cinder represents a cinder volume attached and mounted on kubelets host machine.</summary>
        /// <remarks>
        /// More info: https://examples.k8s.io/mysql-cinder-pd/README.md
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#cinder
        /// </remarks>
        [JsiiProperty(name: "cinder", typeJson: "{\"fqn\":\"k8s.CinderPersistentVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ICinderPersistentVolumeSource? Cinder
        {
            get
            {
                return null;
            }
        }

        /// <summary>claimRef is part of a bi-directional binding between PersistentVolume and PersistentVolumeClaim.</summary>
        /// <remarks>
        /// Expected to be non-nil when bound. claim.VolumeName is the authoritative bind between PV and PVC. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#binding
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#claimRef
        /// </remarks>
        [JsiiProperty(name: "claimRef", typeJson: "{\"fqn\":\"k8s.ObjectReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectReference? ClaimRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>csi represents storage that is handled by an external CSI driver (Beta feature).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#csi
        /// </remarks>
        [JsiiProperty(name: "csi", typeJson: "{\"fqn\":\"k8s.CsiPersistentVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ICsiPersistentVolumeSource? Csi
        {
            get
            {
                return null;
            }
        }

        /// <summary>fc represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#fc
        /// </remarks>
        [JsiiProperty(name: "fc", typeJson: "{\"fqn\":\"k8s.FcVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IFcVolumeSource? Fc
        {
            get
            {
                return null;
            }
        }

        /// <summary>flexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#flexVolume
        /// </remarks>
        [JsiiProperty(name: "flexVolume", typeJson: "{\"fqn\":\"k8s.FlexPersistentVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IFlexPersistentVolumeSource? FlexVolume
        {
            get
            {
                return null;
            }
        }

        /// <summary>flocker represents a Flocker volume attached to a kubelet's host machine and exposed to the pod for its usage.</summary>
        /// <remarks>
        /// This depends on the Flocker control service being running
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#flocker
        /// </remarks>
        [JsiiProperty(name: "flocker", typeJson: "{\"fqn\":\"k8s.FlockerVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IFlockerVolumeSource? Flocker
        {
            get
            {
                return null;
            }
        }

        /// <summary>gcePersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
        /// <remarks>
        /// Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#gcePersistentDisk
        /// </remarks>
        [JsiiProperty(name: "gcePersistentDisk", typeJson: "{\"fqn\":\"k8s.GcePersistentDiskVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IGcePersistentDiskVolumeSource? GcePersistentDisk
        {
            get
            {
                return null;
            }
        }

        /// <summary>glusterfs represents a Glusterfs volume that is attached to a host and exposed to the pod.</summary>
        /// <remarks>
        /// Provisioned by an admin. More info: https://examples.k8s.io/volumes/glusterfs/README.md
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#glusterfs
        /// </remarks>
        [JsiiProperty(name: "glusterfs", typeJson: "{\"fqn\":\"k8s.GlusterfsPersistentVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IGlusterfsPersistentVolumeSource? Glusterfs
        {
            get
            {
                return null;
            }
        }

        /// <summary>hostPath represents a directory on the host.</summary>
        /// <remarks>
        /// Provisioned by a developer or tester. This is useful for single-node development and testing only! On-host storage is not supported in any way and WILL NOT WORK in a multi-node cluster. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#hostPath
        /// </remarks>
        [JsiiProperty(name: "hostPath", typeJson: "{\"fqn\":\"k8s.HostPathVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IHostPathVolumeSource? HostPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>iscsi represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
        /// <remarks>
        /// Provisioned by an admin.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#iscsi
        /// </remarks>
        [JsiiProperty(name: "iscsi", typeJson: "{\"fqn\":\"k8s.IscsiPersistentVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IIscsiPersistentVolumeSource? Iscsi
        {
            get
            {
                return null;
            }
        }

        /// <summary>local represents directly-attached storage with node affinity.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#local
        /// </remarks>
        [JsiiProperty(name: "local", typeJson: "{\"fqn\":\"k8s.LocalVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILocalVolumeSource? Local
        {
            get
            {
                return null;
            }
        }

        /// <summary>mountOptions is the list of mount options, e.g. ["ro", "soft"]. Not validated - mount will simply fail if one is invalid. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes/#mount-options.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#mountOptions
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

        /// <summary>nfs represents an NFS mount on the host.</summary>
        /// <remarks>
        /// Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#nfs
        /// </remarks>
        [JsiiProperty(name: "nfs", typeJson: "{\"fqn\":\"k8s.NfsVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INfsVolumeSource? Nfs
        {
            get
            {
                return null;
            }
        }

        /// <summary>nodeAffinity defines constraints that limit what nodes this volume can be accessed from.</summary>
        /// <remarks>
        /// This field influences the scheduling of pods that use this volume.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#nodeAffinity
        /// </remarks>
        [JsiiProperty(name: "nodeAffinity", typeJson: "{\"fqn\":\"k8s.VolumeNodeAffinity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IVolumeNodeAffinity? NodeAffinity
        {
            get
            {
                return null;
            }
        }

        /// <summary>persistentVolumeReclaimPolicy defines what happens to a persistent volume when released from its claim.</summary>
        /// <remarks>
        /// Valid options are Retain (default for manually created PersistentVolumes), Delete (default for dynamically provisioned PersistentVolumes), and Recycle (deprecated). Recycle must be supported by the volume plugin underlying this PersistentVolume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#reclaiming
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#persistentVolumeReclaimPolicy
        /// </remarks>
        [JsiiProperty(name: "persistentVolumeReclaimPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PersistentVolumeReclaimPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>photonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#photonPersistentDisk
        /// </remarks>
        [JsiiProperty(name: "photonPersistentDisk", typeJson: "{\"fqn\":\"k8s.PhotonPersistentDiskVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPhotonPersistentDiskVolumeSource? PhotonPersistentDisk
        {
            get
            {
                return null;
            }
        }

        /// <summary>portworxVolume represents a portworx volume attached and mounted on kubelets host machine.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#portworxVolume
        /// </remarks>
        [JsiiProperty(name: "portworxVolume", typeJson: "{\"fqn\":\"k8s.PortworxVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPortworxVolumeSource? PortworxVolume
        {
            get
            {
                return null;
            }
        }

        /// <summary>quobyte represents a Quobyte mount on the host that shares a pod's lifetime.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#quobyte
        /// </remarks>
        [JsiiProperty(name: "quobyte", typeJson: "{\"fqn\":\"k8s.QuobyteVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IQuobyteVolumeSource? Quobyte
        {
            get
            {
                return null;
            }
        }

        /// <summary>rbd represents a Rados Block Device mount on the host that shares a pod's lifetime.</summary>
        /// <remarks>
        /// More info: https://examples.k8s.io/volumes/rbd/README.md
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#rbd
        /// </remarks>
        [JsiiProperty(name: "rbd", typeJson: "{\"fqn\":\"k8s.RbdPersistentVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IRbdPersistentVolumeSource? Rbd
        {
            get
            {
                return null;
            }
        }

        /// <summary>scaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#scaleIO
        /// </remarks>
        [JsiiProperty(name: "scaleIo", typeJson: "{\"fqn\":\"k8s.ScaleIoPersistentVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IScaleIoPersistentVolumeSource? ScaleIo
        {
            get
            {
                return null;
            }
        }

        /// <summary>storageClassName is the name of StorageClass to which this persistent volume belongs.</summary>
        /// <remarks>
        /// Empty value means that this volume does not belong to any StorageClass.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#storageClassName
        /// </remarks>
        [JsiiProperty(name: "storageClassName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? StorageClassName
        {
            get
            {
                return null;
            }
        }

        /// <summary>storageOS represents a StorageOS volume that is attached to the kubelet's host machine and mounted into the pod More info: https://examples.k8s.io/volumes/storageos/README.md.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#storageos
        /// </remarks>
        [JsiiProperty(name: "storageos", typeJson: "{\"fqn\":\"k8s.StorageOsPersistentVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IStorageOsPersistentVolumeSource? Storageos
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name of VolumeAttributesClass to which this persistent volume belongs.</summary>
        /// <remarks>
        /// Empty value is not allowed. When this field is not set, it indicates that this volume does not belong to any VolumeAttributesClass. This field is mutable and can be changed by the CSI driver after a volume has been updated successfully to a new class. For an unbound PersistentVolume, the volumeAttributesClassName will be matched with unbound PersistentVolumeClaims during the binding process. This is an alpha field and requires enabling VolumeAttributesClass feature.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#volumeAttributesClassName
        /// </remarks>
        [JsiiProperty(name: "volumeAttributesClassName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeAttributesClassName
        {
            get
            {
                return null;
            }
        }

        /// <summary>volumeMode defines if a volume is intended to be used with a formatted filesystem or to remain in raw block state.</summary>
        /// <remarks>
        /// Value of Filesystem is implied when not included in spec.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#volumeMode
        /// </remarks>
        [JsiiProperty(name: "volumeMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>vsphereVolume represents a vSphere volume attached and mounted on kubelets host machine.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#vsphereVolume
        /// </remarks>
        [JsiiProperty(name: "vsphereVolume", typeJson: "{\"fqn\":\"k8s.VsphereVirtualDiskVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IVsphereVirtualDiskVolumeSource? VsphereVolume
        {
            get
            {
                return null;
            }
        }

        /// <summary>PersistentVolumeSpec is the specification of a persistent volume.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPersistentVolumeSpec), fullyQualifiedName: "k8s.PersistentVolumeSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.IPersistentVolumeSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>accessModes contains all ways the volume can be mounted.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#accessModes
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessModes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AccessModes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>awsElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#awsElasticBlockStore
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsElasticBlockStore", typeJson: "{\"fqn\":\"k8s.AwsElasticBlockStoreVolumeSource\"}", isOptional: true)]
            public K8s.IAwsElasticBlockStoreVolumeSource? AwsElasticBlockStore
            {
                get => GetInstanceProperty<K8s.IAwsElasticBlockStoreVolumeSource?>();
            }

            /// <summary>azureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#azureDisk
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureDisk", typeJson: "{\"fqn\":\"k8s.AzureDiskVolumeSource\"}", isOptional: true)]
            public K8s.IAzureDiskVolumeSource? AzureDisk
            {
                get => GetInstanceProperty<K8s.IAzureDiskVolumeSource?>();
            }

            /// <summary>azureFile represents an Azure File Service mount on the host and bind mount to the pod.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#azureFile
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureFile", typeJson: "{\"fqn\":\"k8s.AzureFilePersistentVolumeSource\"}", isOptional: true)]
            public K8s.IAzureFilePersistentVolumeSource? AzureFile
            {
                get => GetInstanceProperty<K8s.IAzureFilePersistentVolumeSource?>();
            }

            /// <summary>capacity is the description of the persistent volume's resources and capacity.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#capacity
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#capacity
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capacity", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, K8s.Quantity>? Capacity
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, K8s.Quantity>?>();
            }

            /// <summary>cephFS represents a Ceph FS mount on the host that shares a pod's lifetime.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#cephfs
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cephfs", typeJson: "{\"fqn\":\"k8s.CephFsPersistentVolumeSource\"}", isOptional: true)]
            public K8s.ICephFsPersistentVolumeSource? Cephfs
            {
                get => GetInstanceProperty<K8s.ICephFsPersistentVolumeSource?>();
            }

            /// <summary>cinder represents a cinder volume attached and mounted on kubelets host machine.</summary>
            /// <remarks>
            /// More info: https://examples.k8s.io/mysql-cinder-pd/README.md
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#cinder
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cinder", typeJson: "{\"fqn\":\"k8s.CinderPersistentVolumeSource\"}", isOptional: true)]
            public K8s.ICinderPersistentVolumeSource? Cinder
            {
                get => GetInstanceProperty<K8s.ICinderPersistentVolumeSource?>();
            }

            /// <summary>claimRef is part of a bi-directional binding between PersistentVolume and PersistentVolumeClaim.</summary>
            /// <remarks>
            /// Expected to be non-nil when bound. claim.VolumeName is the authoritative bind between PV and PVC. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#binding
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#claimRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "claimRef", typeJson: "{\"fqn\":\"k8s.ObjectReference\"}", isOptional: true)]
            public K8s.IObjectReference? ClaimRef
            {
                get => GetInstanceProperty<K8s.IObjectReference?>();
            }

            /// <summary>csi represents storage that is handled by an external CSI driver (Beta feature).</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#csi
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "csi", typeJson: "{\"fqn\":\"k8s.CsiPersistentVolumeSource\"}", isOptional: true)]
            public K8s.ICsiPersistentVolumeSource? Csi
            {
                get => GetInstanceProperty<K8s.ICsiPersistentVolumeSource?>();
            }

            /// <summary>fc represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#fc
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fc", typeJson: "{\"fqn\":\"k8s.FcVolumeSource\"}", isOptional: true)]
            public K8s.IFcVolumeSource? Fc
            {
                get => GetInstanceProperty<K8s.IFcVolumeSource?>();
            }

            /// <summary>flexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#flexVolume
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flexVolume", typeJson: "{\"fqn\":\"k8s.FlexPersistentVolumeSource\"}", isOptional: true)]
            public K8s.IFlexPersistentVolumeSource? FlexVolume
            {
                get => GetInstanceProperty<K8s.IFlexPersistentVolumeSource?>();
            }

            /// <summary>flocker represents a Flocker volume attached to a kubelet's host machine and exposed to the pod for its usage.</summary>
            /// <remarks>
            /// This depends on the Flocker control service being running
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#flocker
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flocker", typeJson: "{\"fqn\":\"k8s.FlockerVolumeSource\"}", isOptional: true)]
            public K8s.IFlockerVolumeSource? Flocker
            {
                get => GetInstanceProperty<K8s.IFlockerVolumeSource?>();
            }

            /// <summary>gcePersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
            /// <remarks>
            /// Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#gcePersistentDisk
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gcePersistentDisk", typeJson: "{\"fqn\":\"k8s.GcePersistentDiskVolumeSource\"}", isOptional: true)]
            public K8s.IGcePersistentDiskVolumeSource? GcePersistentDisk
            {
                get => GetInstanceProperty<K8s.IGcePersistentDiskVolumeSource?>();
            }

            /// <summary>glusterfs represents a Glusterfs volume that is attached to a host and exposed to the pod.</summary>
            /// <remarks>
            /// Provisioned by an admin. More info: https://examples.k8s.io/volumes/glusterfs/README.md
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#glusterfs
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "glusterfs", typeJson: "{\"fqn\":\"k8s.GlusterfsPersistentVolumeSource\"}", isOptional: true)]
            public K8s.IGlusterfsPersistentVolumeSource? Glusterfs
            {
                get => GetInstanceProperty<K8s.IGlusterfsPersistentVolumeSource?>();
            }

            /// <summary>hostPath represents a directory on the host.</summary>
            /// <remarks>
            /// Provisioned by a developer or tester. This is useful for single-node development and testing only! On-host storage is not supported in any way and WILL NOT WORK in a multi-node cluster. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#hostPath
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostPath", typeJson: "{\"fqn\":\"k8s.HostPathVolumeSource\"}", isOptional: true)]
            public K8s.IHostPathVolumeSource? HostPath
            {
                get => GetInstanceProperty<K8s.IHostPathVolumeSource?>();
            }

            /// <summary>iscsi represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
            /// <remarks>
            /// Provisioned by an admin.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#iscsi
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iscsi", typeJson: "{\"fqn\":\"k8s.IscsiPersistentVolumeSource\"}", isOptional: true)]
            public K8s.IIscsiPersistentVolumeSource? Iscsi
            {
                get => GetInstanceProperty<K8s.IIscsiPersistentVolumeSource?>();
            }

            /// <summary>local represents directly-attached storage with node affinity.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#local
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "local", typeJson: "{\"fqn\":\"k8s.LocalVolumeSource\"}", isOptional: true)]
            public K8s.ILocalVolumeSource? Local
            {
                get => GetInstanceProperty<K8s.ILocalVolumeSource?>();
            }

            /// <summary>mountOptions is the list of mount options, e.g. ["ro", "soft"]. Not validated - mount will simply fail if one is invalid. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes/#mount-options.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#mountOptions
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mountOptions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? MountOptions
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>nfs represents an NFS mount on the host.</summary>
            /// <remarks>
            /// Provisioned by an admin. More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#nfs
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nfs", typeJson: "{\"fqn\":\"k8s.NfsVolumeSource\"}", isOptional: true)]
            public K8s.INfsVolumeSource? Nfs
            {
                get => GetInstanceProperty<K8s.INfsVolumeSource?>();
            }

            /// <summary>nodeAffinity defines constraints that limit what nodes this volume can be accessed from.</summary>
            /// <remarks>
            /// This field influences the scheduling of pods that use this volume.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#nodeAffinity
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeAffinity", typeJson: "{\"fqn\":\"k8s.VolumeNodeAffinity\"}", isOptional: true)]
            public K8s.IVolumeNodeAffinity? NodeAffinity
            {
                get => GetInstanceProperty<K8s.IVolumeNodeAffinity?>();
            }

            /// <summary>persistentVolumeReclaimPolicy defines what happens to a persistent volume when released from its claim.</summary>
            /// <remarks>
            /// Valid options are Retain (default for manually created PersistentVolumes), Delete (default for dynamically provisioned PersistentVolumes), and Recycle (deprecated). Recycle must be supported by the volume plugin underlying this PersistentVolume. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#reclaiming
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#persistentVolumeReclaimPolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "persistentVolumeReclaimPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PersistentVolumeReclaimPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>photonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#photonPersistentDisk
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "photonPersistentDisk", typeJson: "{\"fqn\":\"k8s.PhotonPersistentDiskVolumeSource\"}", isOptional: true)]
            public K8s.IPhotonPersistentDiskVolumeSource? PhotonPersistentDisk
            {
                get => GetInstanceProperty<K8s.IPhotonPersistentDiskVolumeSource?>();
            }

            /// <summary>portworxVolume represents a portworx volume attached and mounted on kubelets host machine.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#portworxVolume
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "portworxVolume", typeJson: "{\"fqn\":\"k8s.PortworxVolumeSource\"}", isOptional: true)]
            public K8s.IPortworxVolumeSource? PortworxVolume
            {
                get => GetInstanceProperty<K8s.IPortworxVolumeSource?>();
            }

            /// <summary>quobyte represents a Quobyte mount on the host that shares a pod's lifetime.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#quobyte
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "quobyte", typeJson: "{\"fqn\":\"k8s.QuobyteVolumeSource\"}", isOptional: true)]
            public K8s.IQuobyteVolumeSource? Quobyte
            {
                get => GetInstanceProperty<K8s.IQuobyteVolumeSource?>();
            }

            /// <summary>rbd represents a Rados Block Device mount on the host that shares a pod's lifetime.</summary>
            /// <remarks>
            /// More info: https://examples.k8s.io/volumes/rbd/README.md
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#rbd
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rbd", typeJson: "{\"fqn\":\"k8s.RbdPersistentVolumeSource\"}", isOptional: true)]
            public K8s.IRbdPersistentVolumeSource? Rbd
            {
                get => GetInstanceProperty<K8s.IRbdPersistentVolumeSource?>();
            }

            /// <summary>scaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#scaleIO
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scaleIo", typeJson: "{\"fqn\":\"k8s.ScaleIoPersistentVolumeSource\"}", isOptional: true)]
            public K8s.IScaleIoPersistentVolumeSource? ScaleIo
            {
                get => GetInstanceProperty<K8s.IScaleIoPersistentVolumeSource?>();
            }

            /// <summary>storageClassName is the name of StorageClass to which this persistent volume belongs.</summary>
            /// <remarks>
            /// Empty value means that this volume does not belong to any StorageClass.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#storageClassName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageClassName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageClassName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>storageOS represents a StorageOS volume that is attached to the kubelet's host machine and mounted into the pod More info: https://examples.k8s.io/volumes/storageos/README.md.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#storageos
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageos", typeJson: "{\"fqn\":\"k8s.StorageOsPersistentVolumeSource\"}", isOptional: true)]
            public K8s.IStorageOsPersistentVolumeSource? Storageos
            {
                get => GetInstanceProperty<K8s.IStorageOsPersistentVolumeSource?>();
            }

            /// <summary>Name of VolumeAttributesClass to which this persistent volume belongs.</summary>
            /// <remarks>
            /// Empty value is not allowed. When this field is not set, it indicates that this volume does not belong to any VolumeAttributesClass. This field is mutable and can be changed by the CSI driver after a volume has been updated successfully to a new class. For an unbound PersistentVolume, the volumeAttributesClassName will be matched with unbound PersistentVolumeClaims during the binding process. This is an alpha field and requires enabling VolumeAttributesClass feature.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#volumeAttributesClassName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeAttributesClassName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeAttributesClassName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>volumeMode defines if a volume is intended to be used with a formatted filesystem or to remain in raw block state.</summary>
            /// <remarks>
            /// Value of Filesystem is implied when not included in spec.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#volumeMode
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>vsphereVolume represents a vSphere volume attached and mounted on kubelets host machine.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeSpec#vsphereVolume
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "vsphereVolume", typeJson: "{\"fqn\":\"k8s.VsphereVirtualDiskVolumeSource\"}", isOptional: true)]
            public K8s.IVsphereVirtualDiskVolumeSource? VsphereVolume
            {
                get => GetInstanceProperty<K8s.IVsphereVirtualDiskVolumeSource?>();
            }
        }
    }
}
