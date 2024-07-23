using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>SSHAuth configures ssh-based auth for git authentication.</summary>
    /// <remarks>
    /// SSHPrivateKey is required but password is optional.
    ///
    /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuth
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackV1Alpha1SpecGitAuthSshAuth), fullyQualifiedName: "compulumi.StackV1Alpha1SpecGitAuthSshAuth")]
    public interface IStackV1Alpha1SpecGitAuthSshAuth
    {
        /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
        /// <remarks>
        /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
        /// strings are currently supported.
        ///
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuth#sshPrivateKey
        /// </remarks>
        [JsiiProperty(name: "sshPrivateKey", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthSshAuthSshPrivateKey\"}")]
        Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKey SshPrivateKey
        {
            get;
        }

        /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
        /// <remarks>
        /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
        /// strings are currently supported.
        ///
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuth#password
        /// </remarks>
        [JsiiProperty(name: "password", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthSshAuthPassword\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthPassword? Password
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
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuth
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackV1Alpha1SpecGitAuthSshAuth), fullyQualifiedName: "compulumi.StackV1Alpha1SpecGitAuthSshAuth")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKey>()!;
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
                get => GetInstanceProperty<Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthPassword?>();
            }
        }
    }
}
