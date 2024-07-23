using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>OwnerReference contains enough information to let you identify an owning object.</summary>
    /// <remarks>
    /// An owning object must be in the same namespace as the dependent, or be cluster-scoped, so there is no namespace field.
    ///
    /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.OwnerReference
    /// </remarks>
    [JsiiByValue(fqn: "k8s.OwnerReference")]
    public class OwnerReference : K8s.IOwnerReference
    {
        /// <summary>API version of the referent.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.OwnerReference#apiVersion
        /// </remarks>
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}")]
        public string ApiVersion
        {
            get;
            set;
        }

        /// <summary>Kind of the referent.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#types-kinds
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.OwnerReference#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <summary>Name of the referent.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names#names
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.OwnerReference#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>UID of the referent.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names#uids
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.OwnerReference#uid
        /// </remarks>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}")]
        public string Uid
        {
            get;
            set;
        }

        /// <summary>If true, AND if the owner has the "foregroundDeletion" finalizer, then the owner cannot be deleted from the key-value store until this reference is removed.</summary>
        /// <remarks>
        /// See https://kubernetes.io/docs/concepts/architecture/garbage-collection/#foreground-deletion for how the garbage collector interacts with this field and enforces the foreground deletion. Defaults to false. To set this field, a user needs "delete" permission of the owner, otherwise 422 (Unprocessable Entity) will be returned.
        ///
        /// <strong>Default</strong>: false. To set this field, a user needs "delete" permission of the owner, otherwise 422 (Unprocessable Entity) will be returned.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.OwnerReference#blockOwnerDeletion
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "blockOwnerDeletion", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? BlockOwnerDeletion
        {
            get;
            set;
        }

        /// <summary>If true, this reference points to the managing controller.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.OwnerReference#controller
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "controller", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? Controller
        {
            get;
            set;
        }
    }
}
