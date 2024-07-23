using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>FlowDistinguisherMethod specifies the method of a flow distinguisher.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.FlowDistinguisherMethod
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IFlowDistinguisherMethod), fullyQualifiedName: "k8s.FlowDistinguisherMethod")]
    public interface IFlowDistinguisherMethod
    {
        /// <summary>`type` is the type of flow distinguisher method The supported types are "ByUser" and "ByNamespace".</summary>
        /// <remarks>
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.FlowDistinguisherMethod#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>FlowDistinguisherMethod specifies the method of a flow distinguisher.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.FlowDistinguisherMethod
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IFlowDistinguisherMethod), fullyQualifiedName: "k8s.FlowDistinguisherMethod")]
        internal sealed class _Proxy : DeputyBase, K8s.IFlowDistinguisherMethod
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`type` is the type of flow distinguisher method The supported types are "ByUser" and "ByNamespace".</summary>
            /// <remarks>
            /// Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.FlowDistinguisherMethod#type
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
