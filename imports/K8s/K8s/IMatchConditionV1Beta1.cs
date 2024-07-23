using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>MatchCondition represents a condition which must be fulfilled for a request to be sent to a webhook.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.MatchCondition
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IMatchConditionV1Beta1), fullyQualifiedName: "k8s.MatchConditionV1Beta1")]
    public interface IMatchConditionV1Beta1
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
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.MatchCondition#expression
        /// </remarks>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        string Expression
        {
            get;
        }

        /// <summary>Name is an identifier for this match condition, used for strategic merging of MatchConditions, as well as providing an identifier for logging purposes.</summary>
        /// <remarks>
        /// A good name should be descriptive of the associated expression. Name must be a qualified name consisting of alphanumeric characters, '-', '<em>' or '.', and must start and end with an alphanumeric character (e.g. 'MyName',  or 'my.name',  or '123-abc', regex used for validation is '([A-Za-z0-9][-A-Za-z0-9</em>.]*)?[A-Za-z0-9]') with an optional DNS subdomain prefix and '/' (e.g. 'example.com/MyName')
        ///
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.MatchCondition#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>MatchCondition represents a condition which must be fulfilled for a request to be sent to a webhook.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.MatchCondition
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IMatchConditionV1Beta1), fullyQualifiedName: "k8s.MatchConditionV1Beta1")]
        internal sealed class _Proxy : DeputyBase, K8s.IMatchConditionV1Beta1
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.MatchCondition#expression
            /// </remarks>
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
            public string Expression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name is an identifier for this match condition, used for strategic merging of MatchConditions, as well as providing an identifier for logging purposes.</summary>
            /// <remarks>
            /// A good name should be descriptive of the associated expression. Name must be a qualified name consisting of alphanumeric characters, '-', '<em>' or '.', and must start and end with an alphanumeric character (e.g. 'MyName',  or 'my.name',  or '123-abc', regex used for validation is '([A-Za-z0-9][-A-Za-z0-9</em>.]*)?[A-Za-z0-9]') with an optional DNS subdomain prefix and '/' (e.g. 'example.com/MyName')
            ///
            /// Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.MatchCondition#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
