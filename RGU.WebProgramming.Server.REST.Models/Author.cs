using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace RGU.WebProgramming.Server.REST.Models;

[Table("author")]
public class Author : DbContext
{
    #region Properties

    [System.ComponentModel.DataAnnotations.Key]
    [Column("author_id")]
    [JsonProperty("author_id")]
    public int AuthorId
    {
        get;
        set;
    }
    
    /// <summary>
    /// 
    /// </summary>
    [Column("surname")]
    [JsonProperty("surname")]
    public string Surname
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
        return $"\"Surname\": {Surname}, \"Name\": \"{Name}\", \"AuthorId\": {AuthorId},";
    }

    #endregion
}