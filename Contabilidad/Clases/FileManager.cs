using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad
{
    class FileManager
    {
        String Workspace;

        public FileManager()
        {
            Workspace = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Contabilidad";
        }
    }
}
