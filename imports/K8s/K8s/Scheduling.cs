using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Scheduling specifies the scheduling constraints for nodes supporting a RuntimeClass.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.node.v1.Scheduling
    /// </remarks>
    [JsiiByValue(fqn: "k8s.Scheduling")]
    public class Scheduling : K8s.IScheduling
    {
        /// <summary>nodeSelector lists labels that must be present on nodes that support this RuntimeClass.</summary>
        /// <remarks>
        /// Pods using this RuntimeClass can only be scheduled to a node matched by this selector. The RuntimeClass nodeSelector is merged with a pod's existing nodeSelector. Any conflicts will cause the pod to be rejected in admission.
        ///
        /// <strong>Schema</strong>: io.k8s.api.node.v1.Scheduling#nodeSelector
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nodeSelector", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, string>? NodeSelector
        {
            get;
            set;
        }

        /// <summary>tolerations are appended (excluding duplicates) to pods running with this RuntimeClass during admission, effectively unioning the set of nodes tolerated by the pod and the RuntimeClass.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.node.v1.Scheduling#tolerations
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tolerations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Toleration\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IToleration[]? Tolerations
        {
            get;
            set;
        }
    }
}
