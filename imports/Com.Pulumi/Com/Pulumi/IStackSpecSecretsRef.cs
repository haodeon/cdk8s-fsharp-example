using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
    /// <remarks>
    /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
    /// strings are currently supported.
    ///
    /// <strong>Schema</strong>: StackSpecSecretsRef
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecSecretsRef), fullyQualifiedName: "compulumi.StackSpecSecretsRef")]
    public interface IStackSpecSecretsRef
    {
        /// <summary>SelectorType is required and signifies the type of selector.</summary>
        /// <remarks>
        /// Must be one of:
        /// Env, FS, Secret, Literal
        ///
        /// <strong>Schema</strong>: StackSpecSecretsRef#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Env selects an environment variable set on the operator process.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecSecretsRef#env
        /// </remarks>
        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackSpecSecretsRefEnv\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecSecretsRefEnv? Env
        {
            get
            {
                return null;
            }
        }

        /// <summary>FileSystem selects a file on the operator's file system.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecSecretsRef#filesystem
        /// </remarks>
        [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackSpecSecretsRefFilesystem\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecSecretsRefFilesystem? Filesystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>LiteralRef refers to a literal value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecSecretsRef#literal
        /// </remarks>
        [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackSpecSecretsRefLiteral\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecSecretsRefLiteral? Literal
        {
            get
            {
                return null;
            }
        }

        /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecSecretsRef#secret
        /// </remarks>
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackSpecSecretsRefSecret\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecSecretsRefSecret? Secret
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
        /// <strong>Schema</strong>: StackSpecSecretsRef
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecSecretsRef), fullyQualifiedName: "compulumi.StackSpecSecretsRef")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecSecretsRef
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>SelectorType is required and signifies the type of selector.</summary>
            /// <remarks>
            /// Must be one of:
            /// Env, FS, Secret, Literal
            ///
            /// <strong>Schema</strong>: StackSpecSecretsRef#type
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Env selects an environment variable set on the operator process.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecSecretsRef#env
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackSpecSecretsRefEnv\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecSecretsRefEnv? Env
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecSecretsRefEnv?>();
            }

            /// <summary>FileSystem selects a file on the operator's file system.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecSecretsRef#filesystem
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackSpecSecretsRefFilesystem\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecSecretsRefFilesystem? Filesystem
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecSecretsRefFilesystem?>();
            }

            /// <summary>LiteralRef refers to a literal value.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecSecretsRef#literal
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackSpecSecretsRefLiteral\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecSecretsRefLiteral? Literal
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecSecretsRefLiteral?>();
            }

            /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecSecretsRef#secret
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackSpecSecretsRefSecret\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecSecretsRefSecret? Secret
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecSecretsRefSecret?>();
            }
        }
    }
}
