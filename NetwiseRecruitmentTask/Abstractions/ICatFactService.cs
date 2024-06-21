using NetwiseRecruitmentTask.Models;

namespace NetwiseRecruitmentTask.Abstractions;

public interface ICatFactService
{
    Task<CatFactModel> GetCatFactAsync();
}