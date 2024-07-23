using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>A StatefulSetSpec is the specification of a StatefulSet.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetSpec
    /// </remarks>
    [JsiiByValue(fqn: "k8s.StatefulSetSpec")]
    public class StatefulSetSpec : K8s.IStatefulSetSpec
    {
        /// <summary>selector is a label query over pods that should match the replica count.</summary>
        /// <remarks>
        /// It must match the pod template's labels. More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/#label-selectors
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetSpec#selector
        /// </remarks>
        [JsiiProperty(name: "selector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}")]
        public K8s.ILabelSelector Selector
        {
            get;
            set;
        }

        /// <summary>serviceName is the name of the service that governs this StatefulSet.</summary>
        /// <remarks>
        /// This service must exist before the StatefulSet, and is responsible for the network identity of the set. Pods get DNS/hostnames that follow the pattern: pod-specific-string.serviceName.default.svc.cluster.local where "pod-specific-string" is managed by the StatefulSet controller.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetSpec#serviceName
        /// </remarks>
        [JsiiProperty(name: "serviceName", typeJson: "{\"primitive\":\"string\"}")]
        public string ServiceName
        {
            get;
            set;
        }

        /// <summary>template is the object that describes the pod that will be created if insufficient replicas are detected.</summary>
        /// <remarks>
        /// Each pod stamped out by the StatefulSet will fulfill this Template, but have a unique identity from the rest of the StatefulSet. Each pod will be named with the format <statefulsetname xmlns="http://www.w3.org/1999/xhtml"></statefulsetname>-<podindex xmlns="http://www.w3.org/1999/xhtml"></podindex>. For example, a pod in a StatefulSet named "web" with index number "3" would be named "web-3". The only allowed template.spec.restartPolicy value is "Always".
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetSpec#template
        /// </remarks>
        [JsiiProperty(name: "template", typeJson: "{\"fqn\":\"k8s.PodTemplateSpec\"}")]
        public K8s.IPodTemplateSpec Template
        {
            get;
            set;
        }

        /// <summary>Minimum number of seconds for which a newly created pod should be ready without any of its container crashing for it to be considered available.</summary>
        /// <remarks>
        /// Defaults to 0 (pod will be considered available as soon as it is ready)
        ///
        /// <strong>Default</strong>: 0 (pod will be considered available as soon as it is ready)
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetSpec#minReadySeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "minReadySeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? MinReadySeconds
        {
            get;
            set;
        }

        /// <summary>ordinals controls the numbering of replica indices in a StatefulSet.</summary>
        /// <remarks>
        /// The default ordinals behavior assigns a "0" index to the first replica and increments the index by one for each additional replica requested. Using the ordinals field requires the StatefulSetStartOrdinal feature gate to be enabled, which is beta.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetSpec#ordinals
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "ordinals", typeJson: "{\"fqn\":\"k8s.StatefulSetOrdinals\"}", isOptional: true)]
        public K8s.IStatefulSetOrdinals? Ordinals
        {
            get;
            set;
        }

        /// <summary>persistentVolumeClaimRetentionPolicy describes the lifecycle of persistent volume claims created from volumeClaimTemplates.</summary>
        /// <remarks>
        /// By default, all persistent volume claims are created as needed and retained until manually deleted. This policy allows the lifecycle to be altered, for example by deleting persistent volume claims when their stateful set is deleted, or when their pod is scaled down. This requires the StatefulSetAutoDeletePVC feature gate to be enabled, which is alpha.  +optional
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetSpec#persistentVolumeClaimRetentionPolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "persistentVolumeClaimRetentionPolicy", typeJson: "{\"fqn\":\"k8s.StatefulSetPersistentVolumeClaimRetentionPolicy\"}", isOptional: true)]
        public K8s.IStatefulSetPersistentVolumeClaimRetentionPolicy? PersistentVolumeClaimRetentionPolicy
        {
            get;
            set;
        }

        /// <summary>podManagementPolicy controls how pods are created during initial scale up, when replacing pods on nodes, or when scaling down.</summary>
        /// <remarks>
        /// The default policy is <c>OrderedReady</c>, where pods are created in increasing order (pod-0, then pod-1, etc) and the controller will wait until each pod is ready before continuing. When scaling down, the pods are removed in the opposite order. The alternative policy is <c>Parallel</c> which will create pods in parallel to match the desired scale without waiting, and on scale down will delete all pods at once.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetSpec#podManagementPolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "podManagementPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? PodManagementPolicy
        {
            get;
            set;
        }

        /// <summary>replicas is the desired number of replicas of the given Template.</summary>
        /// <remarks>
        /// These are replicas in the sense that they are instantiations of the same Template, but individual replicas also have a consistent identity. If unspecified, defaults to 1.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetSpec#replicas
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "replicas", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? Replicas
        {
            get;
            set;
        }

        /// <summary>revisionHistoryLimit is the maximum number of revisions that will be maintained in the StatefulSet's revision history.</summary>
        /// <remarks>
        /// The revision history consists of all revisions not represented by a currently applied StatefulSetSpec version. The default value is 10.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetSpec#revisionHistoryLimit
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "revisionHistoryLimit", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? RevisionHistoryLimit
        {
            get;
            set;
        }

        /// <summary>updateStrategy indicates the StatefulSetUpdateStrategy that will be employed to update Pods in the StatefulSet when a revision is made to Template.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetSpec#updateStrategy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "updateStrategy", typeJson: "{\"fqn\":\"k8s.StatefulSetUpdateStrategy\"}", isOptional: true)]
        public K8s.IStatefulSetUpdateStrategy? UpdateStrategy
        {
            get;
            set;
        }

        /// <summary>volumeClaimTemplates is a list of claims that pods are allowed to reference.</summary>
        /// <remarks>
        /// The StatefulSet controller is responsible for mapping network identities to claims in a way that maintains the identity of a pod. Every claim in this list must have at least one matching (by name) volumeMount in one container in the template. A claim in this list takes precedence over any volumes in the template, with the same name.
        ///
        /// <strong>Schema</strong>: io.k8s.api.apps.v1.StatefulSetSpec#volumeClaimTemplates
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "volumeClaimTemplates", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.KubePersistentVolumeClaimProps\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IKubePersistentVolumeClaimProps[]? VolumeClaimTemplates
        {
            get;
            set;
        }
    }
}
