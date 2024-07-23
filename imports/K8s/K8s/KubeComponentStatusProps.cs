using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ComponentStatus (and ComponentStatusList) holds the cluster validation info.</summary>
    /// <remarks>
    /// Deprecated: This API is deprecated in v1.19+
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatus
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeComponentStatusProps")]
    public class KubeComponentStatusProps : K8s.IKubeComponentStatusProps
    {
        /// <summary>List of component conditions observed.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatus#conditions
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "conditions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ComponentCondition\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IComponentCondition[]? Conditions
        {
            get;
            set;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentStatus#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }
    }
}
