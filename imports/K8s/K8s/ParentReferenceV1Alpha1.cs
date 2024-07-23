using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ParentReference describes a reference to a parent object.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ParentReference
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ParentReferenceV1Alpha1")]
    public class ParentReferenceV1Alpha1 : K8s.IParentReferenceV1Alpha1
    {
        /// <summary>Name is the name of the object being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ParentReference#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Resource is the resource of the object being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ParentReference#resource
        /// </remarks>
        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}")]
        public string Resource
        {
            get;
            set;
        }

        /// <summary>Group is the group of the object being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ParentReference#group
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "group", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Group
        {
            get;
            set;
        }

        /// <summary>Namespace is the namespace of the object being referenced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.ParentReference#namespace
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
