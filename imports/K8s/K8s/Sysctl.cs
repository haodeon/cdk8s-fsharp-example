using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Sysctl defines a kernel parameter to be set.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Sysctl
    /// </remarks>
    [JsiiByValue(fqn: "k8s.Sysctl")]
    public class Sysctl : K8s.ISysctl
    {
        /// <summary>Name of a property to set.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Sysctl#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Value of a property to set.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Sysctl#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}")]
        public string Value
        {
            get;
            set;
        }
    }
}
