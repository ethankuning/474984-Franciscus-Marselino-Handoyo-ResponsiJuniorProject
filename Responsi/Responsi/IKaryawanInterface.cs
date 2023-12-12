using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Responsi
{
    public interface IKaryawanInterface
    {
        public List<Karyawan> getKaryawan();
    }

    public class Responsi : IKaryawanInterface 
    {
        List<Karyawan> getKaryawan()
        {
            List<Karyawan> listKaryawan = new List<Karyawan>();
        }
    }
}
