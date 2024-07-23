using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EventSource contains information for an event.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.EventSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.EventSource")]
    public class EventSource : K8s.IEventSource
    {
        /// <summary>Component from which the event is generated.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EventSource#component
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "component", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Component
        {
            get;
            set;
        }

        /// <summary>Node name on which the event is generated.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EventSource#host
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Host
        {
            get;
            set;
        }
    }
}
