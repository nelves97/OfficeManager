using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contabilidad
{
    class DirectoryManager
    {
        String Workspace;

        public DirectoryManager()
        {
            Workspace = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\Contabilidad";
        }

        public void InitialSetup()
        {
            Boolean WorkspaceExists = Directory.Exists(Workspace);
            if (WorkspaceExists) return;

            Directory.CreateDirectory(Workspace + @"\Clientes");
        }

        public void NewClientDirectory(String GUID)
        {
            String ClientPath = Workspace + @"\Clientes\" + GUID;

            Directory.CreateDirectory(ClientPath + @"\Declaraciones");
            Directory.CreateDirectory(ClientPath + @"\DIOT");
            Directory.CreateDirectory(ClientPath + @"\Facturas");
            Directory.CreateDirectory(ClientPath + @"\FIEL");
            Directory.CreateDirectory(ClientPath + @"\Nóminas");
        }

        public void OpenClientDirectory(String GUID)
        {
            Process.Start("explorer", Workspace + @"\Clientes\" + GUID);
        }
    }
}
