using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.util.intstr.IntOrString
    /// </remarks>
    [JsiiClass(nativeType: typeof(K8s.IntOrString), fullyQualifiedName: "k8s.IntOrString")]
    public class IntOrString : DeputyBase
    {
        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IntOrString(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected IntOrString(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "fromNumber", returnsJson: "{\"type\":{\"fqn\":\"k8s.IntOrString\"}}", parametersJson: "[{\"name\":\"value\",\"type\":{\"primitive\":\"number\"}}]")]
        public static K8s.IntOrString FromNumber(double @value)
        {
            return InvokeStaticMethod<K8s.IntOrString>(typeof(K8s.IntOrString), new System.Type[]{typeof(double)}, new object[]{@value})!;
        }

        [JsiiMethod(name: "fromString", returnsJson: "{\"type\":{\"fqn\":\"k8s.IntOrString\"}}", parametersJson: "[{\"name\":\"value\",\"type\":{\"primitive\":\"string\"}}]")]
        public static K8s.IntOrString FromString(string @value)
        {
            return InvokeStaticMethod<K8s.IntOrString>(typeof(K8s.IntOrString), new System.Type[]{typeof(string)}, new object[]{@value})!;
        }

        [JsiiProperty(name: "value", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"primitive\":\"number\"}]}}")]
        public virtual object Value
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
