using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LB210.Pages
{
    public class IndexModel : PageModel
    {
        public IndexModel()
        {
        }

        public void OnGet()
        {
            ViewData["Joke"] = Jokes.Get(GetJokeId());
        }
        public int GetJokeId()
        {
            try
            {
                int? jokeId = HttpContext.Session.GetInt32("JokeId");
                if (jokeId == null)
                {
                    jokeId = Random.Shared.Next(0, Jokes.Count);
                    HttpContext.Session.SetInt32("JokeId", (int)jokeId);
                }
                return (int)jokeId;
            }
            catch
            {
                return Random.Shared.Next(0, Jokes.Count);
            }

        }
    }
}