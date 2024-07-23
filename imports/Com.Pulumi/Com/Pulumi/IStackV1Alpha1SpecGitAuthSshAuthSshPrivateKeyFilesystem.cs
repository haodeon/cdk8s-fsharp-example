using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>FileSystem selects a file on the operator's file system.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyFilesystem
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyFilesystem), fullyQualifiedName: "compulumi.StackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyFilesystem")]
    public interface IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyFilesystem
    {
        /// <summary>Path on the filesystem to use to load information from.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyFilesystem#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>FileSystem selects a file on the operator's file system.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyFilesystem
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyFilesystem), fullyQualifiedName: "compulumi.StackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyFilesystem")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyFilesystem
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Path on the filesystem to use to load information from.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthSshPrivateKeyFilesystem#path
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}