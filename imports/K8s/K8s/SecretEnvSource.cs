using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SecretEnvSource selects a Secret to populate the environment variables with.</summary>
    /// <remarks>
    /// The contents of the target Secret's Data field will represent the key-value pairs as environment variables.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretEnvSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.SecretEnvSource")]
    public class SecretEnvSource : K8s.ISecretEnvSource
    {
        /// <summary>Name of the referent.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretEnvSource#name
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Specify whether the Secret must be defined.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretEnvSource#optional
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "optional", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? Optional
        {
            get;
            set;
        }
    }
}
