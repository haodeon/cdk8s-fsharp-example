using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>AzureFile represents an Azure File Service mount on the host and bind mount to the pod.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFilePersistentVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.AzureFilePersistentVolumeSource")]
    public class AzureFilePersistentVolumeSource : K8s.IAzureFilePersistentVolumeSource
    {
        /// <summary>secretName is the name of secret that contains Azure Storage Account Name and Key.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFilePersistentVolumeSource#secretName
        /// </remarks>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretName
        {
            get;
            set;
        }

        /// <summary>shareName is the azure Share Name.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFilePersistentVolumeSource#shareName
        /// </remarks>
        [JsiiProperty(name: "shareName", typeJson: "{\"primitive\":\"string\"}")]
        public string ShareName
        {
            get;
            set;
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
            get;
            set;
        }

        /// <summary>secretNamespace is the namespace of the secret that contains Azure Storage Account Name and Key default is the same as the Pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFilePersistentVolumeSource#secretNamespace
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretNamespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SecretNamespace
        {
            get;
            set;
        }
    }
}
