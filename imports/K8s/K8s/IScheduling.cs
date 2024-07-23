using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Scheduling specifies the scheduling constraints for nodes supporting a RuntimeClass.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.node.v1.Scheduling
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IScheduling), fullyQualifiedName: "k8s.Scheduling")]
    public interface IScheduling
    {
        /// <summary>nodeSelector lists labels that must be present on nodes that support this RuntimeClass.</summary>
        /// <remarks>
        /// Pods using this RuntimeClass can only be scheduled to a node matched by this selector. The RuntimeClass nodeSelector is merged with a pod's existing nodeSelector. Any conflicts will cause the pod to be rejected in admission.
        ///
        /// <strong>Schema</strong>: io.k8s.api.node.v1.Scheduling#nodeSelector
        /// </remarks>
        [JsiiProperty(name: "nodeSelector", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.Collections.Generic.IDictionary<string, string>? NodeSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>tolerations are appended (excluding duplicates) to pods running with this RuntimeClass during admission, effectively unioning the set of nodes tolerated by the pod and the RuntimeClass.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.node.v1.Scheduling#tolerations
        /// </remarks>
        [JsiiProperty(name: "tolerations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Toleration\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IToleration[]? Tolerations
        {
            get
            {
                return null;
            }
        }

        /// <summary>Scheduling specifies the scheduling constraints for nodes supporting a RuntimeClass.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.node.v1.Scheduling
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IScheduling), fullyQualifiedName: "k8s.Scheduling")]
        internal sealed class _Proxy : DeputyBase, K8s.IScheduling
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>nodeSelector lists labels that must be present on nodes that support this RuntimeClass.</summary>
            /// <remarks>
            /// Pods using this RuntimeClass can only be scheduled to a node matched by this selector. The RuntimeClass nodeSelector is merged with a pod's existing nodeSelector. Any conflicts will cause the pod to be rejected in admission.
            ///
            /// <strong>Schema</strong>: io.k8s.api.node.v1.Scheduling#nodeSelector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "nodeSelector", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"map\"}}", isOptional: true)]
            public System.Collections.Generic.IDictionary<string, string>? NodeSelector
            {
                get => GetInstanceProperty<System.Collections.Generic.IDictionary<string, string>?>();
            }

            /// <summary>tolerations are appended (excluding duplicates) to pods running with this RuntimeClass during admission, effectively unioning the set of nodes tolerated by the pod and the RuntimeClass.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.node.v1.Scheduling#tolerations
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "tolerations", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.Toleration\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IToleration[]? Tolerations
            {
                get => GetInstanceProperty<K8s.IToleration[]?>();
            }
        }
    }
}
