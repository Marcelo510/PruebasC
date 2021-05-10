using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    public class writer : IDisposable
    {
        private string _path;
        private StreamWriter _file;

        public writer(string path)
        {
            _path = path;
            _file = new StreamWriter(path);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public void write(string text)
        {
            _file.WriteLine(text);
        }
    }
}
