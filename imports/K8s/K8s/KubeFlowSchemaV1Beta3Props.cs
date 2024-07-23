using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>FlowSchema defines the schema of a group of flows.</summary>
    /// <remarks>
    /// Note that a flow is made up of a set of inbound API requests with similar attributes and is identified by a pair of strings: the name of the FlowSchema and a "flow distinguisher".
    ///
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.FlowSchema
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeFlowSchemaV1Beta3Props")]
    public class KubeFlowSchemaV1Beta3Props : K8s.IKubeFlowSchemaV1Beta3Props
    {
        /// <summary>`metadata` is the standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.FlowSchema#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }

        /// <summary>`spec` is the specification of the desired behavior of a FlowSchema.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#spec-and-status
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.FlowSchema#spec
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.FlowSchemaSpecV1Beta3\"}", isOptional: true)]
        public K8s.IFlowSchemaSpecV1Beta3? Spec
        {
            get;
            set;
        }
    }
}
