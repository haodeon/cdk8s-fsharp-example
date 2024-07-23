using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>FileSystem selects a file on the operator's file system.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthAccessTokenFilesystem
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IStackV1Alpha1SpecGitAuthAccessTokenFilesystem), fullyQualifiedName: "compulumi.StackV1Alpha1SpecGitAuthAccessTokenFilesystem")]
    public interface IStackV1Alpha1SpecGitAuthAccessTokenFilesystem
    {
        /// <summary>Path on the filesystem to use to load information from.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthAccessTokenFilesystem#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>FileSystem selects a file on the operator's file system.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthAccessTokenFilesystem
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IStackV1Alpha1SpecGitAuthAccessTokenFilesystem), fullyQualifiedName: "compulumi.StackV1Alpha1SpecGitAuthAccessTokenFilesystem")]
        internal sealed class _Proxy : DeputyBase, Com.Pulumi.IStackV1Alpha1SpecGitAuthAccessTokenFilesystem
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Path on the filesystem to use to load information from.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthAccessTokenFilesystem#path
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
