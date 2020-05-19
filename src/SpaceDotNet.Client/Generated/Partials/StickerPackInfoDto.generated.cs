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

namespace SpaceDotNet.Client.StickerPackInfoExtensions
{
    public static class StickerPackInfoDtoPartialExtensions
    {
        public static Partial<StickerPackInfoDto> WithId(this Partial<StickerPackInfoDto> it)
            => it.AddFieldName("id");
        
        public static Partial<StickerPackInfoDto> WithName(this Partial<StickerPackInfoDto> it)
            => it.AddFieldName("name");
        
        public static Partial<StickerPackInfoDto> WithFavoriteByDefault(this Partial<StickerPackInfoDto> it)
            => it.AddFieldName("favoriteByDefault");
        
        public static Partial<StickerPackInfoDto> WithArchived(this Partial<StickerPackInfoDto> it)
            => it.AddFieldName("archived");
        
        public static Partial<StickerPackInfoDto> WithPrivate(this Partial<StickerPackInfoDto> it)
            => it.AddFieldName("private");
        
        public static Partial<StickerPackInfoDto> WithAddedAt(this Partial<StickerPackInfoDto> it)
            => it.AddFieldName("addedAt");
        
        public static Partial<StickerPackInfoDto> WithPack(this Partial<StickerPackInfoDto> it)
            => it.AddFieldName("pack");
        
        public static Partial<StickerPackInfoDto> WithPack(this Partial<StickerPackInfoDto> it, Func<Partial<StickerPackInfoDto>, Partial<StickerPackInfoDto>> partialBuilder)
            => it.AddFieldName("pack", partialBuilder(new Partial<StickerPackInfoDto>()));
        
        public static Partial<StickerPackInfoDto> WithStickers(this Partial<StickerPackInfoDto> it)
            => it.AddFieldName("stickers");
        
        public static Partial<StickerPackInfoDto> WithStickers(this Partial<StickerPackInfoDto> it, Func<Partial<StickerDto>, Partial<StickerDto>> partialBuilder)
            => it.AddFieldName("stickers", partialBuilder(new Partial<StickerDto>()));
        
    }
    
}
