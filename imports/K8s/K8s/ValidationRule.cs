using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ValidationRule describes a validation rule written in the CEL expression language.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.ValidationRule
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ValidationRule")]
    public class ValidationRule : K8s.IValidationRule
    {
        /// <summary>Rule represents the expression which will be evaluated by CEL.</summary>
        /// <remarks>
        /// ref: https://github.com/google/cel-spec The Rule is scoped to the location of the x-kubernetes-validations extension in the schema. The <c>self</c> variable in the CEL expression is bound to the scoped value. Example: - Rule scoped to the root of a resource with a status subresource: {"rule": "self.status.actual &lt;= self.spec.maxDesired"}
        ///
        /// If the Rule is scoped to an object with properties, the accessible properties of the object are field selectable via <c>self.field</c> and field presence can be checked via <c>has(self.field)</c>. Null valued fields are treated as absent fields in CEL expressions. If the Rule is scoped to an object with additionalProperties (i.e. a map) the value of the map are accessible via <c>self[mapKey]</c>, map containment can be checked via <c>mapKey in self</c> and all entries of the map are accessible via CEL macros and functions such as <c>self.all(...)</c>. If the Rule is scoped to an array, the elements of the array are accessible via <c>self[i]</c> and also by macros and functions. If the Rule is scoped to a scalar, <c>self</c> is bound to the scalar value. Examples: - Rule scoped to a map of objects: {"rule": "self.components['Widget'].priority &lt; 10"} - Rule scoped to a list of integers: {"rule": "self.values.all(value, value &gt;= 0 &amp;&amp; value &lt; 100)"} - Rule scoped to a string value: {"rule": "self.startsWith('kube')"}
        ///
        /// The <c>apiVersion</c>, <c>kind</c>, <c>metadata.name</c> and <c>metadata.generateName</c> are always accessible from the root of the object and from any x-kubernetes-embedded-resource annotated objects. No other metadata properties are accessible.
        ///
        /// Unknown data preserved in custom resources via x-kubernetes-preserve-unknown-fields is not accessible in CEL expressions. This includes: - Unknown field values that are preserved by object schemas with x-kubernetes-preserve-unknown-fields. - Object properties where the property schema is of an "unknown type". An "unknown type" is recursively defined as:
        ///
        /// <list type="bullet">
        /// <description>A schema with no type and x-kubernetes-preserve-unknown-fields set to true</description>
        /// <description>An array where the items schema is of an "unknown type"</description>
        /// <description>An object where the additionalProperties schema is of an "unknown type"</description>
        /// </list>
        ///
        /// Only property names of the form <c>[a-zA-Z_.-/][a-zA-Z0-9_.-/]*</c> are accessible. Accessible property names are escaped according to the following rules when accessed in the expression: - '<strong>' escapes to '<strong>underscores</strong>' - '.' escapes to '<strong>dot</strong>' - '-' escapes to '<strong>dash</strong>' - '/' escapes to '<strong>slash</strong>' - Property names that exactly match a CEL RESERVED keyword escape to '</strong>{keyword}__'. The keywords are:
        /// "true", "false", "null", "in", "as", "break", "const", "continue", "else", "for", "function", "if",
        /// "import", "let", "loop", "package", "namespace", "return".
        /// Examples:
        ///
        /// <list type="bullet">
        /// <description>Rule accessing a property named "namespace": {"rule": "self.<strong>namespace</strong> &gt; 0"}</description>
        /// <description>Rule accessing a property named "x-prop": {"rule": "self.x__dash__prop &gt; 0"}</description>
        /// <description>Rule accessing a property named "redact__d": {"rule": "self.redact__underscores__d &gt; 0"}</description>
        /// </list>
        ///
        /// Equality on arrays with x-kubernetes-list-type of 'set' or 'map' ignores element order, i.e. [1, 2] == [2, 1]. Concatenation on arrays with x-kubernetes-list-type use the semantics of the list type:
        ///
        /// <list type="bullet">
        /// <description>'set': <c>X + Y</c> performs a union where the array positions of all elements in <c>X</c> are preserved and
        /// non-intersecting elements in <c>Y</c> are appended, retaining their partial order.</description>
        /// <description>'map': <c>X + Y</c> performs a merge where the array positions of all keys in <c>X</c> are preserved but the values
        /// are overwritten by values in <c>Y</c> when the key sets of <c>X</c> and <c>Y</c> intersect. Elements in <c>Y</c> with
        /// non-intersecting keys are appended, retaining their partial order.</description>
        /// </list>
        ///
        /// If <c>rule</c> makes use of the <c>oldSelf</c> variable it is implicitly a <c>transition rule</c>.
        ///
        /// By default, the <c>oldSelf</c> variable is the same type as <c>self</c>. When <c>optionalOldSelf</c> is true, the <c>oldSelf</c> variable is a CEL optional
        /// variable whose value() is the same type as <c>self</c>.
        /// See the documentation for the <c>optionalOldSelf</c> field for details.
        ///
        /// Transition rules by default are applied only on UPDATE requests and are skipped if an old value could not be found. You can opt a transition rule into unconditional evaluation by setting <c>optionalOldSelf</c> to true.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.ValidationRule#rule
        /// </remarks>
        [JsiiProperty(name: "rule", typeJson: "{\"primitive\":\"string\"}")]
        public string Rule
        {
            get;
            set;
        }

        /// <summary>fieldPath represents the field path returned when the validation fails.</summary>
        /// <remarks>
        /// It must be a relative JSON path (i.e. with array notation) scoped to the location of this x-kubernetes-validations extension in the schema and refer to an existing field. e.g. when validation checks if a specific attribute <c>foo</c> under a map <c>testMap</c>, the fieldPath could be set to <c>.testMap.foo</c> If the validation checks two lists must have unique attributes, the fieldPath could be set to either of the list: e.g. <c>.testList</c> It does not support list numeric index. It supports child operation to refer to an existing field currently. Refer to <a href="https://kubernetes.io/docs/reference/kubectl/jsonpath/">JSONPath support in Kubernetes</a> for more info. Numeric index of array is not supported. For field name which contains special characters, use <c>['specialName']</c> to refer the field name. e.g. for attribute <c>foo.34$</c> appears in a list <c>testList</c>, the fieldPath could be set to <c>.testList['foo.34$']</c>
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.ValidationRule#fieldPath
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "fieldPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FieldPath
        {
            get;
            set;
        }

        /// <summary>Message represents the message displayed when validation fails.</summary>
        /// <remarks>
        /// The message is required if the Rule contains line breaks. The message must not contain line breaks. If unset, the message is "failed rule: {Rule}". e.g. "must be a URL with the host matching spec.host"
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.ValidationRule#message
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "message", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Message
        {
            get;
            set;
        }

        /// <summary>MessageExpression declares a CEL expression that evaluates to the validation failure message that is returned when this rule fails.</summary>
        /// <remarks>
        /// Since messageExpression is used as a failure message, it must evaluate to a string. If both message and messageExpression are present on a rule, then messageExpression will be used if validation fails. If messageExpression results in a runtime error, the runtime error is logged, and the validation failure message is produced as if the messageExpression field were unset. If messageExpression evaluates to an empty string, a string with only spaces, or a string that contains line breaks, then the validation failure message will also be produced as if the messageExpression field were unset, and the fact that messageExpression produced an empty string/string with only spaces/string with line breaks will be logged. messageExpression has access to all the same variables as the rule; the only difference is the return type. Example: "x must be less than max ("+string(self.max)+")"
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.ValidationRule#messageExpression
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "messageExpression", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MessageExpression
        {
            get;
            set;
        }

        /// <summary>optionalOldSelf is used to opt a transition rule into evaluation even when the object is first created, or if the old object is missing the value.</summary>
        /// <remarks>
        /// When enabled <c>oldSelf</c> will be a CEL optional whose value will be <c>None</c> if there is no old value, or when the object is initially created.
        ///
        /// You may check for presence of oldSelf using <c>oldSelf.hasValue()</c> and unwrap it after checking using <c>oldSelf.value()</c>. Check the CEL documentation for Optional types for more information: https://pkg.go.dev/github.com/google/cel-go/cel#OptionalTypes
        ///
        /// May not be set unless <c>oldSelf</c> is used in <c>rule</c>.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.ValidationRule#optionalOldSelf
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "optionalOldSelf", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? OptionalOldSelf
        {
            get;
            set;
        }

        /// <summary>reason provides a machine-readable validation failure reason that is returned to the caller when a request fails this validation rule.</summary>
        /// <remarks>
        /// The HTTP status code returned to the caller will match the reason of the reason of the first failed validation rule. The currently supported reasons are: "FieldValueInvalid", "FieldValueForbidden", "FieldValueRequired", "FieldValueDuplicate". If not set, default to use "FieldValueInvalid". All future added reasons must be accepted by clients when reading this value and unknown reasons should be treated as FieldValueInvalid.
        ///
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.ValidationRule#reason
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
