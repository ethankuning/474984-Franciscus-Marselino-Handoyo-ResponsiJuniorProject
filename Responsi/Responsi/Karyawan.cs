using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    internal class Karyawan
    {
        private string _id_karyawan;
        private string _name;
        private int _id_dep;

        public string IdKaryawan { get { return _id_karyawan; } set { } }
        public string Name { get { return _name; } set { } }
        public int IdDep { get { return _id_dep; } set { } }


        public Karyawan(string id_karyawan, string name, int id_dep) 
        { 
            this._id_karyawan = id_karyawan;
            this._name = name;
            this._id_dep = id_dep;
        }
    }
}
