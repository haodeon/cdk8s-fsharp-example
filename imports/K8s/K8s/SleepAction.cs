using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>SleepAction describes a "sleep" action.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SleepAction
    /// </remarks>
    [JsiiByValue(fqn: "k8s.SleepAction")]
    public class SleepAction : K8s.ISleepAction
    {
        /// <summary>Seconds is the number of seconds to sleep.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SleepAction#seconds
        /// </remarks>
        [JsiiProperty(name: "seconds", typeJson: "{\"primitive\":\"number\"}")]
        public double Seconds
        {
            get;
            set;
        }
    }
}
