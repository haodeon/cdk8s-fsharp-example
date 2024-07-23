using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <summary>SSHAuth configures ssh-based auth for git authentication.</summary>
    /// <remarks>
    /// SSHPrivateKey is required but password is optional.
    ///
    /// <strong>Schema</strong>: StackSpecGitAuthSshAuth
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackSpecGitAuthSshAuth")]
    public class StackSpecGitAuthSshAuth : Com.Pulumi.IStackSpecGitAuthSshAuth
    {
        /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
        /// <remarks>
        /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
        /// strings are currently supported.
        ///
        /// <strong>Schema</strong>: StackSpecGitAuthSshAuth#sshPrivateKey
        /// </remarks>
        [JsiiProperty(name: "sshPrivateKey", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthSshAuthSshPrivateKey\"}")]
        public Com.Pulumi.IStackSpecGitAuthSshAuthSshPrivateKey SshPrivateKey
        {
            get;
            set;
        }

        /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
        /// <remarks>
        /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
        /// strings are currently supported.
        ///
        /// <strong>Schema</strong>: StackSpecGitAuthSshAuth#password
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthSshAuthPassword\"}", isOptional: true)]
        public Com.Pulumi.IStackSpecGitAuthSshAuthPassword? Password
        {
            get;
            set;
        }
    }
}
