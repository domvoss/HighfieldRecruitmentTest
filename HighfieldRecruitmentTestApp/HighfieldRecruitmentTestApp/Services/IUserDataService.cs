using HighfieldRecruitmentTestApp.Models;

namespace HighfieldRecruitmentTestApp.Services
{
    public interface IUserDataService
    {
        List<AgeDataModel> ProcessAgeData(List<UserDataModel> userDataList);
        List<ColourDataModel> ProcessColourData(List<UserDataModel> userDataList);
    }
}