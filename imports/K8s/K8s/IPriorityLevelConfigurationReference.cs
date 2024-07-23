using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PriorityLevelConfigurationReference contains information that points to the "request-priority" being used.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationReference
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPriorityLevelConfigurationReference), fullyQualifiedName: "k8s.PriorityLevelConfigurationReference")]
    public interface IPriorityLevelConfigurationReference
    {
        /// <summary>`name` is the name of the priority level configuration being referenced Required.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationReference#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>PriorityLevelConfigurationReference contains information that points to the "request-priority" being used.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationReference
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPriorityLevelConfigurationReference), fullyQualifiedName: "k8s.PriorityLevelConfigurationReference")]
        internal sealed class _Proxy : DeputyBase, K8s.IPriorityLevelConfigurationReference
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`name` is the name of the priority level configuration being referenced Required.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationReference#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
