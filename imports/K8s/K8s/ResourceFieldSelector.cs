using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ResourceFieldSelector represents container resources (cpu, memory) and their output format.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceFieldSelector
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ResourceFieldSelector")]
    public class ResourceFieldSelector : K8s.IResourceFieldSelector
    {
        /// <summary>Required: resource to select.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceFieldSelector#resource
        /// </remarks>
        [JsiiProperty(name: "resource", typeJson: "{\"primitive\":\"string\"}")]
        public string Resource
        {
            get;
            set;
        }

        /// <summary>Container name: required for volumes, optional for env vars.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceFieldSelector#containerName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "containerName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ContainerName
        {
            get;
            set;
        }

        /// <summary>Specifies the output format of the exposed resources, defaults to "1".</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ResourceFieldSelector#divisor
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "divisor", typeJson: "{\"fqn\":\"k8s.Quantity\"}", isOptional: true)]
        public K8s.Quantity? Divisor
        {
            get;
            set;
        }
    }
}
