using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPractice.Tests
{
    public abstract class TestBase
    {
        protected Queue<string> GetFileContent(string relativePath)
        {
            var directory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            var fileName = Path.Combine(directory, relativePath);

            var q = new Queue<string>();
            using (var sr = new StreamReader(fileName))
            {
                var s = "";
                while ((s = sr.ReadLine()) != null)
                    q.Enqueue(s);
            }

            return q;
        }
    }
}
