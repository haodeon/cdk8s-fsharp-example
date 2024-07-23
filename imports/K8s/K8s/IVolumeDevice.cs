using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>volumeDevice describes a mapping of a raw block device within a container.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeDevice
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IVolumeDevice), fullyQualifiedName: "k8s.VolumeDevice")]
    public interface IVolumeDevice
    {
        /// <summary>devicePath is the path inside of the container that the device will be mapped to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeDevice#devicePath
        /// </remarks>
        [JsiiProperty(name: "devicePath", typeJson: "{\"primitive\":\"string\"}")]
        string DevicePath
        {
            get;
        }

        /// <summary>name must match the name of a persistentVolumeClaim in the pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeDevice#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>volumeDevice describes a mapping of a raw block device within a container.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeDevice
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IVolumeDevice), fullyQualifiedName: "k8s.VolumeDevice")]
        internal sealed class _Proxy : DeputyBase, K8s.IVolumeDevice
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>devicePath is the path inside of the container that the device will be mapped to.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeDevice#devicePath
            /// </remarks>
            [JsiiProperty(name: "devicePath", typeJson: "{\"primitive\":\"string\"}")]
            public string DevicePath
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>name must match the name of a persistentVolumeClaim in the pod.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeDevice#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
