using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>UserSubject holds detailed information for user-kind subject.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.UserSubject
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IUserSubjectV1Beta3), fullyQualifiedName: "k8s.UserSubjectV1Beta3")]
    public interface IUserSubjectV1Beta3
    {
        /// <summary>`name` is the username that matches, or "*" to match all usernames.</summary>
        /// <remarks>
        /// Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.UserSubject#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>UserSubject holds detailed information for user-kind subject.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.UserSubject
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IUserSubjectV1Beta3), fullyQualifiedName: "k8s.UserSubjectV1Beta3")]
        internal sealed class _Proxy : DeputyBase, K8s.IUserSubjectV1Beta3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>`name` is the username that matches, or "*" to match all usernames.</summary>
            /// <remarks>
            /// Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.UserSubject#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
