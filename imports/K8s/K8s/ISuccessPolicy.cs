using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SuccessPolicy describes when a Job can be declared as succeeded based on the success of some indexes.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.SuccessPolicy
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ISuccessPolicy), fullyQualifiedName: "k8s.SuccessPolicy")]
    public interface ISuccessPolicy
    {
        /// <summary>rules represents the list of alternative rules for the declaring the Jobs as successful before `.status.succeeded &gt;= .spec.completions`. Once any of the rules are met, the "SucceededCriteriaMet" condition is added, and the lingering pods are removed. The terminal state for such a Job has the "Complete" condition. Additionally, these rules are evaluated in order; Once the Job meets one of the rules, other rules are ignored. At most 20 elements are allowed.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.SuccessPolicy#rules
        /// </remarks>
        [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.SuccessPolicyRule\"},\"kind\":\"array\"}}")]
        K8s.ISuccessPolicyRule[] Rules
        {
            get;
        }

        /// <summary>SuccessPolicy describes when a Job can be declared as succeeded based on the success of some indexes.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.SuccessPolicy
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ISuccessPolicy), fullyQualifiedName: "k8s.SuccessPolicy")]
        internal sealed class _Proxy : DeputyBase, K8s.ISuccessPolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>rules represents the list of alternative rules for the declaring the Jobs as successful before `.status.succeeded &gt;= .spec.completions`. Once any of the rules are met, the "SucceededCriteriaMet" condition is added, and the lingering pods are removed. The terminal state for such a Job has the "Complete" condition. Additionally, these rules are evaluated in order; Once the Job meets one of the rules, other rules are ignored. At most 20 elements are allowed.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.SuccessPolicy#rules
            /// </remarks>
            [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.SuccessPolicyRule\"},\"kind\":\"array\"}}")]
            public K8s.ISuccessPolicyRule[] Rules
            {
                get => GetInstanceProperty<K8s.ISuccessPolicyRule[]>()!;
            }
        }
    }
}
