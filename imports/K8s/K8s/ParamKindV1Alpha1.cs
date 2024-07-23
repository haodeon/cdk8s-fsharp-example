using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ParamKind is a tuple of Group Kind and Version.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ParamKind
    /// </remarks>
    [JsiiByValue(fqn: "k8s.ParamKindV1Alpha1")]
    public class ParamKindV1Alpha1 : K8s.IParamKindV1Alpha1
    {
        /// <summary>APIVersion is the API group version the resources belong to.</summary>
        /// <remarks>
        /// In format of "group/version". Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ParamKind#apiVersion
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "apiVersion", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ApiVersion
        {
            get;
            set;
        }

        /// <summary>Kind is the API kind the resources belong to.</summary>
        /// <remarks>
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.ParamKind#kind
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "kind", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Kind
        {
            get;
            set;
        }
    }
}
