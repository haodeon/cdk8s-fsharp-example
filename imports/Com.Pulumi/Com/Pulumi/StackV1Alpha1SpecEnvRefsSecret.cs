using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    #pragma warning disable CS8618

    /// <summary>SecretRef refers to a Kubernetes Secret.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: StackV1Alpha1SpecEnvRefsSecret
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackV1Alpha1SpecEnvRefsSecret")]
    public class StackV1Alpha1SpecEnvRefsSecret : Com.Pulumi.IStackV1Alpha1SpecEnvRefsSecret
    {
        /// <summary>Key within the Secret to use.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecEnvRefsSecret#key
        /// </remarks>
        [JsiiProperty(name: "key", typeJson: "{\"primitive\":\"string\"}")]
        public string Key
        {
            get;
            set;
        }

        /// <summary>Name of the Secret.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: StackV1Alpha1SpecEnvRefsSecret#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Namespace where the Secret is stored.</summary>
        /// <remarks>
        /// Deprecated; non-empty values will be considered invalid
        /// unless namespace isolation is disabled in the controller.
        ///
        /// <strong>Schema</strong>: StackV1Alpha1SpecEnvRefsSecret#namespace
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "namespace", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Namespace
        {
            get;
            set;
        }
    }
}
