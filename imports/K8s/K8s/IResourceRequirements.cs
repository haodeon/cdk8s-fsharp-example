using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceRequirements describes the compute resource requirements.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceRequirements
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IResourceRequirements), fullyQualifiedName: "k8s.ResourceRequirements")]
    public interface IResourceRequirements
    {
        /// <summary>Claims lists the names of resources, defined in spec.resourceClaims, that are used by this container.</summary>
        /// <remarks>
        /// This is an alpha field and requires enabling the DynamicResourceAllocation feature gate.
        ///
        /// This field is immutable. It can only be set for containers.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceRequirements#claims
        /// </remarks>
        [JsiiProperty(name: "claims", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ResourceClaim\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IResourceClaim[]? Claims
        {
            get
            {
                return null;
            }
        }

        /// <summary>Limits describes the maximum amount of compute resources allowed.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceRequirements#limits
        /// </remarks>
        [JsiiProperty(name: "limits", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, K8s.Quantity>? Limits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Requests describes the minimum amount of compute resources required.</summary>
        /// <remarks>
        /// If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceRequirements#requests
        /// </remarks>
        [JsiiProperty(name: "requests", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, K8s.Quantity>? Requests
        {
            get
            {
                return null;
            }
        }

        /// <summary>ResourceRequirements describes the compute resource requirements.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceRequirements
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IResourceRequirements), fullyQualifiedName: "k8s.ResourceRequirements")]
        internal sealed class _Proxy : DeputyBase, K8s.IResourceRequirements
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Claims lists the names of resources, defined in spec.resourceClaims, that are used by this container.</summary>
            /// <remarks>
            /// This is an alpha field and requires enabling the DynamicResourceAllocation feature gate.
            ///
            /// This field is immutable. It can only be set for containers.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceRequirements#claims
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "claims", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ResourceClaim\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IResourceClaim[]? Claims
            {
                get => GetInstanceProperty<K8s.IResourceClaim[]?>();
            }

            /// <summary>Limits describes the maximum amount of compute resources allowed.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceRequirements#limits
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limits", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, K8s.Quantity>? Limits
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, K8s.Quantity>?>();
            }

            /// <summary>Requests describes the minimum amount of compute resources required.</summary>
            /// <remarks>
            /// If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceRequirements#requests
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requests", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, K8s.Quantity>? Requests
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, K8s.Quantity>?>();
            }
        }
    }
}
