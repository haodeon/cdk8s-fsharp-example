using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Represents a volume that is populated with the contents of a git repository.</summary>
    /// <remarks>
    /// Git repo volumes do not support ownership management. Git repo volumes support SELinux relabeling.
    ///
    /// DEPRECATED: GitRepo is deprecated. To provision a container with a git repo, mount an EmptyDir into an InitContainer that clones the repo using git, then mount the EmptyDir into the Pod's container.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.GitRepoVolumeSource
    /// </remarks>
    [JsiiByValue(fqn: "k8s.GitRepoVolumeSource")]
    public class GitRepoVolumeSource : K8s.IGitRepoVolumeSource
    {
        /// <summary>repository is the URL.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GitRepoVolumeSource#repository
        /// </remarks>
        [JsiiProperty(name: "repository", typeJson: "{\"primitive\":\"string\"}")]
        public string Repository
        {
            get;
            set;
        }

        /// <summary>directory is the target directory name.</summary>
        /// <remarks>
        /// Must not contain or start with '..'.  If '.' is supplied, the volume directory will be the git repository.  Otherwise, if specified, the volume will contain the git repository in the subdirectory with the given name.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GitRepoVolumeSource#directory
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "directory", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Directory
        {
            get;
            set;
        }

        /// <summary>revision is the commit hash for the specified revision.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GitRepoVolumeSource#revision
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Revision
        {
            get;
            set;
        }
    }
}
