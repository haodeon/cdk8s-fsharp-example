using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>Requirement gives specific requirements for the prerequisite;</summary>
    /// <remarks>
    /// the base requirement is that
    /// the referenced stack is in a successful state.
    ///
    /// <strong>Schema</strong>: StackV1Alpha1SpecPrerequisitesRequirement
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackV1Alpha1SpecPrerequisitesRequirement")]
    public class StackV1Alpha1SpecPrerequisitesRequirement : Com.Pulumi.IStackV1Alpha1SpecPrerequisitesRequirement
    {
        /// <summary>SucceededWithinDuration gives a duration within which the prerequisite must have reached a succeeded state;</summary>
        /// <remarks>
        /// e.g., "1h" means "the prerequisite must be successful, and have become so in
        /// the last hour". Fields (should there ever be more than one) are not intended to be mutually
        /// exclusive.
        ///
        /// <strong>Schema</strong>: StackV1Alpha1SpecPrerequisitesRequirement#succeededWithinDuration
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "succeededWithinDuration", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? SucceededWithinDuration
        {
            get;
            set;
        }
    }
}
