using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>The node this Taint is attached to has the "effect" on any pod that does not tolerate the Taint.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Taint
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ITaint), fullyQualifiedName: "k8s.Taint")]
    public interface ITaint
    {
        /// <summary>Required.</summary>
        /// <remarks>
        /// The effect of the taint on pods that do not tolerate the taint. Valid effects are NoSchedule, PreferNoSchedule and NoExecute.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Taint#effect
        /// </remarks>
        [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}")]
        string Effect
        {
            get;
        }

        /// <summary>Required.</summary>
        /// <remarks>
        /// The taint key to be applied to a node.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Taint#key
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        string Key
        {
            get;
        }

        /// <summary>TimeAdded represents the time at which the taint was added.</summary>
        /// <remarks>
        /// It is only written for NoExecute taints.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Taint#timeAdded
        /// </remarks>
        [JsiiProperty(name: "timeAdded", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        System.DateTime? TimeAdded
        {
            get
            {
                return null;
            }
        }

        /// <summary>The taint value corresponding to the taint key.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Taint#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Value
        {
            get
            {
                return null;
            }
        }

        /// <summary>The node this Taint is attached to has the "effect" on any pod that does not tolerate the Taint.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Taint
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ITaint), fullyQualifiedName: "k8s.Taint")]
        internal sealed class _Proxy : DeputyBase, K8s.ITaint
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>Required.</summary>
            /// <remarks>
            /// The effect of the taint on pods that do not tolerate the taint. Valid effects are NoSchedule, PreferNoSchedule and NoExecute.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Taint#effect
            /// </remarks>
            [JsiiProperty(name: "effect", typeJson: "{\"primitive\":\"string\"}")]
            public string Effect
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>Required.</summary>
            /// <remarks>
            /// The taint key to be applied to a node.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Taint#key
            /// </remarks>
            [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
            public string Key
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>TimeAdded represents the time at which the taint was added.</summary>
            /// <remarks>
            /// It is only written for NoExecute taints.
            ///
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Taint#timeAdded
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeAdded", typeJson: "{\"primitive\":\"date\"}", isOptional: true)]
            public System.DateTime? TimeAdded
            {
                get => GetInstanceProperty<System.DateTime?>();
            }

            /// <summary>The taint value corresponding to the taint key.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.core.v1.Taint#value
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Value
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
