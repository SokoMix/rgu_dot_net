using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace RGU.WebProgramming.Server.REST.Models;

[Table("reader")]
public class Reader : DbContext
{
    #region Properties

    [System.ComponentModel.DataAnnotations.Key]
    [Column("reader_id")]
    [JsonProperty("reader_id")]
    public int ReaderId
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
    [Column("birthdate")]
    [JsonProperty("birthdate")]
    public int Birthdate
    {
        get;

        set;
    }
    
    /// <summary>
    /// 
    /// </summary>
    [Column("gender")]
    [JsonProperty("gender")]
    public bool Gender
    {
        get;

        set;
    }
    
    /// <summary>
    /// 
    /// </summary>
    [Column("education_degree")]
    [JsonProperty("education_degree")]
    public bool EducationDegree
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
        return $"\"ReaderId\": \"{ReaderId}\", \"Name\": \"{Name}\", \"Surname\": \"{Surname}\", \"Birthdate\": \"{Birthdate}\", \"Gender\": \"{Gender}\", \"EducationDegree\": \"{EducationDegree}\"";
    }

    #endregion
}