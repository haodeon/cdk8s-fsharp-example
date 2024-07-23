using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodResourceClaim references exactly one ResourceClaim through a ClaimSource.</summary>
    /// <remarks>
    /// It adds a name to it that uniquely identifies the ResourceClaim inside the Pod. Containers that need access to the ResourceClaim reference it with this name.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PodResourceClaim
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPodResourceClaim), fullyQualifiedName: "k8s.PodResourceClaim")]
    public interface IPodResourceClaim
    {
        /// <summary>Name uniquely identifies this resource claim inside the pod.</summary>
        /// <remarks>
        /// This must be a DNS_LABEL.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodResourceClaim#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Source describes where to find the ResourceClaim.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodResourceClaim#source
        /// </remarks>
        [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"k8s.ClaimSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IClaimSource? Source
        {
            get
            {
                return null;
            }
        }

        /// <summary>PodResourceClaim references exactly one ResourceClaim through a ClaimSource.</summary>
        /// <remarks>
        /// It adds a name to it that uniquely identifies the ResourceClaim inside the Pod. Containers that need access to the ResourceClaim reference it with this name.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodResourceClaim
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPodResourceClaim), fullyQualifiedName: "k8s.PodResourceClaim")]
        internal sealed class _Proxy : DeputyBase, K8s.IPodResourceClaim
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name uniquely identifies this resource claim inside the pod.</summary>
            /// <remarks>
            /// This must be a DNS_LABEL.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodResourceClaim#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Source describes where to find the ResourceClaim.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodResourceClaim#source
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "source", typeJson: "{\"fqn\":\"k8s.ClaimSource\"}", isOptional: true)]
            public K8s.IClaimSource? Source
            {
                get => GetInstanceProperty<K8s.IClaimSource?>();
            }
        }
    }
}
