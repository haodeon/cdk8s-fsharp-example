using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>PriorityClass defines mapping from a priority class name to the priority integer value.</summary>
    /// <remarks>
    /// The value can be any valid integer.
    ///
    /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClass
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IKubePriorityClassProps), fullyQualifiedName: "k8s.KubePriorityClassProps")]
    public interface IKubePriorityClassProps
    {
        /// <summary>value represents the integer value of this priority class.</summary>
        /// <remarks>
        /// This is the actual priority that pods receive when they have the name of this class in their pod spec.
        ///
        /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClass#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        double Value
        {
            get;
        }

        /// <summary>description is an arbitrary string that usually provides guidelines on when this priority class should be used.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClass#description
        /// </remarks>
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? Description
        {
            get
            {
                return null;
            }
        }

        /// <summary>globalDefault specifies whether this PriorityClass should be considered as the default priority for pods that do not have any priority class.</summary>
        /// <remarks>
        /// Only one PriorityClass can be marked as <c>globalDefault</c>. However, if more than one PriorityClasses exists with their <c>globalDefault</c> field set to true, the smallest value of such global default PriorityClasses will be used as the default priority.
        ///
        /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClass#globalDefault
        /// </remarks>
        [JsiiProperty(name: "globalDefault", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        bool? GlobalDefault
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
        /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClass#metadata
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

        /// <summary>preemptionPolicy is the Policy for preempting pods with lower priority.</summary>
        /// <remarks>
        /// One of Never, PreemptLowerPriority. Defaults to PreemptLowerPriority if unset.
        ///
        /// <strong>Default</strong>: PreemptLowerPriority if unset.
        ///
        /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClass#preemptionPolicy
        /// </remarks>
        [JsiiProperty(name: "preemptionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? PreemptionPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>PriorityClass defines mapping from a priority class name to the priority integer value.</summary>
        /// <remarks>
        /// The value can be any valid integer.
        ///
        /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClass
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IKubePriorityClassProps), fullyQualifiedName: "k8s.KubePriorityClassProps")]
        internal sealed class _Proxy : DeputyBase, K8s.IKubePriorityClassProps
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>value represents the integer value of this priority class.</summary>
            /// <remarks>
            /// This is the actual priority that pods receive when they have the name of this class in their pod spec.
            ///
            /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClass#value
            /// </remarks>
            [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
            public double Value
            {
                get => GetInstanceProperty<double>()!;
            }

            /// <summary>description is an arbitrary string that usually provides guidelines on when this priority class should be used.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClass#description
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? Description
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>globalDefault specifies whether this PriorityClass should be considered as the default priority for pods that do not have any priority class.</summary>
            /// <remarks>
            /// Only one PriorityClass can be marked as <c>globalDefault</c>. However, if more than one PriorityClasses exists with their <c>globalDefault</c> field set to true, the smallest value of such global default PriorityClasses will be used as the default priority.
            ///
            /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClass#globalDefault
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "globalDefault", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
            public bool? GlobalDefault
            {
                get => GetInstanceProperty<bool?>();
            }

            /// <summary>Standard object's metadata.</summary>
            /// <remarks>
            /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
            ///
            /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClass#metadata
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
            public K8s.IObjectMeta? Metadata
            {
                get => GetInstanceProperty<K8s.IObjectMeta?>();
            }

            /// <summary>preemptionPolicy is the Policy for preempting pods with lower priority.</summary>
            /// <remarks>
            /// One of Never, PreemptLowerPriority. Defaults to PreemptLowerPriority if unset.
            ///
            /// <strong>Default</strong>: PreemptLowerPriority if unset.
            ///
            /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClass#preemptionPolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "preemptionPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? PreemptionPolicy
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
