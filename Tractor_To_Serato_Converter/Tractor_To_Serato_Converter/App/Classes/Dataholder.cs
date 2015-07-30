using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tractor_To_Serato_Converter.App.Classes
{
    class Dataholder
    {
        private String TraktorInputFilePath = null;
        private String SeratoOutputFilePath = null;
        
        public void SetTraktorInputFile(String _FilePath)
        {
            this.TraktorInputFilePath = _FilePath;
        }

        public String GetTraktorInputFilePath()
        {
            return this.TraktorInputFilePath;
        }
    }
}
