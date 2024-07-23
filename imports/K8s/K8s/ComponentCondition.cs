using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Information about the condition of a component.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentCondition
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ComponentCondition")]
    public class ComponentCondition : K8s.IComponentCondition
    {
        /// <summary>Status of the condition for a component.</summary>
        /// <remarks>
        /// Valid values for "Healthy": "True", "False", or "Unknown".
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.ComponentCondition#status
        /// </remarks>
        [JsiiProperty(name: "status", typeJson: "{\"primitive\":\"string\"}")]
        public string Status
        {
            get;
            set;
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
            get;
            set;
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
            get;
            set;
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
            get;
            set;
        }
    }
}
