using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ManagedFieldsEntry is a workflow-id, a FieldSet and the group version of the resource that the fieldset applies to.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ManagedFieldsEntry
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IManagedFieldsEntry), fullyQualifiedName: "k8s.ManagedFieldsEntry")]
    public interface IManagedFieldsEntry
    {
        /// <summary>APIVersion defines the version of this resource that this field set applies to.</summary>
        /// <remarks>
        /// The format is "group/version" just like the top-level APIVersion field. It is necessary to track the version of a field set because it cannot be automatically converted.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ManagedFieldsEntry#apiVersion
        /// </remarks>
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ApiVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>FieldsType is the discriminator for the different fields format and version.</summary>
        /// <remarks>
        /// There is currently only one possible value: "FieldsV1"
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ManagedFieldsEntry#fieldsType
        /// </remarks>
        [JsiiProperty(name: "fieldsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FieldsType
        {
            get
            {
                return null;
            }
        }

        /// <summary>FieldsV1 holds the first JSON version format as described in the "FieldsV1" type.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ManagedFieldsEntry#fieldsV1
        /// </remarks>
        [JsiiProperty(name: "fieldsV1", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? FieldsV1
        {
            get
            {
                return null;
            }
        }

        /// <summary>Manager is an identifier of the workflow managing these fields.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ManagedFieldsEntry#manager
        /// </remarks>
        [JsiiProperty(name: "manager", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Manager
        {
            get
            {
                return null;
            }
        }

        /// <summary>Operation is the type of operation which lead to this ManagedFieldsEntry being created.</summary>
        /// <remarks>
        /// The only valid values for this field are 'Apply' and 'Update'.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ManagedFieldsEntry#operation
        /// </remarks>
        [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Operation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Subresource is the name of the subresource used to update that object, or empty string if the object was updated through the main resource.</summary>
        /// <remarks>
        /// The value of this field is used to distinguish between managers, even if they share the same name. For example, a status update will be distinct from a regular update using the same manager name. Note that the APIVersion field is not related to the Subresource field and it always corresponds to the version of the main resource.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ManagedFieldsEntry#subresource
        /// </remarks>
        [JsiiProperty(name: "subresource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Subresource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Time is the timestamp of when the ManagedFields entry was added.</summary>
        /// <remarks>
        /// The timestamp will also be updated if a field is added, the manager changes any of the owned fields value or removes a field. The timestamp does not update when a field is removed from the entry because another manager took it over.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ManagedFieldsEntry#time
        /// </remarks>
        [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.DateTime? Time
        {
            get
            {
                return null;
            }
        }

        /// <summary>ManagedFieldsEntry is a workflow-id, a FieldSet and the group version of the resource that the fieldset applies to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ManagedFieldsEntry
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IManagedFieldsEntry), fullyQualifiedName: "k8s.ManagedFieldsEntry")]
        internal sealed class _Proxy : DeputyBase, K8s.IManagedFieldsEntry
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>APIVersion defines the version of this resource that this field set applies to.</summary>
            /// <remarks>
            /// The format is "group/version" just like the top-level APIVersion field. It is necessary to track the version of a field set because it cannot be automatically converted.
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ManagedFieldsEntry#apiVersion
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ApiVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>FieldsType is the discriminator for the different fields format and version.</summary>
            /// <remarks>
            /// There is currently only one possible value: "FieldsV1"
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ManagedFieldsEntry#fieldsType
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fieldsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FieldsType
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>FieldsV1 holds the first JSON version format as described in the "FieldsV1" type.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ManagedFieldsEntry#fieldsV1
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fieldsV1", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
            public object? FieldsV1
            {
                get => GetInstanceProperty<object?>();
            }

            /// <summary>Manager is an identifier of the workflow managing these fields.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ManagedFieldsEntry#manager
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "manager", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Manager
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Operation is the type of operation which lead to this ManagedFieldsEntry being created.</summary>
            /// <remarks>
            /// The only valid values for this field are 'Apply' and 'Update'.
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ManagedFieldsEntry#operation
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "operation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Operation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Subresource is the name of the subresource used to update that object, or empty string if the object was updated through the main resource.</summary>
            /// <remarks>
            /// The value of this field is used to distinguish between managers, even if they share the same name. For example, a status update will be distinct from a regular update using the same manager name. Note that the APIVersion field is not related to the Subresource field and it always corresponds to the version of the main resource.
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ManagedFieldsEntry#subresource
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subresource", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Subresource
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Time is the timestamp of when the ManagedFields entry was added.</summary>
            /// <remarks>
            /// The timestamp will also be updated if a field is added, the manager changes any of the owned fields value or removes a field. The timestamp does not update when a field is removed from the entry because another manager took it over.
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.ManagedFieldsEntry#time
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "time", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
            public System.DateTime? Time
            {
                get => GetInstanceProperty<System.DateTime?>();
            }
        }
    }
}
