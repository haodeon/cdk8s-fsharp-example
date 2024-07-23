using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceClaimTemplate is used to produce ResourceClaim objects.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplate
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeResourceClaimTemplateV1Alpha2Props), fullyQualifiedName: "k8s.KubeResourceClaimTemplateV1Alpha2Props")]
    public interface IKubeResourceClaimTemplateV1Alpha2Props
    {
        /// <summary>Describes the ResourceClaim that is to be generated.</summary>
        /// <remarks>
        /// This field is immutable. A ResourceClaim will get created by the control plane for a Pod when needed and then not get updated anymore.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplate#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ResourceClaimTemplateSpecV1Alpha2\"}")]
        K8s.IResourceClaimTemplateSpecV1Alpha2 Spec
        {
            get;
        }

        /// <summary>Standard object metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplate#metadata
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

        /// <summary>ResourceClaimTemplate is used to produce ResourceClaim objects.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplate
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeResourceClaimTemplateV1Alpha2Props), fullyQualifiedName: "k8s.KubeResourceClaimTemplateV1Alpha2Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeResourceClaimTemplateV1Alpha2Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Describes the ResourceClaim that is to be generated.</summary>
            /// <remarks>
            /// This field is immutable. A ResourceClaim will get created by the control plane for a Pod when needed and then not get updated anymore.
            ///
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplate#spec
            /// </remarks>
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ResourceClaimTemplateSpecV1Alpha2\"}")]
            public K8s.IResourceClaimTemplateSpecV1Alpha2 Spec
            {
                get => GetInstanceProperty<K8s.IResourceClaimTemplateSpecV1Alpha2>()!;
            }

            /// <summary>Standard object metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaimTemplate#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }
        }
    }
}
