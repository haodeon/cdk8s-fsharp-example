using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PersistentVolumeClaimTemplate is used to produce PersistentVolumeClaim objects as part of an EphemeralVolumeSource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimTemplate
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PersistentVolumeClaimTemplate")]
    public class PersistentVolumeClaimTemplate : K8s.IPersistentVolumeClaimTemplate
    {
        /// <summary>The specification for the PersistentVolumeClaim.</summary>
        /// <remarks>
        /// The entire content is copied unchanged into the PVC that gets created from this template. The same fields as in a PersistentVolumeClaim are also valid here.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimTemplate#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.PersistentVolumeClaimSpec\"}")]
        public K8s.IPersistentVolumeClaimSpec Spec
        {
            get;
            set;
        }

        /// <summary>May contain labels and annotations that will be copied into the PVC when creating it.</summary>
        /// <remarks>
        /// No other fields are allowed and will be rejected during validation.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimTemplate#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }
    }
}
