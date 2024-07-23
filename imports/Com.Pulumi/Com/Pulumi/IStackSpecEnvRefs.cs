using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>ResourceRef identifies a resource from which information can be loaded.</summary>
    /// <remarks>
    /// Environment variables, files on the filesystem, Kubernetes Secrets and literal
    /// strings are currently supported.
    ///
    /// <strong>Schema</strong>: StackSpecEnvRefs
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecEnvRefs), fullyQualifiedName: "compulumi.StackSpecEnvRefs")]
    public interface IStackSpecEnvRefs
    {
        /// <summary>SelectorType is required and signifies the type of selector.</summary>
        /// <remarks>
        /// Must be one of:
        /// Env, FS, Secret, Literal
        ///
        /// <strong>Schema</strong>: StackSpecEnvRefs#type
        /// </remarks>
        [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
        string Type
        {
            get;
        }

        /// <summary>Env selects an environment variable set on the operator process.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecEnvRefs#env
        /// </remarks>
        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackSpecEnvRefsEnv\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecEnvRefsEnv? Env
        {
            get
            {
                return null;
            }
        }

        /// <summary>FileSystem selects a file on the operator's file system.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecEnvRefs#filesystem
        /// </remarks>
        [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackSpecEnvRefsFilesystem\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecEnvRefsFilesystem? Filesystem
        {
            get
            {
                return null;
            }
        }

        /// <summary>LiteralRef refers to a literal value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecEnvRefs#literal
        /// </remarks>
        [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackSpecEnvRefsLiteral\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecEnvRefsLiteral? Literal
        {
            get
            {
                return null;
            }
        }

        /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecEnvRefs#secret
        /// </remarks>
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackSpecEnvRefsSecret\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        Com.Pulumi.IStackSpecEnvRefsSecret? Secret
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
        /// <strong>Schema</strong>: StackSpecEnvRefs
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecEnvRefs), fullyQualifiedName: "compulumi.StackSpecEnvRefs")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecEnvRefs
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>SelectorType is required and signifies the type of selector.</summary>
            /// <remarks>
            /// Must be one of:
            /// Env, FS, Secret, Literal
            ///
            /// <strong>Schema</strong>: StackSpecEnvRefs#type
            /// </remarks>
            [JsiiProperty(name: "type", typeJson: "{\"primitive\":\"string\"}")]
            public string Type
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Env selects an environment variable set on the operator process.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecEnvRefs#env
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackSpecEnvRefsEnv\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecEnvRefsEnv? Env
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecEnvRefsEnv?>();
            }

            /// <summary>FileSystem selects a file on the operator's file system.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecEnvRefs#filesystem
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackSpecEnvRefsFilesystem\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecEnvRefsFilesystem? Filesystem
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecEnvRefsFilesystem?>();
            }

            /// <summary>LiteralRef refers to a literal value.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecEnvRefs#literal
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackSpecEnvRefsLiteral\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecEnvRefsLiteral? Literal
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecEnvRefsLiteral?>();
            }

            /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecEnvRefs#secret
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackSpecEnvRefsSecret\"}", isOptional: true)]
            public Com.Pulumi.IStackSpecEnvRefsSecret? Secret
            {
                get => GetInstanceProperty<Com.Pulumi.IStackSpecEnvRefsSecret?>();
            }
        }
    }
}
