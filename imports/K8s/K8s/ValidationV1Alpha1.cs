using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Validation specifies the CEL expression which is used to apply the validation.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.Validation
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ValidationV1Alpha1")]
    public class ValidationV1Alpha1 : K8s.IValidationV1Alpha1
    {
        /// <summary>Expression represents the expression which will be evaluated by CEL.</summary>
        /// <remarks>
        /// ref: https://github.com/google/cel-spec CEL expressions have access to the contents of the API request/response, organized into CEL variables as well as some other useful variables:
        ///
        /// <list type="bullet">
        /// <description>'object' - The object from the incoming request. The value is null for DELETE requests. - 'oldObject' - The existing object. The value is null for CREATE requests. - 'request' - Attributes of the API request(<a href="/pkg/apis/admission/types.go#AdmissionRequest">ref</a>). - 'params' - Parameter resource referred to by the policy binding being evaluated. Only populated if the policy has a ParamKind. - 'namespaceObject' - The namespace object that the incoming object belongs to. The value is null for cluster-scoped resources. - 'variables' - Map of composited variables, from its name to its lazily evaluated value.
        /// For example, a variable named 'foo' can be accessed as 'variables.foo'.</description>
        /// <description>'authorizer' - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
        /// See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz</description>
        /// <description>'authorizer.requestResource' - A CEL ResourceCheck constructed from the 'authorizer' and configured with the
        /// request resource.</description>
        /// </list>
        ///
        /// The <c>apiVersion</c>, <c>kind</c>, <c>metadata.name</c> and <c>metadata.generateName</c> are always accessible from the root of the object. No other metadata properties are accessible.
        ///
        /// Only property names of the form <c>[a-zA-Z_.-/][a-zA-Z0-9_.-/]*</c> are accessible. Accessible property names are escaped according to the following rules when accessed in the expression: - '<strong>' escapes to '<strong>underscores</strong>' - '.' escapes to '<strong>dot</strong>' - '-' escapes to '<strong>dash</strong>' - '/' escapes to '<strong>slash</strong>' - Property names that exactly match a CEL RESERVED keyword escape to '</strong>{keyword}__'. The keywords are:
        /// "true", "false", "null", "in", "as", "break", "const", "continue", "else", "for", "function", "if",
        /// "import", "let", "loop", "package", "namespace", "return".
        /// Examples:
        ///
        /// <list type="bullet">
        /// <description>Expression accessing a property named "namespace": {"Expression": "object.<strong>namespace</strong> &gt; 0"}</description>
        /// <description>Expression accessing a property named "x-prop": {"Expression": "object.x__dash__prop &gt; 0"}</description>
        /// <description>Expression accessing a property named "redact__d": {"Expression": "object.redact__underscores__d &gt; 0"}</description>
        /// </list>
        ///
        /// Equality on arrays with list type of 'set' or 'map' ignores element order, i.e. [1, 2] == [2, 1]. Concatenation on arrays with x-kubernetes-list-type use the semantics of the list type:
        ///
        /// <list type="bullet">
        /// <description>'set': <c>X + Y</c> performs a union where the array positions of all elements in <c>X</c> are preserved and
        /// non-intersecting elements in <c>Y</c> are appended, retaining their partial order.</description>
        /// <description>'map': <c>X + Y</c> performs a merge where the array positions of all keys in <c>X</c> are preserved but the values
        /// are overwritten by values in <c>Y</c> when the key sets of <c>X</c> and <c>Y</c> intersect. Elements in <c>Y</c> with
        /// non-intersecting keys are appended, retaining their partial order.
        /// Required.</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.Validation#expression
        /// </remarks>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        public string Expression
        {
            get;
            set;
        }

        /// <summary>Message represents the message displayed when validation fails.</summary>
        /// <remarks>
        /// The message is required if the Expression contains line breaks. The message must not contain line breaks. If unset, the message is "failed rule: {Rule}". e.g. "must be a URL with the host matching spec.host" If the Expression contains line breaks. Message is required. The message must not contain line breaks. If unset, the message is "failed Expression: {Expression}".
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.Validation#message
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }

        /// <summary>messageExpression declares a CEL expression that evaluates to the validation failure message that is returned when this rule fails.</summary>
        /// <remarks>
        /// Since messageExpression is used as a failure message, it must evaluate to a string. If both message and messageExpression are present on a validation, then messageExpression will be used if validation fails. If messageExpression results in a runtime error, the runtime error is logged, and the validation failure message is produced as if the messageExpression field were unset. If messageExpression evaluates to an empty string, a string with only spaces, or a string that contains line breaks, then the validation failure message will also be produced as if the messageExpression field were unset, and the fact that messageExpression produced an empty string/string with only spaces/string with line breaks will be logged. messageExpression has access to all the same variables as the <c>expression</c> except for 'authorizer' and 'authorizer.requestResource'. Example: "object.x must be less than max ("+string(params.max)+")"
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.Validation#messageExpression
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "messageExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageExpression
        {
            get;
            set;
        }

        /// <summary>Reason represents a machine-readable description of why this validation failed.</summary>
        /// <remarks>
        /// If this is the first validation in the list to fail, this reason, as well as the corresponding HTTP response code, are used in the HTTP response to the client. The currently supported reasons are: "Unauthorized", "Forbidden", "Invalid", "RequestEntityTooLarge". If not set, StatusReasonInvalid is used in the response to the client.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.Validation#reason
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reason", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Reason
        {
            get;
            set;
        }
    }
}
