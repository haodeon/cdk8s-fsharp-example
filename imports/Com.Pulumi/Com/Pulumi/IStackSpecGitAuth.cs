using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>(optional) GitAuth allows configuring git authentication options There are 3 different authentication options: * SSH private key (and its optional password) * Personal access token * Basic auth username and password Only one authentication mode will be considered if more than one option is specified, with ssh private key/password preferred first, then personal access token, and finally basic auth credentials.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecGitAuth
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecGitAuth), fullyQualifiedName: "compulumi.StackSpecGitAuth")]
    public interface IStackSpecGitAuth
    {
        /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
        /// <remarks>
        /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
        /// strings are currently supported.
        ///
        /// <strong>Schema</strong>: StackSpecGitAuth#accessToken
        /// </remarks>
        [JsiiProperty(name: "accessToken", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthAccessToken\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecGitAuthAccessToken? AccessToken
        {
            get
            {
                return null;
            }
        }

        /// <summary>BasicAuth configures git authentication through basic auth — i.e. username and password. Both UserName and Password are required.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuth#basicAuth
        /// </remarks>
        [JsiiProperty(name: "basicAuth", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuth\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecGitAuthBasicAuth? BasicAuth
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
        /// <strong>Schema</strong>: StackSpecGitAuth#sshAuth
        /// </remarks>
        [JsiiProperty(name: "sshAuth", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthSshAuth\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecGitAuthSshAuth? SshAuth
        {
            get
            {
                return null;
            }
        }

        /// <summary>(optional) GitAuth allows configuring git authentication options There are 3 different authentication options: * SSH private key (and its optional password) * Personal access token * Basic auth username and password Only one authentication mode will be considered if more than one option is specified, with ssh private key/password preferred first, then personal access token, and finally basic auth credentials.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuth
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecGitAuth), fullyQualifiedName: "compulumi.StackSpecGitAuth")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecGitAuth
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
            /// <remarks>
            /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
            /// strings are currently supported.
            ///
            /// <strong>Schema</strong>: StackSpecGitAuth#accessToken
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "accessToken", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthAccessToken\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecGitAuthAccessToken? AccessToken
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecGitAuthAccessToken?>();
            }

            /// <summary>BasicAuth configures git authentication through basic auth — i.e. username and password. Both UserName and Password are required.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuth#basicAuth
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "basicAuth", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuth\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecGitAuthBasicAuth? BasicAuth
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecGitAuthBasicAuth?>();
            }

            /// <summary>SSHAuth configures ssh-based auth for git authentication.</summary>
            /// <remarks>
            /// SSHPrivateKey is required but password is optional.
            ///
            /// <strong>Schema</strong>: StackSpecGitAuth#sshAuth
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "sshAuth", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthSshAuth\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecGitAuthSshAuth? SshAuth
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecGitAuthSshAuth?>();
            }
        }
    }
}
