using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceClaim describes which resources are needed by a resource consumer.</summary>
    /// <remarks>
    /// Its status tracks whether the resource has been allocated and what the resulting attributes are.
    ///
    /// This is an alpha type and requires enabling the DynamicResourceAllocation feature gate.
    ///
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaim
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeResourceClaimV1Alpha2Props), fullyQualifiedName: "k8s.KubeResourceClaimV1Alpha2Props")]
    public interface IKubeResourceClaimV1Alpha2Props
    {
        /// <summary>Spec describes the desired attributes of a resource that then needs to be allocated.</summary>
        /// <remarks>
        /// It can only be set once when creating the ResourceClaim.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaim#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ResourceClaimSpecV1Alpha2\"}")]
        K8s.IResourceClaimSpecV1Alpha2 Spec
        {
            get;
        }

        /// <summary>Standard object metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaim#metadata
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

        /// <summary>ResourceClaim describes which resources are needed by a resource consumer.</summary>
        /// <remarks>
        /// Its status tracks whether the resource has been allocated and what the resulting attributes are.
        ///
        /// This is an alpha type and requires enabling the DynamicResourceAllocation feature gate.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaim
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeResourceClaimV1Alpha2Props), fullyQualifiedName: "k8s.KubeResourceClaimV1Alpha2Props")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeResourceClaimV1Alpha2Props
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Spec describes the desired attributes of a resource that then needs to be allocated.</summary>
            /// <remarks>
            /// It can only be set once when creating the ResourceClaim.
            ///
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaim#spec
            /// </remarks>
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.ResourceClaimSpecV1Alpha2\"}")]
            public K8s.IResourceClaimSpecV1Alpha2 Spec
            {
                get => GetInstanceProperty<K8s.IResourceClaimSpecV1Alpha2>()!;
            }

            /// <summary>Standard object metadata.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClaim#metadata
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
