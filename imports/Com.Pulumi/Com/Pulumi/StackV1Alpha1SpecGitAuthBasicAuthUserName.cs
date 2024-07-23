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
    /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuthUserName
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackV1Alpha1SpecGitAuthBasicAuthUserName")]
    public class StackV1Alpha1SpecGitAuthBasicAuthUserName : Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthUserName
    {
        /// <summary>SelectorType is required and signifies the type of selector.</summary>
        /// <remarks>
        /// Must be one of:
        /// Env, FS, Secret, Literal
        ///
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuthUserName#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Env selects an environment variable set on the operator process.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuthUserName#env
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthBasicAuthUserNameEnv\"}", isOptional: true)]
        public Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthUserNameEnv? Env
        {
            get;
            set;
        }

        /// <summary>FileSystem selects a file on the operator's file system.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuthUserName#filesystem
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthBasicAuthUserNameFilesystem\"}", isOptional: true)]
        public Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthUserNameFilesystem? Filesystem
        {
            get;
            set;
        }

        /// <summary>LiteralRef refers to a literal value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuthUserName#literal
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthBasicAuthUserNameLiteral\"}", isOptional: true)]
        public Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthUserNameLiteral? Literal
        {
            get;
            set;
        }

        /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuthUserName#secret
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthBasicAuthUserNameSecret\"}", isOptional: true)]
        public Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthUserNameSecret? Secret
        {
            get;
            set;
        }
    }
}
