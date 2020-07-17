using SpaceDotNet.Generator.CodeGeneration.Extensions;
using SpaceDotNet.Generator.Model.HttpApi;
using SpaceDotNet.Generator.Utilities;

namespace SpaceDotNet.Generator.CodeGeneration.CSharp.Extensions
{
    public static class ApiEndpointExtensions
    {
        public static string ToCSharpMethodName(this ApiEndpoint subject)
            => CSharpIdentifier.ForClassOrNamespace(subject.DisplayName);
        
        public static string? ToCSharpRequestBodyClassName(this ApiEndpoint subject, string endpointPath)
        {
            if (subject.RequestBody == null || 
                subject.RequestBody.Kind != ApiFieldType.Object.ObjectKind.REQUEST_BODY) return null;
            
            return CSharpIdentifier.ForClassOrNamespace(endpointPath)
                   + subject.Method.ToHttpMethod().ToLowerInvariant().ToUppercaseFirst()
                   + "Request";
        }
    }
}