using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace RGU.WebProgramming.Server.REST.Models;

[Table("give_book")]
public class GiveBook : DbContext
{
    #region Properties

    [System.ComponentModel.DataAnnotations.Key]
    [Column("give_book_id")]
    [JsonProperty("give_book_id")]
    public int GiveBookId
    {
        get; set;
    }

    /// <summary>
    /// 
    /// </summary>
    [Column("book_id")]
    [JsonProperty("book_id")]
    public int BookId
    {
        get;
        set;
    }

    /// <summary>
    /// 
    /// </summary>
    [Column("give_date")]
    [JsonProperty("give_date")]
    public int GiveDate
    {
        get;
        set;
    }

    /// <summary>
    /// 
    /// </summary>
    [Column("awaiting_receive_date")]
    [JsonProperty("awaiting_receive_date")]
    public int AwaitingReceiveDate
    {
        get;
        set;
    }

    /// <summary>
    /// 
    /// </summary>
    [Column("receive_date")]
    [JsonProperty("receive_date")]
    public int ReceiveDate
    {
        get;
        set;
    }

    /// <summary>
    /// Stores id of reader, who took the book
    /// </summary>
    [Column("reader_id")]
    [JsonProperty("reader_id")]
    public int ReaderId
    {
        get;
        set;
    }

    #endregion

    #region System.Object overrides

    public override string ToString()
    {
        return $"\"BookId\": {BookId}, \"GiveDate\": \"{GiveDate}\", \"AwaitingReceiveDate\": {AwaitingReceiveDate}, \"ReceiveDate\": {ReceiveDate}, \"GiveBookId\": {GiveBookId}";
    }

    #endregion
    
}