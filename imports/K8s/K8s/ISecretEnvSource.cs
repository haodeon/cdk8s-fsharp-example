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
    [JsiiInterface(nativeType: typeof(ISecretEnvSource), fullyQualifiedName: "k8s.SecretEnvSource")]
    public interface ISecretEnvSource
    {
        /// <summary>Name of the referent.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretEnvSource#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Name
        {
            get
            {
                return null;
            }
        }

        /// <summary>Specify whether the Secret must be defined.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretEnvSource#optional
        /// </remarks>
        [JsiiProperty(name: "optional", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Optional
        {
            get
            {
                return null;
            }
        }

        /// <summary>SecretEnvSource selects a Secret to populate the environment variables with.</summary>
        /// <remarks>
        /// The contents of the target Secret's Data field will represent the key-value pairs as environment variables.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretEnvSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ISecretEnvSource), fullyQualifiedName: "k8s.SecretEnvSource")]
        internal sealed class _Proxy : DeputyBase, K8s.ISecretEnvSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify whether the Secret must be defined.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretEnvSource#optional
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "optional", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Optional
            {
                get => GetInstanceProperty<bool?>();
            }
        }
    }
}
