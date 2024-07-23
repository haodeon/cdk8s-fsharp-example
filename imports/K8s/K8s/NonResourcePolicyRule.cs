using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>NonResourcePolicyRule is a predicate that matches non-resource requests according to their verb and the target non-resource URL.</summary>
    /// <remarks>
    /// A NonResourcePolicyRule matches a request if and only if both (a) at least one member of verbs matches the request and (b) at least one member of nonResourceURLs matches the request.
    ///
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.NonResourcePolicyRule
    /// </remarks>
    [JsiiByValue(fqn: "k8s.NonResourcePolicyRule")]
    public class NonResourcePolicyRule : K8s.INonResourcePolicyRule
    {
        /// <summary>`nonResourceURLs` is a set of url prefixes that a user should have access to and may not be empty.</summary>
        /// <remarks>
        /// For example:
        ///
        /// <list type="bullet">
        /// <description>"/healthz" is legal</description>
        /// <description>"/hea*" is illegal</description>
        /// <description>"/hea" is legal but matches nothing</description>
        /// <description>"/hea/*" also matches nothing</description>
        /// <description>"/healthz/<em>" matches all per-component health checks.
        /// "</em>" matches all non-resource urls. if it is present, it must be the only entry. Required.</description>
        /// </list>
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.NonResourcePolicyRule#nonResourceURLs
        /// </remarks>
        [JsiiProperty(name: "nonResourceUrLs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] NonResourceUrLs
        {
            get;
            set;
        }

        /// <summary>`verbs` is a list of matching verbs and may not be empty.</summary>
        /// <remarks>
        /// "*" matches all verbs. If it is present, it must be the only entry. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1.NonResourcePolicyRule#verbs
        /// </remarks>
        [JsiiProperty(name: "verbs", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public string[] Verbs
        {
            get;
            set;
        }
    }
}
