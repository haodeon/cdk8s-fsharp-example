using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PodSchedulingGate is associated to a Pod to guard its scheduling.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSchedulingGate
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPodSchedulingGate), fullyQualifiedName: "k8s.PodSchedulingGate")]
    public interface IPodSchedulingGate
    {
        /// <summary>Name of the scheduling gate.</summary>
        /// <remarks>
        /// Each scheduling gate must have a unique name field.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSchedulingGate#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>PodSchedulingGate is associated to a Pod to guard its scheduling.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSchedulingGate
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPodSchedulingGate), fullyQualifiedName: "k8s.PodSchedulingGate")]
        internal sealed class _Proxy : DeputyBase, K8s.IPodSchedulingGate
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of the scheduling gate.</summary>
            /// <remarks>
            /// Each scheduling gate must have a unique name field.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.PodSchedulingGate#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
