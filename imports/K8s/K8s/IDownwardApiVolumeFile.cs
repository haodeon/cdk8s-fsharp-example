using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>DownwardAPIVolumeFile represents information to create the file containing the pod field.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIVolumeFile
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IDownwardApiVolumeFile), fullyQualifiedName: "k8s.DownwardApiVolumeFile")]
    public interface IDownwardApiVolumeFile
    {
        /// <summary>Required: Path is  the relative path name of the file to be created.</summary>
        /// <remarks>
        /// Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIVolumeFile#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>Required: Selects a field of the pod: only annotations, labels, name, namespace and uid are supported.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIVolumeFile#fieldRef
        /// </remarks>
        [JsiiProperty(name: "fieldRef", typeJson: "{\"fqn\":\"k8s.ObjectFieldSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectFieldSelector? FieldRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>Optional: mode bits used to set permissions on this file, must be an octal value between 0000 and 0777 or a decimal value between 0 and 511.</summary>
        /// <remarks>
        /// YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIVolumeFile#mode
        /// </remarks>
        [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? Mode
        {
            get
            {
                return null;
            }
        }

        /// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIVolumeFile#resourceFieldRef
        /// </remarks>
        [JsiiProperty(name: "resourceFieldRef", typeJson: "{\"fqn\":\"k8s.ResourceFieldSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IResourceFieldSelector? ResourceFieldRef
        {
            get
            {
                return null;
            }
        }

        /// <summary>DownwardAPIVolumeFile represents information to create the file containing the pod field.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIVolumeFile
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IDownwardApiVolumeFile), fullyQualifiedName: "k8s.DownwardApiVolumeFile")]
        internal sealed class _Proxy : DeputyBase, K8s.IDownwardApiVolumeFile
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Required: Path is  the relative path name of the file to be created.</summary>
            /// <remarks>
            /// Must not be absolute or contain the '..' path. Must be utf-8 encoded. The first item of the relative path must not start with '..'
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIVolumeFile#path
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Required: Selects a field of the pod: only annotations, labels, name, namespace and uid are supported.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIVolumeFile#fieldRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "fieldRef", typeJson: "{\"fqn\":\"k8s.ObjectFieldSelector\"}", isOptional: true)]
            public K8s.IObjectFieldSelector? FieldRef
            {
                get => GetInstanceProperty<K8s.IObjectFieldSelector?>();
            }

            /// <summary>Optional: mode bits used to set permissions on this file, must be an octal value between 0000 and 0777 or a decimal value between 0 and 511.</summary>
            /// <remarks>
            /// YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIVolumeFile#mode
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Mode
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>Selects a resource of the container: only resources limits and requests (limits.cpu, limits.memory, requests.cpu and requests.memory) are currently supported.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.DownwardAPIVolumeFile#resourceFieldRef
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceFieldRef", typeJson: "{\"fqn\":\"k8s.ResourceFieldSelector\"}", isOptional: true)]
            public K8s.IResourceFieldSelector? ResourceFieldRef
            {
                get => GetInstanceProperty<K8s.IResourceFieldSelector?>();
            }
        }
    }
}