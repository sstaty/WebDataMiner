using System;
using System.Security.Policy;

namespace WebDataMiner.Services.WebSpider.Search
{
  /// <summary>SearchEngine</summary>
  public abstract class SearchEngine
  {
    protected readonly Url BaseSearchUrl;

    protected abstract String ParameterSeparator { get; }

    protected SearchEngine(Url baseSearchUrl)
    {
      BaseSearchUrl = baseSearchUrl;
    }

    public Url GetBase()
    {
      return BaseSearchUrl;
    }

    public abstract Url GetQuery(String searchString, String siteName);

    public abstract Url AddSearchQuery(String searchQuery, Url toThisUrl);

    public abstract Url AddSite(String siteName, Url toThisUrl);

    protected Url AddStringToUrl(String arbitraryString, Url toThisUrl)
    {
      String extendedUrlString = toThisUrl.Value + ParameterSeparator + arbitraryString;
      return new Url(extendedUrlString);
    }
  }
}
