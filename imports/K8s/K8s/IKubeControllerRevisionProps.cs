using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ControllerRevision implements an immutable snapshot of state data.</summary>
    /// <remarks>
    /// Clients are responsible for serializing and deserializing the objects that contain their internal state. Once a ControllerRevision has been successfully created, it can not be updated. The API Server will fail validation of all requests that attempt to mutate the Data field. ControllerRevisions may, however, be deleted. Note that, due to its use by both the DaemonSet and StatefulSet controllers for update and rollback, this object is beta. However, it may be subject to name and representation changes in future releases, and clients should not depend on its stability. It is primarily for internal use by controllers.
    ///
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevision
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubeControllerRevisionProps), fullyQualifiedName: "k8s.KubeControllerRevisionProps")]
    public interface IKubeControllerRevisionProps
    {
        /// <summary>Revision indicates the revision of the state represented by Data.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevision#revision
        /// </remarks>
        [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
        double Revision
        {
            get;
        }

        /// <summary>Data is the serialized representation of the state.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevision#data
        /// </remarks>
        [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        object? Data
        {
            get
            {
                return null;
            }
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevision#metadata
        /// </remarks>
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IObjectMeta? Metadata
        {
            get
            {
                return null;
            }
        }

        /// <summary>ControllerRevision implements an immutable snapshot of state data.</summary>
        /// <remarks>
        /// Clients are responsible for serializing and deserializing the objects that contain their internal state. Once a ControllerRevision has been successfully created, it can not be updated. The API Server will fail validation of all requests that attempt to mutate the Data field. ControllerRevisions may, however, be deleted. Note that, due to its use by both the DaemonSet and StatefulSet controllers for update and rollback, this object is beta. However, it may be subject to name and representation changes in future releases, and clients should not depend on its stability. It is primarily for internal use by controllers.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevision
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubeControllerRevisionProps), fullyQualifiedName: "k8s.KubeControllerRevisionProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubeControllerRevisionProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Revision indicates the revision of the state represented by Data.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevision#revision
            /// </remarks>
            [JsiiProperty(name: "revision", typeJson: "{\"primitive\":\"number\"}")]
            public double Revision
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>Data is the serialized representation of the state.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.apps.v1.ControllerRevision#data
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "data", typeJson: "{\"primitive\":\"any\"}", isOptional: true)]
            public object? Data
            {
                get => GetInstanceProperty<object?>();
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
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }
        }
    }
}
