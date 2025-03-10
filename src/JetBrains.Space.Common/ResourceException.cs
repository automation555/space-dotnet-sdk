using System;
using System.Net;
using JetBrains.Annotations;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Common;

/// <summary>
/// Represents an exception thrown by <see cref="T:Connection" /> when a resource cannot be accessed.
/// </summary>
[PublicAPI]
public class ResourceException 
    : Exception
{
    /// <summary>
    /// Initializes a new instance of the <see cref="T:ResourceException" /> class.
    /// </summary>
    public ResourceException()
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:ResourceException" /> class
    /// with a specific message, HTTP status code and HTTP response body.
    /// </summary>
    /// <param name="message">A message that describes the current exception.</param>
    /// <param name="innerException">Inner exception, if available.</param>
    public ResourceException(string message, Exception? innerException = null) 
        : base(message, innerException)
    {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:ResourceException" /> class
    /// with a specific message, HTTP status code and HTTP response body.
    /// </summary>
    /// <param name="message">A message that describes the current exception.</param>
    /// <param name="statusCode">The <see cref="T:System.Net.Http.HttpStatusCode" /> that was received from the server.</param>
    /// <param name="response">The HTTP response body which was received from the server.</param>
    /// <param name="innerException">Inner exception, if available.</param>
    public ResourceException(string message, HttpStatusCode statusCode, string? response, Exception? innerException = null) 
        : base(message, innerException)
    {
        StatusCode = statusCode;
        Response = response;
    }
        
    /// <summary>
    /// Get the <see cref="T:System.Net.Http.HttpStatusCode" /> that was received from the server.
    /// </summary>
    public HttpStatusCode? StatusCode { get; }
        
    /// <summary>
    /// Get the HTTP response body which was received from the server.
    /// </summary>
    public string? Response { get; }

    /// <summary>
    /// Get the error received from Space.
    /// </summary>
    public SpaceError? Error { get; set; }
}