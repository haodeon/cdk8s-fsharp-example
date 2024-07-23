using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Maps a string key to a path within a volume.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.KeyToPath
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKeyToPath), fullyQualifiedName: "k8s.KeyToPath")]
    public interface IKeyToPath
    {
        /// <summary>key is the key to project.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.KeyToPath#key
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>path is the relative path of the file to map the key to.</summary>
        /// <remarks>
        /// May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.KeyToPath#path
        /// </remarks>
        [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
        string Path
        {
            get;
        }

        /// <summary>mode is Optional: mode bits used to set permissions on this file.</summary>
        /// <remarks>
        /// Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.KeyToPath#mode
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

        /// <summary>Maps a string key to a path within a volume.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.KeyToPath
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKeyToPath), fullyQualifiedName: "k8s.KeyToPath")]
        internal sealed class _Proxy : DeputyBase, K8s.IKeyToPath
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>key is the key to project.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.KeyToPath#key
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>path is the relative path of the file to map the key to.</summary>
            /// <remarks>
            /// May not be an absolute path. May not contain the path element '..'. May not start with the string '..'.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.KeyToPath#path
            /// </remarks>
            [JsiiProperty(name: "path", typeJson: "{\"primitive\":\"string\"}")]
            public string Path
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>mode is Optional: mode bits used to set permissions on this file.</summary>
            /// <remarks>
            /// Must be an octal value between 0000 and 0777 or a decimal value between 0 and 511. YAML accepts both octal and decimal values, JSON requires decimal values for mode bits. If not specified, the volume defaultMode will be used. This might be in conflict with other options that affect the file mode, like fsGroup, and the result can be other mode bits set.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.KeyToPath#mode
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mode", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? Mode
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
