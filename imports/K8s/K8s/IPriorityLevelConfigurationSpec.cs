using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PriorityLevelConfigurationSpec specifies the configuration of a priority level.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPriorityLevelConfigurationSpec), fullyQualifiedName: "k8s.PriorityLevelConfigurationSpec")]
    public interface IPriorityLevelConfigurationSpec
    {
        /// <summary>`type` indicates whether this priority level is subject to limitation on request execution.</summary>
        /// <remarks>
        /// A value of <c>"Exempt"</c> means that requests of this priority level are not subject to a limit (and thus are never queued) and do not detract from the capacity made available to other priority levels.  A value of <c>"Limited"</c> means that (a) requests of this priority level <em>are</em> subject to limits and (b) some of the server's limited capacity is made available exclusively to this priority level. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationSpec#type
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
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationSpec#exempt
        /// </remarks>
        [JsiiProperty(name: "exempt", typeJson: "{\"fqn\":\"k8s.ExemptPriorityLevelConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IExemptPriorityLevelConfiguration? Exempt
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
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationSpec#limited
        /// </remarks>
        [JsiiProperty(name: "limited", typeJson: "{\"fqn\":\"k8s.LimitedPriorityLevelConfiguration\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILimitedPriorityLevelConfiguration? Limited
        {
            get
            {
                return null;
            }
        }

        /// <summary>PriorityLevelConfigurationSpec specifies the configuration of a priority level.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPriorityLevelConfigurationSpec), fullyQualifiedName: "k8s.PriorityLevelConfigurationSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.IPriorityLevelConfigurationSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`type` indicates whether this priority level is subject to limitation on request execution.</summary>
            /// <remarks>
            /// A value of <c>"Exempt"</c> means that requests of this priority level are not subject to a limit (and thus are never queued) and do not detract from the capacity made available to other priority levels.  A value of <c>"Limited"</c> means that (a) requests of this priority level <em>are</em> subject to limits and (b) some of the server's limited capacity is made available exclusively to this priority level. Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationSpec#type
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
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationSpec#exempt
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "exempt", typeJson: "{\"fqn\":\"k8s.ExemptPriorityLevelConfiguration\"}", isOptional: true)]
            public K8s.IExemptPriorityLevelConfiguration? Exempt
            {
                get => GetInstanceProperty<K8s.IExemptPriorityLevelConfiguration?>();
            }

            /// <summary>`limited` specifies how requests are handled for a Limited priority level.</summary>
            /// <remarks>
            /// This field must be non-empty if and only if <c>type</c> is <c>"Limited"</c>.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationSpec#limited
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "limited", typeJson: "{\"fqn\":\"k8s.LimitedPriorityLevelConfiguration\"}", isOptional: true)]
            public K8s.ILimitedPriorityLevelConfiguration? Limited
            {
                get => GetInstanceProperty<K8s.ILimitedPriorityLevelConfiguration?>();
            }
        }
    }
}
