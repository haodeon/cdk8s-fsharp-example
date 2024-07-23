using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>ResourceClassParameters defines resource requests for a ResourceClass in an in-tree format understood by Kubernetes.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.resource.v1alpha2.ResourceClassParameters
    /// </remarks>
    [JsiiClass(nativeType: typeof(K8s.KubeResourceClassParametersV1Alpha2), fullyQualifiedName: "k8s.KubeResourceClassParametersV1Alpha2", parametersJson: "[{\"docs\":{\"summary\":\"the scope in which to define this object.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"a scope-local name for the object.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"initialization props.\"},\"name\":\"props\",\"optional\":true,\"type\":{\"fqn\":\"k8s.KubeResourceClassParametersV1Alpha2Props\"}}]")]
    public class KubeResourceClassParametersV1Alpha2 : Org.Cdk8s.ApiObject
    {
        /// <summary>Defines a "io.k8s.api.resource.v1alpha2.ResourceClassParameters" API object.</summary>
        /// <param name="scope">the scope in which to define this object.</param>
        /// <param name="id">a scope-local name for the object.</param>
        /// <param name="props">initialization props.</param>
        public KubeResourceClassParametersV1Alpha2(Constructs.Construct scope, string id, K8s.IKubeResourceClassParametersV1Alpha2Props? props = null): base(_MakeDeputyProps(scope, id, props))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, K8s.IKubeResourceClassParametersV1Alpha2Props? props = null)
        {
            return new DeputyProps(new object?[]{scope, id, props});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubeResourceClassParametersV1Alpha2(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubeResourceClassParametersV1Alpha2(DeputyProps props): base(props)
        {
        }

        /// <summary>Renders a Kubernetes manifest for "io.k8s.api.resource.v1alpha2.ResourceClassParameters".</summary>
        /// <param name="props">initialization props.</param>
        /// <remarks>
        /// This can be used to inline resource manifests inside other objects (e.g. as templates).
        /// </remarks>
        [JsiiMethod(name: "manifest", returnsJson: "{\"type\":{\"primitive\":\"any\"}}", parametersJson: "[{\"docs\":{\"summary\":\"initialization props.\"},\"name\":\"props\",\"optional\":true,\"type\":{\"fqn\":\"k8s.KubeResourceClassParametersV1Alpha2Props\"}}]")]
        public static object Manifest(K8s.IKubeResourceClassParametersV1Alpha2Props? props = null)
        {
            return InvokeStaticMethod<object>(typeof(K8s.KubeResourceClassParametersV1Alpha2), new System.Type[]{typeof(K8s.IKubeResourceClassParametersV1Alpha2Props)}, new object?[]{props})!;
        }

        /// <summary>Renders the object to Kubernetes JSON.</summary>
        [JsiiMethod(name: "toJson", returnsJson: "{\"type\":{\"primitive\":\"any\"}}")]
        public override object ToJson()
        {
            return InvokeInstanceMethod<object>(new System.Type[]{}, new object[]{})!;
        }

        /// <summary>Returns the apiVersion and kind for "io.k8s.api.resource.v1alpha2.ResourceClassParameters".</summary>
        [JsiiProperty(name: "GVK", typeJson: "{\"fqn\":\"cdk8s.GroupVersionKind\"}")]
        public static Org.Cdk8s.IGroupVersionKind GVK
        {
            get;
        }
        = GetStaticProperty<Org.Cdk8s.IGroupVersionKind>(typeof(K8s.KubeResourceClassParametersV1Alpha2))!;
    }
}
