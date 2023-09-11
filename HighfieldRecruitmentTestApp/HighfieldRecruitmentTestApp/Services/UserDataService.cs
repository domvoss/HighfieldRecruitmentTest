using HighfieldRecruitmentTestApp.Models;

namespace HighfieldRecruitmentTestApp.Services
{
    public class UserDataService : IUserDataService
    {
        public List<AgeDataModel> ProcessAgeData(List<UserDataModel> userDataList)
        {
            List<AgeDataModel> ageDataList = new List<AgeDataModel>();

            foreach (var userData in userDataList)
            {
                ageDataList.Add(new AgeDataModel
                {
                    id = userData.id,
                    firstName = userData.firstName,
                    lastName = userData.lastName,
                    dob = DateTime.Parse(userData.dob).AddYears(20).ToString("yyyy-MM-dd'T'HH:mm:ss"),
                });
            }
            return ageDataList;
        }

        public List<ColourDataModel> ProcessColourData(List<UserDataModel> userDataList)
        {
            List<ColourDataModel> colourData = new List<ColourDataModel>();

            foreach (var data in userDataList.GroupBy(userData => userData.favouriteColour).Select(g => new
            {
                colour = g.Key,
                count = g.Count()
            }).OrderByDescending(newgroup => newgroup.count))
            {
                colourData.Add(new ColourDataModel
                {
                    ColourName = data.colour,
                    Quantity = data.count
                });
            }

            return colourData;
        }
    }
}
