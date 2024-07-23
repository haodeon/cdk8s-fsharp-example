using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthPasswordSecret
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecGitAuthBasicAuthPasswordSecret), fullyQualifiedName: "compulumi.StackSpecGitAuthBasicAuthPasswordSecret")]
    public interface IStackSpecGitAuthBasicAuthPasswordSecret
    {
        /// <summary>Key within the Secret to use.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthPasswordSecret#key
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>Name of the Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthPasswordSecret#name
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
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthPasswordSecret#namespace
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
        /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthPasswordSecret
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecGitAuthBasicAuthPasswordSecret), fullyQualifiedName: "compulumi.StackSpecGitAuthBasicAuthPasswordSecret")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecGitAuthBasicAuthPasswordSecret
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Key within the Secret to use.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthPasswordSecret#key
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Name of the Secret.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthPasswordSecret#name
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
            /// <strong>Schema</strong>: StackSpecGitAuthBasicAuthPasswordSecret#namespace
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
