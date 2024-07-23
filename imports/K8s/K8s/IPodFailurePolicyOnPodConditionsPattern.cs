using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodFailurePolicyOnPodConditionsPattern describes a pattern for matching an actual pod condition type.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnPodConditionsPattern
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPodFailurePolicyOnPodConditionsPattern), fullyQualifiedName: "k8s.PodFailurePolicyOnPodConditionsPattern")]
    public interface IPodFailurePolicyOnPodConditionsPattern
    {
        /// <summary>Specifies the required Pod condition status.</summary>
        /// <remarks>
        /// To match a pod condition it is required that the specified status equals the pod condition status. Defaults to True.
        ///
        /// <strong>Default</strong>: True.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnPodConditionsPattern#status
        /// </remarks>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        /// <summary>Specifies the required Pod condition type.</summary>
        /// <remarks>
        /// To match a pod condition it is required that specified type equals the pod condition type.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnPodConditionsPattern#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>PodFailurePolicyOnPodConditionsPattern describes a pattern for matching an actual pod condition type.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnPodConditionsPattern
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPodFailurePolicyOnPodConditionsPattern), fullyQualifiedName: "k8s.PodFailurePolicyOnPodConditionsPattern")]
        internal sealed class _Proxy : DeputyBase, K8s.IPodFailurePolicyOnPodConditionsPattern
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Specifies the required Pod condition status.</summary>
            /// <remarks>
            /// To match a pod condition it is required that the specified status equals the pod condition status. Defaults to True.
            ///
            /// <strong>Default</strong>: True.
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnPodConditionsPattern#status
            /// </remarks>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Specifies the required Pod condition type.</summary>
            /// <remarks>
            /// To match a pod condition it is required that specified type equals the pod condition type.
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.PodFailurePolicyOnPodConditionsPattern#type
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
