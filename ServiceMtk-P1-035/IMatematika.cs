using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ServiceMtk_P1_035
{
    //Tambahkan kelas berikut
    [DataContract]
    class MathFault
    { [DataMember]
      public string Kode { get; set; }
       
        [DataMember]
      public string Pesan { get; set; }
        
    }
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IMatematika
    {
        [OperationContract]
        /* output->*/
        [FaultContract(typeof(MathFault))]//membuat kelas yang belum yang melambangkan exception
        int Tambah(int a, int b); //method
        [OperationContract]
        [FaultContract(typeof(MathFault))]//membuat kelas yang belum yang melambangkan exception
        int Kurang(int a, int b); //input
        [OperationContract]
        [FaultContract(typeof(MathFault))]//membuat kelas yang belum yang melambangkan exception
        int Kali(int a, int b);
        [OperationContract]
        [FaultContract(typeof(MathFault))]//membuat kelas yang belum yang melambangkan exception
        int Bagi(int a, int b);
        [OperationContract]
        [FaultContract(typeof(MathFault))]//membuat kelas yang belum yang melambangkan exception
        Koordinat TKoordinat(Koordinat a, Koordinat b); //object dari class
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "ServiceMtk_P2_040.ContractType".
    [DataContract]
    public class Koordinat
    {
        private int _x, _y; //atribut
        [DataMember]//membuka koordinat, x,y
        public int X //properties
        {
            get { return _x; }
            set { _x = value; }
        }
        [DataMember]
        public int Y //properties
        {
            get { return _y; }
            set { _y = value; }
        }
    }
}
