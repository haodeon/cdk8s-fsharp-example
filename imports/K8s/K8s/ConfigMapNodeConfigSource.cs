using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ConfigMapNodeConfigSource contains the information to reference a ConfigMap as a config source for the Node.</summary>
    /// <remarks>
    /// This API is deprecated since 1.22: https://git.k8s.io/enhancements/keps/sig-node/281-dynamic-kubelet-configuration
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ConfigMapNodeConfigSource")]
    public class ConfigMapNodeConfigSource : K8s.IConfigMapNodeConfigSource
    {
        /// <summary>KubeletConfigKey declares which key of the referenced ConfigMap corresponds to the KubeletConfiguration structure This field is required in all cases.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource#kubeletConfigKey
        /// </remarks>
        [JsiiProperty(name: "kubeletConfigKey", typeJson: "{\"primitive\":\"string\"}")]
        public string KubeletConfigKey
        {
            get;
            set;
        }

        /// <summary>Name is the metadata.name of the referenced ConfigMap. This field is required in all cases.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Namespace is the metadata.namespace of the referenced ConfigMap. This field is required in all cases.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource#namespace
        /// </remarks>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}")]
        public string Namespace
        {
            get;
            set;
        }

        /// <summary>ResourceVersion is the metadata.ResourceVersion of the referenced ConfigMap. This field is forbidden in Node.Spec, and required in Node.Status.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource#resourceVersion
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ResourceVersion
        {
            get;
            set;
        }

        /// <summary>UID is the metadata.UID of the referenced ConfigMap. This field is forbidden in Node.Spec, and required in Node.Status.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMapNodeConfigSource#uid
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "uid", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Uid
        {
            get;
            set;
        }
    }
}
