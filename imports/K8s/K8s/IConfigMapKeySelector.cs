using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Selects a key from a ConfigMap.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapKeySelector
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IConfigMapKeySelector), fullyQualifiedName: "k8s.ConfigMapKeySelector")]
    public interface IConfigMapKeySelector
    {
        /// <summary>The key to select.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapKeySelector#key
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapKeySelector#name
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

        /// <summary>Specify whether the ConfigMap or its key must be defined.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapKeySelector#optional
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

        /// <summary>Selects a key from a ConfigMap.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapKeySelector
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IConfigMapKeySelector), fullyQualifiedName: "k8s.ConfigMapKeySelector")]
        internal sealed class _Proxy : DeputyBase, K8s.IConfigMapKeySelector
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The key to select.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapKeySelector#key
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
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapKeySelector#name
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Name
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Specify whether the ConfigMap or its key must be defined.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapKeySelector#optional
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
