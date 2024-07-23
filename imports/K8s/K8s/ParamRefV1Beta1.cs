using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ParamRef describes how to locate the params to be used as input to expressions of rules applied by a policy binding.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ParamRef
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ParamRefV1Beta1")]
    public class ParamRefV1Beta1 : K8s.IParamRefV1Beta1
    {
        /// <summary>name is the name of the resource being referenced.</summary>
        /// <remarks>
        /// One of <c>name</c> or <c>selector</c> must be set, but <c>name</c> and <c>selector</c> are mutually exclusive properties. If one is set, the other must be unset.
        ///
        /// A single parameter used for all admission requests can be configured by setting the <c>name</c> field, leaving <c>selector</c> blank, and setting namespace if <c>paramKind</c> is namespace-scoped.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ParamRef#name
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>namespace is the namespace of the referenced resource.</summary>
        /// <remarks>
        /// Allows limiting the search for params to a specific namespace. Applies to both <c>name</c> and <c>selector</c> fields.
        ///
        /// A per-namespace parameter may be used by specifying a namespace-scoped <c>paramKind</c> in the policy and leaving this field empty.
        ///
        /// <list type="bullet">
        /// <description>If <c>paramKind</c> is cluster-scoped, this field MUST be unset. Setting this field results in a configuration error.</description>
        /// <description>If <c>paramKind</c> is namespace-scoped, the namespace of the object being evaluated for admission will be used when this field is left unset. Take care that if this is left empty the binding must not match any cluster-scoped resources, which will result in an error.</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ParamRef#namespace
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }

        /// <summary>`parameterNotFoundAction` controls the behavior of the binding when the resource exists, and name or selector is valid, but there are no parameters matched by the binding.</summary>
        /// <remarks>
        /// If the value is set to <c>Allow</c>, then no matched parameters will be treated as successful validation by the binding. If set to <c>Deny</c>, then no matched parameters will be subject to the <c>failurePolicy</c> of the policy.
        ///
        /// Allowed values are <c>Allow</c> or <c>Deny</c>
        ///
        /// Required
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ParamRef#parameterNotFoundAction
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "parameterNotFoundAction", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ParameterNotFoundAction
        {
            get;
            set;
        }

        /// <summary>selector can be used to match multiple param objects based on their labels.</summary>
        /// <remarks>
        /// Supply selector: {} to match all resources of the ParamKind.
        ///
        /// If multiple params are found, they are all evaluated with the policy expressions and the results are ANDed together.
        ///
        /// One of <c>name</c> or <c>selector</c> must be set, but <c>name</c> and <c>selector</c> are mutually exclusive properties. If one is set, the other must be unset.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1beta1.ParamRef#selector
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        public K8s.ILabelSelector? Selector
        {
            get;
            set;
        }
    }
}
