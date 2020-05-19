// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public partial class UploadClient
    {
        private readonly Connection _connection;
        
        public UploadClient(Connection connection)
        {
            _connection = connection;
        }
        
        public async Task<string> CreateUpload(CreateUploadRequestDto data, Func<Partial<string>, Partial<string>> partialBuilder = null)
            => await _connection.RequestResourceAsync<CreateUploadRequestDto, string>("POST", $"api/http/uploads?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<string>()) : new EagerPartial<string>()), data);        
        
        public ImageClient Image => new ImageClient(_connection);
        
        public partial class ImageClient
        {
            private readonly Connection _connection;
            
            public ImageClient(Connection connection)
            {
                _connection = connection;
            }
            
            public async Task<ImageAttachmentMetaDto> GetImageAttachmentMetadata(string id, Func<Partial<ImageAttachmentMetaDto>, Partial<ImageAttachmentMetaDto>> partialBuilder = null)
                => await _connection.RequestResourceAsync<ImageAttachmentMetaDto>("GET", $"api/http/uploads/image/{id}?$fields=" + (partialBuilder != null ? partialBuilder(new Partial<ImageAttachmentMetaDto>()) : new EagerPartial<ImageAttachmentMetaDto>()));            
            
        }
        
    }
    
}
