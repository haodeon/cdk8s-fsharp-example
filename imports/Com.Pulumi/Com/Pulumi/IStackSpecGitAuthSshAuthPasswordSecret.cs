using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecGitAuthSshAuthPasswordSecret
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecGitAuthSshAuthPasswordSecret), fullyQualifiedName: "compulumi.StackSpecGitAuthSshAuthPasswordSecret")]
    public interface IStackSpecGitAuthSshAuthPasswordSecret
    {
        /// <summary>Key within the Secret to use.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthSshAuthPasswordSecret#key
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Name of the Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthSshAuthPasswordSecret#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>Namespace where the Secret is stored.</summary>
        /// <remarks>
        /// Deprecated; non-empty values will be considered invalid
        /// unless namespace isolation is disabled in the controller.
        ///
        /// <strong>Schema</strong>: StackSpecGitAuthSshAuthPasswordSecret#namespace
        /// </remarks>
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Namespace
        {
            get
            {
                return null;
            }
        }

        /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthSshAuthPasswordSecret
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecGitAuthSshAuthPasswordSecret), fullyQualifiedName: "compulumi.StackSpecGitAuthSshAuthPasswordSecret")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecGitAuthSshAuthPasswordSecret
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Key within the Secret to use.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthSshAuthPasswordSecret#key
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name of the Secret.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthSshAuthPasswordSecret#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Namespace where the Secret is stored.</summary>
            /// <remarks>
            /// Deprecated; non-empty values will be considered invalid
            /// unless namespace isolation is disabled in the controller.
            ///
            /// <strong>Schema</strong>: StackSpecGitAuthSshAuthPasswordSecret#namespace
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Namespace
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}