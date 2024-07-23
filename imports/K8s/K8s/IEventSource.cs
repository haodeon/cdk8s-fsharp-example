using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EventSource contains information for an event.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.EventSource
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IEventSource), fullyQualifiedName: "k8s.EventSource")]
    public interface IEventSource
    {
        /// <summary>Component from which the event is generated.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EventSource#component
        /// </remarks>
        [JsiiProperty(name: "component", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Component
        {
            get
            {
                return null;
            }
        }

        /// <summary>Node name on which the event is generated.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EventSource#host
        /// </remarks>
        [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Host
        {
            get
            {
                return null;
            }
        }

        /// <summary>EventSource contains information for an event.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EventSource
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IEventSource), fullyQualifiedName: "k8s.EventSource")]
        internal sealed class _Proxy : DeputyBase, K8s.IEventSource
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Component from which the event is generated.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EventSource#component
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "component", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Component
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Node name on which the event is generated.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.EventSource#host
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "host", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Host
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
