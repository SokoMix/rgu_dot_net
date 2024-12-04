using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace RGU.WebProgramming.Server.REST.Models;

/// <summary>
/// 
/// </summary>
[Table("book")]
public class Book : DbContext
{
    
    #region Properties

    [System.ComponentModel.DataAnnotations.Key]
    [Column("book_id")]
    [JsonProperty("book_id")]
    public int BookId
    {
        get; set;
    }
    
    /// <summary>
    /// 
    /// </summary>
    [Column("author_ids")]
    [JsonProperty("author_ids")]
    public List<int> AuthorIds
    {
        get;

        set;
    }

    /// <summary>
    /// 
    /// </summary>
    [Column("publishing_id")]
    [JsonProperty("publishing_id")]
    public int PublishingId
    {
        set;

        get;
    }
    
    /// <summary>
    /// 
    /// </summary>
    [Column("publish_info")]
    [JsonProperty("publish_info")]
    public string PublishingInfo
    {
        set;

        get;
    }
    
    /// <summary>
    /// 
    /// </summary>
    [Column("publishing_year")]
    [JsonProperty("publishing_year")]
    public int PublishingYear
    {
        set;

        get;
    }
    
    /// <summary>
    /// 
    /// </summary>
    [Column("address")]
    [JsonProperty("address")]
    public string Address
    {
        set;

        get;
    }
    
    #endregion
    
    #region System.Object overrides

    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"\"AuthorIds\": {AuthorIds}, \"Publishing\": \"{PublishingId}\", \"PublishingInfo\": {PublishingInfo}, \"PublishingYear\": {PublishingYear}, \"Address\": {Address}";
    }

    #endregion
}