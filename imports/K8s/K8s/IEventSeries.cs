using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>EventSeries contain information on series of events, i.e. thing that was/is happening continuously for some time. How often to update the EventSeries is up to the event reporters. The default event reporter in "k8s.io/client-go/tools/events/event_broadcaster.go" shows how this struct is updated on heartbeats and can guide customized reporter implementations.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.events.v1.EventSeries
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IEventSeries), fullyQualifiedName: "k8s.EventSeries")]
    public interface IEventSeries
    {
        /// <summary>count is the number of occurrences in this series up to the last heartbeat time.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.EventSeries#count
        /// </remarks>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        double Count
        {
            get;
        }

        /// <summary>lastObservedTime is the time when last Event from the series was seen before last heartbeat.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.EventSeries#lastObservedTime
        /// </remarks>
        [JsiiProperty(name: "lastObservedTime", typeJson: "{\"primitive\":\"date\"}")]
        System.DateTime LastObservedTime
        {
            get;
        }

        /// <summary>EventSeries contain information on series of events, i.e. thing that was/is happening continuously for some time. How often to update the EventSeries is up to the event reporters. The default event reporter in "k8s.io/client-go/tools/events/event_broadcaster.go" shows how this struct is updated on heartbeats and can guide customized reporter implementations.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.EventSeries
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IEventSeries), fullyQualifiedName: "k8s.EventSeries")]
        internal sealed class _Proxy : DeputyBase, K8s.IEventSeries
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>count is the number of occurrences in this series up to the last heartbeat time.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.events.v1.EventSeries#count
            /// </remarks>
            [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
            public double Count
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>lastObservedTime is the time when last Event from the series was seen before last heartbeat.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.events.v1.EventSeries#lastObservedTime
            /// </remarks>
            [JsiiProperty(name: "lastObservedTime", typeJson: "{\"primitive\":\"date\"}")]
            public System.DateTime LastObservedTime
            {
                get => GetInstanceProperty<System.DateTime>()!;
            }
        }
    }
}
