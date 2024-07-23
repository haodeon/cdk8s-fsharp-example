using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>VolumeResourceRequirements describes the storage resource requirements for a volume.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeResourceRequirements
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IVolumeResourceRequirements), fullyQualifiedName: "k8s.VolumeResourceRequirements")]
    public interface IVolumeResourceRequirements
    {
        /// <summary>Limits describes the maximum amount of compute resources allowed.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeResourceRequirements#limits
        /// </remarks>
        [JsiiProperty(name: "limits", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, K8s.Quantity>? Limits
        {
            get
            {
                return null;
            }
        }

        /// <summary>Requests describes the minimum amount of compute resources required.</summary>
        /// <remarks>
        /// If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeResourceRequirements#requests
        /// </remarks>
        [JsiiProperty(name: "requests", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, K8s.Quantity>? Requests
        {
            get
            {
                return null;
            }
        }

        /// <summary>VolumeResourceRequirements describes the storage resource requirements for a volume.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeResourceRequirements
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IVolumeResourceRequirements), fullyQualifiedName: "k8s.VolumeResourceRequirements")]
        internal sealed class _Proxy : DeputyBase, K8s.IVolumeResourceRequirements
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Limits describes the maximum amount of compute resources allowed.</summary>
            /// <remarks>
            /// More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeResourceRequirements#limits
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limits", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, K8s.Quantity>? Limits
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, K8s.Quantity>?>();
            }

            /// <summary>Requests describes the minimum amount of compute resources required.</summary>
            /// <remarks>
            /// If Requests is omitted for a container, it defaults to Limits if that is explicitly specified, otherwise to an implementation-defined value. Requests cannot exceed Limits. More info: https://kubernetes.io/docs/concepts/configuration/manage-resources-containers/
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeResourceRequirements#requests
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "requests", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Quantity\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, K8s.Quantity>? Requests
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, K8s.Quantity>?>();
            }
        }
    }
}
