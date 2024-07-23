using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace Com.Pulumi
{
    /// <summary>Requirement gives specific requirements for the prerequisite;</summary>
    /// <remarks>
    /// the base requirement is that
    /// the referenced stack is in a successful state.
    ///
    /// <strong>Schema</strong>: StackSpecPrerequisitesRequirement
    /// </remarks>
    [JsiiByValue(fqn: "compulumi.StackSpecPrerequisitesRequirement")]
    public class StackSpecPrerequisitesRequirement : Com.Pulumi.IStackSpecPrerequisitesRequirement
    {
        /// <summary>SucceededWithinDuration gives a duration within which the prerequisite must have reached a succeeded state;</summary>
        /// <remarks>
        /// e.g., "1h" means "the prerequisite must be successful, and have become so in
        /// the last hour". Fields (should there ever be more than one) are not intended to be mutually
        /// exclusive.
        ///
        /// <strong>Schema</strong>: StackSpecPrerequisitesRequirement#succeededWithinDuration
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
