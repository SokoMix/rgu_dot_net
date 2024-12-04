using RGU.WebProgramming.Server.REST.Models;

namespace RGU.WebProgramming.Server.Core;

public interface IStorage
{

    void addBook(Book book, CancellationToken cancellationToken = default);
    List<Book> getBooks(CancellationToken cancellationToken = default);
    void addPublishing(Publishing publishing, CancellationToken cancellationToken = default);
    void deletePublishing(int publishingId, CancellationToken cancellationToken = default);
    void addAuthor(Author author, CancellationToken cancellationToken = default);
    void deleteAuthor(int authorId, CancellationToken cancellationToken = default);
    void addReader(Reader reader, CancellationToken cancellationToken = default);
    void updateReader(Reader reader, CancellationToken cancellationToken = default);
    void deleteReader(int readerId, CancellationToken cancellationToken = default);
    void addGiveBook(GiveBook giveBook, CancellationToken cancellationToken = default);
    void addRefundBook(int giveBookId, CancellationToken cancellationToken = default);
    List<Book> getGivenBooks(int? readerId, CancellationToken cancellationToken = default);
    List<Book> getOutdatedBooks(CancellationToken cancellationToken = default);

}