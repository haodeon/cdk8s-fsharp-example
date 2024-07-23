using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PriorityLevelConfigurationSpec specifies the configuration of a priority level.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PriorityLevelConfigurationSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPriorityLevelConfigurationSpecV1Beta3), fullyQualifiedName: "k8s.PriorityLevelConfigurationSpecV1Beta3")]
    public interface IPriorityLevelConfigurationSpecV1Beta3
    {
        /// <summary>`type` indicates whether this priority level is subject to limitation on request execution.</summary>
        /// <remarks>
        /// A value of <c>"Exempt"</c> means that requests of this priority level are not subject to a limit (and thus are never queued) and do not detract from the capacity made available to other priority levels.  A value of <c>"Limited"</c> means that (a) requests of this priority level <em>are</em> subject to limits and (b) some of the server's limited capacity is made available exclusively to this priority level. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PriorityLevelConfigurationSpec#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>`exempt` specifies how requests are handled for an exempt priority level.</summary>
        /// <remarks>
        /// This field MUST be empty if <c>type</c> is <c>"Limited"</c>. This field MAY be non-empty if <c>type</c> is <c>"Exempt"</c>. If empty and <c>type</c> is <c>"Exempt"</c> then the default values for <c>ExemptPriorityLevelConfiguration</c> apply.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PriorityLevelConfigurationSpec#exempt
        /// </remarks>
        [JsiiProperty(name: "exempt", typeJson: "{\"fqn\":\"k8s.ExemptPriorityLevelConfigurationV1Beta3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IExemptPriorityLevelConfigurationV1Beta3? Exempt
        {
            get
            {
                return null;
            }
        }

        /// <summary>`limited` specifies how requests are handled for a Limited priority level.</summary>
        /// <remarks>
        /// This field must be non-empty if and only if <c>type</c> is <c>"Limited"</c>.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PriorityLevelConfigurationSpec#limited
        /// </remarks>
        [JsiiProperty(name: "limited", typeJson: "{\"fqn\":\"k8s.LimitedPriorityLevelConfigurationV1Beta3\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILimitedPriorityLevelConfigurationV1Beta3? Limited
        {
            get
            {
                return null;
            }
        }

        /// <summary>PriorityLevelConfigurationSpec specifies the configuration of a priority level.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PriorityLevelConfigurationSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPriorityLevelConfigurationSpecV1Beta3), fullyQualifiedName: "k8s.PriorityLevelConfigurationSpecV1Beta3")]
        internal sealed class _Proxy : DeputyBase, K8s.IPriorityLevelConfigurationSpecV1Beta3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`type` indicates whether this priority level is subject to limitation on request execution.</summary>
            /// <remarks>
            /// A value of <c>"Exempt"</c> means that requests of this priority level are not subject to a limit (and thus are never queued) and do not detract from the capacity made available to other priority levels.  A value of <c>"Limited"</c> means that (a) requests of this priority level <em>are</em> subject to limits and (b) some of the server's limited capacity is made available exclusively to this priority level. Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PriorityLevelConfigurationSpec#type
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>`exempt` specifies how requests are handled for an exempt priority level.</summary>
            /// <remarks>
            /// This field MUST be empty if <c>type</c> is <c>"Limited"</c>. This field MAY be non-empty if <c>type</c> is <c>"Exempt"</c>. If empty and <c>type</c> is <c>"Exempt"</c> then the default values for <c>ExemptPriorityLevelConfiguration</c> apply.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PriorityLevelConfigurationSpec#exempt
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exempt", typeJson: "{\"fqn\":\"k8s.ExemptPriorityLevelConfigurationV1Beta3\"}", isOptional: true)]
            public K8s.IExemptPriorityLevelConfigurationV1Beta3? Exempt
            {
                get => GetInstanceProperty<K8s.IExemptPriorityLevelConfigurationV1Beta3?>();
            }

            /// <summary>`limited` specifies how requests are handled for a Limited priority level.</summary>
            /// <remarks>
            /// This field must be non-empty if and only if <c>type</c> is <c>"Limited"</c>.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PriorityLevelConfigurationSpec#limited
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limited", typeJson: "{\"fqn\":\"k8s.LimitedPriorityLevelConfigurationV1Beta3\"}", isOptional: true)]
            public K8s.ILimitedPriorityLevelConfigurationV1Beta3? Limited
            {
                get => GetInstanceProperty<K8s.ILimitedPriorityLevelConfigurationV1Beta3?>();
            }
        }
    }
}
