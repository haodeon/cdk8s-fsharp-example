using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>AzureFile represents an Azure File Service mount on the host and bind mount to the pod.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFilePersistentVolumeSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IAzureFilePersistentVolumeSource), fullyQualifiedName: "k8s.AzureFilePersistentVolumeSource")]
    public interface IAzureFilePersistentVolumeSource
    {
        /// <summary>secretName is the name of secret that contains Azure Storage Account Name and Key.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFilePersistentVolumeSource#secretName
        /// </remarks>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        string SecretName
        {
            get;
        }

        /// <summary>shareName is the azure Share Name.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFilePersistentVolumeSource#shareName
        /// </remarks>
        [JsiiProperty(name: "shareName", typeJson: "{\"primitive\":\"string\"}")]
        string ShareName
        {
            get;
        }

        /// <summary>readOnly defaults to false (read/write).</summary>
        /// <remarks>
        /// ReadOnly here will force the ReadOnly setting in VolumeMounts.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFilePersistentVolumeSource#readOnly
        /// </remarks>
        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ReadOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>secretNamespace is the namespace of the secret that contains Azure Storage Account Name and Key default is the same as the Pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFilePersistentVolumeSource#secretNamespace
        /// </remarks>
        [JsiiProperty(name: "secretNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SecretNamespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>AzureFile represents an Azure File Service mount on the host and bind mount to the pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFilePersistentVolumeSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IAzureFilePersistentVolumeSource), fullyQualifiedName: "k8s.AzureFilePersistentVolumeSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IAzureFilePersistentVolumeSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>secretName is the name of secret that contains Azure Storage Account Name and Key.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFilePersistentVolumeSource#secretName
            /// </remarks>
            [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
            public string SecretName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>shareName is the azure Share Name.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFilePersistentVolumeSource#shareName
            /// </remarks>
            [JsiiProperty(name: "shareName", typeJson: "{\"primitive\":\"string\"}")]
            public string ShareName
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>readOnly defaults to false (read/write).</summary>
            /// <remarks>
            /// ReadOnly here will force the ReadOnly setting in VolumeMounts.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFilePersistentVolumeSource#readOnly
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ReadOnly
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>secretNamespace is the namespace of the secret that contains Azure Storage Account Name and Key default is the same as the Pod.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFilePersistentVolumeSource#secretNamespace
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secretNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SecretNamespace
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
