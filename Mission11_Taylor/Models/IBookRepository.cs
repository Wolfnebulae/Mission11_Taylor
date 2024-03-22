namespace Mission11_Taylor.Models
{
    public interface IBookRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
