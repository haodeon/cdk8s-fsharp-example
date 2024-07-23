using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>A label selector is a label query over a set of resources.</summary>
    /// <remarks>
    /// The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.
    ///
    /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.LabelSelector
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ILabelSelector), fullyQualifiedName: "k8s.LabelSelector")]
    public interface ILabelSelector
    {
        /// <summary>matchExpressions is a list of label selector requirements.</summary>
        /// <remarks>
        /// The requirements are ANDed.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.LabelSelector#matchExpressions
        /// </remarks>
        [JsiiProperty(name: "matchExpressions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.LabelSelectorRequirement\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILabelSelectorRequirement[]? MatchExpressions
        {
            get
            {
                return null;
            }
        }

        /// <summary>matchLabels is a map of {key,value} pairs.</summary>
        /// <remarks>
        /// A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.LabelSelector#matchLabels
        /// </remarks>
        [JsiiProperty(name: "matchLabels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? MatchLabels
        {
            get
            {
                return null;
            }
        }

        /// <summary>A label selector is a label query over a set of resources.</summary>
        /// <remarks>
        /// The result of matchLabels and matchExpressions are ANDed. An empty label selector matches all objects. A null label selector matches no objects.
        ///
        /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.LabelSelector
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ILabelSelector), fullyQualifiedName: "k8s.LabelSelector")]
        internal sealed class _Proxy : DeputyBase, K8s.ILabelSelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>matchExpressions is a list of label selector requirements.</summary>
            /// <remarks>
            /// The requirements are ANDed.
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.LabelSelector#matchExpressions
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchExpressions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.LabelSelectorRequirement\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.ILabelSelectorRequirement[]? MatchExpressions
            {
                get => GetInstanceProperty<K8s.ILabelSelectorRequirement[]?>();
            }

            /// <summary>matchLabels is a map of {key,value} pairs.</summary>
            /// <remarks>
            /// A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is "key", the operator is "In", and the values array contains only "value". The requirements are ANDed.
            ///
            /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.apis.meta.v1.LabelSelector#matchLabels
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchLabels", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? MatchLabels
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }
        }
    }
}
