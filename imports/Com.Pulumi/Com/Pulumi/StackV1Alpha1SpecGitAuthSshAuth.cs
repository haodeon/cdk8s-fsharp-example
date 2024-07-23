using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <summary>SSHAuth configures ssh-based auth for git authentication.</summary>
    /// <remarks>
    /// SSHPrivateKey is required but password is optional.
    ///
    /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuth
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackV1Alpha1SpecGitAuthSshAuth")]
    public class StackV1Alpha1SpecGitAuthSshAuth : Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuth
    {
        /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
        /// <remarks>
        /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
        /// strings are currently supported.
        ///
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuth#sshPrivateKey
        /// </remarks>
        [JsiiProperty(name: "sshPrivateKey", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthSshAuthSshPrivateKey\"}")]
        public Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKey SshPrivateKey
        {
            get;
            set;
        }

        /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
        /// <remarks>
        /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
        /// strings are currently supported.
        ///
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuth#password
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthSshAuthPassword\"}", isOptional: true)]
        public Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthPassword? Password
        {
            get;
            set;
        }
    }
}
