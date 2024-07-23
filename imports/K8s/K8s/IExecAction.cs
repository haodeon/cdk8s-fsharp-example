using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ExecAction describes a "run in container" action.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ExecAction
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IExecAction), fullyQualifiedName: "k8s.ExecAction")]
    public interface IExecAction
    {
        /// <summary>Command is the command line to execute inside the container, the working directory for the command  is root ('/') in the container's filesystem.</summary>
        /// <remarks>
        /// The command is simply exec'd, it is not run inside a shell, so traditional shell instructions ('|', etc) won't work. To use a shell, you need to explicitly call out to that shell. Exit status of 0 is treated as live/healthy and non-zero is unhealthy.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ExecAction#command
        /// </remarks>
        [JsiiProperty(name: "command", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? Command
        {
            get
            {
                return null;
            }
        }

        /// <summary>ExecAction describes a "run in container" action.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ExecAction
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IExecAction), fullyQualifiedName: "k8s.ExecAction")]
        internal sealed class _Proxy : DeputyBase, K8s.IExecAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string[]?>();
            }
        }
    }
}
