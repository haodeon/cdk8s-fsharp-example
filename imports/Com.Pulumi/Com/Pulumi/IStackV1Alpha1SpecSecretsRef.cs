using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
    /// <remarks>
    /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
    /// strings are currently supported.
    ///
    /// <strong>Schema</strong>: StackV1Alpha1SpecSecretsRef
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackV1Alpha1SpecSecretsRef), fullyQualifiedName: "compulumi.StackV1Alpha1SpecSecretsRef")]
    public interface IStackV1Alpha1SpecSecretsRef
    {
        /// <summary>SelectorType is required and signifies the type of selector.</summary>
        /// <remarks>
        /// Must be one of:
        /// Env, FS, Secret, Literal
        ///
        /// <strong>Schema</strong>: StackV1Alpha1SpecSecretsRef#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Env selects an environment variable set on the operator process.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecSecretsRef#env
        /// </remarks>
        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecSecretsRefEnv\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackV1Alpha1SpecSecretsRefEnv? Env
        {
            get
            {
                return null;
            }
        }

        /// <summary>FileSystem selects a file on the operator's file system.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecSecretsRef#filesystem
        /// </remarks>
        [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecSecretsRefFilesystem\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackV1Alpha1SpecSecretsRefFilesystem? Filesystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>LiteralRef refers to a literal value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecSecretsRef#literal
        /// </remarks>
        [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecSecretsRefLiteral\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackV1Alpha1SpecSecretsRefLiteral? Literal
        {
            get
            {
                return null;
            }
        }

        /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecSecretsRef#secret
        /// </remarks>
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecSecretsRefSecret\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackV1Alpha1SpecSecretsRefSecret? Secret
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
        /// <strong>Schema</strong>: StackV1Alpha1SpecSecretsRef
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackV1Alpha1SpecSecretsRef), fullyQualifiedName: "compulumi.StackV1Alpha1SpecSecretsRef")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackV1Alpha1SpecSecretsRef
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>SelectorType is required and signifies the type of selector.</summary>
            /// <remarks>
            /// Must be one of:
            /// Env, FS, Secret, Literal
            ///
            /// <strong>Schema</strong>: StackV1Alpha1SpecSecretsRef#type
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Env selects an environment variable set on the operator process.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecSecretsRef#env
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecSecretsRefEnv\"}", isOptional: true)]
            public Com.Pulumi.IStackV1Alpha1SpecSecretsRefEnv? Env
            {
                get => GetInstanceProperty<Com.Pulumi.IStackV1Alpha1SpecSecretsRefEnv?>();
            }

            /// <summary>FileSystem selects a file on the operator's file system.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecSecretsRef#filesystem
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecSecretsRefFilesystem\"}", isOptional: true)]
            public Com.Pulumi.IStackV1Alpha1SpecSecretsRefFilesystem? Filesystem
            {
                get => GetInstanceProperty<Com.Pulumi.IStackV1Alpha1SpecSecretsRefFilesystem?>();
            }

            /// <summary>LiteralRef refers to a literal value.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecSecretsRef#literal
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecSecretsRefLiteral\"}", isOptional: true)]
            public Com.Pulumi.IStackV1Alpha1SpecSecretsRefLiteral? Literal
            {
                get => GetInstanceProperty<Com.Pulumi.IStackV1Alpha1SpecSecretsRefLiteral?>();
            }

            /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecSecretsRef#secret
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackV1Alpha1SpecSecretsRefSecret\"}", isOptional: true)]
            public Com.Pulumi.IStackV1Alpha1SpecSecretsRefSecret? Secret
            {
                get => GetInstanceProperty<Com.Pulumi.IStackV1Alpha1SpecSecretsRefSecret?>();
            }
        }
    }
}
