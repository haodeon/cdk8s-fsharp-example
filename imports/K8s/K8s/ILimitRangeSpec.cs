using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>LimitRangeSpec defines a min/max usage limit for resources that match on kind.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ILimitRangeSpec), fullyQualifiedName: "k8s.LimitRangeSpec")]
    public interface ILimitRangeSpec
    {
        /// <summary>Limits is the list of LimitRangeItem objects that are enforced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeSpec#limits
        /// </remarks>
        [JsiiProperty(name: "limits", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.LimitRangeItem\"},\"kind\":\"array\"}}")]
        K8s.ILimitRangeItem[] Limits
        {
            get;
        }

        /// <summary>LimitRangeSpec defines a min/max usage limit for resources that match on kind.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ILimitRangeSpec), fullyQualifiedName: "k8s.LimitRangeSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.ILimitRangeSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Limits is the list of LimitRangeItem objects that are enforced.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeSpec#limits
            /// </remarks>
            [JsiiProperty(name: "limits", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.LimitRangeItem\"},\"kind\":\"array\"}}")]
            public K8s.ILimitRangeItem[] Limits
            {
                get => GetInstanceProperty<K8s.ILimitRangeItem[]>()!;
            }
        }
    }
}
