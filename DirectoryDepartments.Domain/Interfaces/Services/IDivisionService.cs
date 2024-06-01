using DirectoryDepartments.Domain.Dto;
using DirectoryDepartments.Domain.Result;

namespace DirectoryDepartments.Domain.Interfaces.Services
{
    public interface IDivisionService
    {
        BaseResult<DivisionDto> GetDivision(int id);
        CollectionResult<DivisionDto> GetDivisions();
        Task<BaseResult<DivisionDto>> CreateDivisionAsync(DivisionDto division);
        Task<BaseResult<DivisionDto>> UpdateDivisionAsync(DivisionDto division);
        Task<BaseResult<DivisionDto>> DeleteDivisionAsync(int divisionId);
        CollectionResult<DivisionDto> GetAllFlatDivisions(int? checkDivisonId);
    }
}
