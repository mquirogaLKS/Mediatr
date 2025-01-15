using MediatrTest.Domain;

namespace MediatrTest.Features.Informa.Repositories
{
    public interface IInformaRepo
    {
        Task Add(Newsletter newsletter);
        Task<IEnumerable<Newsletter>> GetAll();
        Task<Newsletter?> GetById(int id);
    }
}
