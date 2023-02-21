using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioMerger
{
    public static class FileUlti
    {
        public static string GetFileName(string filePath)
        {
            return filePath.Substring(filePath.LastIndexOf("\\") + 1);
        }
    }
}
