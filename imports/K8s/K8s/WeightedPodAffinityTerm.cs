using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>The weights of all of the matched WeightedPodAffinityTerm fields are added per-node to find the most preferred node(s).</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.WeightedPodAffinityTerm
    /// </remarks>
    [JsiiByValue(fqn: "k8s.WeightedPodAffinityTerm")]
    public class WeightedPodAffinityTerm : K8s.IWeightedPodAffinityTerm
    {
        /// <summary>Required.</summary>
        /// <remarks>
        /// A pod affinity term, associated with the corresponding weight.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.WeightedPodAffinityTerm#podAffinityTerm
        /// </remarks>
        [JsiiProperty(name: "podAffinityTerm", typeJson: "{\"fqn\":\"k8s.PodAffinityTerm\"}")]
        public K8s.IPodAffinityTerm PodAffinityTerm
        {
            get;
            set;
        }

        /// <summary>weight associated with matching the corresponding podAffinityTerm, in the range 1-100.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.WeightedPodAffinityTerm#weight
        /// </remarks>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        public double Weight
        {
            get;
            set;
        }
    }
}
