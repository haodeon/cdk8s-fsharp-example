using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ConfigMap holds configuration data for pods to consume.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMap
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeConfigMapProps), fullyQualifiedName: "k8s.KubeConfigMapProps")]
    public interface IKubeConfigMapProps
    {
        /// <summary>BinaryData contains the binary data.</summary>
        /// <remarks>
        /// Each key must consist of alphanumeric characters, '-', '_' or '.'. BinaryData can contain byte sequences that are not in the UTF-8 range. The keys stored in BinaryData must not overlap with the ones in the Data field, this is enforced during validation process. Using this field will require 1.10+ apiserver and kubelet.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMap#binaryData
        /// </remarks>
        [JsiiProperty(name: "binaryData", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? BinaryData
        {
            get
            {
                return null;
            }
        }

        /// <summary>Data contains the configuration data.</summary>
        /// <remarks>
        /// Each key must consist of alphanumeric characters, '-', '_' or '.'. Values with non-UTF-8 byte sequences must use the BinaryData field. The keys stored in Data must not overlap with the keys in the BinaryData field, this is enforced during validation process.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMap#data
        /// </remarks>
        [JsiiProperty(name: "data", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? Data
        {
            get
            {
                return null;
            }
        }

        /// <summary>Immutable, if set to true, ensures that data stored in the ConfigMap cannot be updated (only object metadata can be modified).</summary>
        /// <remarks>
        /// If not set to true, the field can be modified at any time. Defaulted to nil.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMap#immutable
        /// </remarks>
        [JsiiProperty(name: "immutable", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? Immutable
        {
            get
            {
                return null;
            }
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMap#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>ConfigMap holds configuration data for pods to consume.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMap
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeConfigMapProps), fullyQualifiedName: "k8s.KubeConfigMapProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeConfigMapProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>BinaryData contains the binary data.</summary>
            /// <remarks>
            /// Each key must consist of alphanumeric characters, '-', '_' or '.'. BinaryData can contain byte sequences that are not in the UTF-8 range. The keys stored in BinaryData must not overlap with the ones in the Data field, this is enforced during validation process. Using this field will require 1.10+ apiserver and kubelet.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMap#binaryData
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "binaryData", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? BinaryData
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Data contains the configuration data.</summary>
            /// <remarks>
            /// Each key must consist of alphanumeric characters, '-', '_' or '.'. Values with non-UTF-8 byte sequences must use the BinaryData field. The keys stored in Data must not overlap with the keys in the BinaryData field, this is enforced during validation process.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMap#data
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "data", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? Data
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>Immutable, if set to true, ensures that data stored in the ConfigMap cannot be updated (only object metadata can be modified).</summary>
            /// <remarks>
            /// If not set to true, the field can be modified at any time. Defaulted to nil.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMap#immutable
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "immutable", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Immutable
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ConfigMap#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }
        }
    }
}
