using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Event is a report of an event somewhere in the cluster.</summary>
    /// <remarks>
    /// It generally denotes some state change in the system. Events have a limited retention time and triggers and messages may evolve with time.  Event consumers should not rely on the timing of an event with a given Reason reflecting a consistent underlying trigger, or the continued existence of events with that Reason.  Events should be treated as informative, best-effort, supplemental data.
    ///
    /// <strong>Schema</strong>: io.k8s.api.events.v1.Event
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeEventProps), fullyQualifiedName: "k8s.KubeEventProps")]
    public interface IKubeEventProps
    {
        /// <summary>eventTime is the time when this Event was first observed.</summary>
        /// <remarks>
        /// It is required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#eventTime
        /// </remarks>
        [JsiiProperty(name: "eventTime", typeJson: "{\"primitive\":\"date\"}")]
        System.DateTime EventTime
        {
            get;
        }

        /// <summary>action is what action was taken/failed regarding to the regarding object.</summary>
        /// <remarks>
        /// It is machine-readable. This field cannot be empty for new Events and it can have at most 128 characters.
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#action
        /// </remarks>
        [JsiiProperty(name: "action", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Action
        {
            get
            {
                return null;
            }
        }

        /// <summary>deprecatedCount is the deprecated field assuring backward compatibility with core.v1 Event type.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#deprecatedCount
        /// </remarks>
        [JsiiProperty(name: "deprecatedCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? DeprecatedCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>deprecatedFirstTimestamp is the deprecated field assuring backward compatibility with core.v1 Event type.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#deprecatedFirstTimestamp
        /// </remarks>
        [JsiiProperty(name: "deprecatedFirstTimestamp", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.DateTime? DeprecatedFirstTimestamp
        {
            get
            {
                return null;
            }
        }

        /// <summary>deprecatedLastTimestamp is the deprecated field assuring backward compatibility with core.v1 Event type.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#deprecatedLastTimestamp
        /// </remarks>
        [JsiiProperty(name: "deprecatedLastTimestamp", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.DateTime? DeprecatedLastTimestamp
        {
            get
            {
                return null;
            }
        }

        /// <summary>deprecatedSource is the deprecated field assuring backward compatibility with core.v1 Event type.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#deprecatedSource
        /// </remarks>
        [JsiiProperty(name: "deprecatedSource", typeJson: "{\"fqn\":\"k8s.EventSource\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IEventSource? DeprecatedSource
        {
            get
            {
                return null;
            }
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>note is a human-readable description of the status of this operation.</summary>
        /// <remarks>
        /// Maximal length of the note is 1kB, but libraries should be prepared to handle values up to 64kB.
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#note
        /// </remarks>
        [JsiiProperty(name: "note", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Note
        {
            get
            {
                return null;
            }
        }

        /// <summary>reason is why the action was taken.</summary>
        /// <remarks>
        /// It is human-readable. This field cannot be empty for new Events and it can have at most 128 characters.
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#reason
        /// </remarks>
        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Reason
        {
            get
            {
                return null;
            }
        }

        /// <summary>regarding contains the object this Event is about.</summary>
        /// <remarks>
        /// In most cases it's an Object reporting controller implements, e.g. ReplicaSetController implements ReplicaSets and this event is emitted because it acts on some changes in a ReplicaSet object.
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#regarding
        /// </remarks>
        [JsiiProperty(name: "regarding", typeJson: "{\"fqn\":\"k8s.ObjectReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectReference? Regarding
        {
            get
            {
                return null;
            }
        }

        /// <summary>related is the optional secondary object for more complex actions.</summary>
        /// <remarks>
        /// E.g. when regarding object triggers a creation or deletion of related object.
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#related
        /// </remarks>
        [JsiiProperty(name: "related", typeJson: "{\"fqn\":\"k8s.ObjectReference\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectReference? Related
        {
            get
            {
                return null;
            }
        }

        /// <summary>reportingController is the name of the controller that emitted this Event, e.g. `kubernetes.io/kubelet`. This field cannot be empty for new Events.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#reportingController
        /// </remarks>
        [JsiiProperty(name: "reportingController", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReportingController
        {
            get
            {
                return null;
            }
        }

        /// <summary>reportingInstance is the ID of the controller instance, e.g. `kubelet-xyzf`. This field cannot be empty for new Events and it can have at most 128 characters.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#reportingInstance
        /// </remarks>
        [JsiiProperty(name: "reportingInstance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? ReportingInstance
        {
            get
            {
                return null;
            }
        }

        /// <summary>series is data about the Event series this event represents or nil if it's a singleton Event.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#series
        /// </remarks>
        [JsiiProperty(name: "series", typeJson: "{\"fqn\":\"k8s.EventSeries\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IEventSeries? Series
        {
            get
            {
                return null;
            }
        }

        /// <summary>type is the type of this event (Normal, Warning), new types could be added in the future.</summary>
        /// <remarks>
        /// It is machine-readable. This field cannot be empty for new Events.
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#type
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

        /// <summary>Event is a report of an event somewhere in the cluster.</summary>
        /// <remarks>
        /// It generally denotes some state change in the system. Events have a limited retention time and triggers and messages may evolve with time.  Event consumers should not rely on the timing of an event with a given Reason reflecting a consistent underlying trigger, or the continued existence of events with that Reason.  Events should be treated as informative, best-effort, supplemental data.
        ///
        /// <strong>Schema</strong>: io.k8s.api.events.v1.Event
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeEventProps), fullyQualifiedName: "k8s.KubeEventProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeEventProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>eventTime is the time when this Event was first observed.</summary>
            /// <remarks>
            /// It is required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#eventTime
            /// </remarks>
            [JsiiProperty(name: "eventTime", typeJson: "{\"primitive\":\"date\"}")]
            public System.DateTime EventTime
            {
                get => GetInstanceProperty<System.DateTime>()!;
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
                get => GetInstanceProperty<string?>();
            }

            /// <summary>deprecatedCount is the deprecated field assuring backward compatibility with core.v1 Event type.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#deprecatedCount
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deprecatedCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? DeprecatedCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>deprecatedFirstTimestamp is the deprecated field assuring backward compatibility with core.v1 Event type.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#deprecatedFirstTimestamp
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deprecatedFirstTimestamp", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
            public System.DateTime? DeprecatedFirstTimestamp
            {
                get => GetInstanceProperty<System.DateTime?>();
            }

            /// <summary>deprecatedLastTimestamp is the deprecated field assuring backward compatibility with core.v1 Event type.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#deprecatedLastTimestamp
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deprecatedLastTimestamp", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
            public System.DateTime? DeprecatedLastTimestamp
            {
                get => GetInstanceProperty<System.DateTime?>();
            }

            /// <summary>deprecatedSource is the deprecated field assuring backward compatibility with core.v1 Event type.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#deprecatedSource
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "deprecatedSource", typeJson: "{\"fqn\":\"k8s.EventSource\"}", isOptional: true)]
            public K8s.IEventSource? DeprecatedSource
            {
                get => GetInstanceProperty<K8s.IEventSource?>();
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
                get => GetInstanceProperty<K8s.IObjectMeta?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<string?>();
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
                get => GetInstanceProperty<K8s.IObjectReference?>();
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
                get => GetInstanceProperty<K8s.IObjectReference?>();
            }

            /// <summary>reportingController is the name of the controller that emitted this Event, e.g. `kubernetes.io/kubelet`. This field cannot be empty for new Events.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#reportingController
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reportingController", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReportingController
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>reportingInstance is the ID of the controller instance, e.g. `kubelet-xyzf`. This field cannot be empty for new Events and it can have at most 128 characters.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#reportingInstance
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "reportingInstance", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? ReportingInstance
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>series is data about the Event series this event represents or nil if it's a singleton Event.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.events.v1.Event#series
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "series", typeJson: "{\"fqn\":\"k8s.EventSeries\"}", isOptional: true)]
            public K8s.IEventSeries? Series
            {
                get => GetInstanceProperty<K8s.IEventSeries?>();
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
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
