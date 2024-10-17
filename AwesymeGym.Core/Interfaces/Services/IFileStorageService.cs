using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesymeGym.Core.Interfaces.Services
{
    public interface IFileStorageService
    {
        Task AddFile(byte[] content, string fileName);
    }
}
