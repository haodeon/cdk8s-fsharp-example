using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>GroupSubject holds detailed information for group-kind subject.</summary>
    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.GroupSubject
    /// </remarks>
    [JsiiInterface(nativeType: typeof(IGroupSubjectV1Beta3), fullyQualifiedName: "k8s.GroupSubjectV1Beta3")]
    public interface IGroupSubjectV1Beta3
    {
        /// <summary>name is the user group that matches, or "*" to match all user groups.</summary>
        /// <remarks>
        /// See https://github.com/kubernetes/apiserver/blob/master/pkg/authentication/user/user.go for some well-known group names. Required.
        ///
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.GroupSubject#name
        /// </remarks>
        [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
        string Name
        {
            get;
        }

        /// <summary>GroupSubject holds detailed information for group-kind subject.</summary>
        /// <remarks>
        /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.GroupSubject
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(IGroupSubjectV1Beta3), fullyQualifiedName: "k8s.GroupSubjectV1Beta3")]
        internal sealed class _Proxy : DeputyBase, K8s.IGroupSubjectV1Beta3
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>name is the user group that matches, or "*" to match all user groups.</summary>
            /// <remarks>
            /// See https://github.com/kubernetes/apiserver/blob/master/pkg/authentication/user/user.go for some well-known group names. Required.
            ///
            /// <strong>Schema</strong>: io.k8s.api.flowcontrol.v1beta3.GroupSubject#name
            /// </remarks>
            [JsiiProperty(name: "name", typeJson: "{\"primitive\":\"string\"}")]
            public string Name
            {
                get => GetInstanceProperty<string>()!;
            }
        }
    }
}
