using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace RGU.WebProgramming.Server.REST.Models;

[Table("publishing")]
public class Publishing : DbContext
{
    #region Properties

    [System.ComponentModel.DataAnnotations.Key]
    [Column("publishing_id")]
    [JsonProperty("publishing_id")]
    public int PublishingId
    {
        get;
        set;
    }
    
    /// <summary>
    /// 
    /// </summary>
    [Column("name")]
    [JsonProperty("name")]
    public string Name
    {
        get;

        set;
    }
    
    #endregion
    
    #region System.Object overrides
    
    /// <summary>
    /// 
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return $"\"Name\": \"{Name}\", \"PublishingId\": \"{PublishingId}\"";
    }

    #endregion
}