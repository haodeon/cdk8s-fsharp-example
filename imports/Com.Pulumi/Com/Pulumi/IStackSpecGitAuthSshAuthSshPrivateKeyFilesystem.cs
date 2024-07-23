using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>FileSystem selects a file on the operator's file system.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackSpecGitAuthSshAuthSshPrivateKeyFilesystem
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackSpecGitAuthSshAuthSshPrivateKeyFilesystem), fullyQualifiedName: "compulumi.StackSpecGitAuthSshAuthSshPrivateKeyFilesystem")]
    public interface IStackSpecGitAuthSshAuthSshPrivateKeyFilesystem
    {
        /// <summary>Path on the filesystem to use to load information from.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthSshAuthSshPrivateKeyFilesystem#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>FileSystem selects a file on the operator's file system.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackSpecGitAuthSshAuthSshPrivateKeyFilesystem
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackSpecGitAuthSshAuthSshPrivateKeyFilesystem), fullyQualifiedName: "compulumi.StackSpecGitAuthSshAuthSshPrivateKeyFilesystem")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackSpecGitAuthSshAuthSshPrivateKeyFilesystem
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Path on the filesystem to use to load information from.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackSpecGitAuthSshAuthSshPrivateKeyFilesystem#path
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
