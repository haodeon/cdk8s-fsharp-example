using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CSIStorageCapacity stores the result of one CSI GetCapacity call.</summary>
    /// <remarks>
    /// For a given StorageClass, this describes the available capacity in a particular topology segment.  This can be used when considering where to instantiate new PersistentVolumes.
    ///
    /// For example this can express things like: - StorageClass "standard" has "1234 GiB" available in "topology.kubernetes.io/zone=us-east1" - StorageClass "localssd" has "10 GiB" available in "kubernetes.io/hostname=knode-abc123"
    ///
    /// The following three cases all imply that no capacity is available for a certain combination: - no object exists with suitable topology and storage class name - such an object exists, but the capacity is unset - such an object exists, but the capacity is zero
    ///
    /// The producer of these objects can decide which approach is more suitable.
    ///
    /// They are consumed by the kube-scheduler when a CSI driver opts into capacity-aware scheduling with CSIDriverSpec.StorageCapacity. The scheduler compares the MaximumVolumeSize against the requested size of pending volumes to filter out unsuitable nodes. If MaximumVolumeSize is unset, it falls back to a comparison against the less precise Capacity. If that is also unset, the scheduler assumes that capacity is insufficient and tries some other node.
    ///
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacity
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeCsiStorageCapacityProps), fullyQualifiedName: "k8s.KubeCsiStorageCapacityProps")]
    public interface IKubeCsiStorageCapacityProps
    {
        /// <summary>storageClassName represents the name of the StorageClass that the reported capacity applies to.</summary>
        /// <remarks>
        /// It must meet the same requirements as the name of a StorageClass object (non-empty, DNS subdomain). If that object no longer exists, the CSIStorageCapacity object is obsolete and should be removed by its creator. This field is immutable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacity#storageClassName
        /// </remarks>
        [JsiiProperty(name: "storageClassName", typeJson: "{\"primitive\":\"string\"}")]
        string StorageClassName
        {
            get;
        }

        /// <summary>capacity is the value reported by the CSI driver in its GetCapacityResponse for a GetCapacityRequest with topology and parameters that match the previous fields.</summary>
        /// <remarks>
        /// The semantic is currently (CSI spec 1.2) defined as: The available capacity, in bytes, of the storage that can be used to provision volumes. If not set, that information is currently unavailable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacity#capacity
        /// </remarks>
        [JsiiProperty(name: "capacity", typeJson: "{\"fqn\":\"k8s.Quantity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.Quantity? Capacity
        {
            get
            {
                return null;
            }
        }

        /// <summary>maximumVolumeSize is the value reported by the CSI driver in its GetCapacityResponse for a GetCapacityRequest with topology and parameters that match the previous fields.</summary>
        /// <remarks>
        /// This is defined since CSI spec 1.4.0 as the largest size that may be used in a CreateVolumeRequest.capacity_range.required_bytes field to create a volume with the same parameters as those in GetCapacityRequest. The corresponding value in the Kubernetes API is ResourceRequirements.Requests in a volume claim.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacity#maximumVolumeSize
        /// </remarks>
        [JsiiProperty(name: "maximumVolumeSize", typeJson: "{\"fqn\":\"k8s.Quantity\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.Quantity? MaximumVolumeSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// The name has no particular meaning. It must be a DNS subdomain (dots allowed, 253 characters). To ensure that there are no conflicts with other CSI drivers on the cluster, the recommendation is to use csisc-<uuid xmlns="http://www.w3.org/1999/xhtml"></uuid>, a generated name, or a reverse-domain name which ends with the unique CSI driver name.
        ///
        /// Objects are namespaced.
        ///
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacity#metadata
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

        /// <summary>nodeTopology defines which nodes have access to the storage for which capacity was reported.</summary>
        /// <remarks>
        /// If not set, the storage is not accessible from any node in the cluster. If empty, the storage is accessible from all nodes. This field is immutable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacity#nodeTopology
        /// </remarks>
        [JsiiProperty(name: "nodeTopology", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILabelSelector? NodeTopology
        {
            get
            {
                return null;
            }
        }

        /// <summary>CSIStorageCapacity stores the result of one CSI GetCapacity call.</summary>
        /// <remarks>
        /// For a given StorageClass, this describes the available capacity in a particular topology segment.  This can be used when considering where to instantiate new PersistentVolumes.
        ///
        /// For example this can express things like: - StorageClass "standard" has "1234 GiB" available in "topology.kubernetes.io/zone=us-east1" - StorageClass "localssd" has "10 GiB" available in "kubernetes.io/hostname=knode-abc123"
        ///
        /// The following three cases all imply that no capacity is available for a certain combination: - no object exists with suitable topology and storage class name - such an object exists, but the capacity is unset - such an object exists, but the capacity is zero
        ///
        /// The producer of these objects can decide which approach is more suitable.
        ///
        /// They are consumed by the kube-scheduler when a CSI driver opts into capacity-aware scheduling with CSIDriverSpec.StorageCapacity. The scheduler compares the MaximumVolumeSize against the requested size of pending volumes to filter out unsuitable nodes. If MaximumVolumeSize is unset, it falls back to a comparison against the less precise Capacity. If that is also unset, the scheduler assumes that capacity is insufficient and tries some other node.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacity
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeCsiStorageCapacityProps), fullyQualifiedName: "k8s.KubeCsiStorageCapacityProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeCsiStorageCapacityProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>storageClassName represents the name of the StorageClass that the reported capacity applies to.</summary>
            /// <remarks>
            /// It must meet the same requirements as the name of a StorageClass object (non-empty, DNS subdomain). If that object no longer exists, the CSIStorageCapacity object is obsolete and should be removed by its creator. This field is immutable.
            ///
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacity#storageClassName
            /// </remarks>
            [JsiiProperty(name: "storageClassName", typeJson: "{\"primitive\":\"string\"}")]
            public string StorageClassName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>capacity is the value reported by the CSI driver in its GetCapacityResponse for a GetCapacityRequest with topology and parameters that match the previous fields.</summary>
            /// <remarks>
            /// The semantic is currently (CSI spec 1.2) defined as: The available capacity, in bytes, of the storage that can be used to provision volumes. If not set, that information is currently unavailable.
            ///
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacity#capacity
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "capacity", typeJson: "{\"fqn\":\"k8s.Quantity\"}", isOptional: true)]
            public K8s.Quantity? Capacity
            {
                get => GetInstanceProperty<K8s.Quantity?>();
            }

            /// <summary>maximumVolumeSize is the value reported by the CSI driver in its GetCapacityResponse for a GetCapacityRequest with topology and parameters that match the previous fields.</summary>
            /// <remarks>
            /// This is defined since CSI spec 1.4.0 as the largest size that may be used in a CreateVolumeRequest.capacity_range.required_bytes field to create a volume with the same parameters as those in GetCapacityRequest. The corresponding value in the Kubernetes API is ResourceRequirements.Requests in a volume claim.
            ///
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacity#maximumVolumeSize
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "maximumVolumeSize", typeJson: "{\"fqn\":\"k8s.Quantity\"}", isOptional: true)]
            public K8s.Quantity? MaximumVolumeSize
            {
                get => GetInstanceProperty<K8s.Quantity?>();
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// The name has no particular meaning. It must be a DNS subdomain (dots allowed, 253 characters). To ensure that there are no conflicts with other CSI drivers on the cluster, the recommendation is to use csisc-<uuid xmlns="http://www.w3.org/1999/xhtml"></uuid>, a generated name, or a reverse-domain name which ends with the unique CSI driver name.
            ///
            /// Objects are namespaced.
            ///
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacity#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>nodeTopology defines which nodes have access to the storage for which capacity was reported.</summary>
            /// <remarks>
            /// If not set, the storage is not accessible from any node in the cluster. If empty, the storage is accessible from all nodes. This field is immutable.
            ///
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIStorageCapacity#nodeTopology
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeTopology", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
            public K8s.ILabelSelector? NodeTopology
            {
                get => GetInstanceProperty<K8s.ILabelSelector?>();
            }
        }
    }
}
