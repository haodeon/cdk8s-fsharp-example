using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ResourceClassParametersReference contains enough information to let you locate the parameters for a ResourceClass.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParametersReference
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ResourceClassParametersReferenceV1Alpha2")]
    public class ResourceClassParametersReferenceV1Alpha2 : K8s.IResourceClassParametersReferenceV1Alpha2
    {
        /// <summary>Kind is the type of resource being referenced.</summary>
        /// <remarks>
        /// This is the same value as in the parameter object's metadata.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParametersReference#kind
        /// </remarks>
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}")]
        public string Kind
        {
            get;
            set;
        }

        /// <summary>Name is the name of resource being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParametersReference#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>APIGroup is the group for the resource being referenced.</summary>
        /// <remarks>
        /// It is empty for the core API. This matches the group in the APIVersion that is used when creating the resources.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParametersReference#apiGroup
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiGroup", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiGroup
        {
            get;
            set;
        }

        /// <summary>Namespace that contains the referenced resource.</summary>
        /// <remarks>
        /// Must be empty for cluster-scoped resources and non-empty for namespaced resources.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParametersReference#namespace
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }
    }
}
