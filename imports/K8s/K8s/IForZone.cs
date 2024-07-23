using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ForZone provides information about which zones should consume this endpoint.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.discovery.v1.ForZone
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IForZone), fullyQualifiedName: "k8s.ForZone")]
    public interface IForZone
    {
        /// <summary>name represents the name of the zone.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.ForZone#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>ForZone provides information about which zones should consume this endpoint.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.discovery.v1.ForZone
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IForZone), fullyQualifiedName: "k8s.ForZone")]
        internal sealed class _Proxy : DeputyBase, K8s.IForZone
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>name represents the name of the zone.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.discovery.v1.ForZone#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
