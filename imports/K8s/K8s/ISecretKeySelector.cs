using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SecretKeySelector selects a key of a Secret.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretKeySelector
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ISecretKeySelector), fullyQualifiedName: "k8s.SecretKeySelector")]
    public interface ISecretKeySelector
    {
        /// <summary>The key of the secret to select from.</summary>
        /// <remarks>
        /// Must be a valid secret key.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretKeySelector#key
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Name of the referent.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretKeySelector#name
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

        /// <summary>Specify whether the Secret or its key must be defined.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretKeySelector#optional
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

        /// <summary>SecretKeySelector selects a key of a Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretKeySelector
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ISecretKeySelector), fullyQualifiedName: "k8s.SecretKeySelector")]
        internal sealed class _Proxy : DeputyBase, K8s.ISecretKeySelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The key of the secret to select from.</summary>
            /// <remarks>
            /// Must be a valid secret key.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretKeySelector#key
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name of the referent.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretKeySelector#name
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify whether the Secret or its key must be defined.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretKeySelector#optional
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
