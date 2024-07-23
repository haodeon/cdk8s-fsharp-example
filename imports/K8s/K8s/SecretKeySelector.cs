using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>SecretKeySelector selects a key of a Secret.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretKeySelector
    /// </remarks>
    [JsiiByValue(fqn: "k8s.SecretKeySelector")]
    public class SecretKeySelector : K8s.ISecretKeySelector
    {
        /// <summary>The key of the secret to select from.</summary>
        /// <remarks>
        /// Must be a valid secret key.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretKeySelector#key
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Name of the referent.</summary>
        /// <remarks>
        /// More info: https://kubernetes.io/docs/concepts/overview/working-with-objects/names/#names
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretKeySelector#name
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Name
        {
            get;
            set;
        }

        /// <summary>Specify whether the Secret or its key must be defined.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.SecretKeySelector#optional
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "optional", typeJson: "{\"primitive\":\"boolean\"}", isOptional: true)]
        public bool? Optional
        {
            get;
            set;
        }
    }
}
