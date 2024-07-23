using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>An empty preferred scheduling term matches all objects with implicit weight 0 (i.e. it's a no-op). A null preferred scheduling term matches no objects (i.e. is also a no-op).</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PreferredSchedulingTerm
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PreferredSchedulingTerm")]
    public class PreferredSchedulingTerm : K8s.IPreferredSchedulingTerm
    {
        /// <summary>A node selector term, associated with the corresponding weight.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PreferredSchedulingTerm#preference
        /// </remarks>
        [JsiiProperty(name: "preference", typeJson: "{\"fqn\":\"k8s.NodeSelectorTerm\"}")]
        public K8s.INodeSelectorTerm Preference
        {
            get;
            set;
        }

        /// <summary>Weight associated with matching the corresponding nodeSelectorTerm, in the range 1-100.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PreferredSchedulingTerm#weight
        /// </remarks>
        [JsiiProperty(name: "weight", typeJson: "{\"primitive\":\"number\"}")]
        public double Weight
        {
            get;
            set;
        }
    }
}
