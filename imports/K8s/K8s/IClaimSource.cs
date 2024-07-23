using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ClaimSource describes a reference to a ResourceClaim.</summary>
    /// <remarks>
    /// Exactly one of these fields should be set.  Consumers of this type must treat an empty object as if it has an unknown value.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ClaimSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IClaimSource), fullyQualifiedName: "k8s.ClaimSource")]
    public interface IClaimSource
    {
        /// <summary>ResourceClaimName is the name of a ResourceClaim object in the same namespace as this pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClaimSource#resourceClaimName
        /// </remarks>
        [JsiiProperty(name: "resourceClaimName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceClaimName
        {
            get
            {
                return null;
            }
        }

        /// <summary>ResourceClaimTemplateName is the name of a ResourceClaimTemplate object in the same namespace as this pod.</summary>
        /// <remarks>
        /// The template will be used to create a new ResourceClaim, which will be bound to this pod. When this pod is deleted, the ResourceClaim will also be deleted. The pod name and resource name, along with a generated component, will be used to form a unique name for the ResourceClaim, which will be recorded in pod.status.resourceClaimStatuses.
        ///
        /// This field is immutable and no changes will be made to the corresponding ResourceClaim by the control plane after creating the ResourceClaim.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClaimSource#resourceClaimTemplateName
        /// </remarks>
        [JsiiProperty(name: "resourceClaimTemplateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceClaimTemplateName
        {
            get
            {
                return null;
            }
        }

        /// <summary>ClaimSource describes a reference to a ResourceClaim.</summary>
        /// <remarks>
        /// Exactly one of these fields should be set.  Consumers of this type must treat an empty object as if it has an unknown value.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ClaimSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IClaimSource), fullyQualifiedName: "k8s.ClaimSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IClaimSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ResourceClaimName is the name of a ResourceClaim object in the same namespace as this pod.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ClaimSource#resourceClaimName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceClaimName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceClaimName
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>ResourceClaimTemplateName is the name of a ResourceClaimTemplate object in the same namespace as this pod.</summary>
            /// <remarks>
            /// The template will be used to create a new ResourceClaim, which will be bound to this pod. When this pod is deleted, the ResourceClaim will also be deleted. The pod name and resource name, along with a generated component, will be used to form a unique name for the ResourceClaim, which will be recorded in pod.status.resourceClaimStatuses.
            ///
            /// This field is immutable and no changes will be made to the corresponding ResourceClaim by the control plane after creating the ResourceClaim.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ClaimSource#resourceClaimTemplateName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceClaimTemplateName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceClaimTemplateName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
