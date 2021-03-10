using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tv_shows_API.Models;

namespace DataLibrary.Service
{
    public class ShowService
    {
        
        private readonly IMongoCollection<Show> _shows;

        public ShowService(ITvShowsDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _shows = database.GetCollection<Show>(settings.ShowsCollectionName);
        }

        public List<Show> GetAllShows()
        {
            return _shows.Find(show => true).ToList();
        }

        public Show GetOneShow(string id)
        {
            return _shows.Find(show => show.Id == id).FirstOrDefault();
        }

        public void InsertShow(Show show)
        {
            _shows.InsertOne(show);
        }

        public void RemoveShow(string id)
        {
            _shows.DeleteOne(show => show.Id == id);
        }

        public void RemoveShow(Show showIn)
        {
            _shows.DeleteOne(show => show.Id == showIn.Id);
        }

        public void Update(Show showIn)
        {
            _shows.ReplaceOne(show => show.Id == showIn.Id, showIn);
        }

        
    }
}
