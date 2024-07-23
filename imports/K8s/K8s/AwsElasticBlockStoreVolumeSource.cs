using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Represents a Persistent Disk resource in AWS.</summary>
    /// <remarks>
    /// An AWS EBS disk must exist before mounting to a container. The disk must also be in the same AWS zone as the kubelet. An AWS EBS disk can only be mounted as read/write once. AWS EBS volumes support ownership management and SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.AWSElasticBlockStoreVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.AwsElasticBlockStoreVolumeSource")]
    public class AwsElasticBlockStoreVolumeSource : K8s.IAwsElasticBlockStoreVolumeSource
    {
        /// <summary>volumeID is unique ID of the persistent disk resource in AWS (Amazon EBS volume).</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AWSElasticBlockStoreVolumeSource#volumeID
        /// </remarks>
        [JsiiProperty(name: "volumeId", typeJson: "{\"primitive\":\"string\"}")]
        public string VolumeId
        {
            get;
            set;
        }

        /// <summary>fsType is the filesystem type of the volume that you want to mount.</summary>
        /// <remarks>
        /// Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AWSElasticBlockStoreVolumeSource#fsType
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FsType
        {
            get;
            set;
        }

        /// <summary>partition is the partition in the volume that you want to mount.</summary>
        /// <remarks>
        /// If omitted, the default is to mount by volume name. Examples: For volume /dev/sda1, you specify the partition as "1". Similarly, the volume partition for /dev/sda is "0" (or you can leave the property empty).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AWSElasticBlockStoreVolumeSource#partition
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "partition", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Partition
        {
            get;
            set;
        }

        /// <summary>readOnly value true will force the readOnly setting in VolumeMounts.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/volumes#awselasticblockstore
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AWSElasticBlockStoreVolumeSource#readOnly
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