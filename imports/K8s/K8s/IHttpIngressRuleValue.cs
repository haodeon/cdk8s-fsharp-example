using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>HTTPIngressRuleValue is a list of http selectors pointing to backends.</summary>
    /// <remarks>
    /// In the example: http://<host xmlns="http://www.w3.org/1999/xhtml"></host>/<path xmlns="http://www.w3.org/1999/xhtml"></path>?<searchpart xmlns="http://www.w3.org/1999/xhtml"></searchpart> -&gt; backend where where parts of the url correspond to RFC 3986, this resource will be used to match against everything after the last '/' and before the first '?' or '#'.
    ///
    /// <strong>Schema</strong>: io.k8s.api.networking.v1.HTTPIngressRuleValue
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IHttpIngressRuleValue), fullyQualifiedName: "k8s.HttpIngressRuleValue")]
    public interface IHttpIngressRuleValue
    {
        /// <summary>paths is a collection of paths that map requests to backends.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.HTTPIngressRuleValue#paths
        /// </remarks>
        [JsiiProperty(name: "paths", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.HttpIngressPath\"},\"kind\":\"array\"}}")]
        K8s.IHttpIngressPath[] Paths
        {
            get;
        }

        /// <summary>HTTPIngressRuleValue is a list of http selectors pointing to backends.</summary>
        /// <remarks>
        /// In the example: http://<host xmlns="http://www.w3.org/1999/xhtml"></host>/<path xmlns="http://www.w3.org/1999/xhtml"></path>?<searchpart xmlns="http://www.w3.org/1999/xhtml"></searchpart> -&gt; backend where where parts of the url correspond to RFC 3986, this resource will be used to match against everything after the last '/' and before the first '?' or '#'.
        ///
        /// <strong>Schema</strong>: io.k8s.api.networking.v1.HTTPIngressRuleValue
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IHttpIngressRuleValue), fullyQualifiedName: "k8s.HttpIngressRuleValue")]
        internal sealed class _Proxy : DeputyBase, K8s.IHttpIngressRuleValue
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>paths is a collection of paths that map requests to backends.</summary>
            /// <remarks>
            /// <strong>Schema</strong>: io.k8s.api.networking.v1.HTTPIngressRuleValue#paths
            /// </remarks>
            [JsiiProperty(name: "paths", typeJson: "{\"collection\":{\"elementtype\":{\"fqn\":\"k8s.HttpIngressPath\"},\"kind\":\"array\"}}")]
            public K8s.IHttpIngressPath[] Paths
            {
                get => GetInstanceProperty<K8s.IHttpIngressPath[]>()!;
            }
        }
    }
}
