using Amazon.JSII.Runtime.Deputy;

#pragma warning disable CS0672,CS0809,CS1591

namespace K8s
{
    #pragma warning disable CS8618

    /// <remarks>
    /// <strong>Schema</strong>: io.k8s.api.core.v1.GRPCAction
    /// </remarks>
    [JsiiByValue(fqn: "k8s.GrpcAction")]
    public class GrpcAction : K8s.IGrpcAction
    {
        /// <summary>Port number of the gRPC service.</summary>
        /// <remarks>
        /// Number must be in the range 1 to 65535.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GRPCAction#port
        /// </remarks>
        [JsiiProperty(name: "port", typeJson: "{\"primitive\":\"number\"}")]
        public double Port
        {
            get;
            set;
        }

        /// <summary>Service is the name of the service to place in the gRPC HealthCheckRequest (see https://github.com/grpc/grpc/blob/master/doc/health-checking.md).</summary>
        /// <remarks>
        /// If this is not specified, the default behavior is defined by gRPC.
        ///
        /// <strong>Schema</strong>: io.k8s.api.core.v1.GRPCAction#service
        /// </remarks>
        [JsiiOptional]
        [JsiiProperty(name: "service", typeJson: "{\"primitive\":\"string\"}", isOptional: true)]
        public string? Service
        {
            get;
            set;
        }
    }
}
