using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodFailurePolicy describes how failed pods influence the backoffLimit.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicy
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPodFailurePolicy), fullyQualifiedName: "k8s.PodFailurePolicy")]
    public interface IPodFailurePolicy
    {
        /// <summary>A list of pod failure policy rules.</summary>
        /// <remarks>
        /// The rules are evaluated in order. Once a rule matches a Pod failure, the remaining of the rules are ignored. When no rule matches the Pod failure, the default handling applies - the counter of pod failures is incremented and it is checked against the backoffLimit. At most 20 elements are allowed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicy#rules
        /// </remarks>
        [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.PodFailurePolicyRule\"},\"kind\":\"array\"}}")]
        K8s.IPodFailurePolicyRule[] Rules
        {
            get;
        }

        /// <summary>PodFailurePolicy describes how failed pods influence the backoffLimit.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicy
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPodFailurePolicy), fullyQualifiedName: "k8s.PodFailurePolicy")]
        internal sealed class _Proxy : DeputyBase, K8s.IPodFailurePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A list of pod failure policy rules.</summary>
            /// <remarks>
            /// The rules are evaluated in order. Once a rule matches a Pod failure, the remaining of the rules are ignored. When no rule matches the Pod failure, the default handling applies - the counter of pod failures is incremented and it is checked against the backoffLimit. At most 20 elements are allowed.
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicy#rules
            /// </remarks>
            [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.PodFailurePolicyRule\"},\"kind\":\"array\"}}")]
            public K8s.IPodFailurePolicyRule[] Rules
            {
                get => GetInstanceProperty<K8s.IPodFailurePolicyRule[]>()!;
            }
        }
    }
}
