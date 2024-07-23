using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>PriorityClass defines mapping from a priority class name to the priority integer value.</summary>
    /// <remarks>
    /// The value can be any valid integer.
    ///
    /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClass
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubePriorityClassProps")]
    public class KubePriorityClassProps : K8s.IKubePriorityClassProps
    {
        /// <summary>value represents the integer value of this priority class.</summary>
        /// <remarks>
        /// This is the actual priority that pods receive when they have the name of this class in their pod spec.
        ///
        /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClass#value
        /// </remarks>
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"number\"}")]
        public double Value
        {
            get;
            set;
        }

        /// <summary>description is an arbitrary string that usually provides guidelines on when this priority class should be used.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.scheduling.v1.PriorityClass#description
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "description", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Description
        {
            get;
            set;
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
            get;
            set;
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
            get;
            set;
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
            get;
            set;
        }
    }
}
