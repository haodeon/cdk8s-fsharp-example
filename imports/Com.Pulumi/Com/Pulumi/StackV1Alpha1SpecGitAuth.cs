using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>(optional) GitAuth allows configuring git authentication options There are 3 different authentication options: * SSH private key (and its optional password) * Personal access token * Basic auth username and password Only one authentication mode will be considered if more than one option is specified, with ssh private key/password preferred first, then personal access token, and finally basic auth credentials.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuth
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackV1Alpha1SpecGitAuth")]
    public class StackV1Alpha1SpecGitAuth : Com.Pulumi.IStackV1Alpha1SpecGitAuth
    {
        /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
        /// <remarks>
        /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
        /// strings are currently supported.
        ///
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuth#accessToken
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "accessToken", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthAccessToken\"}", isOptional: true)]
        public Com.Pulumi.IStackV1Alpha1SpecGitAuthAccessToken? AccessToken
        {
            get;
            set;
        }

        /// <summary>BasicAuth configures git authentication through basic auth — i.e. username and password. Both UserName and Password are required.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuth#basicAuth
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "basicAuth", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthBasicAuth\"}", isOptional: true)]
        public Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuth? BasicAuth
        {
            get;
            set;
        }

        /// <summary>SSHAuth configures ssh-based auth for git authentication.</summary>
        /// <remarks>
        /// SSHPrivateKey is required but password is optional.
        ///
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuth#sshAuth
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "sshAuth", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthSshAuth\"}", isOptional: true)]
        public Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuth? SshAuth
        {
            get;
            set;
        }
    }
}
