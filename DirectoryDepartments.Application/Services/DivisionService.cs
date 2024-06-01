using DirectoryDepartments.Domain.Dto;
using DirectoryDepartments.Domain.Interfaces.Repositories;
using DirectoryDepartments.Domain.Interfaces.Services;
using DirectoryDepartments.Domain.Result;

namespace DirectoryDepartments.Application.Services
{
    public class DivisionService : IDivisionService
    {
        private readonly IDivisionRepository _divisionRepository;
        public DivisionService(IDivisionRepository divisionRepository)
        {
            _divisionRepository = divisionRepository;
        }
        public Task<BaseResult<DivisionDto>> CreateDivisionAsync(DivisionDto division)
        {
            throw new NotImplementedException();
        }

        public Task<BaseResult<DivisionDto>> DeleteDivisionAsync(int divisionId)
        {
            throw new NotImplementedException();
        }

        public CollectionResult<DivisionDto> GetAllFlatDivisions(int? checkDivisonId)
        {
            throw new NotImplementedException();
        }

        public BaseResult<DivisionDto> GetDivision(int id)
        {
            throw new NotImplementedException();
        }

        public CollectionResult<DivisionDto> GetDivisions()
        {
            throw new NotImplementedException();
        }

        public Task<BaseResult<DivisionDto>> UpdateDivisionAsync(DivisionDto division)
        {
            throw new NotImplementedException();
        }
    }
}
