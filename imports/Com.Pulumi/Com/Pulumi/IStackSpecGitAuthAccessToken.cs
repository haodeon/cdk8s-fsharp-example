using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
    /// <remarks>
    /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
    /// strings are currently supported.
    ///
    /// <strong>Schema</strong>: StackSpecGitAuthAccessToken
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecGitAuthAccessToken), fullyQualifiedName: "compulumi.StackSpecGitAuthAccessToken")]
    public interface IStackSpecGitAuthAccessToken
    {
        /// <summary>SelectorType is required and signifies the type of selector.</summary>
        /// <remarks>
        /// Must be one of:
        /// Env, FS, Secret, Literal
        ///
        /// <strong>Schema</strong>: StackSpecGitAuthAccessToken#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Env selects an environment variable set on the operator process.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthAccessToken#env
        /// </remarks>
        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthAccessTokenEnv\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecGitAuthAccessTokenEnv? Env
        {
            get
            {
                return null;
            }
        }

        /// <summary>FileSystem selects a file on the operator's file system.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthAccessToken#filesystem
        /// </remarks>
        [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthAccessTokenFilesystem\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecGitAuthAccessTokenFilesystem? Filesystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>LiteralRef refers to a literal value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthAccessToken#literal
        /// </remarks>
        [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthAccessTokenLiteral\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecGitAuthAccessTokenLiteral? Literal
        {
            get
            {
                return null;
            }
        }

        /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthAccessToken#secret
        /// </remarks>
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthAccessTokenSecret\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecGitAuthAccessTokenSecret? Secret
        {
            get
            {
                return null;
            }
        }

        /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
        /// <remarks>
        /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
        /// strings are currently supported.
        ///
        /// <strong>Schema</strong>: StackSpecGitAuthAccessToken
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecGitAuthAccessToken), fullyQualifiedName: "compulumi.StackSpecGitAuthAccessToken")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecGitAuthAccessToken
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Env selects an environment variable set on the operator process.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthAccessToken#env
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthAccessTokenEnv\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecGitAuthAccessTokenEnv? Env
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecGitAuthAccessTokenEnv?>();
            }

            /// <summary>FileSystem selects a file on the operator's file system.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthAccessToken#filesystem
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthAccessTokenFilesystem\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecGitAuthAccessTokenFilesystem? Filesystem
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecGitAuthAccessTokenFilesystem?>();
            }

            /// <summary>LiteralRef refers to a literal value.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthAccessToken#literal
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthAccessTokenLiteral\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecGitAuthAccessTokenLiteral? Literal
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecGitAuthAccessTokenLiteral?>();
            }

            /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthAccessToken#secret
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthAccessTokenSecret\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecGitAuthAccessTokenSecret? Secret
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecGitAuthAccessTokenSecret?>();
            }
        }
    }
}
