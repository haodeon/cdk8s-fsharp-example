using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.apimachinery.pkg.api.resource.Quantity
    /// </remarks>
    [JsiiClass(nativeType: typeof(K8s.Quantity), fullyQualifiedName: "k8s.Quantity")]
    public class Quantity : DeputyBase
    {
        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Quantity(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected Quantity(DeputyProps props): base(props)
        {
        }

        [JsiiMethod(name: "fromNumber", returnsJson: "{\"type\":{\"fqn\":\"k8s.Quantity\"}}", parametersJson: "[{\"name\":\"value\",\"type\":{\"primitive\":\"number\"}}]")]
        public static K8s.Quantity FromNumber(double @value)
        {
            return InvokeStaticMethod<K8s.Quantity>(typeof(K8s.Quantity), new System.Type[]{typeof(double)}, new object[]{@value})!;
        }

        [JsiiMethod(name: "fromString", returnsJson: "{\"type\":{\"fqn\":\"k8s.Quantity\"}}", parametersJson: "[{\"name\":\"value\",\"type\":{\"primitive\":\"string\"}}]")]
        public static K8s.Quantity FromString(string @value)
        {
            return InvokeStaticMethod<K8s.Quantity>(typeof(K8s.Quantity), new System.Type[]{typeof(string)}, new object[]{@value})!;
        }

        [JsiiProperty(name: "value", typeJson: "{\"union\":{\"types\":[{\"primitive\":\"string\"},{\"primitive\":\"number\"}]}}")]
        public virtual object Value
        {
            get => GetInstanceProperty<object>()!;
        }
    }
}
