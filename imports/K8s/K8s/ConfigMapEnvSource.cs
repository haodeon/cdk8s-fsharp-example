using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ConfigMapEnvSource selects a ConfigMap to populate the environment variables with.</summary>
    /// <remarks>
    /// The contents of the target ConfigMap's Data field will represent the key-value pairs as environment variables.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapEnvSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ConfigMapEnvSource")]
    public class ConfigMapEnvSource : K8s.IConfigMapEnvSource
    {
        /// <summary>Name of the referent.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapEnvSource#name
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Specify whether the ConfigMap must be defined.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapEnvSource#optional
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
