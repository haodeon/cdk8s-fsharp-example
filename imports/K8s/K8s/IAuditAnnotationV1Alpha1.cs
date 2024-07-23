using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>AuditAnnotation describes how to produce an audit annotation for an API request.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.AuditAnnotation
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IAuditAnnotationV1Alpha1), fullyQualifiedName: "k8s.AuditAnnotationV1Alpha1")]
    public interface IAuditAnnotationV1Alpha1
    {
        /// <summary>key specifies the audit annotation key.</summary>
        /// <remarks>
        /// The audit annotation keys of a ValidatingAdmissionPolicy must be unique. The key must be a qualified name ([A-Za-z0-9][-A-Za-z0-9_.]*) no more than 63 bytes in length.
        ///
        /// The key is combined with the resource name of the ValidatingAdmissionPolicy to construct an audit annotation key: "{ValidatingAdmissionPolicy name}/{key}".
        ///
        /// If an admission webhook uses the same resource name as this ValidatingAdmissionPolicy and the same audit annotation key, the annotation key will be identical. In this case, the first annotation written with the key will be included in the audit event and all subsequent annotations with the same key will be discarded.
        ///
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.AuditAnnotation#key
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>valueExpression represents the expression which is evaluated by CEL to produce an audit annotation value.</summary>
        /// <remarks>
        /// The expression must evaluate to either a string or null value. If the expression evaluates to a string, the audit annotation is included with the string value. If the expression evaluates to null or empty string the audit annotation will be omitted. The valueExpression may be no longer than 5kb in length. If the result of the valueExpression is more than 10kb in length, it will be truncated to 10kb.
        ///
        /// If multiple ValidatingAdmissionPolicyBinding resources match an API request, then the valueExpression will be evaluated for each binding. All unique values produced by the valueExpressions will be joined together in a comma-separated list.
        ///
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.AuditAnnotation#valueExpression
        /// </remarks>
        [JsiiProperty(name: "valueExpression", typeJson: "{\"primitive\":\"string\"}")]
        string ValueExpression
        {
            get;
        }

        /// <summary>AuditAnnotation describes how to produce an audit annotation for an API request.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.AuditAnnotation
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IAuditAnnotationV1Alpha1), fullyQualifiedName: "k8s.AuditAnnotationV1Alpha1")]
        internal sealed class _Proxy : DeputyBase, K8s.IAuditAnnotationV1Alpha1
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>key specifies the audit annotation key.</summary>
            /// <remarks>
            /// The audit annotation keys of a ValidatingAdmissionPolicy must be unique. The key must be a qualified name ([A-Za-z0-9][-A-Za-z0-9_.]*) no more than 63 bytes in length.
            ///
            /// The key is combined with the resource name of the ValidatingAdmissionPolicy to construct an audit annotation key: "{ValidatingAdmissionPolicy name}/{key}".
            ///
            /// If an admission webhook uses the same resource name as this ValidatingAdmissionPolicy and the same audit annotation key, the annotation key will be identical. In this case, the first annotation written with the key will be included in the audit event and all subsequent annotations with the same key will be discarded.
            ///
            /// Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.AuditAnnotation#key
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>valueExpression represents the expression which is evaluated by CEL to produce an audit annotation value.</summary>
            /// <remarks>
            /// The expression must evaluate to either a string or null value. If the expression evaluates to a string, the audit annotation is included with the string value. If the expression evaluates to null or empty string the audit annotation will be omitted. The valueExpression may be no longer than 5kb in length. If the result of the valueExpression is more than 10kb in length, it will be truncated to 10kb.
            ///
            /// If multiple ValidatingAdmissionPolicyBinding resources match an API request, then the valueExpression will be evaluated for each binding. All unique values produced by the valueExpressions will be joined together in a comma-separated list.
            ///
            /// Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.AuditAnnotation#valueExpression
            /// </remarks>
            [JsiiProperty(name: "valueExpression", typeJson: "{\"primitive\":\"string\"}")]
            public string ValueExpression
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
