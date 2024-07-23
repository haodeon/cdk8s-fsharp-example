using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodSchedulingContextSpec describes where resources for the Pod are needed.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PodSchedulingContextSpecV1Alpha2")]
    public class PodSchedulingContextSpecV1Alpha2 : K8s.IPodSchedulingContextSpecV1Alpha2
    {
        /// <summary>PotentialNodes lists nodes where the Pod might be able to run.</summary>
        /// <remarks>
        /// The size of this field is limited to 128. This is large enough for many clusters. Larger clusters may need more attempts to find a node that suits all pending resources. This may get increased in the future, but not reduced.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextSpec#potentialNodes
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "potentialNodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? PotentialNodes
        {
            get;
            set;
        }

        /// <summary>SelectedNode is the node for which allocation of ResourceClaims that are referenced by the Pod and that use "WaitForFirstConsumer" allocation is to be attempted.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextSpec#selectedNode
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "selectedNode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SelectedNode
        {
            get;
            set;
        }
    }
}
