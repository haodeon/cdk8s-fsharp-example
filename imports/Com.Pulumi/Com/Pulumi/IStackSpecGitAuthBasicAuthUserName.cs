using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
    /// <remarks>
    /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
    /// strings are currently supported.
    ///
    /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecGitAuthBasicAuthUserName), fullyQualifiedName: "compulumi.StackSpecGitAuthBasicAuthUserName")]
    public interface IStackSpecGitAuthBasicAuthUserName
    {
        /// <summary>SelectorType is required and signifies the type of selector.</summary>
        /// <remarks>
        /// Must be one of:
        /// Env, FS, Secret, Literal
        ///
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Env selects an environment variable set on the operator process.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName#env
        /// </remarks>
        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuthUserNameEnv\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameEnv? Env
        {
            get
            {
                return null;
            }
        }

        /// <summary>FileSystem selects a file on the operator's file system.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName#filesystem
        /// </remarks>
        [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuthUserNameFilesystem\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameFilesystem? Filesystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>LiteralRef refers to a literal value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName#literal
        /// </remarks>
        [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuthUserNameLiteral\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameLiteral? Literal
        {
            get
            {
                return null;
            }
        }

        /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName#secret
        /// </remarks>
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuthUserNameSecret\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameSecret? Secret
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
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecGitAuthBasicAuthUserName), fullyQualifiedName: "compulumi.StackSpecGitAuthBasicAuthUserName")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecGitAuthBasicAuthUserName
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

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
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Env selects an environment variable set on the operator process.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName#env
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuthUserNameEnv\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameEnv? Env
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameEnv?>();
            }

            /// <summary>FileSystem selects a file on the operator's file system.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName#filesystem
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuthUserNameFilesystem\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameFilesystem? Filesystem
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameFilesystem?>();
            }

            /// <summary>LiteralRef refers to a literal value.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName#literal
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuthUserNameLiteral\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameLiteral? Literal
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameLiteral?>();
            }

            /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthUserName#secret
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackSpecGitAuthBasicAuthUserNameSecret\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameSecret? Secret
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecGitAuthBasicAuthUserNameSecret?>();
            }
        }
    }
}
