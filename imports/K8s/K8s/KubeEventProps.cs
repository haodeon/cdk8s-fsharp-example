using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Event is a report of an event somewhere in the cluster.</summary>
    /// <remarks>
    /// It generally denotes some state change in the system. Events have a limited retention time and triggers and messages may evolve with time.  Event consumers should not rely on the timing of an event with a given Reason reflecting a consistent underlying trigger, or the continued existence of events with that Reason.  Events should be treated as informative, best-effort, supplemental data.
    ///
    /// <strong>Schema</strong>: io.k8s.api.events.v1.Event
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeEventProps")]
    public class KubeEventProps : K8s.IKubeEventProps
    {
        /// <summary>eventTime is the time when this Event was first observed.</summary>
        /// <remarks>
        /// It is required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#eventTime
        /// </remarks>
        [JsiiProperty(name: "eventTime", typeJson: "{\"primitive\":\"date\"}")]
        public System.DateTime EventTime
        {
            get;
            set;
        }

        /// <summary>action is what action was taken/failed regarding to the regarding object.</summary>
        /// <remarks>
        /// It is machine-readable. This field cannot be empty for new Events and it can have at most 128 characters.
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#action
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Action
        {
            get;
            set;
        }

        /// <summary>deprecatedCount is the deprecated field assuring backward compatibility with core.v1 Event type.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#deprecatedCount
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deprecatedCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? DeprecatedCount
        {
            get;
            set;
        }

        /// <summary>deprecatedFirstTimestamp is the deprecated field assuring backward compatibility with core.v1 Event type.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#deprecatedFirstTimestamp
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deprecatedFirstTimestamp", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
        public System.DateTime? DeprecatedFirstTimestamp
        {
            get;
            set;
        }

        /// <summary>deprecatedLastTimestamp is the deprecated field assuring backward compatibility with core.v1 Event type.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#deprecatedLastTimestamp
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deprecatedLastTimestamp", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
        public System.DateTime? DeprecatedLastTimestamp
        {
            get;
            set;
        }

        /// <summary>deprecatedSource is the deprecated field assuring backward compatibility with core.v1 Event type.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#deprecatedSource
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "deprecatedSource", typeJson: "{\"fqn\":\"k8s.EventSource\"}", isOptional: true)]
        public K8s.IEventSource? DeprecatedSource
        {
            get;
            set;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>note is a human-readable description of the status of this operation.</summary>
        /// <remarks>
        /// Maximal length of the note is 1kB, but libraries should be prepared to handle values up to 64kB.
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#note
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "note", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Note
        {
            get;
            set;
        }

        /// <summary>reason is why the action was taken.</summary>
        /// <remarks>
        /// It is human-readable. This field cannot be empty for new Events and it can have at most 128 characters.
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#reason
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Reason
        {
            get;
            set;
        }

        /// <summary>regarding contains the object this Event is about.</summary>
        /// <remarks>
        /// In most cases it's an Object reporting controller implements, e.g. ReplicaSetController implements ReplicaSets and this event is emitted because it acts on some changes in a ReplicaSet object.
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#regarding
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "regarding", typeJson: "{\"fqn\":\"k8s.ObjectReference\"}", isOptional: true)]
        public K8s.IObjectReference? Regarding
        {
            get;
            set;
        }

        /// <summary>related is the optional secondary object for more complex actions.</summary>
        /// <remarks>
        /// E.g. when regarding object triggers a creation or deletion of related object.
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#related
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "related", typeJson: "{\"fqn\":\"k8s.ObjectReference\"}", isOptional: true)]
        public K8s.IObjectReference? Related
        {
            get;
            set;
        }

        /// <summary>reportingController is the name of the controller that emitted this Event, e.g. `kubernetes.io/kubelet`. This field cannot be empty for new Events.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#reportingController
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reportingController", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReportingController
        {
            get;
            set;
        }

        /// <summary>reportingInstance is the ID of the controller instance, e.g. `kubelet-xyzf`. This field cannot be empty for new Events and it can have at most 128 characters.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#reportingInstance
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reportingInstance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReportingInstance
        {
            get;
            set;
        }

        /// <summary>series is data about the Event series this event represents or nil if it's a singleton Event.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#series
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "series", typeJson: "{\"fqn\":\"k8s.EventSeries\"}", isOptional: true)]
        public K8s.IEventSeries? Series
        {
            get;
            set;
        }

        /// <summary>type is the type of this event (Normal, Warning), new types could be added in the future.</summary>
        /// <remarks>
        /// It is machine-readable. This field cannot be empty for new Events.
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#type
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }
    }
}
