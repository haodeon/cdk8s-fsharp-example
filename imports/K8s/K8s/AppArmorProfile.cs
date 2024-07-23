using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>AppArmorProfile defines a pod or container's AppArmor settings.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.AppArmorProfile
    /// </remarks>
    [JsiiByValue(fqn: "k8s.AppArmorProfile")]
    public class AppArmorProfile : K8s.IAppArmorProfile
    {
        /// <summary>type indicates which kind of AppArmor profile will be applied.</summary>
        /// <remarks>
        /// Valid options are:
        /// Localhost - a profile pre-loaded on the node.
        /// RuntimeDefault - the container runtime's default profile.
        /// Unconfined - no AppArmor enforcement.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AppArmorProfile#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>localhostProfile indicates a profile loaded on the node that should be used.</summary>
        /// <remarks>
        /// The profile must be preconfigured on the node to work. Must match the loaded name of the profile. Must be set if and only if type is "Localhost".
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.AppArmorProfile#localhostProfile
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "localhostProfile", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? LocalhostProfile
        {
            get;
            set;
        }
    }
}
