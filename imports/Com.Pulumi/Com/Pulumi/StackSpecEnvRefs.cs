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
    /// <strong>Schema</strong>: StackSpecEnvRefs
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackSpecEnvRefs")]
    public class StackSpecEnvRefs : Com.Pulumi.IStackSpecEnvRefs
    {
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
            get;
            set;
        }

        /// <summary>Env selects an environment variable set on the operator process.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecEnvRefs#env
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "env", typeJson: "{\"fqn\":\"compulumi.StackSpecEnvRefsEnv\"}", isOptional: true)]
        public Com.Pulumi.IStackSpecEnvRefsEnv? Env
        {
            get;
            set;
        }

        /// <summary>FileSystem selects a file on the operator's file system.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecEnvRefs#filesystem
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "filesystem", typeJson: "{\"fqn\":\"compulumi.StackSpecEnvRefsFilesystem\"}", isOptional: true)]
        public Com.Pulumi.IStackSpecEnvRefsFilesystem? Filesystem
        {
            get;
            set;
        }

        /// <summary>LiteralRef refers to a literal value.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecEnvRefs#literal
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "literal", typeJson: "{\"fqn\":\"compulumi.StackSpecEnvRefsLiteral\"}", isOptional: true)]
        public Com.Pulumi.IStackSpecEnvRefsLiteral? Literal
        {
            get;
            set;
        }

        /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecEnvRefs#secret
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "secret", typeJson: "{\"fqn\":\"compulumi.StackSpecEnvRefsSecret\"}", isOptional: true)]
        public Com.Pulumi.IStackSpecEnvRefsSecret? Secret
        {
            get;
            set;
        }
    }
}
