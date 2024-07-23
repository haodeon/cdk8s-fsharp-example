using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SeccompProfile defines a pod/container's seccomp profile settings.</summary>
    /// <remarks>
    /// Only one profile source may be set.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SeccompProfile
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ISeccompProfile), fullyQualifiedName: "k8s.SeccompProfile")]
    public interface ISeccompProfile
    {
        /// <summary>type indicates which kind of seccomp profile will be applied. Valid options are:.</summary>
        /// <remarks>
        /// Localhost - a profile defined in a file on the node should be used. RuntimeDefault - the container runtime default profile should be used. Unconfined - no profile should be applied.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SeccompProfile#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>localhostProfile indicates a profile defined in a file on the node should be used.</summary>
        /// <remarks>
        /// The profile must be preconfigured on the node to work. Must be a descending path, relative to the kubelet's configured seccomp profile location. Must be set if type is "Localhost". Must NOT be set for any other type.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SeccompProfile#localhostProfile
        /// </remarks>
        [JsiiProperty(name: "localhostProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? LocalhostProfile
        {
            get
            {
                return null;
            }
        }

        /// <summary>SeccompProfile defines a pod/container's seccomp profile settings.</summary>
        /// <remarks>
        /// Only one profile source may be set.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SeccompProfile
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ISeccompProfile), fullyQualifiedName: "k8s.SeccompProfile")]
        internal sealed class _Proxy : DeputyBase, K8s.ISeccompProfile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>type indicates which kind of seccomp profile will be applied. Valid options are:.</summary>
            /// <remarks>
            /// Localhost - a profile defined in a file on the node should be used. RuntimeDefault - the container runtime default profile should be used. Unconfined - no profile should be applied.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SeccompProfile#type
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>localhostProfile indicates a profile defined in a file on the node should be used.</summary>
            /// <remarks>
            /// The profile must be preconfigured on the node to work. Must be a descending path, relative to the kubelet's configured seccomp profile location. Must be set if type is "Localhost". Must NOT be set for any other type.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SeccompProfile#localhostProfile
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "localhostProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? LocalhostProfile
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
