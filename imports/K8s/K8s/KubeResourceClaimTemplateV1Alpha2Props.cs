using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ResourceClaimTemplate is used to produce ResourceClaim objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplate
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeResourceClaimTemplateV1Alpha2Props")]
    public class KubeResourceClaimTemplateV1Alpha2Props : K8s.IKubeResourceClaimTemplateV1Alpha2Props
    {
        /// <summary>Describes the ResourceClaim that is to be generated.</summary>
        /// <remarks>
        /// This field is immutable. A ResourceClaim will get created by the control plane for a Pod when needed and then not get updated anymore.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplate#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ResourceClaimTemplateSpecV1Alpha2\"}")]
        public K8s.IResourceClaimTemplateSpecV1Alpha2 Spec
        {
            get;
            set;
        }

        /// <summary>Standard object metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplate#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }
    }
}
