using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>VolumeAttributesClass represents a specification of mutable volume attributes defined by the CSI driver.</summary>
    /// <remarks>
    /// The class can be specified during dynamic provisioning of PersistentVolumeClaims, and changed in the PersistentVolumeClaim spec after provisioning.
    ///
    /// <strong>Schema</strong>: io.k8s.api.storage.v1alpha1.VolumeAttributesClass
    /// </remarks>
    [JsiiClass(nativeType: typeof(K8s.KubeVolumeAttributesClassV1Alpha1), fullyQualifiedName: "k8s.KubeVolumeAttributesClassV1Alpha1", parametersJson: "[{\"docs\":{\"summary\":\"the scope in which to define this object.\"},\"name\":\"scope\",\"type\":{\"fqn\":\"constructs.Construct\"}},{\"docs\":{\"summary\":\"a scope-local name for the object.\"},\"name\":\"id\",\"type\":{\"primitive\":\"string\"}},{\"docs\":{\"summary\":\"initialization props.\"},\"name\":\"props\",\"type\":{\"fqn\":\"k8s.KubeVolumeAttributesClassV1Alpha1Props\"}}]")]
    public class KubeVolumeAttributesClassV1Alpha1 : Org.Cdk8s.ApiObject
    {
        /// <summary>Defines a "io.k8s.api.storage.v1alpha1.VolumeAttributesClass" API object.</summary>
        /// <param name="scope">the scope in which to define this object.</param>
        /// <param name="id">a scope-local name for the object.</param>
        /// <param name="props">initialization props.</param>
        public KubeVolumeAttributesClassV1Alpha1(Constructs.Construct scope, string id, K8s.IKubeVolumeAttributesClassV1Alpha1Props props): base(_MakeDeputyProps(scope, id, props))
        {
        }

        [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
        private static DeputyProps _MakeDeputyProps(Constructs.Construct scope, string id, K8s.IKubeVolumeAttributesClassV1Alpha1Props props)
        {
            return new DeputyProps(new object?[]{scope, id, props});
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubeVolumeAttributesClassV1Alpha1(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected KubeVolumeAttributesClassV1Alpha1(DeputyProps props): base(props)
        {
        }

        /// <summary>Renders a Kubernetes manifest for "io.k8s.api.storage.v1alpha1.VolumeAttributesClass".</summary>
        /// <param name="props">initialization props.</param>
        /// <remarks>
        /// This can be used to inline resource manifests inside other objects (e.g. as templates).
        /// </remarks>
        [JsiiMethod(name: "manifest", returnsJson: "{\"type\":{\"primitive\":\"any\"}}", parametersJson: "[{\"docs\":{\"summary\":\"initialization props.\"},\"name\":\"props\",\"type\":{\"fqn\":\"k8s.KubeVolumeAttributesClassV1Alpha1Props\"}}]")]
        public static object Manifest(K8s.IKubeVolumeAttributesClassV1Alpha1Props props)
        {
            return InvokeStaticMethod<object>(typeof(K8s.KubeVolumeAttributesClassV1Alpha1), new System.Type[]{typeof(K8s.IKubeVolumeAttributesClassV1Alpha1Props)}, new object[]{props})!;
        }

        /// <summary>Renders the object to Kubernetes JSON.</summary>
        [JsiiMethod(name: "toJson", returnsJson: "{\"type\":{\"primitive\":\"any\"}}")]
        public override object ToJson()
        {
            return InvokeInstanceMethod<object>(new System.Type[]{}, new object[]{})!;
        }

        /// <summary>Returns the apiVersion and kind for "io.k8s.api.storage.v1alpha1.VolumeAttributesClass".</summary>
        [JsiiProperty(name: "GVK", typeJson: "{\"fqn\":\"cdk8s.GroupVersionKind\"}")]
        public static Org.Cdk8s.IGroupVersionKind GVK
        {
            get;
        }
        = GetStaticProperty<Org.Cdk8s.IGroupVersionKind>(typeof(K8s.KubeVolumeAttributesClassV1Alpha1))!;
    }
}
