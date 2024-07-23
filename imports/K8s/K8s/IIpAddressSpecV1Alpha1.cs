using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>IPAddressSpec describe the attributes in an IP Address.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.IPAddressSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IIpAddressSpecV1Alpha1), fullyQualifiedName: "k8s.IpAddressSpecV1Alpha1")]
    public interface IIpAddressSpecV1Alpha1
    {
        /// <summary>ParentRef references the resource that an IPAddress is attached to.</summary>
        /// <remarks>
        /// An IPAddress must reference a parent object.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.IPAddressSpec#parentRef
        /// </remarks>
        [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"k8s.ParentReferenceV1Alpha1\"}")]
        K8s.IParentReferenceV1Alpha1 ParentRef
        {
            get;
        }

        /// <summary>IPAddressSpec describe the attributes in an IP Address.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.IPAddressSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IIpAddressSpecV1Alpha1), fullyQualifiedName: "k8s.IpAddressSpecV1Alpha1")]
        internal sealed class _Proxy : DeputyBase, K8s.IIpAddressSpecV1Alpha1
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ParentRef references the resource that an IPAddress is attached to.</summary>
            /// <remarks>
            /// An IPAddress must reference a parent object.
            ///
            /// <strong>Schema</strong>: io.k8s.api.networking.v1alpha1.IPAddressSpec#parentRef
            /// </remarks>
            [JsiiProperty(name: "parentRef", typeJson: "{\"fqn\":\"k8s.ParentReferenceV1Alpha1\"}")]
            public K8s.IParentReferenceV1Alpha1 ParentRef
            {
                get => GetInstanceProperty<K8s.IParentReferenceV1Alpha1>()!;
            }
        }
    }
}
