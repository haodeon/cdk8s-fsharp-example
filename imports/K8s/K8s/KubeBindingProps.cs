using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <summary>Binding ties one object to another;</summary>
    /// <remarks>
    /// for example, a pod is bound to a node by a scheduler. Deprecated in 1.7, please use the bindings subresource of pods instead.
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Binding
    /// </remarks>
    [JsiiByValue(fqn: "k8s.KubeBindingProps")]
    public class KubeBindingProps : K8s.IKubeBindingProps
    {
        /// <summary>The target object that you want to bind to the standard object.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Binding#target
        /// </remarks>
        [JsiiProperty(name: "target", typeJson: "{\"fqn\":\"k8s.ObjectReference\"}")]
        public K8s.IObjectReference Target
        {
            get;
            set;
        }

        /// <summary>Standard object's metadata.</summary>
        /// <remarks>
        /// More info: https://git.k8s.io/community/contributors/devel/sig-architecture/api-conventions.md#metadata
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.Binding#metadata
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
