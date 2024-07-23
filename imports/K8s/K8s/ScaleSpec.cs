using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ScaleSpec describes the attributes of a scale subresource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.ScaleSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ScaleSpec")]
    public class ScaleSpec : K8s.IScaleSpec
    {
        /// <summary>replicas is the desired number of instances for the scaled object.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.autoscaling.v1.ScaleSpec#replicas
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "replicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Replicas
        {
            get;
            set;
        }
    }
}
