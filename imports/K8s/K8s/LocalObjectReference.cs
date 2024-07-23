using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>LocalObjectReference contains enough information to let you locate the referenced object inside the same namespace.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.LocalObjectReference
    /// </remarks>
    [JsiiByValue(fqn: "k8s.LocalObjectReference")]
    public class LocalObjectReference : K8s.ILocalObjectReference
    {
        /// <summary>Name of the referent.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.LocalObjectReference#name
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }
    }
}
