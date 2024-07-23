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
    /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuthPassword
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackV1Alpha1SpecGitAuthBasicAuthPassword")]
    public class StackV1Alpha1SpecGitAuthBasicAuthPassword : Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthPassword
    {
        /// <summary>SelectorType is required and signifies the type of selector.</summary>
        /// <remarks>
        /// Must be one of:
        /// Env, FS, Secret, Literal
        ///
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuthPassword#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        public string Type
        {
            get;
            set;
        }

        /// <summary>Env selects an environment variable set on the operator process.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuthPassword#env
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthBasicAuthPasswordEnv\"}", isOptional: true)]
        public Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthPasswordEnv? Env
        {
            get;
            set;
        }

        /// <summary>FileSystem selects a file on the operator's file system.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuthPassword#filesystem
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthBasicAuthPasswordFilesystem\"}", isOptional: true)]
        public Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthPasswordFilesystem? Filesystem
        {
            get;
            set;
        }

        /// <summary>LiteralRef refers to a literal value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuthPassword#literal
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthBasicAuthPasswordLiteral\"}", isOptional: true)]
        public Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthPasswordLiteral? Literal
        {
            get;
            set;
        }

        /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthBasicAuthPassword#secret
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthBasicAuthPasswordSecret\"}", isOptional: true)]
        public Com.Pulumi.IStackV1Alpha1SpecGitAuthBasicAuthPasswordSecret? Secret
        {
            get;
            set;
        }
    }
}
