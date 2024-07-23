using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Represents an empty directory for a pod.</summary>
    /// <remarks>
    /// Empty directory volumes support ownership management and SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.EmptyDirVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.EmptyDirVolumeSource")]
    public class EmptyDirVolumeSource : K8s.IEmptyDirVolumeSource
    {
        /// <summary>medium represents what type of storage medium should back this directory.</summary>
        /// <remarks>
        /// The default is "" which means to use the node's default medium. Must be an empty string (default) or Memory. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EmptyDirVolumeSource#medium
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "medium", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Medium
        {
            get;
            set;
        }

        /// <summary>sizeLimit is the total amount of local storage required for this EmptyDir volume.</summary>
        /// <remarks>
        /// The size limit is also applicable for memory medium. The maximum usage on memory medium EmptyDir would be the minimum value between the SizeLimit specified here and the sum of memory limits of all containers in a pod. The default is nil which means that the limit is undefined. More info: https://kubernetes.io/docs/concepts/storage/volumes#emptydir
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EmptyDirVolumeSource#sizeLimit
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sizeLimit", typeJson: "{\"fqn\":\"k8s.Quantity\"}", isOptional: true)]
        public K8s.Quantity? SizeLimit
        {
            get;
            set;
        }
    }
}
