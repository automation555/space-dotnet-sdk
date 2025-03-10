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

namespace JetBrains.Space.Client;

public partial class OrganizationClient : ISpaceClient
{
    private readonly Connection _connection;
    
    public OrganizationClient(Connection connection)
    {
        _connection = connection;
    }
    
    public async Task<OrganizationRecord> GetOrganizationAsync(Func<Partial<OrganizationRecord>, Partial<OrganizationRecord>>? partial = null, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        queryParameters.Append("$fields", (partial != null ? partial(new Partial<OrganizationRecord>()) : Partial<OrganizationRecord>.Default()).ToString());
        
        return await _connection.RequestResourceAsync<OrganizationRecord>("GET", $"api/http/organization{queryParameters.ToQueryString()}", cancellationToken);
    }
    

    public async Task UpdateOrganizationAsync(OrganizationForUpdate orgData, CancellationToken cancellationToken = default)
    {
        var queryParameters = new NameValueCollection();
        
        await _connection.RequestResourceAsync("PATCH", $"api/http/organization{queryParameters.ToQueryString()}", 
            new OrganizationPatchRequest
            { 
                OrgData = orgData,
            }, cancellationToken);
    }
    

    public DomainClient Domains => new DomainClient(_connection);
    
    public partial class DomainClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public DomainClient(Connection connection)
        {
            _connection = connection;
        }
        
        public async Task<List<OrgDomain>> GetAllDomainsAsync(Func<Partial<OrgDomain>, Partial<OrgDomain>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<OrgDomain>()) : Partial<OrgDomain>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<List<OrgDomain>>("GET", $"api/http/organization/domains{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        public async Task<CDomainStatus> CheckDomainAvailabilityAsync(string domain, Func<Partial<CDomainStatus>, Partial<CDomainStatus>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("domain", domain);
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<CDomainStatus>()) : Partial<CDomainStatus>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<CDomainStatus>("GET", $"api/http/organization/domains/check{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        public async Task UpdateOrganizationDomainAsync(string domain, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("PATCH", $"api/http/organization/domains{queryParameters.ToQueryString()}", 
                new OrganizationDomainsPatchRequest
                { 
                    Domain = domain,
                }, cancellationToken);
        }
        
    
    }

}

