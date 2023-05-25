using MvcMovie.Data;

namespace MvcMovie.Models
{
    public class CrudMovie
    {
        public CrudMovie() { }

        public async static Task SaveContext(MvcMovieContext context)
        {
            await context.SaveChangesAsync();
        }
    }
}
