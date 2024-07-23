using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PolicyRulesWithSubjects prescribes a test that applies to a request to an apiserver.</summary>
    /// <remarks>
    /// The test considers the subject making the request, the verb being requested, and the resource to be acted upon. This PolicyRulesWithSubjects matches a request if and only if both (a) at least one member of subjects matches the request and (b) at least one member of resourceRules or nonResourceRules matches the request.
    ///
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PolicyRulesWithSubjects
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PolicyRulesWithSubjects")]
    public class PolicyRulesWithSubjects : K8s.IPolicyRulesWithSubjects
    {
        /// <summary>subjects is the list of normal user, serviceaccount, or group that this rule cares about.</summary>
        /// <remarks>
        /// There must be at least one member in this slice. A slice that includes both the system:authenticated and system:unauthenticated user groups matches every request. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PolicyRulesWithSubjects#subjects
        /// </remarks>
        [JsiiProperty(name: "subjects", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Subject\"},\"kind\":\"array\"}}")]
        public K8s.ISubject[] Subjects
        {
            get;
            set;
        }

        /// <summary>`nonResourceRules` is a list of NonResourcePolicyRules that identify matching requests according to their verb and the target non-resource URL.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PolicyRulesWithSubjects#nonResourceRules
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "nonResourceRules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NonResourcePolicyRule\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.INonResourcePolicyRule[]? NonResourceRules
        {
            get;
            set;
        }

        /// <summary>`resourceRules` is a slice of ResourcePolicyRules that identify matching requests according to their verb and the target resource.</summary>
        /// <remarks>
        /// At least one of <c>resourceRules</c> and <c>nonResourceRules</c> has to be non-empty.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PolicyRulesWithSubjects#resourceRules
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "resourceRules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ResourcePolicyRule\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IResourcePolicyRule[]? ResourceRules
        {
            get;
            set;
        }
    }
}
