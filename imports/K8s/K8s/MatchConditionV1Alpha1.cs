using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.MatchCondition
    /// </remarks>
    [JsiiByValue(fqn: "k8s.MatchConditionV1Alpha1")]
    public class MatchConditionV1Alpha1 : K8s.IMatchConditionV1Alpha1
    {
        /// <summary>Expression represents the expression which will be evaluated by CEL.</summary>
        /// <remarks>
        /// Must evaluate to bool. CEL expressions have access to the contents of the AdmissionRequest and Authorizer, organized into CEL variables:
        ///
        /// 'object' - The object from the incoming request. The value is null for DELETE requests. 'oldObject' - The existing object. The value is null for CREATE requests. 'request' - Attributes of the admission request(/pkg/apis/admission/types.go#AdmissionRequest). 'authorizer' - A CEL Authorizer. May be used to perform authorization checks for the principal (user or service account) of the request.
        /// See https://pkg.go.dev/k8s.io/apiserver/pkg/cel/library#Authz
        /// 'authorizer.requestResource' - A CEL ResourceCheck constructed from the 'authorizer' and configured with the
        /// request resource.
        /// Documentation on CEL: https://kubernetes.io/docs/reference/using-api/cel/
        ///
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.MatchCondition#expression
        /// </remarks>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        public string Expression
        {
            get;
            set;
        }

        /// <summary>Name is an identifier for this match condition, used for strategic merging of MatchConditions, as well as providing an identifier for logging purposes.</summary>
        /// <remarks>
        /// A good name should be descriptive of the associated expression. Name must be a qualified name consisting of alphanumeric characters, '-', '<em>' or '.', and must start and end with an alphanumeric character (e.g. 'MyName',  or 'my.name',  or '123-abc', regex used for validation is '([A-Za-z0-9][-A-Za-z0-9</em>.]*)?[A-Za-z0-9]') with an optional DNS subdomain prefix and '/' (e.g. 'example.com/MyName')
        ///
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.MatchCondition#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
