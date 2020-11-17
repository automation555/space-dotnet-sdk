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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Client.Internal;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public partial class CustomFieldClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public CustomFieldClient(Connection connection)
        {
            _connection = connection;
        }
        
        public ExtendedTypeClient ExtendedTypes => new ExtendedTypeClient(_connection);
        
        public partial class ExtendedTypeClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public ExtendedTypeClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get all types that support custom fields.
            /// </summary>
            public async Task<List<ExtendedType>> GetAllExtendedTypesAsync(ExtendedTypeScopeType? scope = null, Func<Partial<ExtendedType>, Partial<ExtendedType>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<List<ExtendedType>>("GET", $"api/http/custom-fields/extended-types?scope={(scope ?? ExtendedTypeScopeType.Org).ToString()}&$fields={(partial != null ? partial(new Partial<ExtendedType>()) : Partial<ExtendedType>.Default())}", cancellationToken);
        
        }
    
        public AllValueClient AllValues => new AllValueClient(_connection);
        
        public partial class AllValueClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public AllValueClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get all custom field values for a type. Optionally, extendedEntityIds can be used to get data for one or more entity ids.
            /// </summary>
            public async Task<Batch<CustomFieldsRecord>> GetAllValuesAsync(string typeKey, ExtendedTypeScope scope, string? skip = null, int? top = 100, List<string>? extendedEntityIds = null, Func<Partial<Batch<CustomFieldsRecord>>, Partial<Batch<CustomFieldsRecord>>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<Batch<CustomFieldsRecord>>("GET", $"api/http/custom-fields/{typeKey}/all-values?$skip={skip?.ToString() ?? "null"}&$top={top?.ToString() ?? "null"}&extendedEntityIds={extendedEntityIds?.JoinToString("extendedEntityIds", it => it.ToString()) ?? "null"}&scope={scope.ToString()}&$fields={(partial != null ? partial(new Partial<Batch<CustomFieldsRecord>>()) : Partial<Batch<CustomFieldsRecord>>.Default())}", cancellationToken);
            
            /// <summary>
            /// Get all custom field values for a type. Optionally, extendedEntityIds can be used to get data for one or more entity ids.
            /// </summary>
            public IAsyncEnumerable<CustomFieldsRecord> GetAllValuesAsyncEnumerable(string typeKey, ExtendedTypeScope scope, string? skip = null, int? top = 100, List<string>? extendedEntityIds = null, Func<Partial<CustomFieldsRecord>, Partial<CustomFieldsRecord>>? partial = null, CancellationToken cancellationToken = default)
                => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => GetAllValuesAsync(typeKey: typeKey, scope: scope, top: top, extendedEntityIds: extendedEntityIds, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<CustomFieldsRecord>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<CustomFieldsRecord>.Default())), skip, cancellationToken);
        
        }
    
        public FieldClient Fields => new FieldClient(_connection);
        
        public partial class FieldClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public FieldClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Create custom field for a type.
            /// </summary>
            public async Task<CustomField> CreateFieldAsync(string typeKey, string name, CFType type, bool required, bool @private, CFValue defaultValue, ExtendedTypeScope scope, string? description = null, CFConstraint? constraint = null, AccessType? access = null, Func<Partial<CustomField>, Partial<CustomField>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<CustomFieldsForTypeKeyFieldsPostRequest, CustomField>("POST", $"api/http/custom-fields/{typeKey}/fields?$fields={(partial != null ? partial(new Partial<CustomField>()) : Partial<CustomField>.Default())}", 
                    new CustomFieldsForTypeKeyFieldsPostRequest { 
                        Name = name,
                        Description = description,
                        Type = type,
                        Constraint = constraint,
                        IsRequired = required,
                        IsPrivate = @private,
                        Access = access,
                        DefaultValue = defaultValue,
                        Scope = scope,
                    }
            , cancellationToken);
        
            /// <summary>
            /// Re-order custom fields. Pass IDs of the custom fields in the order you wish the custom fields to be.
            /// </summary>
            public async Task ReorderAsync(string typeKey, List<string> customFieldOrder, ExtendedTypeScope scope, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync("POST", $"api/http/custom-fields/{typeKey}/fields/reorder", 
                    new CustomFieldsForTypeKeyFieldsReorderPostRequest { 
                        CustomFieldOrder = customFieldOrder,
                        Scope = scope,
                    }
            , cancellationToken);
        
            /// <summary>
            /// Archive a custom field for a type.
            /// </summary>
            public async Task ArchiveAsync(string typeKey, string id, ExtendedTypeScope scope, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync("POST", $"api/http/custom-fields/{typeKey}/fields/{id}/archive", 
                    new CustomFieldsForTypeKeyFieldsForIdArchivePostRequest { 
                        Scope = scope,
                    }
            , cancellationToken);
        
            /// <summary>
            /// Restore custom field for a type.
            /// </summary>
            public async Task RestoreAsync(string typeKey, string id, ExtendedTypeScope scope, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync("POST", $"api/http/custom-fields/{typeKey}/fields/{id}/restore", 
                    new CustomFieldsForTypeKeyFieldsForIdRestorePostRequest { 
                        Scope = scope,
                    }
            , cancellationToken);
        
            /// <summary>
            /// Get custom fields for a type.
            /// </summary>
            public async Task<List<CustomField>> GetAllFieldsAsync(string typeKey, ExtendedTypeScope scope, bool withArchived = false, Func<Partial<CustomField>, Partial<CustomField>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<List<CustomField>>("GET", $"api/http/custom-fields/{typeKey}/fields?withArchived={withArchived.ToString("l")}&scope={scope.ToString()}&$fields={(partial != null ? partial(new Partial<CustomField>()) : Partial<CustomField>.Default())}", cancellationToken);
        
            /// <summary>
            /// Update custom field for a type. Optional parameters will be ignored when not specified, and updated otherwise.
            /// </summary>
            public async Task UpdateFieldAsync(string typeKey, string id, ExtendedTypeScope scope, string? name = null, string? description = null, CFConstraint? constraint = null, bool? required = null, bool? @private = null, AccessType? access = null, CFValue? defaultValue = null, List<EnumValueData>? enumValues = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync("PATCH", $"api/http/custom-fields/{typeKey}/fields/{id}", 
                    new CustomFieldsForTypeKeyFieldsForIdPatchRequest { 
                        Name = name,
                        Description = description,
                        Constraint = constraint,
                        IsRequired = required,
                        IsPrivate = @private,
                        Access = access,
                        DefaultValue = defaultValue,
                        EnumValues = enumValues,
                        Scope = scope,
                    }
            , cancellationToken);
        
            /// <summary>
            /// Remove custom field for a type.
            /// </summary>
            public async Task DeleteFieldAsync(string typeKey, string id, ExtendedTypeScope scope, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync("DELETE", $"api/http/custom-fields/{typeKey}/fields/{id}?scope={scope.ToString()}", cancellationToken);
        
        }
    
        public ValueClient Values => new ValueClient(_connection);
        
        public partial class ValueClient : ISpaceClient
        {
            private readonly Connection _connection;
            
            public ValueClient(Connection connection)
            {
                _connection = connection;
            }
            
            /// <summary>
            /// Get custom field value for a type and entity id.
            /// </summary>
            public async Task<CustomFieldsRecord> GetValueAsync(string typeKey, string entityId, ExtendedTypeScope scope, Func<Partial<CustomFieldsRecord>, Partial<CustomFieldsRecord>>? partial = null, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync<CustomFieldsRecord>("GET", $"api/http/custom-fields/{typeKey}/{entityId}/values?scope={scope.ToString()}&$fields={(partial != null ? partial(new Partial<CustomFieldsRecord>()) : Partial<CustomFieldsRecord>.Default())}", cancellationToken);
        
            /// <summary>
            /// Update custom field value(s) for a type and entity id.
            /// </summary>
            public async Task UpdateValueAsync(string entityId, string typeKey, List<CustomFieldValue> values, ExtendedTypeScope scope, CancellationToken cancellationToken = default)
                => await _connection.RequestResourceAsync("PATCH", $"api/http/custom-fields/{typeKey}/{entityId}/values", 
                    new CustomFieldsForTypeKeyForEntityIdValuesPatchRequest { 
                        Values = values,
                        Scope = scope,
                    }
            , cancellationToken);
        
        }
    
    }
    
}
