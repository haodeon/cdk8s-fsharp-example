using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SELinuxOptions are the labels to be applied to the container.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SELinuxOptions
    /// </remarks>
    [JsiiByValue(fqn: "k8s.SeLinuxOptions")]
    public class SeLinuxOptions : K8s.ISeLinuxOptions
    {
        /// <summary>Level is SELinux level label that applies to the container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SELinuxOptions#level
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "level", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Level
        {
            get;
            set;
        }

        /// <summary>Role is a SELinux role label that applies to the container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SELinuxOptions#role
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "role", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Role
        {
            get;
            set;
        }

        /// <summary>Type is a SELinux type label that applies to the container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SELinuxOptions#type
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Type
        {
            get;
            set;
        }

        /// <summary>User is a SELinux user label that applies to the container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SELinuxOptions#user
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "user", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? User
        {
            get;
            set;
        }
    }
}
