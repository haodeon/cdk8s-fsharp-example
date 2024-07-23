using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PersistentVolumeClaimSpec describes the common attributes of storage devices and allows a Source for provider-specific attributes.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPersistentVolumeClaimSpec), fullyQualifiedName: "k8s.PersistentVolumeClaimSpec")]
    public interface IPersistentVolumeClaimSpec
    {
        /// <summary>accessModes contains the desired access modes the volume should have.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#accessModes
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

        /// <summary>dataSource field can be used to specify either: * An existing VolumeSnapshot object (snapshot.storage.k8s.io/VolumeSnapshot) * An existing PVC (PersistentVolumeClaim) If the provisioner or an external controller can support the specified data source, it will create a new volume based on the contents of the specified data source. When the AnyVolumeDataSource feature gate is enabled, dataSource contents will be copied to dataSourceRef, and dataSourceRef contents will be copied to dataSource when dataSourceRef.namespace is not specified. If the namespace is specified, then dataSourceRef will not be copied to dataSource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#dataSource
        /// </remarks>
        [JsiiProperty(name: "dataSource", typeJson: "{\"fqn\":\"k8s.TypedLocalObjectReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ITypedLocalObjectReference? DataSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>dataSourceRef specifies the object from which to populate the volume with data, if a non-empty volume is desired.</summary>
        /// <remarks>
        /// This may be any object from a non-empty API group (non core object) or a PersistentVolumeClaim object. When this field is specified, volume binding will only succeed if the type of the specified object matches some installed volume populator or dynamic provisioner. This field will replace the functionality of the dataSource field and as such if both fields are non-empty, they must have the same value. For backwards compatibility, when namespace isn't specified in dataSourceRef, both fields (dataSource and dataSourceRef) will be set to the same value automatically if one of them is empty and the other is non-empty. When namespace is specified in dataSourceRef, dataSource isn't set to the same value and must be empty. There are three important differences between dataSource and dataSourceRef: * While dataSource only allows two specific types of objects, dataSourceRef
        /// allows any non-core object, as well as PersistentVolumeClaim objects.
        ///
        /// <list type="bullet">
        /// <description>While dataSource ignores disallowed values (dropping them), dataSourceRef
        /// preserves all values, and generates an error if a disallowed value is
        /// specified.</description>
        /// <description>While dataSource only allows local objects, dataSourceRef allows objects
        /// in any namespaces.
        /// (Beta) Using this field requires the AnyVolumeDataSource feature gate to be enabled. (Alpha) Using the namespace field of dataSourceRef requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#dataSourceRef
        /// </remarks>
        [JsiiProperty(name: "dataSourceRef", typeJson: "{\"fqn\":\"k8s.TypedObjectReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ITypedObjectReference? DataSourceRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>resources represents the minimum resources the volume should have.</summary>
        /// <remarks>
        /// If RecoverVolumeExpansionFailure feature is enabled users are allowed to specify resource requirements that are lower than previous value but must still be higher than capacity recorded in the status field of the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#resources
        /// </remarks>
        [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"k8s.VolumeResourceRequirements\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IVolumeResourceRequirements? Resources
        {
            get
            {
                return null;
            }
        }

        /// <summary>selector is a label query over volumes to consider for binding.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#selector
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILabelSelector? Selector
        {
            get
            {
                return null;
            }
        }

        /// <summary>storageClassName is the name of the StorageClass required by the claim.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#class-1
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#storageClassName
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

        /// <summary>volumeAttributesClassName may be used to set the VolumeAttributesClass used by this claim.</summary>
        /// <remarks>
        /// If specified, the CSI driver will create or update the volume with the attributes defined in the corresponding VolumeAttributesClass. This has a different purpose than storageClassName, it can be changed after the claim is created. An empty string value means that no VolumeAttributesClass will be applied to the claim but it's not allowed to reset this field to empty string once it is set. If unspecified and the PersistentVolumeClaim is unbound, the default VolumeAttributesClass will be set by the persistentvolume controller if it exists. If the resource referred to by volumeAttributesClass does not exist, this PersistentVolumeClaim will be set to a Pending state, as reflected by the modifyVolumeStatus field, until such as a resource exists. More info: https://kubernetes.io/docs/concepts/storage/volume-attributes-classes/ (Alpha) Using this field requires the VolumeAttributesClass feature gate to be enabled.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#volumeAttributesClassName
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

        /// <summary>volumeMode defines what type of volume is required by the claim.</summary>
        /// <remarks>
        /// Value of Filesystem is implied when not included in claim spec.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#volumeMode
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

        /// <summary>volumeName is the binding reference to the PersistentVolume backing this claim.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#volumeName
        /// </remarks>
        [JsiiProperty(name: "volumeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? VolumeName
        {
            get
            {
                return null;
            }
        }

        /// <summary>PersistentVolumeClaimSpec describes the common attributes of storage devices and allows a Source for provider-specific attributes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPersistentVolumeClaimSpec), fullyQualifiedName: "k8s.PersistentVolumeClaimSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.IPersistentVolumeClaimSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>accessModes contains the desired access modes the volume should have.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#access-modes-1
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#accessModes
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessModes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? AccessModes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>dataSource field can be used to specify either: * An existing VolumeSnapshot object (snapshot.storage.k8s.io/VolumeSnapshot) * An existing PVC (PersistentVolumeClaim) If the provisioner or an external controller can support the specified data source, it will create a new volume based on the contents of the specified data source. When the AnyVolumeDataSource feature gate is enabled, dataSource contents will be copied to dataSourceRef, and dataSourceRef contents will be copied to dataSource when dataSourceRef.namespace is not specified. If the namespace is specified, then dataSourceRef will not be copied to dataSource.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#dataSource
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataSource", typeJson: "{\"fqn\":\"k8s.TypedLocalObjectReference\"}", isOptional: true)]
            public K8s.ITypedLocalObjectReference? DataSource
            {
                get => GetInstanceProperty<K8s.ITypedLocalObjectReference?>();
            }

            /// <summary>dataSourceRef specifies the object from which to populate the volume with data, if a non-empty volume is desired.</summary>
            /// <remarks>
            /// This may be any object from a non-empty API group (non core object) or a PersistentVolumeClaim object. When this field is specified, volume binding will only succeed if the type of the specified object matches some installed volume populator or dynamic provisioner. This field will replace the functionality of the dataSource field and as such if both fields are non-empty, they must have the same value. For backwards compatibility, when namespace isn't specified in dataSourceRef, both fields (dataSource and dataSourceRef) will be set to the same value automatically if one of them is empty and the other is non-empty. When namespace is specified in dataSourceRef, dataSource isn't set to the same value and must be empty. There are three important differences between dataSource and dataSourceRef: * While dataSource only allows two specific types of objects, dataSourceRef
            /// allows any non-core object, as well as PersistentVolumeClaim objects.
            ///
            /// <list type="bullet">
            /// <description>While dataSource ignores disallowed values (dropping them), dataSourceRef
            /// preserves all values, and generates an error if a disallowed value is
            /// specified.</description>
            /// <description>While dataSource only allows local objects, dataSourceRef allows objects
            /// in any namespaces.
            /// (Beta) Using this field requires the AnyVolumeDataSource feature gate to be enabled. (Alpha) Using the namespace field of dataSourceRef requires the CrossNamespaceVolumeDataSource feature gate to be enabled.</description>
            /// </list>
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#dataSourceRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "dataSourceRef", typeJson: "{\"fqn\":\"k8s.TypedObjectReference\"}", isOptional: true)]
            public K8s.ITypedObjectReference? DataSourceRef
            {
                get => GetInstanceProperty<K8s.ITypedObjectReference?>();
            }

            /// <summary>resources represents the minimum resources the volume should have.</summary>
            /// <remarks>
            /// If RecoverVolumeExpansionFailure feature is enabled users are allowed to specify resource requirements that are lower than previous value but must still be higher than capacity recorded in the status field of the claim. More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#resources
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#resources
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resources", typeJson: "{\"fqn\":\"k8s.VolumeResourceRequirements\"}", isOptional: true)]
            public K8s.IVolumeResourceRequirements? Resources
            {
                get => GetInstanceProperty<K8s.IVolumeResourceRequirements?>();
            }

            /// <summary>selector is a label query over volumes to consider for binding.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#selector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
            public K8s.ILabelSelector? Selector
            {
                get => GetInstanceProperty<K8s.ILabelSelector?>();
            }

            /// <summary>storageClassName is the name of the StorageClass required by the claim.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#class-1
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#storageClassName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "storageClassName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? StorageClassName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>volumeAttributesClassName may be used to set the VolumeAttributesClass used by this claim.</summary>
            /// <remarks>
            /// If specified, the CSI driver will create or update the volume with the attributes defined in the corresponding VolumeAttributesClass. This has a different purpose than storageClassName, it can be changed after the claim is created. An empty string value means that no VolumeAttributesClass will be applied to the claim but it's not allowed to reset this field to empty string once it is set. If unspecified and the PersistentVolumeClaim is unbound, the default VolumeAttributesClass will be set by the persistentvolume controller if it exists. If the resource referred to by volumeAttributesClass does not exist, this PersistentVolumeClaim will be set to a Pending state, as reflected by the modifyVolumeStatus field, until such as a resource exists. More info: https://kubernetes.io/docs/concepts/storage/volume-attributes-classes/ (Alpha) Using this field requires the VolumeAttributesClass feature gate to be enabled.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#volumeAttributesClassName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeAttributesClassName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeAttributesClassName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>volumeMode defines what type of volume is required by the claim.</summary>
            /// <remarks>
            /// Value of Filesystem is implied when not included in claim spec.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#volumeMode
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeMode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeMode
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>volumeName is the binding reference to the PersistentVolume backing this claim.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimSpec#volumeName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "volumeName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? VolumeName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
