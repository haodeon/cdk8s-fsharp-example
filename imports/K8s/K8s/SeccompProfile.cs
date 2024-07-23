using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>SeccompProfile defines a pod/container's seccomp profile settings.</summary>
    /// <remarks>
    /// Only one profile source may be set.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SeccompProfile
    /// </remarks>
    [JsiiByValue(fqn: "k8s.SeccompProfile")]
    public class SeccompProfile : K8s.ISeccompProfile
    {
        /// <summary>type indicates which kind of seccomp profile will be applied. Valid options are:.</summary>
        /// <remarks>
        /// Localhost - a profile defined in a file on the node should be used. RuntimeDefault - the container runtime default profile should be used. Unconfined - no profile should be applied.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SeccompProfile#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
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
            get;
            set;
        }
    }
}
