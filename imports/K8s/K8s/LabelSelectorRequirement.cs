using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>A label selector requirement is a selector that contains values, a key, and an operator that relates the key and values.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.LabelSelectorRequirement
    /// </remarks>
    [JsiiByValue(fqn: "k8s.LabelSelectorRequirement")]
    public class LabelSelectorRequirement : K8s.ILabelSelectorRequirement
    {
        /// <summary>key is the label key that the selector applies to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.LabelSelectorRequirement#key
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>operator represents a key's relationship to a set of values.</summary>
        /// <remarks>
        /// Valid operators are In, NotIn, Exists and DoesNotExist.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.LabelSelectorRequirement#operator
        /// </remarks>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        public string Operator
        {
            get;
            set;
        }

        /// <summary>values is an array of string values.</summary>
        /// <remarks>
        /// If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.LabelSelectorRequirement#values
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
