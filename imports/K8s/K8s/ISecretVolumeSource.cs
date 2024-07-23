using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Adapts a Secret into a volume.</summary>
    /// <remarks>
    /// The contents of the target Secret's Data field will be presented in a volume as files using the keys in the Data field as the file names. Secret volumes support ownership management and SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ISecretVolumeSource), fullyQualifiedName: "k8s.SecretVolumeSource")]
    public interface ISecretVolumeSource
    {
        /// <summary>defaultMode is Optional: mode bits used to set permissions on created files by default.</summary>
        /// <remarks>
        /// Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        ///
        /// <strong>Default</strong>: 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretVolumeSource#defaultMode
        /// </remarks>
        [JsiiProperty(name: "defaultMode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DefaultMode
        {
            get
            {
                return null;
            }
        }

        /// <summary>items If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value.</summary>
        /// <remarks>
        /// If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretVolumeSource#items
        /// </remarks>
        [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KeyToPath\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IKeyToPath[]? Items
        {
            get
            {
                return null;
            }
        }

        /// <summary>optional field specify whether the Secret or its keys must be defined.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretVolumeSource#optional
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

        /// <summary>secretName is the name of the secret in the pod's namespace to use.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/volumes#secret
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretVolumeSource#secretName
        /// </remarks>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretName
        {
            get
            {
                return null;
            }
        }

        /// <summary>Adapts a Secret into a volume.</summary>
        /// <remarks>
        /// The contents of the target Secret's Data field will be presented in a volume as files using the keys in the Data field as the file names. Secret volumes support ownership management and SELinux relabeling.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ISecretVolumeSource), fullyQualifiedName: "k8s.SecretVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.ISecretVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>defaultMode is Optional: mode bits used to set permissions on created files by default.</summary>
            /// <remarks>
            /// Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. Defaults to 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
            ///
            /// <strong>Default</strong>: 0644. Directories within the path are not affected by this setting. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretVolumeSource#defaultMode
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "defaultMode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DefaultMode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>items If unspecified, each key-value pair in the Data field of the referenced Secret will be projected into the volume as a file whose name is the key and content is the value.</summary>
            /// <remarks>
            /// If specified, the listed keys will be projected into the specified paths, and unlisted keys will not be present. If a key is specified which is not present in the Secret, the volume setup will error unless it is marked optional. Paths must be relative and may not contain the '..' path or start with '..'.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretVolumeSource#items
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "items", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KeyToPath\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IKeyToPath[]? Items
            {
                get => GetInstanceProperty<K8s.IKeyToPath[]?>();
            }

            /// <summary>optional field specify whether the Secret or its keys must be defined.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretVolumeSource#optional
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "optional", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? Optional
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>secretName is the name of the secret in the pod's namespace to use.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/storage/volumes#secret
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretVolumeSource#secretName
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretName
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
