using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>Endpoints is a collection of endpoints that implement the actual service. Example:.</summary>
    /// <remarks>
    /// Name: "mysvc",
    /// Subsets: [
    /// {
    /// Addresses: [{"ip": "10.10.1.1"}, {"ip": "10.10.2.2"}],
    /// Ports: [{"name": "a", "port": 8675}, {"name": "b", "port": 309}]
    /// },
    /// {
    /// Addresses: [{"ip": "10.10.3.3"}],
    /// Ports: [{"name": "a", "port": 93}, {"name": "b", "port": 76}]
    /// },
    /// ]
    ///
    /// <strong>Schema</strong>: io.k8s.api.core.v1.Endpoints
    /// </remarks>
    [JsiiClass(nativeType: typeof(K8s.KubeEndpoints), fullyQualifiedName: "k8s.KubeEndpoints", parametersJson: "[{\"docs\":{\"summary\":\"the scope in which to define this object.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"a scope-local name for the object.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"initialization props.\"},\"name\":\"props\",\"optional\":true,\"type\":{\"fqn\":\"k8s.KubeEndpointsProps\"}}]")]
    public class KubeEndpoints : Org.Cdk8s.ApiObject
    {
        /// <summary>Defines a "io.k8s.api.core.v1.Endpoints" API object.</summary>
        /// <param name="scope">the scope in which to define this object.</param>
        /// <param name="id">a scope-local name for the object.</param>
        /// <param name="props">initialization props.</param>
        public KubeEndpoints(Constructs.Construct scope, string id, K8s.IKubeEndpointsProps? props = null): base(_MakeDeputyProps(scope, id, props))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, K8s.IKubeEndpointsProps? props = null)
        {
            return new DeputyProps(new object?[]{scope, id, props});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubeEndpoints(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubeEndpoints(DeputyProps props): base(props)
        {
        }

        /// <summary>Renders a Kubernetes manifest for "io.k8s.api.core.v1.Endpoints".</summary>
        /// <param name="props">initialization props.</param>
        /// <remarks>
        /// This can be used to inline resource manifests inside other objects (e.g. as templates).
        /// </remarks>
        [JsiiMethod(name: "manifest", returnsJson: "{\"type\":{\"primitive\":\"any\"}}", parametersJson: "[{\"docs\":{\"summary\":\"initialization props.\"},\"name\":\"props\",\"optional\":true,\"type\":{\"fqn\":\"k8s.KubeEndpointsProps\"}}]")]
        public static object Manifest(K8s.IKubeEndpointsProps? props = null)
        {
            return InvokeStaticMethod<object>(typeof(K8s.KubeEndpoints), new System.Type[]{typeof(K8s.IKubeEndpointsProps)}, new object?[]{props})!;
        }

        /// <summary>Renders the object to Kubernetes JSON.</summary>
        [JsiiMethod(name: "toJson", returnsJson: "{\"type\":{\"primitive\":\"any\"}}")]
        public override object ToJson()
        {
            return InvokeInstanceMethod<object>(new System.Type[]{}, new object[]{})!;
        }

        /// <summary>Returns the apiVersion and kind for "io.k8s.api.core.v1.Endpoints".</summary>
        [JsiiProperty(name: "GVK", typeJson: "{\"fqn\":\"cdk8s.GroupVersionKind\"}")]
        public static Org.Cdk8s.IGroupVersionKind GVK
        {
            get;
        }
        = GetStaticProperty<Org.Cdk8s.IGroupVersionKind>(typeof(K8s.KubeEndpoints))!;
    }
}
