using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Information about the condition of a component.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentCondition
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IComponentCondition), fullyQualifiedName: "k8s.ComponentCondition")]
    public interface IComponentCondition
    {
        /// <summary>Status of the condition for a component.</summary>
        /// <remarks>
        /// Valid values for "Healthy": "True", "False", or "Unknown".
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentCondition#status
        /// </remarks>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        string Status
        {
            get;
        }

        /// <summary>Type of condition for a component.</summary>
        /// <remarks>
        /// Valid value: "Healthy"
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentCondition#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Condition error code for a component.</summary>
        /// <remarks>
        /// For example, a health check error code.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentCondition#error
        /// </remarks>
        [JsiiProperty(name: "error", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Error
        {
            get
            {
                return null;
            }
        }

        /// <summary>Message about the condition for a component.</summary>
        /// <remarks>
        /// For example, information about a health check.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentCondition#message
        /// </remarks>
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Message
        {
            get
            {
                return null;
            }
        }

        /// <summary>Information about the condition of a component.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentCondition
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IComponentCondition), fullyQualifiedName: "k8s.ComponentCondition")]
        internal sealed class _Proxy : DeputyBase, K8s.IComponentCondition
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Status of the condition for a component.</summary>
            /// <remarks>
            /// Valid values for "Healthy": "True", "False", or "Unknown".
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentCondition#status
            /// </remarks>
            [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
            public string Status
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Type of condition for a component.</summary>
            /// <remarks>
            /// Valid value: "Healthy"
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentCondition#type
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Condition error code for a component.</summary>
            /// <remarks>
            /// For example, a health check error code.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentCondition#error
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "error", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Error
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Message about the condition for a component.</summary>
            /// <remarks>
            /// For example, information about a health check.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentCondition#message
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Message
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
