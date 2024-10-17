using AwesymeGym.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeGym.Infrastructure.Services
{
    public class AzureFileStorageService : IFileStorageService
    {
        public Task AddFile(byte[] content, string fileName)
        {
            throw new NotImplementedException();
        }
    }
}


