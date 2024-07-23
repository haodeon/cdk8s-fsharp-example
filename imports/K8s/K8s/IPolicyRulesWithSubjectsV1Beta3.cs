using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PolicyRulesWithSubjects prescribes a test that applies to a request to an apiserver.</summary>
    /// <remarks>
    /// The test considers the subject making the request, the verb being requested, and the resource to be acted upon. This PolicyRulesWithSubjects matches a request if and only if both (a) at least one member of subjects matches the request and (b) at least one member of resourceRules or nonResourceRules matches the request.
    ///
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PolicyRulesWithSubjects
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPolicyRulesWithSubjectsV1Beta3), fullyQualifiedName: "k8s.PolicyRulesWithSubjectsV1Beta3")]
    public interface IPolicyRulesWithSubjectsV1Beta3
    {
        /// <summary>subjects is the list of normal user, serviceaccount, or group that this rule cares about.</summary>
        /// <remarks>
        /// There must be at least one member in this slice. A slice that includes both the system:authenticated and system:unauthenticated user groups matches every request. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PolicyRulesWithSubjects#subjects
        /// </remarks>
        [JsiiProperty(name: "subjects", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.SubjectV1Beta3\"},\"kind\":\"array\"}}")]
        K8s.ISubjectV1Beta3[] Subjects
        {
            get;
        }

        /// <summary>`nonResourceRules` is a list of NonResourcePolicyRules that identify matching requests according to their verb and the target non-resource URL.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PolicyRulesWithSubjects#nonResourceRules
        /// </remarks>
        [JsiiProperty(name: "nonResourceRules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NonResourcePolicyRuleV1Beta3\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INonResourcePolicyRuleV1Beta3[]? NonResourceRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>`resourceRules` is a slice of ResourcePolicyRules that identify matching requests according to their verb and the target resource.</summary>
        /// <remarks>
        /// At least one of <c>resourceRules</c> and <c>nonResourceRules</c> has to be non-empty.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PolicyRulesWithSubjects#resourceRules
        /// </remarks>
        [JsiiProperty(name: "resourceRules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ResourcePolicyRuleV1Beta3\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IResourcePolicyRuleV1Beta3[]? ResourceRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>PolicyRulesWithSubjects prescribes a test that applies to a request to an apiserver.</summary>
        /// <remarks>
        /// The test considers the subject making the request, the verb being requested, and the resource to be acted upon. This PolicyRulesWithSubjects matches a request if and only if both (a) at least one member of subjects matches the request and (b) at least one member of resourceRules or nonResourceRules matches the request.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PolicyRulesWithSubjects
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPolicyRulesWithSubjectsV1Beta3), fullyQualifiedName: "k8s.PolicyRulesWithSubjectsV1Beta3")]
        internal sealed class _Proxy : DeputyBase, K8s.IPolicyRulesWithSubjectsV1Beta3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>subjects is the list of normal user, serviceaccount, or group that this rule cares about.</summary>
            /// <remarks>
            /// There must be at least one member in this slice. A slice that includes both the system:authenticated and system:unauthenticated user groups matches every request. Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PolicyRulesWithSubjects#subjects
            /// </remarks>
            [JsiiProperty(name: "subjects", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.SubjectV1Beta3\"},\"kind\":\"array\"}}")]
            public K8s.ISubjectV1Beta3[] Subjects
            {
                get => GetInstanceProperty<K8s.ISubjectV1Beta3[]>()!;
            }

            /// <summary>`nonResourceRules` is a list of NonResourcePolicyRules that identify matching requests according to their verb and the target non-resource URL.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PolicyRulesWithSubjects#nonResourceRules
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nonResourceRules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NonResourcePolicyRuleV1Beta3\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.INonResourcePolicyRuleV1Beta3[]? NonResourceRules
            {
                get => GetInstanceProperty<K8s.INonResourcePolicyRuleV1Beta3[]?>();
            }

            /// <summary>`resourceRules` is a slice of ResourcePolicyRules that identify matching requests according to their verb and the target resource.</summary>
            /// <remarks>
            /// At least one of <c>resourceRules</c> and <c>nonResourceRules</c> has to be non-empty.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PolicyRulesWithSubjects#resourceRules
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceRules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.ResourcePolicyRuleV1Beta3\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IResourcePolicyRuleV1Beta3[]? ResourceRules
            {
                get => GetInstanceProperty<K8s.IResourcePolicyRuleV1Beta3[]?>();
            }
        }
    }
}
