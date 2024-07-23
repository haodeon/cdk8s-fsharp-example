using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>CustomResourceDefinition represents a resource that should be exposed on the API server.</summary>
    /// <remarks>
    /// Its name MUST be in the format &lt;.spec.name&gt;.&lt;.spec.group&gt;.
    ///
    /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinition
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeCustomResourceDefinitionProps")]
    public class KubeCustomResourceDefinitionProps : K8s.IKubeCustomResourceDefinitionProps
    {
        /// <summary>spec describes how the user wants the resources to appear.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinition#spec
        /// </remarks>
        [JsiiProperty(name: "spec", typeJson: "{\"fqn\":\"k8s.CustomResourceDefinitionSpec\"}")]
        public K8s.ICustomResourceDefinitionSpec Spec
        {
            get;
            set;
        }

        /// <summary>Standard object's metadata More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.apiextensions-apiserver.pkg.apis.apiextensions.v1.CustomResourceDefinition#metadata
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "metadata", typeJson: "{\"fqn\":\"k8s.ObjectMeta\"}", isOptional: true)]
        public K8s.IObjectMeta? Metadata
        {
            get;
            set;
        }
    }
}
