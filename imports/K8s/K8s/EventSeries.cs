using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>EventSeries contain information on series of events, i.e. thing that was/is happening continuously for some time. How often to update the EventSeries is up to the event reporters. The default event reporter in "k8s.io/client-go/tools/events/event_broadcaster.go" shows how this struct is updated on heartbeats and can guide customized reporter implementations.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.events.v1.EventSeries
    /// </remarks>
    [JsiiByValue(fqn: "k8s.EventSeries")]
    public class EventSeries : K8s.IEventSeries
    {
        /// <summary>count is the number of occurrences in this series up to the last heartbeat time.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.EventSeries#count
        /// </remarks>
        [JsiiProperty(name: "count", typeJson: "{\"primitive\":\"number\"}")]
        public double Count
        {
            get;
            set;
        }

        /// <summary>lastObservedTime is the time when last Event from the series was seen before last heartbeat.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.EventSeries#lastObservedTime
        /// </remarks>
        [JsiiProperty(name: "lastObservedTime", typeJson: "{\"primitive\":\"date\"}")]
        public System.DateTime LastObservedTime
        {
            get;
            set;
        }
    }
}
