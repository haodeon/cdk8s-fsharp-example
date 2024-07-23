using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>EnvVar represents an environment variable present in a Container.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVar
    /// </remarks>
    [JsiiByValue(fqn: "k8s.EnvVar")]
    public class EnvVar : K8s.IEnvVar
    {
        /// <summary>Name of the environment variable.</summary>
        /// <remarks>
        /// Must be a C_IDENTIFIER.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVar#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        public string Name
        {
            get;
            set;
        }

        /// <summary>Variable references $(VAR_NAME) are expanded using the previously defined environment variables in the container and any service environment variables.</summary>
        /// <remarks>
        /// If a variable cannot be resolved, the reference in the input string will be unchanged. Double $$ are reduced to a single $, which allows for escaping the $(VAR_NAME) syntax: i.e. "$$(VAR_NAME)" will produce the string literal "$(VAR_NAME)". Escaped references will never be expanded, regardless of whether the variable exists or not. Defaults to "".
        ///
        /// <strong>Default</strong>: .
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVar#value
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "value", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Value
        {
            get;
            set;
        }

        /// <summary>Source for the environment variable's value.</summary>
        /// <remarks>
        /// Cannot be used if value is not empty.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.EnvVar#valueFrom
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "valueFrom", typeJson: "{\"fqn\":\"k8s.EnvVarSource\"}", isOptional: true)]
        public K8s.IEnvVarSource? ValueFrom
        {
            get;
            set;
        }
    }
}
