using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PodReadinessGate contains the reference to a pod condition.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PodReadinessGate
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PodReadinessGate")]
    public class PodReadinessGate : K8s.IPodReadinessGate
    {
        /// <summary>ConditionType refers to a condition in the pod's condition list with matching type.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodReadinessGate#conditionType
        /// </remarks>
        [JsiiProperty(name: "conditionType", typeJson: "{\"primitive\":\"string\"}")]
        public string ConditionType
        {
            get;
            set;
        }
    }
}
