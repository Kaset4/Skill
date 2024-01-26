using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YouTubeApp
{
    abstract class Command
    {
        public abstract void Download(string url, string path);
        public abstract void GetInfo(string url);
    }
}
