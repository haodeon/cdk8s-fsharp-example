using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>The node this Taint is attached to has the "effect" on any pod that does not tolerate the Taint.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Taint
    /// </remarks>
    [JsiiByValue(fqn: "k8s.Taint")]
    public class Taint : K8s.ITaint
    {
        /// <summary>Required.</summary>
        /// <remarks>
        /// The effect of the taint on pods that do not tolerate the taint. Valid effects are NoSchedule, PreferNoSchedule and NoExecute.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Taint#effect
        /// </remarks>
        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}")]
        public string Effect
        {
            get;
            set;
        }

        /// <summary>Required.</summary>
        /// <remarks>
        /// The taint key to be applied to a node.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Taint#key
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>TimeAdded represents the time at which the taint was added.</summary>
        /// <remarks>
        /// It is only written for NoExecute taints.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Taint#timeAdded
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeAdded", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
        public System.DateTime? TimeAdded
        {
            get;
            set;
        }

        /// <summary>The taint value corresponding to the taint key.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Taint#value
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }
    }
}
