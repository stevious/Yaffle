using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Yaffle
{
    class CYaffleCore
    {
        private List<CFile> _files = new List<CFile>();

        private string _series;
        private int _season;
        private int _episode;

        public List<CFile> getFiles()
        {
            return _files;
        }

        public int Episode
        {
            get { return _episode; }
            set { _episode = value; }
        }
        
        public int Season
        {
            get { return _season; }
            set { _season = value; }
        }
        
        public string Series
        {
            get { return _series; }
            set { _series = value; }
        }

        private static int compareFilenames(string x, string y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }

        public void addOriginalFile(string filename)
        {
            _files.Add(new CFile(filename));
            update();
        }

        public void update()
        {
            int episode = _episode;

            _files.Sort();
            foreach (CFile file in _files)
            {
                string sourcepath = Path.GetDirectoryName(file.OriginalName);
                string extension = Path.GetExtension(file.OriginalName);
                file.UpdatedName = Path.Combine(sourcepath, _series + " s" + Season.ToString("00") + "e" + episode.ToString("00")  + extension);
                ++episode;                
            }
        }

        public void reset()
        {
            _files.Clear();
        }
    }
}
