using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>volumeDevice describes a mapping of a raw block device within a container.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeDevice
    /// </remarks>
    [JsiiByValue(fqn: "k8s.VolumeDevice")]
    public class VolumeDevice : K8s.IVolumeDevice
    {
        /// <summary>devicePath is the path inside of the container that the device will be mapped to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeDevice#devicePath
        /// </remarks>
        [JsiiProperty(name: "devicePath", typeJson: "{\"primitive\":\"string\"}")]
        public string DevicePath
        {
            get;
            set;
        }

        /// <summary>name must match the name of a persistentVolumeClaim in the pod.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.VolumeDevice#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }
    }
}
