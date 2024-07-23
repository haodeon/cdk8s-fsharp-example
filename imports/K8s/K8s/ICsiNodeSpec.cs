using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>CSINodeSpec holds information about the specification of all CSI drivers installed on a node.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeSpec
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ICsiNodeSpec), fullyQualifiedName: "k8s.CsiNodeSpec")]
    public interface ICsiNodeSpec
    {
        /// <summary>drivers is a list of information of all CSI Drivers existing on a node.</summary>
        /// <remarks>
        /// If all drivers in the list are uninstalled, this can become empty.
        ///
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeSpec#drivers
        /// </remarks>
        [JsiiProperty(name: "drivers", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.CsiNodeDriver\"},\"kind\":\"array\"}}")]
        K8s.ICsiNodeDriver[] Drivers
        {
            get;
        }

        /// <summary>CSINodeSpec holds information about the specification of all CSI drivers installed on a node.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeSpec
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ICsiNodeSpec), fullyQualifiedName: "k8s.CsiNodeSpec")]
        internal sealed class _Proxy : DeputyBase, K8s.ICsiNodeSpec
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>drivers is a list of information of all CSI Drivers existing on a node.</summary>
            /// <remarks>
            /// If all drivers in the list are uninstalled, this can become empty.
            ///
            /// <strong>Schema</strong>: io.k8s.api.storage.v1.CSINodeSpec#drivers
            /// </remarks>
            [JsiiProperty(name: "drivers", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.CsiNodeDriver\"},\"kind\":\"array\"}}")]
            public K8s.ICsiNodeDriver[] Drivers
            {
                get => GetInstanceProperty<K8s.ICsiNodeDriver[]>()!;
            }
        }
    }
}
