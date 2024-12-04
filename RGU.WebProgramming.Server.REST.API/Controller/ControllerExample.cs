using ClassLibrary1;
using DryIoc;
using Microsoft.AspNetCore.Mvc;

using RGU.WebProgramming.Server.REST.Models;

namespace RGU.WebProgramming.Server.REST.API.Controller;

/// <summary>
/// 
/// </summary>
[ApiController]
[Route("api/controller_example")]
[Produces("application/json")]
public sealed class ControllerExample:
    ControllerBase
{
    
    #region Fields
    
    /// <summary>
    /// 
    /// </summary>
    private readonly ILogger<ControllerExample> _logger;

    //private readonly IResolver _resolver;
    
    #endregion
    
    #region Constructors
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="resolver"></param>
    /// <param name="logger"></param>
    /// <exception cref="ArgumentNullException"></exception>
    public ControllerExample(
        //IResolver resolver,
        ILogger<ControllerExample> logger)
    {
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        //_resolver = resolver ?? throw new ArgumentNullException(nameof(resolver));
    }
    
    #endregion
    
    #region API methods
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpGet("method_example_get")]
    public async Task<IActionResult> MethodExampleGetAsync(
        CancellationToken cancellationToken = default)
    {
        try
        {
            _logger.LogInformation($"Got GET request");

            //

            return StatusCode(StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An exception occured");
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="modelExampleInstance"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("method_example_post")]
    public async Task<IActionResult> MethodExamplePostAsync(
        [FromBody] ModelExample modelExampleInstance,
        CancellationToken cancellationToken = default)
    {
        try
        {
            _logger.LogInformation($"Got request body: {modelExampleInstance}");

            //

            return StatusCode(StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "An exception occured");
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="book"></param>
    /// <param name="cancellationToken"></param>
    /// <returns></returns>
    [HttpPost("add_book")]
    public async Task<IActionResult> AddBook(
        [FromBody] Book book,
        CancellationToken cancellationToken = default)
    {
        try
        {
            _logger.LogInformation($"Got request addBook, body: {book}");

            /*await using (var context = _resolver.Resolve<PostgresStorage>())
            {
                await context.Books.AddAsync(book, cancellationToken);
                await context.SaveChangesAsync(cancellationToken);
            }*/
            
            return StatusCode(StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Exception in add book flow, book: {book}");
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpGet("get_books")]
    public async Task<IActionResult> GetBooks(
        CancellationToken cancellationToken = default)
    {
        try
        {
            _logger.LogInformation($"Got request get_books");

            /*await using (var context = _resolver.Resolve<PostgresStorage>())
            {
                var books = context.Books.ToList();
                return Ok(books);
            }*/

            return StatusCode(StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Exception in get_books flow");
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    /*
    [HttpPost("add_publishing")]
    public async Task<IActionResult> AddPublishing(
        [FromBody] Publishing publishing,
        CancellationToken cancellationToken = default)
    {
        try
        {
            _logger.LogInformation($"Got request body: {modelExampleInstance}");

            //

            return StatusCode(StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Exception in add book flow, book: {book}");
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpPost("add_author")]
    public async Task<IActionResult> AddAuthor(
        [FromBody] Author author,
        CancellationToken cancellationToken = default)
    {
        try
        {
            _logger.LogInformation($"Got request body: {modelExampleInstance}");

            //

            return StatusCode(StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Exception in add book flow, book: {book}");
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpDelete("delete_author")]
    public async Task<IActionResult> DeleteAuthor(
        [FromQuery(Name = "author_id")] int authorId,
        CancellationToken cancellationToken = default)
    {
        try
        {
            _logger.LogInformation($"Got request body: {modelExampleInstance}");

            //

            return StatusCode(StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Exception in add book flow, book: {book}");
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpDelete("delete_publishing")]
    public async Task<IActionResult> DeletePublishing(
        [FromQuery(Name = "publishing_id")] int publishingId,
        CancellationToken cancellationToken = default)
    {
        try
        {
            _logger.LogInformation($"Got request body: {modelExampleInstance}");

            //

            return StatusCode(StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, $"Exception in add book flow, book: {book}");
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    } */

    [HttpPost("add_reader")]
    public async Task<IActionResult> AddReader(
        [FromBody] Reader reader,
        CancellationToken cancellationToken = default)
    {
        try
        {
            _logger.LogInformation("fwef");
            return StatusCode(StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpPut("update_reader")]
    public async Task<IActionResult> UpdateReader(
        [FromBody] Reader reader,
        CancellationToken cancellationToken = default)
    {
        try
        {
            _logger.LogInformation("fwef");
            return StatusCode(StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpDelete("delete_reader")]
    public async Task<IActionResult> DeleteReader(
        [FromBody] Reader reader,
        CancellationToken cancellationToken = default)
    {
        try
        {
            _logger.LogInformation("fwef");
            return StatusCode(StatusCodes.Status200OK);
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }

    [HttpPost("request_book")]
    public async Task<IActionResult> RequestBook(
        [FromBody] GiveBook giveBook,
        CancellationToken cancellationToken)
    {
        try
        {
            return StatusCode(StatusCodes.Status200OK);
        }
        catch (Exception e)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpPost("refund_book")]
    public async Task<IActionResult> RefundBook(
        [FromBody] GiveBook giveBook,
        CancellationToken cancellationToken)
    {
        try
        {
            return StatusCode(StatusCodes.Status200OK);
        }
        catch (Exception e)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpGet("all_given_books")]
    public async Task<IActionResult> AllGivenBooks(
        CancellationToken cancellationToken)
    {
        try
        {
            return StatusCode(StatusCodes.Status200OK);
        }
        catch (Exception e)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpGet("all_given_books")]
    public async Task<IActionResult> AllGivenBooksFilter(
        [FromQuery(Name = "reader_id")] string readerId,
        CancellationToken cancellationToken)
    {
        try
        {
            return StatusCode(StatusCodes.Status200OK);
        }
        catch (Exception e)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    [HttpGet("outdated_books")]
    public async Task<IActionResult> OutdatedBooks(
        CancellationToken cancellationToken)
    {
        try
        {
            return StatusCode(StatusCodes.Status200OK);
        }
        catch (Exception e)
        {
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
    
    #endregion
    
}