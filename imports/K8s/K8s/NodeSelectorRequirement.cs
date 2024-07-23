using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>A node selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelectorRequirement
    /// </remarks>
    [JsiiByValue(fqn: "k8s.NodeSelectorRequirement")]
    public class NodeSelectorRequirement : K8s.INodeSelectorRequirement
    {
        /// <summary>The label key that the selector applies to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelectorRequirement#key
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Represents a key's relationship to a set of values.</summary>
        /// <remarks>
        /// Valid operators are In, NotIn, Exists, DoesNotExist. Gt, and Lt.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelectorRequirement#operator
        /// </remarks>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public string Operator
        {
            get;
            set;
        }

        /// <summary>An array of string values.</summary>
        /// <remarks>
        /// If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. If the operator is Gt or Lt, the values array must have a single element, which will be interpreted as an integer. This array is replaced during a strategic merge patch.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.NodeSelectorRequirement#values
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Values
        {
            get;
            set;
        }
    }
}
