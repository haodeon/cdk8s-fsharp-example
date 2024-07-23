using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>MatchResources decides whether to run the admission control policy on an object based on whether it meets the match criteria.</summary>
    /// <remarks>
    /// The exclude rules take precedence over include rules (if a resource matches both, it is excluded)
    ///
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.MatchResources
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IMatchResourcesV1Alpha1), fullyQualifiedName: "k8s.MatchResourcesV1Alpha1")]
    public interface IMatchResourcesV1Alpha1
    {
        /// <summary>ExcludeResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy should not care about.</summary>
        /// <remarks>
        /// The exclude rules take precedence over include rules (if a resource matches both, it is excluded)
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.MatchResources#excludeResourceRules
        /// </remarks>
        [JsiiProperty(name: "excludeResourceRules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NamedRuleWithOperationsV1Alpha1\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INamedRuleWithOperationsV1Alpha1[]? ExcludeResourceRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>matchPolicy defines how the "MatchResources" list is used to match incoming requests. Allowed values are "Exact" or "Equivalent".</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description>Exact: match a request only if it exactly matches a specified rule. For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1, but "rules" only included <c>apiGroups:["apps"], apiVersions:["v1"], resources: ["deployments"]</c>, a request to apps/v1beta1 or extensions/v1beta1 would not be sent to the ValidatingAdmissionPolicy.</description>
        /// <description>Equivalent: match a request if modifies a resource listed in rules, even via another API group or version. For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1, and "rules" only included <c>apiGroups:["apps"], apiVersions:["v1"], resources: ["deployments"]</c>, a request to apps/v1beta1 or extensions/v1beta1 would be converted to apps/v1 and sent to the ValidatingAdmissionPolicy.</description>
        /// </list>
        ///
        /// Defaults to "Equivalent"
        ///
        /// <strong>Default</strong>: Equivalent"
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.MatchResources#matchPolicy
        /// </remarks>
        [JsiiProperty(name: "matchPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? MatchPolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>NamespaceSelector decides whether to run the admission control policy on an object based on whether the namespace for that object matches the selector.</summary>
        /// <remarks>
        /// If the object itself is a namespace, the matching is performed on object.metadata.labels. If the object is another cluster scoped resource, it never skips the policy.
        ///
        /// For example, to run the webhook on any objects whose namespace is not associated with "runlevel" of "0" or "1";  you will set the selector as follows: "namespaceSelector": {
        /// "matchExpressions": [
        /// {
        /// "key": "runlevel",
        /// "operator": "NotIn",
        /// "values": [
        /// "0",
        /// "1"
        /// ]
        /// }
        /// ]
        /// }
        ///
        /// If instead you want to only run the policy on any objects whose namespace is associated with the "environment" of "prod" or "staging"; you will set the selector as follows: "namespaceSelector": {
        /// "matchExpressions": [
        /// {
        /// "key": "environment",
        /// "operator": "In",
        /// "values": [
        /// "prod",
        /// "staging"
        /// ]
        /// }
        /// ]
        /// }
        ///
        /// See https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/ for more examples of label selectors.
        ///
        /// Default to the empty LabelSelector, which matches everything.
        ///
        /// <strong>Default</strong>: the empty LabelSelector, which matches everything.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.MatchResources#namespaceSelector
        /// </remarks>
        [JsiiProperty(name: "namespaceSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILabelSelector? NamespaceSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>ObjectSelector decides whether to run the validation based on if the object has matching labels.</summary>
        /// <remarks>
        /// objectSelector is evaluated against both the oldObject and newObject that would be sent to the cel validation, and is considered to match if either object matches the selector. A null object (oldObject in the case of create, or newObject in the case of delete) or an object that cannot have labels (like a DeploymentRollback or a PodProxyOptions object) is not considered to match. Use the object selector only if the webhook is opt-in, because end users may skip the admission webhook by setting the labels. Default to the empty LabelSelector, which matches everything.
        ///
        /// <strong>Default</strong>: the empty LabelSelector, which matches everything.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.MatchResources#objectSelector
        /// </remarks>
        [JsiiProperty(name: "objectSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.ILabelSelector? ObjectSelector
        {
            get
            {
                return null;
            }
        }

        /// <summary>ResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy matches.</summary>
        /// <remarks>
        /// The policy cares about an operation if it matches <em>any</em> Rule.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.MatchResources#resourceRules
        /// </remarks>
        [JsiiProperty(name: "resourceRules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NamedRuleWithOperationsV1Alpha1\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.INamedRuleWithOperationsV1Alpha1[]? ResourceRules
        {
            get
            {
                return null;
            }
        }

        /// <summary>MatchResources decides whether to run the admission control policy on an object based on whether it meets the match criteria.</summary>
        /// <remarks>
        /// The exclude rules take precedence over include rules (if a resource matches both, it is excluded)
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.MatchResources
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IMatchResourcesV1Alpha1), fullyQualifiedName: "k8s.MatchResourcesV1Alpha1")]
        internal sealed class _Proxy : DeputyBase, K8s.IMatchResourcesV1Alpha1
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>ExcludeResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy should not care about.</summary>
            /// <remarks>
            /// The exclude rules take precedence over include rules (if a resource matches both, it is excluded)
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.MatchResources#excludeResourceRules
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "excludeResourceRules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NamedRuleWithOperationsV1Alpha1\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.INamedRuleWithOperationsV1Alpha1[]? ExcludeResourceRules
            {
                get => GetInstanceProperty<K8s.INamedRuleWithOperationsV1Alpha1[]?>();
            }

            /// <summary>matchPolicy defines how the "MatchResources" list is used to match incoming requests. Allowed values are "Exact" or "Equivalent".</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description>Exact: match a request only if it exactly matches a specified rule. For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1, but "rules" only included <c>apiGroups:["apps"], apiVersions:["v1"], resources: ["deployments"]</c>, a request to apps/v1beta1 or extensions/v1beta1 would not be sent to the ValidatingAdmissionPolicy.</description>
            /// <description>Equivalent: match a request if modifies a resource listed in rules, even via another API group or version. For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1, and "rules" only included <c>apiGroups:["apps"], apiVersions:["v1"], resources: ["deployments"]</c>, a request to apps/v1beta1 or extensions/v1beta1 would be converted to apps/v1 and sent to the ValidatingAdmissionPolicy.</description>
            /// </list>
            ///
            /// Defaults to "Equivalent"
            ///
            /// <strong>Default</strong>: Equivalent"
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.MatchResources#matchPolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MatchPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>NamespaceSelector decides whether to run the admission control policy on an object based on whether the namespace for that object matches the selector.</summary>
            /// <remarks>
            /// If the object itself is a namespace, the matching is performed on object.metadata.labels. If the object is another cluster scoped resource, it never skips the policy.
            ///
            /// For example, to run the webhook on any objects whose namespace is not associated with "runlevel" of "0" or "1";  you will set the selector as follows: "namespaceSelector": {
            /// "matchExpressions": [
            /// {
            /// "key": "runlevel",
            /// "operator": "NotIn",
            /// "values": [
            /// "0",
            /// "1"
            /// ]
            /// }
            /// ]
            /// }
            ///
            /// If instead you want to only run the policy on any objects whose namespace is associated with the "environment" of "prod" or "staging"; you will set the selector as follows: "namespaceSelector": {
            /// "matchExpressions": [
            /// {
            /// "key": "environment",
            /// "operator": "In",
            /// "values": [
            /// "prod",
            /// "staging"
            /// ]
            /// }
            /// ]
            /// }
            ///
            /// See https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/ for more examples of label selectors.
            ///
            /// Default to the empty LabelSelector, which matches everything.
            ///
            /// <strong>Default</strong>: the empty LabelSelector, which matches everything.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.MatchResources#namespaceSelector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespaceSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
            public K8s.ILabelSelector? NamespaceSelector
            {
                get => GetInstanceProperty<K8s.ILabelSelector?>();
            }

            /// <summary>ObjectSelector decides whether to run the validation based on if the object has matching labels.</summary>
            /// <remarks>
            /// objectSelector is evaluated against both the oldObject and newObject that would be sent to the cel validation, and is considered to match if either object matches the selector. A null object (oldObject in the case of create, or newObject in the case of delete) or an object that cannot have labels (like a DeploymentRollback or a PodProxyOptions object) is not considered to match. Use the object selector only if the webhook is opt-in, because end users may skip the admission webhook by setting the labels. Default to the empty LabelSelector, which matches everything.
            ///
            /// <strong>Default</strong>: the empty LabelSelector, which matches everything.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.MatchResources#objectSelector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "objectSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
            public K8s.ILabelSelector? ObjectSelector
            {
                get => GetInstanceProperty<K8s.ILabelSelector?>();
            }

            /// <summary>ResourceRules describes what operations on what resources/subresources the ValidatingAdmissionPolicy matches.</summary>
            /// <remarks>
            /// The policy cares about an operation if it matches <em>any</em> Rule.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1alpha1.MatchResources#resourceRules
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "resourceRules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.NamedRuleWithOperationsV1Alpha1\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.INamedRuleWithOperationsV1Alpha1[]? ResourceRules
            {
                get => GetInstanceProperty<K8s.INamedRuleWithOperationsV1Alpha1[]?>();
            }
        }
    }
}
