using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PodSchedulingContext objects hold information that is needed to schedule a Pod with ResourceClaims that use "WaitForFirstConsumer" allocation mode.</summary>
    /// <remarks>
    /// This is an alpha type and requires enabling the DynamicResourceAllocation feature gate.
    ///
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContext
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubePodSchedulingContextV1Alpha2Props")]
    public class KubePodSchedulingContextV1Alpha2Props : K8s.IKubePodSchedulingContextV1Alpha2Props
    {
        /// <summary>Spec describes where resources for the Pod are needed.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContext#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.PodSchedulingContextSpecV1Alpha2\"}")]
        public K8s.IPodSchedulingContextSpecV1Alpha2 Spec
        {
            get;
            set;
        }

        /// <summary>Standard object metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContext#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }
    }
}
