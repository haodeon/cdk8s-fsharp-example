using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>StatefulSetOrdinals describes the policy used for replica ordinal assignment in this StatefulSet.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetOrdinals
    /// </remarks>
    [JsiiByValue(fqn: "k8s.StatefulSetOrdinals")]
    public class StatefulSetOrdinals : K8s.IStatefulSetOrdinals
    {
        /// <summary>start is the number representing the first replica's index.</summary>
        /// <remarks>
        /// It may be used to number replicas from an alternate index (eg: 1-indexed) over the default 0-indexed names, or to orchestrate progressive movement of replicas from one StatefulSet to another. If set, replica indices will be in the range:
        /// [.spec.ordinals.start, .spec.ordinals.start + .spec.replicas).
        /// If unset, defaults to 0. Replica indices will be in the range:
        /// [0, .spec.replicas).
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetOrdinals#start
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "start", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Start
        {
            get;
            set;
        }
    }
}
