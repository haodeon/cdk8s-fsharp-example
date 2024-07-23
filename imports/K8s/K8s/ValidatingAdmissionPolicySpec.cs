using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ValidatingAdmissionPolicySpec is the specification of the desired behavior of the AdmissionPolicy.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicySpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ValidatingAdmissionPolicySpec")]
    public class ValidatingAdmissionPolicySpec : K8s.IValidatingAdmissionPolicySpec
    {
        /// <summary>auditAnnotations contains CEL expressions which are used to produce audit annotations for the audit event of the API request.</summary>
        /// <remarks>
        /// validations and auditAnnotations may not both be empty; a least one of validations or auditAnnotations is required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicySpec#auditAnnotations
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "auditAnnotations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.AuditAnnotation\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IAuditAnnotation[]? AuditAnnotations
        {
            get;
            set;
        }

        /// <summary>failurePolicy defines how to handle failures for the admission policy.</summary>
        /// <remarks>
        /// Failures can occur from CEL expression parse errors, type check errors, runtime errors and invalid or mis-configured policy definitions or bindings.
        ///
        /// A policy is invalid if spec.paramKind refers to a non-existent Kind. A binding is invalid if spec.paramRef.name refers to a non-existent resource.
        ///
        /// failurePolicy does not define how validations that evaluate to false are handled.
        ///
        /// When failurePolicy is set to Fail, ValidatingAdmissionPolicyBinding validationActions define how failures are enforced.
        ///
        /// Allowed values are Ignore or Fail. Defaults to Fail.
        ///
        /// <strong>Default</strong>: Fail.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicySpec#failurePolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "failurePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FailurePolicy
        {
            get;
            set;
        }

        /// <summary>MatchConditions is a list of conditions that must be met for a request to be validated.</summary>
        /// <remarks>
        /// Match conditions filter requests that have already been matched by the rules, namespaceSelector, and objectSelector. An empty list of matchConditions matches all requests. There are a maximum of 64 match conditions allowed.
        ///
        /// If a parameter object is provided, it can be accessed via the <c>params</c> handle in the same manner as validation expressions.
        ///
        /// The exact matching logic is (in order):
        ///
        /// <list type="number">
        /// <description>If ANY matchCondition evaluates to FALSE, the policy is skipped.</description>
        /// <description>If ALL matchConditions evaluate to TRUE, the policy is evaluated.</description>
        /// <description>If any matchCondition evaluates to an error (but none are FALSE):</description>
        /// </list>
        ///
        /// <list type="bullet">
        /// <description>If failurePolicy=Fail, reject the request</description>
        /// <description>If failurePolicy=Ignore, the policy is skipped</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicySpec#matchConditions
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchConditions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.MatchCondition\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IMatchCondition[]? MatchConditions
        {
            get;
            set;
        }

        /// <summary>MatchConstraints specifies what resources this policy is designed to validate.</summary>
        /// <remarks>
        /// The AdmissionPolicy cares about a request if it matches <em>all</em> Constraints. However, in order to prevent clusters from being put into an unstable state that cannot be recovered from via the API ValidatingAdmissionPolicy cannot match ValidatingAdmissionPolicy and ValidatingAdmissionPolicyBinding. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicySpec#matchConstraints
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchConstraints", typeJson: "{\"fqn\":\"k8s.MatchResources\"}", isOptional: true)]
        public K8s.IMatchResources? MatchConstraints
        {
            get;
            set;
        }

        /// <summary>ParamKind specifies the kind of resources used to parameterize this policy.</summary>
        /// <remarks>
        /// If absent, there are no parameters for this policy and the param CEL variable will not be provided to validation expressions. If ParamKind refers to a non-existent kind, this policy definition is mis-configured and the FailurePolicy is applied. If paramKind is specified but paramRef is unset in ValidatingAdmissionPolicyBinding, the params variable will be null.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicySpec#paramKind
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "paramKind", typeJson: "{\"fqn\":\"k8s.ParamKind\"}", isOptional: true)]
        public K8s.IParamKind? ParamKind
        {
            get;
            set;
        }

        /// <summary>Validations contain CEL expressions which is used to apply the validation.</summary>
        /// <remarks>
        /// Validations and AuditAnnotations may not both be empty; a minimum of one Validations or AuditAnnotations is required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicySpec#validations
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "validations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Validation\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IValidation[]? Validations
        {
            get;
            set;
        }

        /// <summary>Variables contain definitions of variables that can be used in composition of other expressions.</summary>
        /// <remarks>
        /// Each variable is defined as a named CEL expression. The variables defined here will be available under <c>variables</c> in other expressions of the policy except MatchConditions because MatchConditions are evaluated before the rest of the policy.
        ///
        /// The expression of a variable can refer to other variables defined earlier in the list but not those after. Thus, Variables must be sorted by the order of first appearance and acyclic.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingAdmissionPolicySpec#variables
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "variables", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Variable\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IVariable[]? Variables
        {
            get;
            set;
        }
    }
}
