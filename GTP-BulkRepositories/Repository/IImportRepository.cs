using System.Collections.Generic;
using System.Threading.Tasks;

namespace GTP_BulkRepositories
{
    public interface IImportRepository
    {
        Task ImportExcel(Queue<DriverVM> listModel);
    }
}
