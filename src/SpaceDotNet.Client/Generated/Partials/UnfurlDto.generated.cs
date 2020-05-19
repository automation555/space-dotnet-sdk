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

namespace SpaceDotNet.Client.UnfurlExtensions
{
    public static class UnfurlDtoPartialExtensions
    {
        public static Partial<UnfurlDto> WithTitle(this Partial<UnfurlDto> it)
            => it.AddFieldName("title");
        
        public static Partial<UnfurlDto> WithLink(this Partial<UnfurlDto> it)
            => it.AddFieldName("link");
        
        public static Partial<UnfurlDto> WithText(this Partial<UnfurlDto> it)
            => it.AddFieldName("text");
        
        public static Partial<UnfurlDto> WithDetails(this Partial<UnfurlDto> it)
            => it.AddFieldName("details");
        
        public static Partial<UnfurlDto> WithDetails(this Partial<UnfurlDto> it, Func<Partial<UnfurlDetailsDto>, Partial<UnfurlDetailsDto>> partialBuilder)
            => it.AddFieldName("details", partialBuilder(new Partial<UnfurlDetailsDto>()));
        
        public static Partial<UnfurlDto> WithSitename(this Partial<UnfurlDto> it)
            => it.AddFieldName("sitename");
        
        public static Partial<UnfurlDto> WithImage(this Partial<UnfurlDto> it)
            => it.AddFieldName("image");
        
        public static Partial<UnfurlDto> WithImageMime(this Partial<UnfurlDto> it)
            => it.AddFieldName("imageMime");
        
        public static Partial<UnfurlDto> WithImageWidth(this Partial<UnfurlDto> it)
            => it.AddFieldName("imageWidth");
        
        public static Partial<UnfurlDto> WithImageHeight(this Partial<UnfurlDto> it)
            => it.AddFieldName("imageHeight");
        
        public static Partial<UnfurlDto> WithVideo(this Partial<UnfurlDto> it)
            => it.AddFieldName("video");
        
        public static Partial<UnfurlDto> WithVideoIFrame(this Partial<UnfurlDto> it)
            => it.AddFieldName("videoIFrame");
        
        public static Partial<UnfurlDto> WithVideoMime(this Partial<UnfurlDto> it)
            => it.AddFieldName("videoMime");
        
        public static Partial<UnfurlDto> WithVideoHeight(this Partial<UnfurlDto> it)
            => it.AddFieldName("videoHeight");
        
        public static Partial<UnfurlDto> WithVideoWidth(this Partial<UnfurlDto> it)
            => it.AddFieldName("videoWidth");
        
        public static Partial<UnfurlDto> WithFavicon(this Partial<UnfurlDto> it)
            => it.AddFieldName("favicon");
        
    }
    
}
