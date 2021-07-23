// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public partial class ToDoItemClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public ToDoItemClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Create a new To-Do item, with an optional due date.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Edit todo</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<TodoItemRecord> CreateTodoItemAsync(string text, DateTime? dueDate = null, Func<Partial<TodoItemRecord>, Partial<TodoItemRecord>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<TodoItemRecord>()) : Partial<TodoItemRecord>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<TodoPostRequest, TodoItemRecord>("POST", $"api/http/todo{queryParameters.ToQueryString()}", 
                new TodoPostRequest
                { 
                    Text = text,
                    DueDate = dueDate,
                }, cancellationToken);
        }
        
    
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Edit todo</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task DeleteTasksAsync(string text, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("POST", $"api/http/todo/deletetaskswithtext{queryParameters.ToQueryString()}", 
                new TodoDeletetaskswithtextPostRequest
                { 
                    Text = text,
                }, cancellationToken);
        }
        
    
        /// <summary>
        /// Get all To-Do items that match given parameters. Parameters are applied as 'AND' filters.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View todo</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task<Batch<TodoItemRecord>> GetAllTodoItemsAsync(string? skip = null, int? top = 100, bool? open = null, DateTime? from = null, DateTime? till = null, Func<Partial<Batch<TodoItemRecord>>, Partial<Batch<TodoItemRecord>>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            if (skip != null) queryParameters.Append("$skip", skip);
            if (top != null) queryParameters.Append("$top", top?.ToString());
            if (open != null) queryParameters.Append("open", open?.ToString("l"));
            if (from != null) queryParameters.Append("from", from?.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            if (till != null) queryParameters.Append("till", till?.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture));
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<Batch<TodoItemRecord>>()) : Partial<Batch<TodoItemRecord>>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<Batch<TodoItemRecord>>("GET", $"api/http/todo{queryParameters.ToQueryString()}", cancellationToken);
        }
        
        
        /// <summary>
        /// Get all To-Do items that match given parameters. Parameters are applied as 'AND' filters.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>View todo</term>
        /// </item>
        /// </list>
        /// </remarks>
        public IAsyncEnumerable<TodoItemRecord> GetAllTodoItemsAsyncEnumerable(string? skip = null, int? top = 100, bool? open = null, DateTime? from = null, DateTime? till = null, Func<Partial<TodoItemRecord>, Partial<TodoItemRecord>>? partial = null, CancellationToken cancellationToken = default)
            => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllTodoItemsAsync(top: top, open: open, from: from, till: till, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<TodoItemRecord>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<TodoItemRecord>.Default())), skip, cancellationToken);
    
        /// <summary>
        /// Update an existing To-Do item. Optional parameters will be ignored when not specified, and updated otherwise.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Edit todo</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task UpdateTodoItemAsync(string id, string? text = null, DateTime? dueDate = null, bool? open = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("PATCH", $"api/http/todo/{id}{queryParameters.ToQueryString()}", 
                new TodoForIdPatchRequest
                { 
                    Text = text,
                    DueDate = dueDate,
                    IsOpen = open,
                }, cancellationToken);
        }
        
    
        /// <summary>
        /// Delete an existing To-Do item.
        /// </summary>
        /// <remarks>
        /// Required permissions:
        /// <list type="bullet">
        /// <item>
        /// <term>Edit todo</term>
        /// </item>
        /// </list>
        /// </remarks>
        public async Task DeleteTodoItemAsync(string id, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("DELETE", $"api/http/todo/{id}{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
    }
    
}
