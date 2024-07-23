using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>DeleteOptions may be provided when deleting an API object.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.DeleteOptions
    /// </remarks>
    [JsiiByValue(fqn: "k8s.DeleteOptions")]
    public class DeleteOptions : K8s.IDeleteOptions
    {
        /// <summary>APIVersion defines the versioned schema of this representation of an object.</summary>
        /// <remarks>
        /// Servers should convert recognized schemas to the latest internal value, and may reject unrecognized values. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#resources
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.DeleteOptions#apiVersion
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiVersion
        {
            get;
            set;
        }

        /// <summary>When present, indicates that modifications should not be persisted.</summary>
        /// <remarks>
        /// An invalid or unrecognized dryRun directive will result in an error response and no further processing of the request. Valid values are: - All: all dry run stages will be processed
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.DeleteOptions#dryRun
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "dryRun", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? DryRun
        {
            get;
            set;
        }

        /// <summary>The duration in seconds before the object should be deleted.</summary>
        /// <remarks>
        /// Value must be non-negative integer. The value zero indicates delete immediately. If this value is nil, the default grace period for the specified type will be used. Defaults to a per object value if not specified. zero means delete immediately.
        ///
        /// <strong>Default</strong>: a per object value if not specified. zero means delete immediately.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.DeleteOptions#gracePeriodSeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "gracePeriodSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? GracePeriodSeconds
        {
            get;
            set;
        }

        /// <summary>Kind is a string value representing the REST resource this object represents.</summary>
        /// <remarks>
        /// Servers may infer this from the endpoint the client submits requests to. Cannot be updated. In CamelCase. More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.DeleteOptions#kind
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kind", typeJson: "{\"fqn\":\"k8s.IoK8SApimachineryPkgApisMetaV1DeleteOptionsKind\"}", isOptional: true)]
        public K8s.IoK8SApimachineryPkgApisMetaV1DeleteOptionsKind? Kind
        {
            get;
            set;
        }

        /// <summary>Deprecated: please use the PropagationPolicy, this field will be deprecated in 1.7. Should the dependent objects be orphaned. If true/false, the "orphan" finalizer will be added to/removed from the object's finalizers list. Either this field or PropagationPolicy may be set, but not both.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.DeleteOptions#orphanDependents
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "orphanDependents", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? OrphanDependents
        {
            get;
            set;
        }

        /// <summary>Must be fulfilled before a deletion is carried out.</summary>
        /// <remarks>
        /// If not possible, a 409 Conflict status will be returned.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.DeleteOptions#preconditions
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "preconditions", typeJson: "{\"fqn\":\"k8s.Preconditions\"}", isOptional: true)]
        public K8s.IPreconditions? Preconditions
        {
            get;
            set;
        }

        /// <summary>Whether and how garbage collection will be performed.</summary>
        /// <remarks>
        /// Either this field or OrphanDependents may be set, but not both. The default policy is decided by the existing finalizer set in the metadata.finalizers and the resource-specific default policy. Acceptable values are: 'Orphan' - orphan the dependents; 'Background' - allow the garbage collector to delete the dependents in the background; 'Foreground' - a cascading policy that deletes all dependents in the foreground.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.DeleteOptions#propagationPolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "propagationPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PropagationPolicy
        {
            get;
            set;
        }
    }
}
