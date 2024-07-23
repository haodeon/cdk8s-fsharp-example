using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EnvFromSource represents the source of a set of ConfigMaps.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvFromSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IEnvFromSource), fullyQualifiedName: "k8s.EnvFromSource")]
    public interface IEnvFromSource
    {
        /// <summary>The ConfigMap to select from.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvFromSource#configMapRef
        /// </remarks>
        [JsiiProperty(name: "configMapRef", typeJson: "{\"fqn\":\"k8s.ConfigMapEnvSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IConfigMapEnvSource? ConfigMapRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>An optional identifier to prepend to each key in the ConfigMap.</summary>
        /// <remarks>
        /// Must be a C_IDENTIFIER.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvFromSource#prefix
        /// </remarks>
        [JsiiProperty(name: "prefix", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Prefix
        {
            get
            {
                return null;
            }
        }

        /// <summary>The Secret to select from.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvFromSource#secretRef
        /// </remarks>
        [JsiiProperty(name: "secretRef", typeJson: "{\"fqn\":\"k8s.SecretEnvSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ISecretEnvSource? SecretRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>EnvFromSource represents the source of a set of ConfigMaps.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvFromSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IEnvFromSource), fullyQualifiedName: "k8s.EnvFromSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IEnvFromSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The ConfigMap to select from.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvFromSource#configMapRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "configMapRef", typeJson: "{\"fqn\":\"k8s.ConfigMapEnvSource\"}", isOptional: true)]
            public K8s.IConfigMapEnvSource? ConfigMapRef
            {
                get => GetInstanceProperty<K8s.IConfigMapEnvSource?>();
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>The Secret to select from.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvFromSource#secretRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretRef", typeJson: "{\"fqn\":\"k8s.SecretEnvSource\"}", isOptional: true)]
            public K8s.ISecretEnvSource? SecretRef
            {
                get => GetInstanceProperty<K8s.ISecretEnvSource?>();
            }
        }
    }
}
