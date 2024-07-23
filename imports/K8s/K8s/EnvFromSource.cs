using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EnvFromSource represents the source of a set of ConfigMaps.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvFromSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.EnvFromSource")]
    public class EnvFromSource : K8s.IEnvFromSource
    {
        /// <summary>The ConfigMap to select from.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvFromSource#configMapRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "configMapRef", typeJson: "{\"fqn\":\"k8s.ConfigMapEnvSource\"}", isOptional: true)]
        public K8s.IConfigMapEnvSource? ConfigMapRef
        {
            get;
            set;
        }

        /// <summary>An optional identifier to prepend to each key in the ConfigMap.</summary>
        /// <remarks>
        /// Must be a C_IDENTIFIER.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvFromSource#prefix
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Prefix
        {
            get;
            set;
        }

        /// <summary>The Secret to select from.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvFromSource#secretRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretRef", typeJson: "{\"fqn\":\"k8s.SecretEnvSource\"}", isOptional: true)]
        public K8s.ISecretEnvSource? SecretRef
        {
            get;
            set;
        }
    }
}
