using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodReadinessGate contains the reference to a pod condition.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PodReadinessGate
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPodReadinessGate), fullyQualifiedName: "k8s.PodReadinessGate")]
    public interface IPodReadinessGate
    {
        /// <summary>ConditionType refers to a condition in the pod's condition list with matching type.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodReadinessGate#conditionType
        /// </remarks>
        [JsiiProperty(name: "conditionType", typeJson: "{\"primitive\":\"string\"}")]
        string ConditionType
        {
            get;
        }

        /// <summary>PodReadinessGate contains the reference to a pod condition.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodReadinessGate
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPodReadinessGate), fullyQualifiedName: "k8s.PodReadinessGate")]
        internal sealed class _Proxy : DeputyBase, K8s.IPodReadinessGate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ConditionType refers to a condition in the pod's condition list with matching type.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodReadinessGate#conditionType
            /// </remarks>
            [JsiiProperty(name: "conditionType", typeJson: "{\"primitive\":\"string\"}")]
            public string ConditionType
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
