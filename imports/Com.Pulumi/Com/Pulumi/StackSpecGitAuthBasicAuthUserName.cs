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
    /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackSpecGitAuthBasicAuthUserName")]
    public class StackSpecGitAuthBasicAuthUserName : Com.Pulumi.IStackSpecGitAuthBasicAuthUserName
    {
        /// <summary>SelectorType is required and signifies the type of selector.</summary>
        /// <remarks>
        /// Must be one of:
        /// Env, FS, Secret, Literal
        ///
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Env selects an environment variable set on the operator process.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName#env
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuthUserNameEnv\"}", isOptional: true)]
        public Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameEnv? Env
        {
            get;
            set;
        }

        /// <summary>FileSystem selects a file on the operator's file system.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName#filesystem
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuthUserNameFilesystem\"}", isOptional: true)]
        public Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameFilesystem? Filesystem
        {
            get;
            set;
        }

        /// <summary>LiteralRef refers to a literal value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName#literal
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuthUserNameLiteral\"}", isOptional: true)]
        public Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameLiteral? Literal
        {
            get;
            set;
        }

        /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName#secret
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuthUserNameSecret\"}", isOptional: true)]
        public Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameSecret? Secret
        {
            get;
            set;
        }
    }
}
