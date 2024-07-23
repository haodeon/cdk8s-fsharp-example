using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ValidatingWebhook describes an admission webhook and the resources and operations it applies to.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IValidatingWebhook), fullyQualifiedName: "k8s.ValidatingWebhook")]
    public interface IValidatingWebhook
    {
        /// <summary>AdmissionReviewVersions is an ordered list of preferred `AdmissionReview` versions the Webhook expects.</summary>
        /// <remarks>
        /// API server will try to use first version in the list which it supports. If none of the versions specified in this list supported by API server, validation will fail for this object. If a persisted webhook configuration specifies allowed versions and does not include any versions known to the API Server, calls to the webhook will fail and be subject to the failure policy.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#admissionReviewVersions
        /// </remarks>
        [JsiiProperty(name: "admissionReviewVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        string[] AdmissionReviewVersions
        {
            get;
        }

        /// <summary>ClientConfig defines how to communicate with the hook.</summary>
        /// <remarks>
        /// Required
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#clientConfig
        /// </remarks>
        [JsiiProperty(name: "clientConfig", typeJson: "{\"fqn\":\"k8s.WebhookClientConfig\"}")]
        K8s.IWebhookClientConfig ClientConfig
        {
            get;
        }

        /// <summary>The name of the admission webhook.</summary>
        /// <remarks>
        /// Name should be fully qualified, e.g., imagepolicy.kubernetes.io, where "imagepolicy" is the name of the webhook, and kubernetes.io is the name of the organization. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>SideEffects states whether this webhook has side effects.</summary>
        /// <remarks>
        /// Acceptable values are: None, NoneOnDryRun (webhooks created via v1beta1 may also specify Some or Unknown). Webhooks with side effects MUST implement a reconciliation system, since a request may be rejected by a future step in the admission chain and the side effects therefore need to be undone. Requests with the dryRun attribute will be auto-rejected if they match a webhook with sideEffects == Unknown or Some.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#sideEffects
        /// </remarks>
        [JsiiProperty(name: "sideEffects", typeJson: "{\"primitive\":\"string\"}")]
        string SideEffects
        {
            get;
        }

        /// <summary>FailurePolicy defines how unrecognized errors from the admission endpoint are handled - allowed values are Ignore or Fail.</summary>
        /// <remarks>
        /// Defaults to Fail.
        ///
        /// <strong>Default</strong>: Fail.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#failurePolicy
        /// </remarks>
        [JsiiProperty(name: "failurePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? FailurePolicy
        {
            get
            {
                return null;
            }
        }

        /// <summary>MatchConditions is a list of conditions that must be met for a request to be sent to this webhook.</summary>
        /// <remarks>
        /// Match conditions filter requests that have already been matched by the rules, namespaceSelector, and objectSelector. An empty list of matchConditions matches all requests. There are a maximum of 64 match conditions allowed.
        ///
        /// The exact matching logic is (in order):
        ///
        /// <list type="number">
        /// <description>If ANY matchCondition evaluates to FALSE, the webhook is skipped.</description>
        /// <description>If ALL matchConditions evaluate to TRUE, the webhook is called.</description>
        /// <description>If any matchCondition evaluates to an error (but none are FALSE):</description>
        /// </list>
        ///
        /// <list type="bullet">
        /// <description>If failurePolicy=Fail, reject the request</description>
        /// <description>If failurePolicy=Ignore, the error is ignored and the webhook is skipped</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#matchConditions
        /// </remarks>
        [JsiiProperty(name: "matchConditions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.MatchCondition\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IMatchCondition[]? MatchConditions
        {
            get
            {
                return null;
            }
        }

        /// <summary>matchPolicy defines how the "rules" list is used to match incoming requests. Allowed values are "Exact" or "Equivalent".</summary>
        /// <remarks>
        /// <list type="bullet">
        /// <description>Exact: match a request only if it exactly matches a specified rule. For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1, but "rules" only included <c>apiGroups:["apps"], apiVersions:["v1"], resources: ["deployments"]</c>, a request to apps/v1beta1 or extensions/v1beta1 would not be sent to the webhook.</description>
        /// <description>Equivalent: match a request if modifies a resource listed in rules, even via another API group or version. For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1, and "rules" only included <c>apiGroups:["apps"], apiVersions:["v1"], resources: ["deployments"]</c>, a request to apps/v1beta1 or extensions/v1beta1 would be converted to apps/v1 and sent to the webhook.</description>
        /// </list>
        ///
        /// Defaults to "Equivalent"
        ///
        /// <strong>Default</strong>: Equivalent"
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#matchPolicy
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

        /// <summary>NamespaceSelector decides whether to run the webhook on an object based on whether the namespace for that object matches the selector.</summary>
        /// <remarks>
        /// If the object itself is a namespace, the matching is performed on object.metadata.labels. If the object is another cluster scoped resource, it never skips the webhook.
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
        /// If instead you want to only run the webhook on any objects whose namespace is associated with the "environment" of "prod" or "staging"; you will set the selector as follows: "namespaceSelector": {
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
        /// See https://kubernetes.io/docs/concepts/overview/working-with-objects/labels for more examples of label selectors.
        ///
        /// Default to the empty LabelSelector, which matches everything.
        ///
        /// <strong>Default</strong>: the empty LabelSelector, which matches everything.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#namespaceSelector
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

        /// <summary>ObjectSelector decides whether to run the webhook based on if the object has matching labels.</summary>
        /// <remarks>
        /// objectSelector is evaluated against both the oldObject and newObject that would be sent to the webhook, and is considered to match if either object matches the selector. A null object (oldObject in the case of create, or newObject in the case of delete) or an object that cannot have labels (like a DeploymentRollback or a PodProxyOptions object) is not considered to match. Use the object selector only if the webhook is opt-in, because end users may skip the admission webhook by setting the labels. Default to the empty LabelSelector, which matches everything.
        ///
        /// <strong>Default</strong>: the empty LabelSelector, which matches everything.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#objectSelector
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

        /// <summary>Rules describes what operations on what resources/subresources the webhook cares about.</summary>
        /// <remarks>
        /// The webhook cares about an operation if it matches <em>any</em> Rule. However, in order to prevent ValidatingAdmissionWebhooks and MutatingAdmissionWebhooks from putting the cluster in a state which cannot be recovered from without completely disabling the plugin, ValidatingAdmissionWebhooks and MutatingAdmissionWebhooks are never called on admission requests for ValidatingWebhookConfiguration and MutatingWebhookConfiguration objects.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#rules
        /// </remarks>
        [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.RuleWithOperations\"},\"kind\":\"array\"}}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        K8s.IRuleWithOperations[]? Rules
        {
            get
            {
                return null;
            }
        }

        /// <summary>TimeoutSeconds specifies the timeout for this webhook.</summary>
        /// <remarks>
        /// After the timeout passes, the webhook call will be ignored or the API call will fail based on the failure policy. The timeout value must be between 1 and 30 seconds. Default to 10 seconds.
        ///
        /// <strong>Default</strong>: 10 seconds.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#timeoutSeconds
        /// </remarks>
        [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? TimeoutSeconds
        {
            get
            {
                return null;
            }
        }

        /// <summary>ValidatingWebhook describes an admission webhook and the resources and operations it applies to.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IValidatingWebhook), fullyQualifiedName: "k8s.ValidatingWebhook")]
        internal sealed class _Proxy : DeputyBase, K8s.IValidatingWebhook
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>AdmissionReviewVersions is an ordered list of preferred `AdmissionReview` versions the Webhook expects.</summary>
            /// <remarks>
            /// API server will try to use first version in the list which it supports. If none of the versions specified in this list supported by API server, validation will fail for this object. If a persisted webhook configuration specifies allowed versions and does not include any versions known to the API Server, calls to the webhook will fail and be subject to the failure policy.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#admissionReviewVersions
            /// </remarks>
            [JsiiProperty(name: "admissionReviewVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
            public string[] AdmissionReviewVersions
            {
                get => GetInstanceProperty<string[]>()!;
            }

            /// <summary>ClientConfig defines how to communicate with the hook.</summary>
            /// <remarks>
            /// Required
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#clientConfig
            /// </remarks>
            [JsiiProperty(name: "clientConfig", typeJson: "{\"fqn\":\"k8s.WebhookClientConfig\"}")]
            public K8s.IWebhookClientConfig ClientConfig
            {
                get => GetInstanceProperty<K8s.IWebhookClientConfig>()!;
            }

            /// <summary>The name of the admission webhook.</summary>
            /// <remarks>
            /// Name should be fully qualified, e.g., imagepolicy.kubernetes.io, where "imagepolicy" is the name of the webhook, and kubernetes.io is the name of the organization. Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>SideEffects states whether this webhook has side effects.</summary>
            /// <remarks>
            /// Acceptable values are: None, NoneOnDryRun (webhooks created via v1beta1 may also specify Some or Unknown). Webhooks with side effects MUST implement a reconciliation system, since a request may be rejected by a future step in the admission chain and the side effects therefore need to be undone. Requests with the dryRun attribute will be auto-rejected if they match a webhook with sideEffects == Unknown or Some.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#sideEffects
            /// </remarks>
            [JsiiProperty(name: "sideEffects", typeJson: "{\"primitive\":\"string\"}")]
            public string SideEffects
            {
                get => GetInstanceProperty<string>()!;
            }

            /// <summary>FailurePolicy defines how unrecognized errors from the admission endpoint are handled - allowed values are Ignore or Fail.</summary>
            /// <remarks>
            /// Defaults to Fail.
            ///
            /// <strong>Default</strong>: Fail.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#failurePolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "failurePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? FailurePolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>MatchConditions is a list of conditions that must be met for a request to be sent to this webhook.</summary>
            /// <remarks>
            /// Match conditions filter requests that have already been matched by the rules, namespaceSelector, and objectSelector. An empty list of matchConditions matches all requests. There are a maximum of 64 match conditions allowed.
            ///
            /// The exact matching logic is (in order):
            ///
            /// <list type="number">
            /// <description>If ANY matchCondition evaluates to FALSE, the webhook is skipped.</description>
            /// <description>If ALL matchConditions evaluate to TRUE, the webhook is called.</description>
            /// <description>If any matchCondition evaluates to an error (but none are FALSE):</description>
            /// </list>
            ///
            /// <list type="bullet">
            /// <description>If failurePolicy=Fail, reject the request</description>
            /// <description>If failurePolicy=Ignore, the error is ignored and the webhook is skipped</description>
            /// </list>
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#matchConditions
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchConditions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.MatchCondition\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IMatchCondition[]? MatchConditions
            {
                get => GetInstanceProperty<K8s.IMatchCondition[]?>();
            }

            /// <summary>matchPolicy defines how the "rules" list is used to match incoming requests. Allowed values are "Exact" or "Equivalent".</summary>
            /// <remarks>
            /// <list type="bullet">
            /// <description>Exact: match a request only if it exactly matches a specified rule. For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1, but "rules" only included <c>apiGroups:["apps"], apiVersions:["v1"], resources: ["deployments"]</c>, a request to apps/v1beta1 or extensions/v1beta1 would not be sent to the webhook.</description>
            /// <description>Equivalent: match a request if modifies a resource listed in rules, even via another API group or version. For example, if deployments can be modified via apps/v1, apps/v1beta1, and extensions/v1beta1, and "rules" only included <c>apiGroups:["apps"], apiVersions:["v1"], resources: ["deployments"]</c>, a request to apps/v1beta1 or extensions/v1beta1 would be converted to apps/v1 and sent to the webhook.</description>
            /// </list>
            ///
            /// Defaults to "Equivalent"
            ///
            /// <strong>Default</strong>: Equivalent"
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#matchPolicy
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "matchPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? MatchPolicy
            {
                get => GetInstanceProperty<string?>();
            }

            /// <summary>NamespaceSelector decides whether to run the webhook on an object based on whether the namespace for that object matches the selector.</summary>
            /// <remarks>
            /// If the object itself is a namespace, the matching is performed on object.metadata.labels. If the object is another cluster scoped resource, it never skips the webhook.
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
            /// If instead you want to only run the webhook on any objects whose namespace is associated with the "environment" of "prod" or "staging"; you will set the selector as follows: "namespaceSelector": {
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
            /// See https://kubernetes.io/docs/concepts/overview/working-with-objects/labels for more examples of label selectors.
            ///
            /// Default to the empty LabelSelector, which matches everything.
            ///
            /// <strong>Default</strong>: the empty LabelSelector, which matches everything.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#namespaceSelector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "namespaceSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
            public K8s.ILabelSelector? NamespaceSelector
            {
                get => GetInstanceProperty<K8s.ILabelSelector?>();
            }

            /// <summary>ObjectSelector decides whether to run the webhook based on if the object has matching labels.</summary>
            /// <remarks>
            /// objectSelector is evaluated against both the oldObject and newObject that would be sent to the webhook, and is considered to match if either object matches the selector. A null object (oldObject in the case of create, or newObject in the case of delete) or an object that cannot have labels (like a DeploymentRollback or a PodProxyOptions object) is not considered to match. Use the object selector only if the webhook is opt-in, because end users may skip the admission webhook by setting the labels. Default to the empty LabelSelector, which matches everything.
            ///
            /// <strong>Default</strong>: the empty LabelSelector, which matches everything.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#objectSelector
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "objectSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
            public K8s.ILabelSelector? ObjectSelector
            {
                get => GetInstanceProperty<K8s.ILabelSelector?>();
            }

            /// <summary>Rules describes what operations on what resources/subresources the webhook cares about.</summary>
            /// <remarks>
            /// The webhook cares about an operation if it matches <em>any</em> Rule. However, in order to prevent ValidatingAdmissionWebhooks and MutatingAdmissionWebhooks from putting the cluster in a state which cannot be recovered from without completely disabling the plugin, ValidatingAdmissionWebhooks and MutatingAdmissionWebhooks are never called on admission requests for ValidatingWebhookConfiguration and MutatingWebhookConfiguration objects.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#rules
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.RuleWithOperations\"},\"kind\":\"array\"}}", isOptional: true)]
            public K8s.IRuleWithOperations[]? Rules
            {
                get => GetInstanceProperty<K8s.IRuleWithOperations[]?>();
            }

            /// <summary>TimeoutSeconds specifies the timeout for this webhook.</summary>
            /// <remarks>
            /// After the timeout passes, the webhook call will be ignored or the API call will fail based on the failure policy. The timeout value must be between 1 and 30 seconds. Default to 10 seconds.
            ///
            /// <strong>Default</strong>: 10 seconds.
            ///
            /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.ValidatingWebhook#timeoutSeconds
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? TimeoutSeconds
            {
                get => GetInstanceProperty<double?>();
            }
        }
    }
}
