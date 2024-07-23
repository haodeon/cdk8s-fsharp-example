using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ExecAction describes a "run in container" action.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ExecAction
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ExecAction")]
    public class ExecAction : K8s.IExecAction
    {
        /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem.</summary>
        /// <remarks>
        /// The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ExecAction#command
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Command
        {
            get;
            set;
        }
    }
}
