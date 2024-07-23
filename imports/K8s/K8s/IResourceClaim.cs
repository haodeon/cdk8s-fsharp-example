using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceClaim
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IResourceClaim), fullyQualifiedName: "k8s.ResourceClaim")]
    public interface IResourceClaim
    {
        /// <summary>Name must match the name of one entry in pod.spec.resourceClaims of the Pod where this field is used. It makes that resource available inside a container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceClaim#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>ResourceClaim references one entry in PodSpec.ResourceClaims.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceClaim
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IResourceClaim), fullyQualifiedName: "k8s.ResourceClaim")]
        internal sealed class _Proxy : DeputyBase, K8s.IResourceClaim
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name must match the name of one entry in pod.spec.resourceClaims of the Pod where this field is used. It makes that resource available inside a container.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceClaim#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
