using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PreferredSchedulingTerm
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPreferredSchedulingTerm), fullyQualifiedName: "k8s.PreferredSchedulingTerm")]
    public interface IPreferredSchedulingTerm
    {
        /// <summary>A node selector term, associated with the corresponding weight.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PreferredSchedulingTerm#preference
        /// </remarks>
        [JsiiProperty(name: "preference", typeJson: "{\"fqn\":\"k8s.NodeSelectorTerm\"}")]
        K8s.INodeSelectorTerm Preference
        {
            get;
        }

        /// <summary>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PreferredSchedulingTerm#weight
        /// </remarks>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        double Weight
        {
            get;
        }

        /// <summary>An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PreferredSchedulingTerm
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPreferredSchedulingTerm), fullyQualifiedName: "k8s.PreferredSchedulingTerm")]
        internal sealed class _Proxy : DeputyBase, K8s.IPreferredSchedulingTerm
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>A node selector term, associated with the corresponding weight.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PreferredSchedulingTerm#preference
            /// </remarks>
            [JsiiProperty(name: "preference", typeJson: "{\"fqn\":\"k8s.NodeSelectorTerm\"}")]
            public K8s.INodeSelectorTerm Preference
            {
                get => GetInstanceProperty<K8s.INodeSelectorTerm>()!;
            }

            /// <summary>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PreferredSchedulingTerm#weight
            /// </remarks>
            [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
            public double Weight
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
