using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PriorityLevelConfigurationReference contains information that points to the "request-priority" being used.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PriorityLevelConfigurationReference
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IPriorityLevelConfigurationReferenceV1Beta3), fullyQualifiedName: "k8s.PriorityLevelConfigurationReferenceV1Beta3")]
    public interface IPriorityLevelConfigurationReferenceV1Beta3
    {
        /// <summary>`name` is the name of the priority level configuration being referenced Required.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PriorityLevelConfigurationReference#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>PriorityLevelConfigurationReference contains information that points to the "request-priority" being used.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PriorityLevelConfigurationReference
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IPriorityLevelConfigurationReferenceV1Beta3), fullyQualifiedName: "k8s.PriorityLevelConfigurationReferenceV1Beta3")]
        internal sealed class _Proxy : DeputyBase, K8s.IPriorityLevelConfigurationReferenceV1Beta3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`name` is the name of the priority level configuration being referenced Required.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.PriorityLevelConfigurationReference#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
