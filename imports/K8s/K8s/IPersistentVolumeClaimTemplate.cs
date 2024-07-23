using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PersistentVolumeClaimTemplate is used to produce PersistentVolumeClaim objects as part of an EphemeralVolumeSource.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimTemplate
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPersistentVolumeClaimTemplate), fullyQualifiedName: "k8s.PersistentVolumeClaimTemplate")]
    public interface IPersistentVolumeClaimTemplate
    {
        /// <summary>The specification for the PersistentVolumeClaim.</summary>
        /// <remarks>
        /// The entire content is copied unchanged into the PVC that gets created from this template. The same fields as in a PersistentVolumeClaim are also valid here.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimTemplate#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.PersistentVolumeClaimSpec\"}")]
        K8s.IPersistentVolumeClaimSpec Spec
        {
            get;
        }

        /// <summary>May contain labels and annotations that will be copied into the PVC when creating it.</summary>
        /// <remarks>
        /// No other fields are allowed and will be rejected during validation.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimTemplate#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>PersistentVolumeClaimTemplate is used to produce PersistentVolumeClaim objects as part of an EphemeralVolumeSource.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimTemplate
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPersistentVolumeClaimTemplate), fullyQualifiedName: "k8s.PersistentVolumeClaimTemplate")]
        internal sealed class _Proxy : DeputyBase, K8s.IPersistentVolumeClaimTemplate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>The specification for the PersistentVolumeClaim.</summary>
            /// <remarks>
            /// The entire content is copied unchanged into the PVC that gets created from this template. The same fields as in a PersistentVolumeClaim are also valid here.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PersistentVolumeClaimTemplate#spec
            /// </remarks>
            [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.PersistentVolumeClaimSpec\"}")]
            public K8s.IPersistentVolumeClaimSpec Spec
            {
                get => GetInstanceProperty<K8s.IPersistentVolumeClaimSpec>()!;
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
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }
        }
    }
}
