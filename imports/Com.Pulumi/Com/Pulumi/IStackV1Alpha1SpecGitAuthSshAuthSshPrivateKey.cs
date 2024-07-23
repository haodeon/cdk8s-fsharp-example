using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
    /// <remarks>
    /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
    /// strings are currently supported.
    ///
    /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthSshPrivateKey
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKey), fullyQualifiedName: "compulumi.StackV1Alpha1SpecGitAuthSshAuthSshPrivateKey")]
    public interface IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKey
    {
        /// <summary>SelectorType is required and signifies the type of selector.</summary>
        /// <remarks>
        /// Must be one of:
        /// Env, FS, Secret, Literal
        ///
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthSshPrivateKey#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Env selects an environment variable set on the operator process.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthSshPrivateKey#env
        /// </remarks>
        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyEnv\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyEnv? Env
        {
            get
            {
                return null;
            }
        }

        /// <summary>FileSystem selects a file on the operator's file system.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthSshPrivateKey#filesystem
        /// </remarks>
        [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyFilesystem\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyFilesystem? Filesystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>LiteralRef refers to a literal value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthSshPrivateKey#literal
        /// </remarks>
        [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyLiteral\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyLiteral? Literal
        {
            get
            {
                return null;
            }
        }

        /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthSshPrivateKey#secret
        /// </remarks>
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthSshAuthSshPrivateKeySecret\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKeySecret? Secret
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
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthSshPrivateKey
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKey), fullyQualifiedName: "compulumi.StackV1Alpha1SpecGitAuthSshAuthSshPrivateKey")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKey
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>SelectorType is required and signifies the type of selector.</summary>
            /// <remarks>
            /// Must be one of:
            /// Env, FS, Secret, Literal
            ///
            /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthSshPrivateKey#type
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Env selects an environment variable set on the operator process.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthSshPrivateKey#env
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyEnv\"}", isOptional: true)]
            public Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyEnv? Env
            {
                get => GetInstanceProperty<Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyEnv?>();
            }

            /// <summary>FileSystem selects a file on the operator's file system.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthSshPrivateKey#filesystem
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyFilesystem\"}", isOptional: true)]
            public Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyFilesystem? Filesystem
            {
                get => GetInstanceProperty<Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyFilesystem?>();
            }

            /// <summary>LiteralRef refers to a literal value.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthSshPrivateKey#literal
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyLiteral\"}", isOptional: true)]
            public Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyLiteral? Literal
            {
                get => GetInstanceProperty<Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyLiteral?>();
            }

            /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthSshPrivateKey#secret
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecGitAuthSshAuthSshPrivateKeySecret\"}", isOptional: true)]
            public Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKeySecret? Secret
            {
                get => GetInstanceProperty<Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKeySecret?>();
            }
        }
    }
}
