using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Sysctl defines a kernel parameter to be set.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Sysctl
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ISysctl), fullyQualifiedName: "k8s.Sysctl")]
    public interface ISysctl
    {
        /// <summary>Name of a property to set.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Sysctl#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Value of a property to set.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Sysctl#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        string Value
        {
            get;
        }

        /// <summary>Sysctl defines a kernel parameter to be set.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Sysctl
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ISysctl), fullyQualifiedName: "k8s.Sysctl")]
        internal sealed class _Proxy : DeputyBase, K8s.ISysctl
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Name of a property to set.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Sysctl#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Value of a property to set.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Sysctl#value
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
            public string Value
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
