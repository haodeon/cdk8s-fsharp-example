using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>FlowDistinguisherMethod specifies the method of a flow distinguisher.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.FlowDistinguisherMethod
    /// </remarks>
    [JsiiByValue(fqn: "k8s.FlowDistinguisherMethodV1Beta3")]
    public class FlowDistinguisherMethodV1Beta3 : K8s.IFlowDistinguisherMethodV1Beta3
    {
        /// <summary>`type` is the type of flow distinguisher method The supported types are "ByUser" and "ByNamespace".</summary>
        /// <remarks>
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.FlowDistinguisherMethod#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }
    }
}
