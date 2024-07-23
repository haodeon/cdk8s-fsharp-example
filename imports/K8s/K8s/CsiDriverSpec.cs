using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CSIDriverSpec is the specification of a CSIDriver.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.CsiDriverSpec")]
    public class CsiDriverSpec : K8s.ICsiDriverSpec
    {
        /// <summary>attachRequired indicates this CSI volume driver requires an attach operation (because it implements the CSI ControllerPublishVolume() method), and that the Kubernetes attach detach controller should call the attach volume interface which checks the volumeattachment status and waits until the volume is attached before proceeding to mounting.</summary>
        /// <remarks>
        /// The CSI external-attacher coordinates with CSI volume driver and updates the volumeattachment status when the attach operation is complete. If the CSIDriverRegistry feature gate is enabled and the value is specified to false, the attach operation will be skipped. Otherwise the attach operation will be called.
        ///
        /// This field is immutable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverSpec#attachRequired
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "attachRequired", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? AttachRequired
        {
            get;
            set;
        }

        /// <summary>fsGroupPolicy defines if the underlying volume supports changing ownership and permission of the volume before being mounted.</summary>
        /// <remarks>
        /// Refer to the specific FSGroupPolicy values for additional details.
        ///
        /// This field was immutable in Kubernetes &lt; 1.29 and now is mutable.
        ///
        /// Defaults to ReadWriteOnceWithFSType, which will examine each volume to determine if Kubernetes should modify ownership and permissions of the volume. With the default policy the defined fsGroup will only be applied if a fstype is defined and the volume's access mode contains ReadWriteOnce.
        ///
        /// <strong>Default</strong>: ReadWriteOnceWithFSType, which will examine each volume to determine if Kubernetes should modify ownership and permissions of the volume. With the default policy the defined fsGroup will only be applied if a fstype is defined and the volume's access mode contains ReadWriteOnce.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverSpec#fsGroupPolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fsGroupPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FsGroupPolicy
        {
            get;
            set;
        }

        /// <summary>podInfoOnMount indicates this CSI volume driver requires additional pod information (like podName, podUID, etc.) during mount operations, if set to true. If set to false, pod information will not be passed on mount. Default is false.</summary>
        /// <remarks>
        /// The CSI driver specifies podInfoOnMount as part of driver deployment. If true, Kubelet will pass pod information as VolumeContext in the CSI NodePublishVolume() calls. The CSI driver is responsible for parsing and validating the information passed in as VolumeContext.
        ///
        /// The following VolumeContext will be passed if podInfoOnMount is set to true. This list might grow, but the prefix will be used. "csi.storage.k8s.io/pod.name": pod.Name "csi.storage.k8s.io/pod.namespace": pod.Namespace "csi.storage.k8s.io/pod.uid": string(pod.UID) "csi.storage.k8s.io/ephemeral": "true" if the volume is an ephemeral inline volume
        /// defined by a CSIVolumeSource, otherwise "false"
        ///
        /// "csi.storage.k8s.io/ephemeral" is a new feature in Kubernetes 1.16. It is only required for drivers which support both the "Persistent" and "Ephemeral" VolumeLifecycleMode. Other drivers can leave pod info disabled and/or ignore this field. As Kubernetes 1.15 doesn't support this field, drivers can only support one mode when deployed on such a cluster and the deployment determines which mode that is, for example via a command line parameter of the driver.
        ///
        /// This field was immutable in Kubernetes &lt; 1.29 and now is mutable.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverSpec#podInfoOnMount
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "podInfoOnMount", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? PodInfoOnMount
        {
            get;
            set;
        }

        /// <summary>requiresRepublish indicates the CSI driver wants `NodePublishVolume` being periodically called to reflect any possible change in the mounted volume.</summary>
        /// <remarks>
        /// This field defaults to false.
        ///
        /// Note: After a successful initial NodePublishVolume call, subsequent calls to NodePublishVolume should only update the contents of the volume. New mount points will not be seen by a running container.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverSpec#requiresRepublish
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "requiresRepublish", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? RequiresRepublish
        {
            get;
            set;
        }

        /// <summary>seLinuxMount specifies if the CSI driver supports "-o context" mount option.</summary>
        /// <remarks>
        /// When "true", the CSI driver must ensure that all volumes provided by this CSI driver can be mounted separately with different <c>-o context</c> options. This is typical for storage backends that provide volumes as filesystems on block devices or as independent shared volumes. Kubernetes will call NodeStage / NodePublish with "-o context=xyz" mount option when mounting a ReadWriteOncePod volume used in Pod that has explicitly set SELinux context. In the future, it may be expanded to other volume AccessModes. In any case, Kubernetes will ensure that the volume is mounted only with a single SELinux context.
        ///
        /// When "false", Kubernetes won't pass any special SELinux mount options to the driver. This is typical for volumes that represent subdirectories of a bigger shared filesystem.
        ///
        /// Default is "false".
        ///
        /// <strong>Default</strong>: false".
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverSpec#seLinuxMount
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "seLinuxMount", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? SeLinuxMount
        {
            get;
            set;
        }

        /// <summary>storageCapacity indicates that the CSI volume driver wants pod scheduling to consider the storage capacity that the driver deployment will report by creating CSIStorageCapacity objects with capacity information, if set to true.</summary>
        /// <remarks>
        /// The check can be enabled immediately when deploying a driver. In that case, provisioning new volumes with late binding will pause until the driver deployment has published some suitable CSIStorageCapacity object.
        ///
        /// Alternatively, the driver can be deployed with the field unset or false and it can be flipped later when storage capacity information has been published.
        ///
        /// This field was immutable in Kubernetes &lt;= 1.22 and now is mutable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverSpec#storageCapacity
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "storageCapacity", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? StorageCapacity
        {
            get;
            set;
        }

        /// <summary>tokenRequests indicates the CSI driver needs pods' service account tokens it is mounting volume for to do necessary authentication.</summary>
        /// <remarks>
        /// Kubelet will pass the tokens in VolumeContext in the CSI NodePublishVolume calls. The CSI driver should parse and validate the following VolumeContext: "csi.storage.k8s.io/serviceAccount.tokens": {
        /// "<audience xmlns="http://www.w3.org/1999/xhtml"></audience>": {
        /// "token": <token xmlns="http://www.w3.org/1999/xhtml"></token>,
        /// "expirationTimestamp": <expiration timestamp="timestamp" in="in" RFC3339="RFC3339" xmlns="http://www.w3.org/1999/xhtml"></expiration>,
        /// },
        /// ...
        /// }
        ///
        /// Note: Audience in each TokenRequest should be different and at most one token is empty string. To receive a new token after expiry, RequiresRepublish can be used to trigger NodePublishVolume periodically.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverSpec#tokenRequests
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "tokenRequests", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.TokenRequest\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.ITokenRequest[]? TokenRequests
        {
            get;
            set;
        }

        /// <summary>volumeLifecycleModes defines what kind of volumes this CSI volume driver supports.</summary>
        /// <remarks>
        /// The default if the list is empty is "Persistent", which is the usage defined by the CSI specification and implemented in Kubernetes via the usual PV/PVC mechanism.
        ///
        /// The other mode is "Ephemeral". In this mode, volumes are defined inline inside the pod spec with CSIVolumeSource and their lifecycle is tied to the lifecycle of that pod. A driver has to be aware of this because it is only going to get a NodePublishVolume call for such a volume.
        ///
        /// For more information about implementing this mode, see https://kubernetes-csi.github.io/docs/ephemeral-local-volumes.html A driver can support one or more of these modes and more modes may be added in the future.
        ///
        /// This field is beta. This field is immutable.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSIDriverSpec#volumeLifecycleModes
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volumeLifecycleModes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        public string[]? VolumeLifecycleModes
        {
            get;
            set;
        }
    }
}
