using FindECD.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FindECD.Services
{
    public class Location : ILocation
    {
        List<LocationModel> myData;

        public Location()
        {
            myData = new List<LocationModel>();

            myData.Add(new LocationModel { ECDName = "Curro Castle Langebaan", Description = "ECD Partial Care.", Id = 0, Latiute = 725.4655, Longitute = 722.566, ImageUrl= "https://film.codedwap.com/download/umzi-watsha-abantwana-iingoma-iziqulatho-kwimfundo-yasesikolweni-isixhosa-nursery-rhymes/LS1BaC02N0tJdHV2OA" });
            myData.Add(new LocationModel { ECDName = "3 Bears Educare", Description = "ECD Partial Care .", Id = 1, Latiute = 825.4655, Longitute = 852.566, ImageUrl = "https://film.codedwap.com/download/umzimba-the-human-body-isizulu/LS0zUkhVX0NXR2ItSQ" });
            myData.Add(new LocationModel { ECDName = "101 Dalmations Educare", Description = "EDUCARE.......", Id = 3, Latiute = 950.4655, Longitute = 632.566, ImageUrl = "https://film.codedwap.com/download/umizi-washa-african-nursery-rhymes-isizulu-zulu-kids-songs-london-bridge-in-zulu-african/LS0yUnRwWHAzLXotcw" });

        }
        public async Task<List<LocationModel>> getlocations()
        {
            return await Task.FromResult(myData);
        }

        Task<List<LocationModel>> ILocation.getlocations()
        {
            throw new NotImplementedException();
        }
    }
}

