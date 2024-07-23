using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    /// <summary>SuccessPolicyRule describes rule for declaring a Job as succeeded.</summary>
    /// <remarks>
    /// Each rule must have at least one of the "succeededIndexes" or "succeededCount" specified.
    ///
    /// <strong>Schema</strong>: io.k8s.api.batch.v1.SuccessPolicyRule
    /// </remarks>
    [JsiiInterface(nativeType: typeof(ISuccessPolicyRule), fullyQualifiedName: "k8s.SuccessPolicyRule")]
    public interface ISuccessPolicyRule
    {
        /// <summary>succeededCount specifies the minimal required size of the actual set of the succeeded indexes for the Job.</summary>
        /// <remarks>
        /// When succeededCount is used along with succeededIndexes, the check is constrained only to the set of indexes specified by succeededIndexes. For example, given that succeededIndexes is "1-4", succeededCount is "3", and completed indexes are "1", "3", and "5", the Job isn't declared as succeeded because only "1" and "3" indexes are considered in that rules. When this field is null, this doesn't default to any value and is never evaluated at any time. When specified it needs to be a positive integer.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.SuccessPolicyRule#succeededCount
        /// </remarks>
        [JsiiProperty(name: "succeededCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        double? SucceededCount
        {
            get
            {
                return null;
            }
        }

        /// <summary>succeededIndexes specifies the set of indexes which need to be contained in the actual set of the succeeded indexes for the Job.</summary>
        /// <remarks>
        /// The list of indexes must be within 0 to ".spec.completions-1" and must not contain duplicates. At least one element is required. The indexes are represented as intervals separated by commas. The intervals can be a decimal integer or a pair of decimal integers separated by a hyphen. The number are listed in represented by the first and last element of the series, separated by a hyphen. For example, if the completed indexes are 1, 3, 4, 5 and 7, they are represented as "1,3-5,7". When this field is null, this field doesn't default to any value and is never evaluated at any time.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.SuccessPolicyRule#succeededIndexes
        /// </remarks>
        [JsiiProperty(name: "succeededIndexes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        [Amazon.JSII.Runtime.Deputy.JsiiOptional]
        string? SucceededIndexes
        {
            get
            {
                return null;
            }
        }

        /// <summary>SuccessPolicyRule describes rule for declaring a Job as succeeded.</summary>
        /// <remarks>
        /// Each rule must have at least one of the "succeededIndexes" or "succeededCount" specified.
        ///
        /// <strong>Schema</strong>: io.k8s.api.batch.v1.SuccessPolicyRule
        /// </remarks>
        [JsiiTypeProxy(nativeType: typeof(ISuccessPolicyRule), fullyQualifiedName: "k8s.SuccessPolicyRule")]
        internal sealed class _Proxy : DeputyBase, K8s.ISuccessPolicyRule
        {
            private _Proxy(ByRefValue reference): base(reference)
            {
            }

            /// <summary>succeededCount specifies the minimal required size of the actual set of the succeeded indexes for the Job.</summary>
            /// <remarks>
            /// When succeededCount is used along with succeededIndexes, the check is constrained only to the set of indexes specified by succeededIndexes. For example, given that succeededIndexes is "1-4", succeededCount is "3", and completed indexes are "1", "3", and "5", the Job isn't declared as succeeded because only "1" and "3" indexes are considered in that rules. When this field is null, this doesn't default to any value and is never evaluated at any time. When specified it needs to be a positive integer.
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.SuccessPolicyRule#succeededCount
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "succeededCount", typeJson: "{\"primitive\":\"number\"}", isOptional: true)]
            public double? SucceededCount
            {
                get => GetInstanceProperty<double?>();
            }

            /// <summary>succeededIndexes specifies the set of indexes which need to be contained in the actual set of the succeeded indexes for the Job.</summary>
            /// <remarks>
            /// The list of indexes must be within 0 to ".spec.completions-1" and must not contain duplicates. At least one element is required. The indexes are represented as intervals separated by commas. The intervals can be a decimal integer or a pair of decimal integers separated by a hyphen. The number are listed in represented by the first and last element of the series, separated by a hyphen. For example, if the completed indexes are 1, 3, 4, 5 and 7, they are represented as "1,3-5,7". When this field is null, this field doesn't default to any value and is never evaluated at any time.
            ///
            /// <strong>Schema</strong>: io.k8s.api.batch.v1.SuccessPolicyRule#succeededIndexes
            /// </remarks>
            [JsiiOptional]
            [JsiiProperty(name: "succeededIndexes", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
            public string? SucceededIndexes
            {
                get => GetInstanceProperty<string?>();
            }
        }
    }
}
