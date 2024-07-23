using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
    /// <remarks>
    /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
    /// strings are currently supported.
    ///
    /// <strong>Schema</strong>: StackSpecGitAuthAccessToken
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackSpecGitAuthAccessToken")]
    public class StackSpecGitAuthAccessToken : Com.Pulumi.IStackSpecGitAuthAccessToken
    {
        /// <summary>SelectorType is required and signifies the type of selector.</summary>
        /// <remarks>
        /// Must be one of:
        /// Env, FS, Secret, Literal
        ///
        /// <strong>Schema</strong>: StackSpecGitAuthAccessToken#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Env selects an environment variable set on the operator process.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthAccessToken#env
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthAccessTokenEnv\"}", isOptional: true)]
        public Com.Pulumi.IStackSpecGitAuthAccessTokenEnv? Env
        {
            get;
            set;
        }

        /// <summary>FileSystem selects a file on the operator's file system.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthAccessToken#filesystem
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthAccessTokenFilesystem\"}", isOptional: true)]
        public Com.Pulumi.IStackSpecGitAuthAccessTokenFilesystem? Filesystem
        {
            get;
            set;
        }

        /// <summary>LiteralRef refers to a literal value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthAccessToken#literal
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthAccessTokenLiteral\"}", isOptional: true)]
        public Com.Pulumi.IStackSpecGitAuthAccessTokenLiteral? Literal
        {
            get;
            set;
        }

        /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthAccessToken#secret
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthAccessTokenSecret\"}", isOptional: true)]
        public Com.Pulumi.IStackSpecGitAuthAccessTokenSecret? Secret
        {
            get;
            set;
        }
    }
}
