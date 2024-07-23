using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ConfigMapNodeConfigSource contains the information to reference a ConfigMap as a config source for the Node.</summary>
    /// <remarks>
    /// This API is deprecated since 1.22: https://git.k8s.io/enhancements/keps/sig-node/281-dynamic-kubelet-configuration
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IConfigMapNodeConfigSource), fullyQualifiedName: "k8s.ConfigMapNodeConfigSource")]
    public interface IConfigMapNodeConfigSource
    {
        /// <summary>KubeletConfigKey declares which key of the referenced ConfigMap corresponds to the KubeletConfiguration structure This field is required in all cases.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource#kubeletConfigKey
        /// </remarks>
        [JsiiProperty(name: "kubeletConfigKey", typeJson: "{\"primitive\":\"string\"}")]
        string KubeletConfigKey
        {
            get;
        }

        /// <summary>Name is the metadata.name of the referenced ConfigMap. This field is required in all cases.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Namespace is the metadata.namespace of the referenced ConfigMap. This field is required in all cases.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource#namespace
        /// </remarks>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        string Namespace
        {
            get;
        }

        /// <summary>ResourceVersion is the metadata.ResourceVersion of the referenced ConfigMap. This field is forbidden in Node.Spec, and required in Node.Status.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource#resourceVersion
        /// </remarks>
        [JsiiProperty(name: "resourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ResourceVersion
        {
            get
            {
                return null;
            }
        }

        /// <summary>UID is the metadata.UID of the referenced ConfigMap. This field is forbidden in Node.Spec, and required in Node.Status.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource#uid
        /// </remarks>
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Uid
        {
            get
            {
                return null;
            }
        }

        /// <summary>ConfigMapNodeConfigSource contains the information to reference a ConfigMap as a config source for the Node.</summary>
        /// <remarks>
        /// This API is deprecated since 1.22: https://git.k8s.io/enhancements/keps/sig-node/281-dynamic-kubelet-configuration
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IConfigMapNodeConfigSource), fullyQualifiedName: "k8s.ConfigMapNodeConfigSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IConfigMapNodeConfigSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>KubeletConfigKey declares which key of the referenced ConfigMap corresponds to the KubeletConfiguration structure This field is required in all cases.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource#kubeletConfigKey
            /// </remarks>
            [JsiiProperty(name: "kubeletConfigKey", typeJson: "{\"primitive\":\"string\"}")]
            public string KubeletConfigKey
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name is the metadata.name of the referenced ConfigMap. This field is required in all cases.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Namespace is the metadata.namespace of the referenced ConfigMap. This field is required in all cases.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource#namespace
            /// </remarks>
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
            public string Namespace
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>ResourceVersion is the metadata.ResourceVersion of the referenced ConfigMap. This field is forbidden in Node.Spec, and required in Node.Status.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource#resourceVersion
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ResourceVersion
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>UID is the metadata.UID of the referenced ConfigMap. This field is forbidden in Node.Spec, and required in Node.Status.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource#uid
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Uid
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
