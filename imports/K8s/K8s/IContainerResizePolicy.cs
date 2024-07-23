using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ContainerResizePolicy represents resource resize policy for the container.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerResizePolicy
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IContainerResizePolicy), fullyQualifiedName: "k8s.ContainerResizePolicy")]
    public interface IContainerResizePolicy
    {
        /// <summary>Name of the resource to which this resource resize policy applies.</summary>
        /// <remarks>
        /// Supported values: cpu, memory.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerResizePolicy#resourceName
        /// </remarks>
        [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
        string ResourceName
        {
            get;
        }

        /// <summary>Restart policy to apply when specified resource is resized.</summary>
        /// <remarks>
        /// If not specified, it defaults to NotRequired.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerResizePolicy#restartPolicy
        /// </remarks>
        [JsiiProperty(name: "restartPolicy", typeJson: "{\"primitive\":\"string\"}")]
        string RestartPolicy
        {
            get;
        }

        /// <summary>ContainerResizePolicy represents resource resize policy for the container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerResizePolicy
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IContainerResizePolicy), fullyQualifiedName: "k8s.ContainerResizePolicy")]
        internal sealed class _Proxy : DeputyBase, K8s.IContainerResizePolicy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the resource to which this resource resize policy applies.</summary>
            /// <remarks>
            /// Supported values: cpu, memory.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ContainerResizePolicy#resourceName
            /// </remarks>
            [JsiiProperty(name: "resourceName", typeJson: "{\"primitive\":\"string\"}")]
            public string ResourceName
            {
                get => GetInstanceProperty<string>()!;
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
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
