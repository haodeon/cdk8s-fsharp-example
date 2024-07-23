using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>A scoped-resource selector requirement is a selector that contains values, a scope name, and an operator that relates the scope name and values.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ScopedResourceSelectorRequirement
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IScopedResourceSelectorRequirement), fullyQualifiedName: "k8s.ScopedResourceSelectorRequirement")]
    public interface IScopedResourceSelectorRequirement
    {
        /// <summary>Represents a scope's relationship to a set of values.</summary>
        /// <remarks>
        /// Valid operators are In, NotIn, Exists, DoesNotExist.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScopedResourceSelectorRequirement#operator
        /// </remarks>
        [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
        string Operator
        {
            get;
        }

        /// <summary>The name of the scope that the selector applies to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScopedResourceSelectorRequirement#scopeName
        /// </remarks>
        [JsiiProperty(name: "scopeName", typeJson: "{\"primitive\":\"string\"}")]
        string ScopeName
        {
            get;
        }

        /// <summary>An array of string values.</summary>
        /// <remarks>
        /// If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScopedResourceSelectorRequirement#values
        /// </remarks>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Values
        {
            get
            {
                return null;
            }
        }

        /// <summary>A scoped-resource selector requirement is a selector that contains values, a scope name, and an operator that relates the scope name and values.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ScopedResourceSelectorRequirement
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IScopedResourceSelectorRequirement), fullyQualifiedName: "k8s.ScopedResourceSelectorRequirement")]
        internal sealed class _Proxy : DeputyBase, K8s.IScopedResourceSelectorRequirement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Represents a scope's relationship to a set of values.</summary>
            /// <remarks>
            /// Valid operators are In, NotIn, Exists, DoesNotExist.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ScopedResourceSelectorRequirement#operator
            /// </remarks>
            [JsiiProperty(name: "operator", typeJson: "{\"primitive\":\"string\"}")]
            public string Operator
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>The name of the scope that the selector applies to.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ScopedResourceSelectorRequirement#scopeName
            /// </remarks>
            [JsiiProperty(name: "scopeName", typeJson: "{\"primitive\":\"string\"}")]
            public string ScopeName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>An array of string values.</summary>
            /// <remarks>
            /// If the operator is In or NotIn, the values array must be non-empty. If the operator is Exists or DoesNotExist, the values array must be empty. This array is replaced during a strategic merge patch.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ScopedResourceSelectorRequirement#values
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? Values
            {
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
