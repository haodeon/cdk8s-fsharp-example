using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PodSchedulingGate is associated to a Pod to guard its scheduling.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSchedulingGate
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PodSchedulingGate")]
    public class PodSchedulingGate : K8s.IPodSchedulingGate
    {
        /// <summary>Name of the scheduling gate.</summary>
        /// <remarks>
        /// Each scheduling gate must have a unique name field.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSchedulingGate#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
