using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>SSHAuth configures ssh-based auth for git authentication.</summary>
    /// <remarks>
    /// SSHPrivateKey is required but password is optional.
    ///
    /// <strong>Schema</strong>: StackSpecGitAuthSshAuth
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecGitAuthSshAuth), fullyQualifiedName: "compulumi.StackSpecGitAuthSshAuth")]
    public interface IStackSpecGitAuthSshAuth
    {
        /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
        /// <remarks>
        /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
        /// strings are currently supported.
        ///
        /// <strong>Schema</strong>: StackSpecGitAuthSshAuth#sshPrivateKey
        /// </remarks>
        [JsiiProperty(name: "sshPrivateKey", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthSshAuthSshPrivateKey\"}")]
        Com.Pulumi.IStackSpecGitAuthSshAuthSshPrivateKey SshPrivateKey
        {
            get;
        }

        /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
        /// <remarks>
        /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
        /// strings are currently supported.
        ///
        /// <strong>Schema</strong>: StackSpecGitAuthSshAuth#password
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthSshAuthPassword\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecGitAuthSshAuthPassword? Password
        {
            get
            {
                return null;
            }
        }

        /// <summary>SSHAuth configures ssh-based auth for git authentication.</summary>
        /// <remarks>
        /// SSHPrivateKey is required but password is optional.
        ///
        /// <strong>Schema</strong>: StackSpecGitAuthSshAuth
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecGitAuthSshAuth), fullyQualifiedName: "compulumi.StackSpecGitAuthSshAuth")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecGitAuthSshAuth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<Com.Pulumi.IStackSpecGitAuthSshAuthSshPrivateKey>()!;
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
                get => GetInstanceProperty<Com.Pulumi.IStackSpecGitAuthSshAuthPassword?>();
            }
        }
    }
}
