using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Represents an ISCSI disk.</summary>
    /// <remarks>
    /// ISCSI volumes can only be mounted as read/write once. ISCSI volumes support ownership management and SELinux relabeling.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ISCSIVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.IscsiVolumeSource")]
    public class IscsiVolumeSource : K8s.IIscsiVolumeSource
    {
        /// <summary>iqn is the target iSCSI Qualified Name.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ISCSIVolumeSource#iqn
        /// </remarks>
        [JsiiProperty(name: "iqn", typeJson: "{\"primitive\":\"string\"}")]
        public string Iqn
        {
            get;
            set;
        }

        /// <summary>lun represents iSCSI Target Lun number.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ISCSIVolumeSource#lun
        /// </remarks>
        [JsiiProperty(name: "lun", typeJson: "{\"primitive\":\"number\"}")]
        public double Lun
        {
            get;
            set;
        }

        /// <summary>targetPortal is iSCSI Target Portal.</summary>
        /// <remarks>
        /// The Portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ISCSIVolumeSource#targetPortal
        /// </remarks>
        [JsiiProperty(name: "targetPortal", typeJson: "{\"primitive\":\"string\"}")]
        public string TargetPortal
        {
            get;
            set;
        }

        /// <summary>chapAuthDiscovery defines whether support iSCSI Discovery CHAP authentication.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ISCSIVolumeSource#chapAuthDiscovery
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "chapAuthDiscovery", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ChapAuthDiscovery
        {
            get;
            set;
        }

        /// <summary>chapAuthSession defines whether support iSCSI Session CHAP authentication.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ISCSIVolumeSource#chapAuthSession
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "chapAuthSession", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ChapAuthSession
        {
            get;
            set;
        }

        /// <summary>fsType is the filesystem type of the volume that you want to mount.</summary>
        /// <remarks>
        /// Tip: Ensure that the filesystem type is supported by the host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly inferred to be "ext4" if unspecified. More info: https://kubernetes.io/docs/concepts/storage/volumes#iscsi
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ISCSIVolumeSource#fsType
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fsType", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FsType
        {
            get;
            set;
        }

        /// <summary>initiatorName is the custom iSCSI Initiator Name.</summary>
        /// <remarks>
        /// If initiatorName is specified with iscsiInterface simultaneously, new iSCSI interface <target portal="portal" xmlns="http://www.w3.org/1999/xhtml"></target>:<volume name="name" xmlns="http://www.w3.org/1999/xhtml"></volume> will be created for the connection.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ISCSIVolumeSource#initiatorName
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "initiatorName", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? InitiatorName
        {
            get;
            set;
        }

        /// <summary>iscsiInterface is the interface Name that uses an iSCSI transport.</summary>
        /// <remarks>
        /// Defaults to 'default' (tcp).
        ///
        /// <strong>Default</strong>: default' (tcp).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ISCSIVolumeSource#iscsiInterface
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "iscsiInterface", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? IscsiInterface
        {
            get;
            set;
        }

        /// <summary>portals is the iSCSI Target Portal List.</summary>
        /// <remarks>
        /// The portal is either an IP or ip_addr:port if the port is other than default (typically TCP ports 860 and 3260).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ISCSIVolumeSource#portals
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "portals", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? Portals
        {
            get;
            set;
        }

        /// <summary>readOnly here will force the ReadOnly setting in VolumeMounts.</summary>
        /// <remarks>
        /// Defaults to false.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ISCSIVolumeSource#readOnly
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? ReadOnly
        {
            get;
            set;
        }

        /// <summary>secretRef is the CHAP Secret for iSCSI target and initiator authentication.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ISCSIVolumeSource#secretRef
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secretRef", typeJson: "{\"fqn\":\"k8s.LocalObjectReference\"}", isOptional: true)]
        public K8s.ILocalObjectReference? SecretRef
        {
            get;
            set;
        }
    }
}
