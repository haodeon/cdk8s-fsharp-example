using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>VolumeMount describes a mounting of a Volume within a container.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IVolumeMount), fullyQualifiedName: "k8s.VolumeMount")]
    public interface IVolumeMount
    {
        /// <summary>Path within the container at which the volume should be mounted.</summary>
        /// <remarks>
        /// Must not contain ':'.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#mountPath
        /// </remarks>
        [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}")]
        string MountPath
        {
            get;
        }

        /// <summary>This must match the Name of a Volume.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>mountPropagation determines how mounts are propagated from the host to container and the other way around.</summary>
        /// <remarks>
        /// When not set, MountPropagationNone is used. This field is beta in 1.10. When RecursiveReadOnly is set to IfPossible or to Enabled, MountPropagation must be None or unspecified (which defaults to None).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#mountPropagation
        /// </remarks>
        [JsiiProperty(name: "mountPropagation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MountPropagation
        {
            get
            {
                return null;
            }
        }

        /// <summary>Mounted read-only if true, read-write otherwise (false or unspecified).</summary>
        /// <remarks>
        /// Defaults to false.
        ///
        /// <strong>Default</strong>: false.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#readOnly
        /// </remarks>
        [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? ReadOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>RecursiveReadOnly specifies whether read-only mounts should be handled recursively.</summary>
        /// <remarks>
        /// If ReadOnly is false, this field has no meaning and must be unspecified.
        ///
        /// If ReadOnly is true, and this field is set to Disabled, the mount is not made recursively read-only.  If this field is set to IfPossible, the mount is made recursively read-only, if it is supported by the container runtime.  If this field is set to Enabled, the mount is made recursively read-only if it is supported by the container runtime, otherwise the pod will not be started and an error will be generated to indicate the reason.
        ///
        /// If this field is set to IfPossible or Enabled, MountPropagation must be set to None (or be unspecified, which defaults to None).
        ///
        /// If this field is not specified, it is treated as an equivalent of Disabled.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#recursiveReadOnly
        /// </remarks>
        [JsiiProperty(name: "recursiveReadOnly", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? RecursiveReadOnly
        {
            get
            {
                return null;
            }
        }

        /// <summary>Path within the volume from which the container's volume should be mounted.</summary>
        /// <remarks>
        /// Defaults to "" (volume's root).
        ///
        /// <strong>Default</strong>: volume's root).
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#subPath
        /// </remarks>
        [JsiiProperty(name: "subPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubPath
        {
            get
            {
                return null;
            }
        }

        /// <summary>Expanded path within the volume from which the container's volume should be mounted.</summary>
        /// <remarks>
        /// Behaves similarly to SubPath but environment variable references $(VAR_NAME) are expanded using the container's environment. Defaults to "" (volume's root). SubPathExpr and SubPath are mutually exclusive.
        ///
        /// <strong>Default</strong>: volume's root). SubPathExpr and SubPath are mutually exclusive.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#subPathExpr
        /// </remarks>
        [JsiiProperty(name: "subPathExpr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SubPathExpr
        {
            get
            {
                return null;
            }
        }

        /// <summary>VolumeMount describes a mounting of a Volume within a container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IVolumeMount), fullyQualifiedName: "k8s.VolumeMount")]
        internal sealed class _Proxy : DeputyBase, K8s.IVolumeMount
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Path within the container at which the volume should be mounted.</summary>
            /// <remarks>
            /// Must not contain ':'.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#mountPath
            /// </remarks>
            [JsiiProperty(name: "mountPath", typeJson: "{\"primitive\":\"string\"}")]
            public string MountPath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>This must match the Name of a Volume.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>mountPropagation determines how mounts are propagated from the host to container and the other way around.</summary>
            /// <remarks>
            /// When not set, MountPropagationNone is used. This field is beta in 1.10. When RecursiveReadOnly is set to IfPossible or to Enabled, MountPropagation must be None or unspecified (which defaults to None).
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#mountPropagation
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "mountPropagation", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MountPropagation
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Mounted read-only if true, read-write otherwise (false or unspecified).</summary>
            /// <remarks>
            /// Defaults to false.
            ///
            /// <strong>Default</strong>: false.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#readOnly
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "readOnly", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? ReadOnly
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>RecursiveReadOnly specifies whether read-only mounts should be handled recursively.</summary>
            /// <remarks>
            /// If ReadOnly is false, this field has no meaning and must be unspecified.
            ///
            /// If ReadOnly is true, and this field is set to Disabled, the mount is not made recursively read-only.  If this field is set to IfPossible, the mount is made recursively read-only, if it is supported by the container runtime.  If this field is set to Enabled, the mount is made recursively read-only if it is supported by the container runtime, otherwise the pod will not be started and an error will be generated to indicate the reason.
            ///
            /// If this field is set to IfPossible or Enabled, MountPropagation must be set to None (or be unspecified, which defaults to None).
            ///
            /// If this field is not specified, it is treated as an equivalent of Disabled.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#recursiveReadOnly
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "recursiveReadOnly", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? RecursiveReadOnly
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Path within the volume from which the container's volume should be mounted.</summary>
            /// <remarks>
            /// Defaults to "" (volume's root).
            ///
            /// <strong>Default</strong>: volume's root).
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#subPath
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subPath", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubPath
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>Expanded path within the volume from which the container's volume should be mounted.</summary>
            /// <remarks>
            /// Behaves similarly to SubPath but environment variable references $(VAR_NAME) are expanded using the container's environment. Defaults to "" (volume's root). SubPathExpr and SubPath are mutually exclusive.
            ///
            /// <strong>Default</strong>: volume's root). SubPathExpr and SubPath are mutually exclusive.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeMount#subPathExpr
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "subPathExpr", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SubPathExpr
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
