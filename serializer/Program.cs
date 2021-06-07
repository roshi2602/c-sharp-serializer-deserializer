using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

//serialization
//object converted into byte to change into database/memory

//import using System.Runtime.Serialization.Formatters.Binary;


[Serializable]                         //serializable attribute
 class Stu          //class to serialize
{
    int roll;
    string name;
     
    public Stu(int roll, string name)
    {
        this.roll = roll;
        this.name = name;
    }
}
public class Program
    {
      public  static void Main()
        {
        //create file stream
        //the data in file is serialized using binary format
        //so create stream object
        FileStream stream = new FileStream("E:\\sss.txt", FileMode.OpenOrCreate);   //use stream for fileStream
        BinaryFormatter formatter = new BinaryFormatter();   //use formatter for converting file to binary

      
        //initializing
        Stu su = new Stu(52, "riya");
        formatter.Serialize(stream, su);        //serializer method to transfer binary data to file

        stream.Close();

        //on running open the file sss.txt , it will have data getting serialized


        //-------------------------------------------------------------------
        // now to read the binary data deserialize it
        //deserialization
        //we use deserialization for checking data is present in file
    /*
    Stu s = (Stu)formatter.Deserialize(stream);
      Console.WriteLine(s.roll);
    Console.WriteLine(s.name);

     stream.Close();
  */    

        
    }
}




