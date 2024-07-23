using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>QueuingConfiguration holds the configuration parameters for queuing.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.QueuingConfiguration
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IQueuingConfigurationV1Beta3), fullyQualifiedName: "k8s.QueuingConfigurationV1Beta3")]
    public interface IQueuingConfigurationV1Beta3
    {
        /// <summary>`handSize` is a small positive number that configures the shuffle sharding of requests into queues.</summary>
        /// <remarks>
        /// When enqueuing a request at this priority level the request's flow identifier (a string pair) is hashed and the hash value is used to shuffle the list of queues and deal a hand of the size specified here.  The request is put into one of the shortest queues in that hand. <c>handSize</c> must be no larger than <c>queues</c>, and should be significantly smaller (so that a few heavy flows do not saturate most of the queues).  See the user-facing documentation for more extensive guidance on setting this field.  This field has a default value of 8.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.QueuingConfiguration#handSize
        /// </remarks>
        [JsiiProperty(name: "handSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? HandSize
        {
            get
            {
                return null;
            }
        }

        /// <summary>`queueLengthLimit` is the maximum number of requests allowed to be waiting in a given queue of this priority level at a time;</summary>
        /// <remarks>
        /// excess requests are rejected.  This value must be positive.  If not specified, it will be defaulted to 50.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.QueuingConfiguration#queueLengthLimit
        /// </remarks>
        [JsiiProperty(name: "queueLengthLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? QueueLengthLimit
        {
            get
            {
                return null;
            }
        }

        /// <summary>`queues` is the number of queues for this priority level.</summary>
        /// <remarks>
        /// The queues exist independently at each apiserver. The value must be positive.  Setting it to 1 effectively precludes shufflesharding and thus makes the distinguisher method of associated flow schemas irrelevant.  This field has a default value of 64.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.QueuingConfiguration#queues
        /// </remarks>
        [JsiiProperty(name: "queues", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Queues
        {
            get
            {
                return null;
            }
        }

        /// <summary>QueuingConfiguration holds the configuration parameters for queuing.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.QueuingConfiguration
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IQueuingConfigurationV1Beta3), fullyQualifiedName: "k8s.QueuingConfigurationV1Beta3")]
        internal sealed class _Proxy : DeputyBase, K8s.IQueuingConfigurationV1Beta3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`handSize` is a small positive number that configures the shuffle sharding of requests into queues.</summary>
            /// <remarks>
            /// When enqueuing a request at this priority level the request's flow identifier (a string pair) is hashed and the hash value is used to shuffle the list of queues and deal a hand of the size specified here.  The request is put into one of the shortest queues in that hand. <c>handSize</c> must be no larger than <c>queues</c>, and should be significantly smaller (so that a few heavy flows do not saturate most of the queues).  See the user-facing documentation for more extensive guidance on setting this field.  This field has a default value of 8.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.QueuingConfiguration#handSize
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "handSize", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? HandSize
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>`queueLengthLimit` is the maximum number of requests allowed to be waiting in a given queue of this priority level at a time;</summary>
            /// <remarks>
            /// excess requests are rejected.  This value must be positive.  If not specified, it will be defaulted to 50.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.QueuingConfiguration#queueLengthLimit
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queueLengthLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? QueueLengthLimit
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>`queues` is the number of queues for this priority level.</summary>
            /// <remarks>
            /// The queues exist independently at each apiserver. The value must be positive.  Setting it to 1 effectively precludes shufflesharding and thus makes the distinguisher method of associated flow schemas irrelevant.  This field has a default value of 64.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.QueuingConfiguration#queues
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "queues", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Queues
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
