using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Variable is the definition of a variable that is used for composition.</summary>
    /// <remarks>
    /// A variable is defined as a named expression.
    ///
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.Variable
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IVariableV1Beta1), fullyQualifiedName: "k8s.VariableV1Beta1")]
    public interface IVariableV1Beta1
    {
        /// <summary>Expression is the expression that will be evaluated as the value of the variable.</summary>
        /// <remarks>
        /// The CEL expression has access to the same identifiers as the CEL expressions in Validation.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.Variable#expression
        /// </remarks>
        [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
        string Expression
        {
            get;
        }

        /// <summary>Name is the name of the variable.</summary>
        /// <remarks>
        /// The name must be a valid CEL identifier and unique among all variables. The variable can be accessed in other expressions through <c>variables</c> For example, if name is "foo", the variable will be available as <c>variables.foo</c>
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.Variable#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Variable is the definition of a variable that is used for composition.</summary>
        /// <remarks>
        /// A variable is defined as a named expression.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.Variable
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IVariableV1Beta1), fullyQualifiedName: "k8s.VariableV1Beta1")]
        internal sealed class _Proxy : DeputyBase, K8s.IVariableV1Beta1
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Expression is the expression that will be evaluated as the value of the variable.</summary>
            /// <remarks>
            /// The CEL expression has access to the same identifiers as the CEL expressions in Validation.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.Variable#expression
            /// </remarks>
            [JsiiProperty(name: "expression", typeJson: "{\"primitive\":\"string\"}")]
            public string Expression
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name is the name of the variable.</summary>
            /// <remarks>
            /// The name must be a valid CEL identifier and unique among all variables. The variable can be accessed in other expressions through <c>variables</c> For example, if name is "foo", the variable will be available as <c>variables.foo</c>
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.Variable#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
