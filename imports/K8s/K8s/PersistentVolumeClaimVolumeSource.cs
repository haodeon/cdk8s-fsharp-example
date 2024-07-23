using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PersistentVolumeClaimVolumeSource references the user's PVC in the same namespace.</summary>
    /// <remarks>
    /// This volume finds the bound PV and mounts that volume for the pod. A PersistentVolumeClaimVolumeSource is, essentially, a wrapper around another type of volume that is owned by someone else (the system).
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PersistentVolumeClaimVolumeSource")]
    public class PersistentVolumeClaimVolumeSource : K8s.IPersistentVolumeClaimVolumeSource
    {
        /// <summary>claimName is the name of a PersistentVolumeClaim in the same namespace as the pod using this volume.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/storage/persistent-volumes#persistentvolumeclaims
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimVolumeSource#claimName
        /// </remarks>
        [JsiiProperty(name: "claimName", typeJson: "{\"primitive\":\"string\"}")]
        public string ClaimName
        {
            get;
            set;
        }

        /// <summary>readOnly Will force the ReadOnly setting in VolumeMounts.</summary>
        /// <remarks>
        /// Default false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimVolumeSource#readOnly
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
