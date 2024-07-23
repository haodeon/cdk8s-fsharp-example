using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IObjectMeta), fullyQualifiedName: "k8s.ObjectMeta")]
    public interface IObjectMeta
    {
        /// <summary>Annotations is an unstructured key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata.</summary>
        /// <remarks>
        /// They are not queryable and should be preserved when modifying objects. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#annotations
        /// </remarks>
        [JsiiProperty(name: "annotations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Annotations
        {
            get
            {
                return null;
            }
        }

        /// <summary>CreationTimestamp is a timestamp representing the server time when this object was created.</summary>
        /// <remarks>
        /// It is not guaranteed to be set in happens-before order across separate operations. Clients may not set this value. It is represented in RFC3339 form and is in UTC.
        ///
        /// Populated by the system. Read-only. Null for lists. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#creationTimestamp
        /// </remarks>
        [JsiiProperty(name: "creationTimestamp", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.DateTime? CreationTimestamp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Number of seconds allowed for this object to gracefully terminate before it will be removed from the system.</summary>
        /// <remarks>
        /// Only set when deletionTimestamp is also set. May only be shortened. Read-only.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#deletionGracePeriodSeconds
        /// </remarks>
        [JsiiProperty(name: "deletionGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeletionGracePeriodSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>DeletionTimestamp is RFC 3339 date and time at which this resource will be deleted.</summary>
        /// <remarks>
        /// This field is set by the server when a graceful deletion is requested by the user, and is not directly settable by a client. The resource is expected to be deleted (no longer visible from resource lists, and not reachable by name) after the time in this field, once the finalizers list is empty. As long as the finalizers list contains items, deletion is blocked. Once the deletionTimestamp is set, this value may not be unset or be set further into the future, although it may be shortened or the resource may be deleted prior to this time. For example, a user may request that a pod is deleted in 30 seconds. The Kubelet will react by sending a graceful termination signal to the containers in the pod. After that 30 seconds, the Kubelet will send a hard termination signal (SIGKILL) to the container and after cleanup, remove the pod from the API. In the presence of network partitions, this object may still exist after this timestamp, until an administrator or automated process can determine the resource is fully terminated. If not set, graceful deletion of the object has not been requested.
        ///
        /// Populated by the system when a graceful deletion is requested. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#deletionTimestamp
        /// </remarks>
        [JsiiProperty(name: "deletionTimestamp", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.DateTime? DeletionTimestamp
        {
            get
            {
                return null;
            }
        }

        /// <summary>Must be empty before the object is deleted from the registry.</summary>
        /// <remarks>
        /// Each entry is an identifier for the responsible component that will remove the entry from the list. If the deletionTimestamp of the object is non-nil, entries in this list can only be removed. Finalizers may be processed and removed in any order.  Order is NOT enforced because it introduces significant risk of stuck finalizers. finalizers is a shared field, any actor with permission can reorder it. If the finalizer list is processed in order, then this can lead to a situation in which the component responsible for the first finalizer in the list is waiting for a signal (field value, external system, or other) produced by a component responsible for a finalizer later in the list, resulting in a deadlock. Without enforced ordering finalizers are free to order amongst themselves and are not vulnerable to ordering changes in the list.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#finalizers
        /// </remarks>
        [JsiiProperty(name: "finalizers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Finalizers
        {
            get
            {
                return null;
            }
        }

        /// <summary>GenerateName is an optional prefix, used by the server, to generate a unique name ONLY IF the Name field has not been provided.</summary>
        /// <remarks>
        /// If this field is used, the name returned to the client will be different than the name passed. This value will also be combined with a unique suffix. The provided value has the same validation rules as the Name field, and may be truncated by the length of the suffix required to make the value unique on the server.
        ///
        /// If this field is specified and the generated name exists, the server will return a 409.
        ///
        /// Applied only if Name is not specified. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#idempotency
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#generateName
        /// </remarks>
        [JsiiProperty(name: "generateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? GenerateName
        {
            get
            {
                return null;
            }
        }

        /// <summary>A sequence number representing a specific generation of the desired state.</summary>
        /// <remarks>
        /// Populated by the system. Read-only.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#generation
        /// </remarks>
        [JsiiProperty(name: "generation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Generation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects.</summary>
        /// <remarks>
        /// May match selectors of replication controllers and services. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#labels
        /// </remarks>
        [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Labels
        {
            get
            {
                return null;
            }
        }

        /// <summary>ManagedFields maps workflow-id and version to the set of fields that are managed by that workflow.</summary>
        /// <remarks>
        /// This is mostly for internal housekeeping, and users typically shouldn't need to set or understand this field. A workflow can be the user's name, a controller's name, or the name of a specific apply path like "ci-cd". The set of fields is always in the version that the workflow used when modifying the object.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#managedFields
        /// </remarks>
        [JsiiProperty(name: "managedFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ManagedFieldsEntry\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IManagedFieldsEntry[]? ManagedFields
        {
            get
            {
                return null;
            }
        }

        /// <summary>Name must be unique within a namespace.</summary>
        /// <remarks>
        /// Is required when creating resources, although some resources may allow a client to request the generation of an appropriate name automatically. Name is primarily intended for creation idempotence and configuration definition. Cannot be updated. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names#names
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Namespace defines the space within which each name must be unique.</summary>
        /// <remarks>
        /// An empty namespace is equivalent to the "default" namespace, but "default" is the canonical representation. Not all objects are required to be scoped to a namespace - the value of this field for those objects will be empty.
        ///
        /// Must be a DNS_LABEL. Cannot be updated. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#namespace
        /// </remarks>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>List of objects depended by this object.</summary>
        /// <remarks>
        /// If ALL objects in the list have been deleted, this object will be garbage collected. If this object is managed by a controller, then an entry in this list will point to this controller, with the controller field set to true. There cannot be more than one managing controller.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#ownerReferences
        /// </remarks>
        [JsiiProperty(name: "ownerReferences", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.OwnerReference\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IOwnerReference[]? OwnerReferences
        {
            get
            {
                return null;
            }
        }

        /// <summary>An opaque value that represents the internal version of this object that can be used by clients to determine when objects have changed.</summary>
        /// <remarks>
        /// May be used for optimistic concurrency, change detection, and the watch operation on a resource or set of resources. Clients must treat these values as opaque and passed unmodified back to the server. They may only be valid for a particular resource or set of resources.
        ///
        /// Populated by the system. Read-only. Value must be treated as opaque by clients and . More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#resourceVersion
        /// </remarks>
        [JsiiProperty(name: "resourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>Deprecated: selfLink is a legacy read-only field that is no longer populated by the system.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#selfLink
        /// </remarks>
        [JsiiProperty(name: "selfLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SelfLink
        {
            get
            {
                return null;
            }
        }

        /// <summary>UID is the unique in time and space value for this object.</summary>
        /// <remarks>
        /// It is typically generated by the server on successful creation of a resource and is not allowed to change on PUT operations.
        ///
        /// Populated by the system. Read-only. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names#uids
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#uid
        /// </remarks>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uid
        {
            get
            {
                return null;
            }
        }

        /// <summary>ObjectMeta is metadata that all persisted resources must have, which includes all objects users must create.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IObjectMeta), fullyQualifiedName: "k8s.ObjectMeta")]
        internal sealed class _Proxy : DeputyBase, K8s.IObjectMeta
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Annotations is an unstructured key value map stored with a resource that may be set by external tools to store and retrieve arbitrary metadata.</summary>
            /// <remarks>
            /// They are not queryable and should be preserved when modifying objects. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/annotations
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#annotations
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "annotations", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Annotations
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>CreationTimestamp is a timestamp representing the server time when this object was created.</summary>
            /// <remarks>
            /// It is not guaranteed to be set in happens-before order across separate operations. Clients may not set this value. It is represented in RFC3339 form and is in UTC.
            ///
            /// Populated by the system. Read-only. Null for lists. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#creationTimestamp
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "creationTimestamp", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
            public System.DateTime? CreationTimestamp
            {
                get => GetInstanceProperty<System.DateTime?>();
            }

            /// <summary>Number of seconds allowed for this object to gracefully terminate before it will be removed from the system.</summary>
            /// <remarks>
            /// Only set when deletionTimestamp is also set. May only be shortened. Read-only.
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#deletionGracePeriodSeconds
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deletionGracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeletionGracePeriodSeconds
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>DeletionTimestamp is RFC 3339 date and time at which this resource will be deleted.</summary>
            /// <remarks>
            /// This field is set by the server when a graceful deletion is requested by the user, and is not directly settable by a client. The resource is expected to be deleted (no longer visible from resource lists, and not reachable by name) after the time in this field, once the finalizers list is empty. As long as the finalizers list contains items, deletion is blocked. Once the deletionTimestamp is set, this value may not be unset or be set further into the future, although it may be shortened or the resource may be deleted prior to this time. For example, a user may request that a pod is deleted in 30 seconds. The Kubelet will react by sending a graceful termination signal to the containers in the pod. After that 30 seconds, the Kubelet will send a hard termination signal (SIGKILL) to the container and after cleanup, remove the pod from the API. In the presence of network partitions, this object may still exist after this timestamp, until an administrator or automated process can determine the resource is fully terminated. If not set, graceful deletion of the object has not been requested.
            ///
            /// Populated by the system when a graceful deletion is requested. Read-only. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#deletionTimestamp
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deletionTimestamp", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
            public System.DateTime? DeletionTimestamp
            {
                get => GetInstanceProperty<System.DateTime?>();
            }

            /// <summary>Must be empty before the object is deleted from the registry.</summary>
            /// <remarks>
            /// Each entry is an identifier for the responsible component that will remove the entry from the list. If the deletionTimestamp of the object is non-nil, entries in this list can only be removed. Finalizers may be processed and removed in any order.  Order is NOT enforced because it introduces significant risk of stuck finalizers. finalizers is a shared field, any actor with permission can reorder it. If the finalizer list is processed in order, then this can lead to a situation in which the component responsible for the first finalizer in the list is waiting for a signal (field value, external system, or other) produced by a component responsible for a finalizer later in the list, resulting in a deadlock. Without enforced ordering finalizers are free to order amongst themselves and are not vulnerable to ordering changes in the list.
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#finalizers
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "finalizers", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Finalizers
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>GenerateName is an optional prefix, used by the server, to generate a unique name ONLY IF the Name field has not been provided.</summary>
            /// <remarks>
            /// If this field is used, the name returned to the client will be different than the name passed. This value will also be combined with a unique suffix. The provided value has the same validation rules as the Name field, and may be truncated by the length of the suffix required to make the value unique on the server.
            ///
            /// If this field is specified and the generated name exists, the server will return a 409.
            ///
            /// Applied only if Name is not specified. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#idempotency
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#generateName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "generateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? GenerateName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>A sequence number representing a specific generation of the desired state.</summary>
            /// <remarks>
            /// Populated by the system. Read-only.
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#generation
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "generation", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Generation
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Map of string keys and values that can be used to organize and categorize (scope and select) objects.</summary>
            /// <remarks>
            /// May match selectors of replication controllers and services. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#labels
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "labels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Labels
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>ManagedFields maps workflow-id and version to the set of fields that are managed by that workflow.</summary>
            /// <remarks>
            /// This is mostly for internal housekeeping, and users typically shouldn't need to set or understand this field. A workflow can be the user's name, a controller's name, or the name of a specific apply path like "ci-cd". The set of fields is always in the version that the workflow used when modifying the object.
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#managedFields
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "managedFields", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ManagedFieldsEntry\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IManagedFieldsEntry[]? ManagedFields
            {
                get => GetInstanceProperty<K8s.IManagedFieldsEntry[]?>();
            }

            /// <summary>Name must be unique within a namespace.</summary>
            /// <remarks>
            /// Is required when creating resources, although some resources may allow a client to request the generation of an appropriate name automatically. Name is primarily intended for creation idempotence and configuration definition. Cannot be updated. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names#names
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#name
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Namespace defines the space within which each name must be unique.</summary>
            /// <remarks>
            /// An empty namespace is equivalent to the "default" namespace, but "default" is the canonical representation. Not all objects are required to be scoped to a namespace - the value of this field for those objects will be empty.
            ///
            /// Must be a DNS_LABEL. Cannot be updated. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/namespaces
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#namespace
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>List of objects depended by this object.</summary>
            /// <remarks>
            /// If ALL objects in the list have been deleted, this object will be garbage collected. If this object is managed by a controller, then an entry in this list will point to this controller, with the controller field set to true. There cannot be more than one managing controller.
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#ownerReferences
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "ownerReferences", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.OwnerReference\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IOwnerReference[]? OwnerReferences
            {
                get => GetInstanceProperty<K8s.IOwnerReference[]?>();
            }

            /// <summary>An opaque value that represents the internal version of this object that can be used by clients to determine when objects have changed.</summary>
            /// <remarks>
            /// May be used for optimistic concurrency, change detection, and the watch operation on a resource or set of resources. Clients must treat these values as opaque and passed unmodified back to the server. They may only be valid for a particular resource or set of resources.
            ///
            /// Populated by the system. Read-only. Value must be treated as opaque by clients and . More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#concurrency-control-and-consistency
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#resourceVersion
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Deprecated: selfLink is a legacy read-only field that is no longer populated by the system.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#selfLink
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selfLink", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SelfLink
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>UID is the unique in time and space value for this object.</summary>
            /// <remarks>
            /// It is typically generated by the server on successful creation of a resource and is not allowed to change on PUT operations.
            ///
            /// Populated by the system. Read-only. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names#uids
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ObjectMeta#uid
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
