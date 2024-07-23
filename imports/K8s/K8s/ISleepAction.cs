using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SleepAction describes a "sleep" action.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SleepAction
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ISleepAction), fullyQualifiedName: "k8s.SleepAction")]
    public interface ISleepAction
    {
        /// <summary>Seconds is the number of seconds to sleep.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SleepAction#seconds
        /// </remarks>
        [JsiiProperty(name: "seconds", typeJson: "{\"primitive\":\"number\"}")]
        double Seconds
        {
            get;
        }

        /// <summary>SleepAction describes a "sleep" action.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SleepAction
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ISleepAction), fullyQualifiedName: "k8s.SleepAction")]
        internal sealed class _Proxy : DeputyBase, K8s.ISleepAction
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Seconds is the number of seconds to sleep.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.SleepAction#seconds
            /// </remarks>
            [JsiiProperty(name: "seconds", typeJson: "{\"primitive\":\"number\"}")]
            public double Seconds
            {
                get => GetInstanceProperty<double>()!;
            }
        }
    }
}
