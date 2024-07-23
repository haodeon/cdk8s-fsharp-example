using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>DaemonSetUpdateStrategy is a struct used to control the update strategy for a DaemonSet.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetUpdateStrategy
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IDaemonSetUpdateStrategy), fullyQualifiedName: "k8s.DaemonSetUpdateStrategy")]
    public interface IDaemonSetUpdateStrategy
    {
        /// <summary>Rolling update config params.</summary>
        /// <remarks>
        /// Present only if type = "RollingUpdate".
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetUpdateStrategy#rollingUpdate
        /// </remarks>
        [JsiiProperty(name: "rollingUpdate", typeJson: "{\"fqn\":\"k8s.RollingUpdateDaemonSet\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IRollingUpdateDaemonSet? RollingUpdate
        {
            get
            {
                return null;
            }
        }

        /// <summary>Type of daemon set update.</summary>
        /// <remarks>
        /// Can be "RollingUpdate" or "OnDelete". Default is RollingUpdate.
        ///
        /// <strong>Default</strong>: RollingUpdate.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetUpdateStrategy#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Type
        {
            get
            {
                return null;
            }
        }

        /// <summary>DaemonSetUpdateStrategy is a struct used to control the update strategy for a DaemonSet.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetUpdateStrategy
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IDaemonSetUpdateStrategy), fullyQualifiedName: "k8s.DaemonSetUpdateStrategy")]
        internal sealed class _Proxy : DeputyBase, K8s.IDaemonSetUpdateStrategy
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Rolling update config params.</summary>
            /// <remarks>
            /// Present only if type = "RollingUpdate".
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetUpdateStrategy#rollingUpdate
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rollingUpdate", typeJson: "{\"fqn\":\"k8s.RollingUpdateDaemonSet\"}", isOptional: true)]
            public K8s.IRollingUpdateDaemonSet? RollingUpdate
            {
                get => GetInstanceProperty<K8s.IRollingUpdateDaemonSet?>();
            }

            /// <summary>Type of daemon set update.</summary>
            /// <remarks>
            /// Can be "RollingUpdate" or "OnDelete". Default is RollingUpdate.
            ///
            /// <strong>Default</strong>: RollingUpdate.
            ///
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.DaemonSetUpdateStrategy#type
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Type
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
