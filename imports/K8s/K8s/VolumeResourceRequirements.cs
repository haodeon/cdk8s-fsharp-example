using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>VolumeResourceRequirements describes the storage resource requirements for a volume.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeResourceRequirements
    /// </remarks>
    [JsiiByValue(fqn: "k8s.VolumeResourceRequirements")]
    public class VolumeResourceRequirements : K8s.IVolumeResourceRequirements
    {
        /// <summary>Limits describes the maximum amount of compute resources allowed.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeResourceRequirements#limits
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "limits", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, K8s.Quantity>? Limits
        {
            get;
            set;
        }

        /// <summary>Requests describes the minimum amount of compute resources required.</summary>
        /// <remarks>
        /// If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeResourceRequirements#requests
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requests", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
        public System.Collections.Generic.IDictionary<string, K8s.Quantity>? Requests
        {
            get;
            set;
        }
    }
}
