using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <summary>FileSystem selects a file on the operator's file system.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthPasswordFilesystem
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackV1Alpha1SpecGitAuthSshAuthPasswordFilesystem")]
    public class StackV1Alpha1SpecGitAuthSshAuthPasswordFilesystem : Com.Pulumi.IStackV1Alpha1SpecGitAuthSshAuthPasswordFilesystem
    {
        /// <summary>Path on the filesystem to use to load information from.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecGitAuthSshAuthPasswordFilesystem#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        public string Path
        {
            get;
            set;
        }
    }
}