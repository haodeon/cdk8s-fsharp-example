using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PriorityLevelConfigurationReference contains information that points to the "request-priority" being used.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationReference
    /// </remarks>
    [JsiiByValue(fqn: "k8s.PriorityLevelConfigurationReference")]
    public class PriorityLevelConfigurationReference : K8s.IPriorityLevelConfigurationReference
    {
        /// <summary>`name` is the name of the priority level configuration being referenced Required.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.PriorityLevelConfigurationReference#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
