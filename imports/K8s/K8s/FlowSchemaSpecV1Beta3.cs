using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>FlowSchemaSpec describes how the FlowSchema's specification looks like.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.FlowSchemaSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.FlowSchemaSpecV1Beta3")]
    public class FlowSchemaSpecV1Beta3 : K8s.IFlowSchemaSpecV1Beta3
    {
        /// <summary>`priorityLevelConfiguration` should reference a PriorityLevelConfiguration in the cluster.</summary>
        /// <remarks>
        /// If the reference cannot be resolved, the FlowSchema will be ignored and marked as invalid in its status. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.FlowSchemaSpec#priorityLevelConfiguration
        /// </remarks>
        [JsiiProperty(name: "priorityLevelConfiguration", typeJson: "{\"fqn\":\"k8s.PriorityLevelConfigurationReferenceV1Beta3\"}")]
        public K8s.IPriorityLevelConfigurationReferenceV1Beta3 PriorityLevelConfiguration
        {
            get;
            set;
        }

        /// <summary>`distinguisherMethod` defines how to compute the flow distinguisher for requests that match this schema.</summary>
        /// <remarks>
        /// <c>nil</c> specifies that the distinguisher is disabled and thus will always be the empty string.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.FlowSchemaSpec#distinguisherMethod
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "distinguisherMethod", typeJson: "{\"fqn\":\"k8s.FlowDistinguisherMethodV1Beta3\"}", isOptional: true)]
        public K8s.IFlowDistinguisherMethodV1Beta3? DistinguisherMethod
        {
            get;
            set;
        }

        /// <summary>`matchingPrecedence` is used to choose among the FlowSchemas that match a given request.</summary>
        /// <remarks>
        /// The chosen FlowSchema is among those with the numerically lowest (which we take to be logically highest) MatchingPrecedence.  Each MatchingPrecedence value must be ranged in [1,10000]. Note that if the precedence is not specified, it will be set to 1000 as default.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.FlowSchemaSpec#matchingPrecedence
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchingPrecedence", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MatchingPrecedence
        {
            get;
            set;
        }

        /// <summary>`rules` describes which requests will match this flow schema.</summary>
        /// <remarks>
        /// This FlowSchema matches a request if and only if at least one member of rules matches the request. if it is an empty slice, there will be no requests matching the FlowSchema.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.FlowSchemaSpec#rules
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.PolicyRulesWithSubjectsV1Beta3\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IPolicyRulesWithSubjectsV1Beta3[]? Rules
        {
            get;
            set;
        }
    }
}
