using System.Collections.Generic;
using System.Threading.Tasks;
using System.IO;
using System.Text.Json;

namespace MadislolincWeb.Data
{
    public class NewsDataFetcher
    {
        public Task<News[]> GetNewsAsync()
        {

            String datatext = File.ReadAllText("wwwroot/data/News.json");
            News[] news = JsonSerializer.Deserialize<News[]>(datatext);

            return Task.FromResult(Enumerable.Range(0, news.Length).Select(Index => new News
            {
                Title = news[Index].Title,
                ImageName = news[Index].ImageName,
                Story = news[Index].Story
            }
            ).ToArray());
        }

    }
}
