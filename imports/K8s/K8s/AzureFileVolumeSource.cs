using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>AzureFile represents an Azure File Service mount on the host and bind mount to the pod.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFileVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.AzureFileVolumeSource")]
    public class AzureFileVolumeSource : K8s.IAzureFileVolumeSource
    {
        /// <summary>secretName is the  name of secret that contains Azure Storage Account Name and Key.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFileVolumeSource#secretName
        /// </remarks>
        [JsiiProperty(name: "secretName", typeJson: "{\"primitive\":\"string\"}")]
        public string SecretName
        {
            get;
            set;
        }

        /// <summary>shareName is the azure share Name.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFileVolumeSource#shareName
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
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AzureFileVolumeSource#readOnly
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ReadOnly
        {
            get;
            set;
        }
    }
}
