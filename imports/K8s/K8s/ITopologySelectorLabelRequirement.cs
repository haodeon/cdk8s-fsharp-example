using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>A topology selector requirement is a selector that matches given label.</summary>
    /// <remarks>
    /// This is an alpha feature and may change in the future.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySelectorLabelRequirement
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ITopologySelectorLabelRequirement), fullyQualifiedName: "k8s.TopologySelectorLabelRequirement")]
    public interface ITopologySelectorLabelRequirement
    {
        /// <summary>The label key that the selector applies to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySelectorLabelRequirement#key
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>An array of string values.</summary>
        /// <remarks>
        /// One value must match the label to be selected. Each entry in Values is ORed.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySelectorLabelRequirement#values
        /// </remarks>
        [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] Values
        {
            get;
        }

        /// <summary>A topology selector requirement is a selector that matches given label.</summary>
        /// <remarks>
        /// This is an alpha feature and may change in the future.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySelectorLabelRequirement
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ITopologySelectorLabelRequirement), fullyQualifiedName: "k8s.TopologySelectorLabelRequirement")]
        internal sealed class _Proxy : DeputyBase, K8s.ITopologySelectorLabelRequirement
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The label key that the selector applies to.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySelectorLabelRequirement#key
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>An array of string values.</summary>
            /// <remarks>
            /// One value must match the label to be selected. Each entry in Values is ORed.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.TopologySelectorLabelRequirement#values
            /// </remarks>
            [JsiiProperty(name: "values", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] Values
            {
                get => GetInstanceProperty<string[]>()!;
            }
        }
    }
}
