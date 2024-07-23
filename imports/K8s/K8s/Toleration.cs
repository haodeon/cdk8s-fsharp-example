using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>The pod this Toleration is attached to tolerates any taint that matches the triple &lt;key,value,effect&gt; using the matching operator &lt;operator&gt;.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Toleration
    /// </remarks>
    [JsiiByValue(fqn: "k8s.Toleration")]
    public class Toleration : K8s.IToleration
    {
        /// <summary>Effect indicates the taint effect to match.</summary>
        /// <remarks>
        /// Empty means match all taint effects. When specified, allowed values are NoSchedule, PreferNoSchedule and NoExecute.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Toleration#effect
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Effect
        {
            get;
            set;
        }

        /// <summary>Key is the taint key that the toleration applies to.</summary>
        /// <remarks>
        /// Empty means match all taint keys. If the key is empty, operator must be Exists; this combination means to match all values and all keys.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Toleration#key
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Key
        {
            get;
            set;
        }

        /// <summary>Operator represents a key's relationship to the value.</summary>
        /// <remarks>
        /// Valid operators are Exists and Equal. Defaults to Equal. Exists is equivalent to wildcard for value, so that a pod can tolerate all taints of a particular category.
        ///
        /// <strong>Default</strong>: Equal. Exists is equivalent to wildcard for value, so that a pod can tolerate all taints of a particular category.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Toleration#operator
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Operator
        {
            get;
            set;
        }

        /// <summary>TolerationSeconds represents the period of time the toleration (which must be of effect NoExecute, otherwise this field is ignored) tolerates the taint.</summary>
        /// <remarks>
        /// By default, it is not set, which means tolerate the taint forever (do not evict). Zero and negative values will be treated as 0 (evict immediately) by the system.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Toleration#tolerationSeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tolerationSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TolerationSeconds
        {
            get;
            set;
        }

        /// <summary>Value is the taint value the toleration matches to.</summary>
        /// <remarks>
        /// If the operator is Exists, the value should be empty, otherwise just a regular string.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Toleration#value
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