namespace Mission11_Taylor.Models
{
    public class EFBookRepository : IBookRepository
    {
        private BookstoreContext _repo;

        public EFBookRepository(BookstoreContext temp) 
        {
            _repo = temp;
        }

        public IQueryable<Book> Books => _repo.Books;
    }
}
