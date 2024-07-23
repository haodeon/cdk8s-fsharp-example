using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodSchedulingContextSpec describes where resources for the Pod are needed.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPodSchedulingContextSpecV1Alpha2), fullyQualifiedName: "k8s.PodSchedulingContextSpecV1Alpha2")]
    public interface IPodSchedulingContextSpecV1Alpha2
    {
        /// <summary>PotentialNodes lists nodes where the Pod might be able to run.</summary>
        /// <remarks>
        /// The size of this field is limited to 128. This is large enough for many clusters. Larger clusters may need more attempts to find a node that suits all pending resources. This may get increased in the future, but not reduced.
        ///
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextSpec#potentialNodes
        /// </remarks>
        [JsiiProperty(name: "potentialNodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string[]? PotentialNodes
        {
            get
            {
                return null;
            }
        }

        /// <summary>SelectedNode is the node for which allocation of ResourceClaims that are referenced by the Pod and that use "WaitForFirstConsumer" allocation is to be attempted.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextSpec#selectedNode
        /// </remarks>
        [JsiiProperty(name: "selectedNode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SelectedNode
        {
            get
            {
                return null;
            }
        }

        /// <summary>PodSchedulingContextSpec describes where resources for the Pod are needed.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPodSchedulingContextSpecV1Alpha2), fullyQualifiedName: "k8s.PodSchedulingContextSpecV1Alpha2")]
        internal sealed class _Proxy : DeputyBase, K8s.IPodSchedulingContextSpecV1Alpha2
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>PotentialNodes lists nodes where the Pod might be able to run.</summary>
            /// <remarks>
            /// The size of this field is limited to 128. This is large enough for many clusters. Larger clusters may need more attempts to find a node that suits all pending resources. This may get increased in the future, but not reduced.
            ///
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextSpec#potentialNodes
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "potentialNodes", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}", isOptional: true)]
            public string[]? PotentialNodes
            {
                get => GetInstanceProperty<string[]?>();
            }

            /// <summary>SelectedNode is the node for which allocation of ResourceClaims that are referenced by the Pod and that use "WaitForFirstConsumer" allocation is to be attempted.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.PodSchedulingContextSpec#selectedNode
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "selectedNode", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SelectedNode
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
