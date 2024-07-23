using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ContainerResizePolicy represents resource resize policy for the container.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerResizePolicy
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ContainerResizePolicy")]
    public class ContainerResizePolicy : K8s.IContainerResizePolicy
    {
        /// <summary>Name of the resource to which this resource resize policy applies.</summary>
        /// <remarks>
        /// Supported values: cpu, memory.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerResizePolicy#resourceName
        /// </remarks>
        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        public string ResourceName
        {
            get;
            set;
        }

        /// <summary>Restart policy to apply when specified resource is resized.</summary>
        /// <remarks>
        /// If not specified, it defaults to NotRequired.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerResizePolicy#restartPolicy
        /// </remarks>
        [JsiiProperty(name: "restartPolicy", typeJson: "{\"primitive\":\"string\"}")]
        public string RestartPolicy
        {
            get;
            set;
        }
    }
}
