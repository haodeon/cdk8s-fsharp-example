using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Volume represents a named volume in a pod that may be accessed by any container in the pod.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IVolume), fullyQualifiedName: "k8s.Volume")]
    public interface IVolume
    {
        /// <summary>name of the volume.</summary>
        /// <remarks>
        /// Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>awsElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#awsElasticBlockStore
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#azureDisk
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#azureFile
        /// </remarks>
        [JsiiProperty(name: "azureFile", typeJson: "{\"fqn\":\"k8s.AzureFileVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IAzureFileVolumeSource? AzureFile
        {
            get
            {
                return null;
            }
        }

        /// <summary>cephFS represents a Ceph FS mount on the host that shares a pod's lifetime.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#cephfs
        /// </remarks>
        [JsiiProperty(name: "cephfs", typeJson: "{\"fqn\":\"k8s.CephFsVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ICephFsVolumeSource? Cephfs
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#cinder
        /// </remarks>
        [JsiiProperty(name: "cinder", typeJson: "{\"fqn\":\"k8s.CinderVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ICinderVolumeSource? Cinder
        {
            get
            {
                return null;
            }
        }

        /// <summary>configMap represents a configMap that should populate this volume.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#configMap
        /// </remarks>
        [JsiiProperty(name: "configMap", typeJson: "{\"fqn\":\"k8s.ConfigMapVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IConfigMapVolumeSource? ConfigMap
        {
            get
            {
                return null;
            }
        }

        /// <summary>csi (Container Storage Interface) represents ephemeral storage that is handled by certain external CSI drivers (Beta feature).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#csi
        /// </remarks>
        [JsiiProperty(name: "csi", typeJson: "{\"fqn\":\"k8s.CsiVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ICsiVolumeSource? Csi
        {
            get
            {
                return null;
            }
        }

        /// <summary>downwardAPI represents downward API about the pod that should populate this volume.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#downwardAPI
        /// </remarks>
        [JsiiProperty(name: "downwardApi", typeJson: "{\"fqn\":\"k8s.DownwardApiVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IDownwardApiVolumeSource? DownwardApi
        {
            get
            {
                return null;
            }
        }

        /// <summary>emptyDir represents a temporary directory that shares a pod's lifetime.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#emptyDir
        /// </remarks>
        [JsiiProperty(name: "emptyDir", typeJson: "{\"fqn\":\"k8s.EmptyDirVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IEmptyDirVolumeSource? EmptyDir
        {
            get
            {
                return null;
            }
        }

        /// <summary>ephemeral represents a volume that is handled by a cluster storage driver.</summary>
        /// <remarks>
        /// The volume's lifecycle is tied to the pod that defines it - it will be created before the pod starts, and deleted when the pod is removed.
        ///
        /// Use this if: a) the volume is only needed while the pod runs, b) features of normal volumes like restoring from snapshot or capacity
        /// tracking are needed,
        /// c) the storage driver is specified through a storage class, and d) the storage driver supports dynamic volume provisioning through
        /// a PersistentVolumeClaim (see EphemeralVolumeSource for more
        /// information on the connection between this volume type
        /// and PersistentVolumeClaim).
        ///
        /// Use PersistentVolumeClaim or one of the vendor-specific APIs for volumes that persist for longer than the lifecycle of an individual pod.
        ///
        /// Use CSI for light-weight local ephemeral volumes if the CSI driver is meant to be used that way - see the documentation of the driver for more information.
        ///
        /// A pod can use both types of ephemeral volumes and persistent volumes at the same time.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#ephemeral
        /// </remarks>
        [JsiiProperty(name: "ephemeral", typeJson: "{\"fqn\":\"k8s.EphemeralVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IEphemeralVolumeSource? Ephemeral
        {
            get
            {
                return null;
            }
        }

        /// <summary>fc represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#fc
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#flexVolume
        /// </remarks>
        [JsiiProperty(name: "flexVolume", typeJson: "{\"fqn\":\"k8s.FlexVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IFlexVolumeSource? FlexVolume
        {
            get
            {
                return null;
            }
        }

        /// <summary>flocker represents a Flocker volume attached to a kubelet's host machine.</summary>
        /// <remarks>
        /// This depends on the Flocker control service being running
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#flocker
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
        /// More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#gcePersistentDisk
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

        /// <summary>gitRepo represents a git repository at a particular revision.</summary>
        /// <remarks>
        /// DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#gitRepo
        /// </remarks>
        [JsiiProperty(name: "gitRepo", typeJson: "{\"fqn\":\"k8s.GitRepoVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IGitRepoVolumeSource? GitRepo
        {
            get
            {
                return null;
            }
        }

        /// <summary>glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime.</summary>
        /// <remarks>
        /// More info: https://examples.k8s.io/volumes/glusterfs/README.md
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#glusterfs
        /// </remarks>
        [JsiiProperty(name: "glusterfs", typeJson: "{\"fqn\":\"k8s.GlusterfsVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IGlusterfsVolumeSource? Glusterfs
        {
            get
            {
                return null;
            }
        }

        /// <summary>hostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container.</summary>
        /// <remarks>
        /// This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#hostPath
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
        /// More info: https://examples.k8s.io/volumes/iscsi/README.md
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#iscsi
        /// </remarks>
        [JsiiProperty(name: "iscsi", typeJson: "{\"fqn\":\"k8s.IscsiVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IIscsiVolumeSource? Iscsi
        {
            get
            {
                return null;
            }
        }

        /// <summary>nfs represents an NFS mount on the host that shares a pod's lifetime More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#nfs
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

        /// <summary>persistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#persistentVolumeClaim
        /// </remarks>
        [JsiiProperty(name: "persistentVolumeClaim", typeJson: "{\"fqn\":\"k8s.PersistentVolumeClaimVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IPersistentVolumeClaimVolumeSource? PersistentVolumeClaim
        {
            get
            {
                return null;
            }
        }

        /// <summary>photonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#photonPersistentDisk
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#portworxVolume
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

        /// <summary>projected items for all in one resources secrets, configmaps, and downward API.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#projected
        /// </remarks>
        [JsiiProperty(name: "projected", typeJson: "{\"fqn\":\"k8s.ProjectedVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IProjectedVolumeSource? Projected
        {
            get
            {
                return null;
            }
        }

        /// <summary>quobyte represents a Quobyte mount on the host that shares a pod's lifetime.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#quobyte
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#rbd
        /// </remarks>
        [JsiiProperty(name: "rbd", typeJson: "{\"fqn\":\"k8s.RbdVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IRbdVolumeSource? Rbd
        {
            get
            {
                return null;
            }
        }

        /// <summary>scaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#scaleIO
        /// </remarks>
        [JsiiProperty(name: "scaleIo", typeJson: "{\"fqn\":\"k8s.ScaleIoVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IScaleIoVolumeSource? ScaleIo
        {
            get
            {
                return null;
            }
        }

        /// <summary>secret represents a secret that should populate this volume.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/volumes#secret
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#secret
        /// </remarks>
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"k8s.SecretVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISecretVolumeSource? Secret
        {
            get
            {
                return null;
            }
        }

        /// <summary>storageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#storageos
        /// </remarks>
        [JsiiProperty(name: "storageos", typeJson: "{\"fqn\":\"k8s.StorageOsVolumeSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IStorageOsVolumeSource? Storageos
        {
            get
            {
                return null;
            }
        }

        /// <summary>vsphereVolume represents a vSphere volume attached and mounted on kubelets host machine.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#vsphereVolume
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

        /// <summary>Volume represents a named volume in a pod that may be accessed by any container in the pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IVolume), fullyQualifiedName: "k8s.Volume")]
        internal sealed class _Proxy : DeputyBase, K8s.IVolume
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>name of the volume.</summary>
            /// <remarks>
            /// Must be a DNS_LABEL and unique within the pod. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>awsElasticBlockStore represents an AWS Disk resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#awsElasticBlockStore
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "awsElasticBlockStore", typeJson: "{\"fqn\":\"k8s.AwsElasticBlockStoreVolumeSource\"}", isOptional: true)]
            public K8s.IAwsElasticBlockStoreVolumeSource? AwsElasticBlockStore
            {
                get => GetInstanceProperty<K8s.IAwsElasticBlockStoreVolumeSource?>();
            }

            /// <summary>azureDisk represents an Azure Data Disk mount on the host and bind mount to the pod.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#azureDisk
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureDisk", typeJson: "{\"fqn\":\"k8s.AzureDiskVolumeSource\"}", isOptional: true)]
            public K8s.IAzureDiskVolumeSource? AzureDisk
            {
                get => GetInstanceProperty<K8s.IAzureDiskVolumeSource?>();
            }

            /// <summary>azureFile represents an Azure File Service mount on the host and bind mount to the pod.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#azureFile
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "azureFile", typeJson: "{\"fqn\":\"k8s.AzureFileVolumeSource\"}", isOptional: true)]
            public K8s.IAzureFileVolumeSource? AzureFile
            {
                get => GetInstanceProperty<K8s.IAzureFileVolumeSource?>();
            }

            /// <summary>cephFS represents a Ceph FS mount on the host that shares a pod's lifetime.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#cephfs
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cephfs", typeJson: "{\"fqn\":\"k8s.CephFsVolumeSource\"}", isOptional: true)]
            public K8s.ICephFsVolumeSource? Cephfs
            {
                get => GetInstanceProperty<K8s.ICephFsVolumeSource?>();
            }

            /// <summary>cinder represents a cinder volume attached and mounted on kubelets host machine.</summary>
            /// <remarks>
            /// More info: https://examples.k8s.io/mysql-cinder-pd/README.md
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#cinder
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "cinder", typeJson: "{\"fqn\":\"k8s.CinderVolumeSource\"}", isOptional: true)]
            public K8s.ICinderVolumeSource? Cinder
            {
                get => GetInstanceProperty<K8s.ICinderVolumeSource?>();
            }

            /// <summary>configMap represents a configMap that should populate this volume.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#configMap
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configMap", typeJson: "{\"fqn\":\"k8s.ConfigMapVolumeSource\"}", isOptional: true)]
            public K8s.IConfigMapVolumeSource? ConfigMap
            {
                get => GetInstanceProperty<K8s.IConfigMapVolumeSource?>();
            }

            /// <summary>csi (Container Storage Interface) represents ephemeral storage that is handled by certain external CSI drivers (Beta feature).</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#csi
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "csi", typeJson: "{\"fqn\":\"k8s.CsiVolumeSource\"}", isOptional: true)]
            public K8s.ICsiVolumeSource? Csi
            {
                get => GetInstanceProperty<K8s.ICsiVolumeSource?>();
            }

            /// <summary>downwardAPI represents downward API about the pod that should populate this volume.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#downwardAPI
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "downwardApi", typeJson: "{\"fqn\":\"k8s.DownwardApiVolumeSource\"}", isOptional: true)]
            public K8s.IDownwardApiVolumeSource? DownwardApi
            {
                get => GetInstanceProperty<K8s.IDownwardApiVolumeSource?>();
            }

            /// <summary>emptyDir represents a temporary directory that shares a pod's lifetime.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#emptyDir
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "emptyDir", typeJson: "{\"fqn\":\"k8s.EmptyDirVolumeSource\"}", isOptional: true)]
            public K8s.IEmptyDirVolumeSource? EmptyDir
            {
                get => GetInstanceProperty<K8s.IEmptyDirVolumeSource?>();
            }

            /// <summary>ephemeral represents a volume that is handled by a cluster storage driver.</summary>
            /// <remarks>
            /// The volume's lifecycle is tied to the pod that defines it - it will be created before the pod starts, and deleted when the pod is removed.
            ///
            /// Use this if: a) the volume is only needed while the pod runs, b) features of normal volumes like restoring from snapshot or capacity
            /// tracking are needed,
            /// c) the storage driver is specified through a storage class, and d) the storage driver supports dynamic volume provisioning through
            /// a PersistentVolumeClaim (see EphemeralVolumeSource for more
            /// information on the connection between this volume type
            /// and PersistentVolumeClaim).
            ///
            /// Use PersistentVolumeClaim or one of the vendor-specific APIs for volumes that persist for longer than the lifecycle of an individual pod.
            ///
            /// Use CSI for light-weight local ephemeral volumes if the CSI driver is meant to be used that way - see the documentation of the driver for more information.
            ///
            /// A pod can use both types of ephemeral volumes and persistent volumes at the same time.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#ephemeral
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ephemeral", typeJson: "{\"fqn\":\"k8s.EphemeralVolumeSource\"}", isOptional: true)]
            public K8s.IEphemeralVolumeSource? Ephemeral
            {
                get => GetInstanceProperty<K8s.IEphemeralVolumeSource?>();
            }

            /// <summary>fc represents a Fibre Channel resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#fc
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fc", typeJson: "{\"fqn\":\"k8s.FcVolumeSource\"}", isOptional: true)]
            public K8s.IFcVolumeSource? Fc
            {
                get => GetInstanceProperty<K8s.IFcVolumeSource?>();
            }

            /// <summary>flexVolume represents a generic volume resource that is provisioned/attached using an exec based plugin.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#flexVolume
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flexVolume", typeJson: "{\"fqn\":\"k8s.FlexVolumeSource\"}", isOptional: true)]
            public K8s.IFlexVolumeSource? FlexVolume
            {
                get => GetInstanceProperty<K8s.IFlexVolumeSource?>();
            }

            /// <summary>flocker represents a Flocker volume attached to a kubelet's host machine.</summary>
            /// <remarks>
            /// This depends on the Flocker control service being running
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#flocker
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "flocker", typeJson: "{\"fqn\":\"k8s.FlockerVolumeSource\"}", isOptional: true)]
            public K8s.IFlockerVolumeSource? Flocker
            {
                get => GetInstanceProperty<K8s.IFlockerVolumeSource?>();
            }

            /// <summary>gcePersistentDisk represents a GCE Disk resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/storage/volumes#gcepersistentdisk
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#gcePersistentDisk
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gcePersistentDisk", typeJson: "{\"fqn\":\"k8s.GcePersistentDiskVolumeSource\"}", isOptional: true)]
            public K8s.IGcePersistentDiskVolumeSource? GcePersistentDisk
            {
                get => GetInstanceProperty<K8s.IGcePersistentDiskVolumeSource?>();
            }

            /// <summary>gitRepo represents a git repository at a particular revision.</summary>
            /// <remarks>
            /// DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#gitRepo
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "gitRepo", typeJson: "{\"fqn\":\"k8s.GitRepoVolumeSource\"}", isOptional: true)]
            public K8s.IGitRepoVolumeSource? GitRepo
            {
                get => GetInstanceProperty<K8s.IGitRepoVolumeSource?>();
            }

            /// <summary>glusterfs represents a Glusterfs mount on the host that shares a pod's lifetime.</summary>
            /// <remarks>
            /// More info: https://examples.k8s.io/volumes/glusterfs/README.md
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#glusterfs
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "glusterfs", typeJson: "{\"fqn\":\"k8s.GlusterfsVolumeSource\"}", isOptional: true)]
            public K8s.IGlusterfsVolumeSource? Glusterfs
            {
                get => GetInstanceProperty<K8s.IGlusterfsVolumeSource?>();
            }

            /// <summary>hostPath represents a pre-existing file or directory on the host machine that is directly exposed to the container.</summary>
            /// <remarks>
            /// This is generally used for system agents or other privileged things that are allowed to see the host machine. Most containers will NOT need this. More info: https://kubernetes.io/docs/concepts/storage/volumes#hostpath
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#hostPath
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "hostPath", typeJson: "{\"fqn\":\"k8s.HostPathVolumeSource\"}", isOptional: true)]
            public K8s.IHostPathVolumeSource? HostPath
            {
                get => GetInstanceProperty<K8s.IHostPathVolumeSource?>();
            }

            /// <summary>iscsi represents an ISCSI Disk resource that is attached to a kubelet's host machine and then exposed to the pod.</summary>
            /// <remarks>
            /// More info: https://examples.k8s.io/volumes/iscsi/README.md
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#iscsi
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "iscsi", typeJson: "{\"fqn\":\"k8s.IscsiVolumeSource\"}", isOptional: true)]
            public K8s.IIscsiVolumeSource? Iscsi
            {
                get => GetInstanceProperty<K8s.IIscsiVolumeSource?>();
            }

            /// <summary>nfs represents an NFS mount on the host that shares a pod's lifetime More info: https://kubernetes.io/docs/concepts/storage/volumes#nfs.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#nfs
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nfs", typeJson: "{\"fqn\":\"k8s.NfsVolumeSource\"}", isOptional: true)]
            public K8s.INfsVolumeSource? Nfs
            {
                get => GetInstanceProperty<K8s.INfsVolumeSource?>();
            }

            /// <summary>persistentVolumeClaimVolumeSource represents a reference to a PersistentVolumeClaim in the same namespace.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#persistentVolumeClaim
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "persistentVolumeClaim", typeJson: "{\"fqn\":\"k8s.PersistentVolumeClaimVolumeSource\"}", isOptional: true)]
            public K8s.IPersistentVolumeClaimVolumeSource? PersistentVolumeClaim
            {
                get => GetInstanceProperty<K8s.IPersistentVolumeClaimVolumeSource?>();
            }

            /// <summary>photonPersistentDisk represents a PhotonController persistent disk attached and mounted on kubelets host machine.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#photonPersistentDisk
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "photonPersistentDisk", typeJson: "{\"fqn\":\"k8s.PhotonPersistentDiskVolumeSource\"}", isOptional: true)]
            public K8s.IPhotonPersistentDiskVolumeSource? PhotonPersistentDisk
            {
                get => GetInstanceProperty<K8s.IPhotonPersistentDiskVolumeSource?>();
            }

            /// <summary>portworxVolume represents a portworx volume attached and mounted on kubelets host machine.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#portworxVolume
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "portworxVolume", typeJson: "{\"fqn\":\"k8s.PortworxVolumeSource\"}", isOptional: true)]
            public K8s.IPortworxVolumeSource? PortworxVolume
            {
                get => GetInstanceProperty<K8s.IPortworxVolumeSource?>();
            }

            /// <summary>projected items for all in one resources secrets, configmaps, and downward API.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#projected
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "projected", typeJson: "{\"fqn\":\"k8s.ProjectedVolumeSource\"}", isOptional: true)]
            public K8s.IProjectedVolumeSource? Projected
            {
                get => GetInstanceProperty<K8s.IProjectedVolumeSource?>();
            }

            /// <summary>quobyte represents a Quobyte mount on the host that shares a pod's lifetime.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#quobyte
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
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#rbd
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rbd", typeJson: "{\"fqn\":\"k8s.RbdVolumeSource\"}", isOptional: true)]
            public K8s.IRbdVolumeSource? Rbd
            {
                get => GetInstanceProperty<K8s.IRbdVolumeSource?>();
            }

            /// <summary>scaleIO represents a ScaleIO persistent volume attached and mounted on Kubernetes nodes.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#scaleIO
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "scaleIo", typeJson: "{\"fqn\":\"k8s.ScaleIoVolumeSource\"}", isOptional: true)]
            public K8s.IScaleIoVolumeSource? ScaleIo
            {
                get => GetInstanceProperty<K8s.IScaleIoVolumeSource?>();
            }

            /// <summary>secret represents a secret that should populate this volume.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/storage/volumes#secret
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#secret
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"k8s.SecretVolumeSource\"}", isOptional: true)]
            public K8s.ISecretVolumeSource? Secret
            {
                get => GetInstanceProperty<K8s.ISecretVolumeSource?>();
            }

            /// <summary>storageOS represents a StorageOS volume attached and mounted on Kubernetes nodes.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#storageos
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageos", typeJson: "{\"fqn\":\"k8s.StorageOsVolumeSource\"}", isOptional: true)]
            public K8s.IStorageOsVolumeSource? Storageos
            {
                get => GetInstanceProperty<K8s.IStorageOsVolumeSource?>();
            }

            /// <summary>vsphereVolume represents a vSphere volume attached and mounted on kubelets host machine.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Volume#vsphereVolume
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
