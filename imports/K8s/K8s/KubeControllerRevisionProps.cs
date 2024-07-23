using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>ControllerRevision implements an immutable snapshot of state data.</summary>
    /// <remarks>
    /// Clients are responsible for serializing and deserializing the objects that contain their internal state. Once a ControllerRevision has been successfully created, it can not be updated. The API Server will fail validation of all requests that attempt to mutate the Data field. ControllerRevisions may, however, be deleted. Note that, due to its use by both the DaemonSet and StatefulSet controllers for update and rollback, this object is beta. However, it may be subject to name and representation changes in future releases, and clients should not depend on its stability. It is primarily for internal use by controllers.
    ///
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevision
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeControllerRevisionProps")]
    public class KubeControllerRevisionProps : K8s.IKubeControllerRevisionProps
    {
        /// <summary>Revision indicates the revision of the state represented by Data.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevision#revision
        /// </remarks>
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
        public double Revision
        {
            get;
            set;
        }

        /// <summary>Data is the serialized representation of the state.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevision#data
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        public object? Data
        {
            get;
            set;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevision#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }
    }
}
