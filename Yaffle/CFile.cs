using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yaffle
{
    public class CFile:IComparable<CFile>
    {
        private string _originalName;
        private string _updatedName;

        public CFile(string filename)
        {
            _originalName = filename;
        }

        public string OriginalName
        {
            get
            {
                return _originalName;
            }
            set
            {
                _originalName = value;
            }
        }

        public string UpdatedName
        {
            get
            {
                return _updatedName;
            }
            set
            {
                _updatedName = value;
            }
        }

        public int CompareTo(CFile other)
        {
            return this._originalName.CompareTo(other._originalName);
        }
    }
}
