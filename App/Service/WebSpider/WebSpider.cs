using WebDataMiner.Services.WebSpider.Search;

namespace WebDataMiner.Services.WebSpider
{
  class WebSpider
  {
    private readonly SearchEngine _searchEngine;

    public WebSpider(SearchEngine searchEngine)
    {
      _searchEngine = searchEngine;
    }

    public static WebSpider WithDuckDuckGoSearch()
    {
      return new WebSpider(new DuckDuckGoSearch());
    }
  }
}
