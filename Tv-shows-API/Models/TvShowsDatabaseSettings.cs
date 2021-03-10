using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tv_shows_API.Models
{
    public interface ITvShowsDatabaseSettings
    {
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
        string ShowsCollectionName { get; set; }
    }

    public class TvShowsDatabaseSettings : ITvShowsDatabaseSettings
    {
        public string ShowsCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}
