using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>LimitRangeSpec defines a min/max usage limit for resources that match on kind.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.LimitRangeSpec")]
    public class LimitRangeSpec : K8s.ILimitRangeSpec
    {
        /// <summary>Limits is the list of LimitRangeItem objects that are enforced.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LimitRangeSpec#limits
        /// </remarks>
        [JsiiProperty(name: "limits", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.LimitRangeItem\"},\"kind\":\"array\"}}")]
        public K8s.ILimitRangeItem[] Limits
        {
            get;
            set;
        }
    }
}
