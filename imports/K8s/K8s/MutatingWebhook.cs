using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>MutatingWebhook describes an admission webhook and the resources and operations it applies to.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhook
    /// </remarks>
    [JsiiByValue(fqn: "k8s.MutatingWebhook")]
    public class MutatingWebhook : K8s.IMutatingWebhook
    {
        /// <summary>AdmissionReviewVersions is an ordered list of preferred `AdmissionReview` versions the Webhook expects.</summary>
        /// <remarks>
        /// API server will try to use first version in the list which it supports. If none of the versions specified in this list supported by API server, validation will fail for this object. If a persisted webhook configuration specifies allowed versions and does not include any versions known to the API Server, calls to the webhook will fail and be subject to the failure policy.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhook#admissionReviewVersions
        /// </remarks>
        [JsiiProperty(name: "admissionReviewVersions", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] AdmissionReviewVersions
        {
            get;
            set;
        }

        /// <summary>ClientConfig defines how to communicate with the hook.</summary>
        /// <remarks>
        /// Required
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhook#clientConfig
        /// </remarks>
        [JsiiProperty(name: "clientConfig", typeJson: "{\"fqn\":\"k8s.WebhookClientConfig\"}")]
        public K8s.IWebhookClientConfig ClientConfig
        {
            get;
            set;
        }

        /// <summary>The name of the admission webhook.</summary>
        /// <remarks>
        /// Name should be fully qualified, e.g., imagepolicy.kubernetes.io, where "imagepolicy" is the name of the webhook, and kubernetes.io is the name of the organization. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhook#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>SideEffects states whether this webhook has side effects.</summary>
        /// <remarks>
        /// Acceptable values are: None, NoneOnDryRun (webhooks created via v1beta1 may also specify Some or Unknown). Webhooks with side effects MUST implement a reconciliation system, since a request may be rejected by a future step in the admission chain and the side effects therefore need to be undone. Requests with the dryRun attribute will be auto-rejected if they match a webhook with sideEffects == Unknown or Some.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhook#sideEffects
        /// </remarks>
        [JsiiProperty(name: "sideEffects", typeJson: "{\"primitive\":\"string\"}")]
        public string SideEffects
        {
            get;
            set;
        }

        /// <summary>FailurePolicy defines how unrecognized errors from the admission endpoint are handled - allowed values are Ignore or Fail.</summary>
        /// <remarks>
        /// Defaults to Fail.
        ///
        /// <strong>Default</strong>: Fail.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhook#failurePolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "failurePolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? FailurePolicy
        {
            get;
            set;
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
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhook#matchConditions
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchConditions", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.MatchCondition\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IMatchCondition[]? MatchConditions
        {
            get;
            set;
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
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhook#matchPolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "matchPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? MatchPolicy
        {
            get;
            set;
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
        /// See https://kubernetes.io/docs/concepts/overview/working-with-objects/labels/ for more examples of label selectors.
        ///
        /// Default to the empty LabelSelector, which matches everything.
        ///
        /// <strong>Default</strong>: the empty LabelSelector, which matches everything.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhook#namespaceSelector
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespaceSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        public K8s.ILabelSelector? NamespaceSelector
        {
            get;
            set;
        }

        /// <summary>ObjectSelector decides whether to run the webhook based on if the object has matching labels.</summary>
        /// <remarks>
        /// objectSelector is evaluated against both the oldObject and newObject that would be sent to the webhook, and is considered to match if either object matches the selector. A null object (oldObject in the case of create, or newObject in the case of delete) or an object that cannot have labels (like a DeploymentRollback or a PodProxyOptions object) is not considered to match. Use the object selector only if the webhook is opt-in, because end users may skip the admission webhook by setting the labels. Default to the empty LabelSelector, which matches everything.
        ///
        /// <strong>Default</strong>: the empty LabelSelector, which matches everything.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhook#objectSelector
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "objectSelector", typeJson: "{\"fqn\":\"k8s.LabelSelector\"}", isOptional: true)]
        public K8s.ILabelSelector? ObjectSelector
        {
            get;
            set;
        }

        /// <summary>reinvocationPolicy indicates whether this webhook should be called multiple times as part of a single admission evaluation.</summary>
        /// <remarks>
        /// Allowed values are "Never" and "IfNeeded".
        ///
        /// Never: the webhook will not be called more than once in a single admission evaluation.
        ///
        /// IfNeeded: the webhook will be called at least one additional time as part of the admission evaluation if the object being admitted is modified by other admission plugins after the initial webhook call. Webhooks that specify this option <em>must</em> be idempotent, able to process objects they previously admitted. Note: * the number of additional invocations is not guaranteed to be exactly one. * if additional invocations result in further modifications to the object, webhooks are not guaranteed to be invoked again. * webhooks that use this option may be reordered to minimize the number of additional invocations. * to validate an object after all mutations are guaranteed complete, use a validating admission webhook instead.
        ///
        /// Defaults to "Never".
        ///
        /// <strong>Default</strong>: Never".
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhook#reinvocationPolicy
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "reinvocationPolicy", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? ReinvocationPolicy
        {
            get;
            set;
        }

        /// <summary>Rules describes what operations on what resources/subresources the webhook cares about.</summary>
        /// <remarks>
        /// The webhook cares about an operation if it matches <em>any</em> Rule. However, in order to prevent ValidatingAdmissionWebhooks and MutatingAdmissionWebhooks from putting the cluster in a state which cannot be recovered from without completely disabling the plugin, ValidatingAdmissionWebhooks and MutatingAdmissionWebhooks are never called on admission requests for ValidatingWebhookConfiguration and MutatingWebhookConfiguration objects.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhook#rules
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "rules", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.RuleWithOperations\"},\"kind\":\"array\"}}", isOptional: true)]
        public K8s.IRuleWithOperations[]? Rules
        {
            get;
            set;
        }

        /// <summary>TimeoutSeconds specifies the timeout for this webhook.</summary>
        /// <remarks>
        /// After the timeout passes, the webhook call will be ignored or the API call will fail based on the failure policy. The timeout value must be between 1 and 30 seconds. Default to 10 seconds.
        ///
        /// <strong>Default</strong>: 10 seconds.
        ///
        /// <strong>Schema</strong>: io.k8s.api.admissionregistration.v1.MutatingWebhook#timeoutSeconds
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "timeoutSeconds", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        public double? TimeoutSeconds
        {
            get;
            set;
        }
    }
}