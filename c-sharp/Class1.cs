namespace TestLibrary1NE;

using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;

public class Class1
{
  [UnmanagedCallersOnlyAttribute]
  public static IntPtr AddNE(IntPtr a)
  {
    try
    {
      IntPtr add = a;

      return add;
    }
    catch (Exception ex)
    {
      Console.WriteLine("Exception: " + ex.Message);
    }
    return (IntPtr)0;
  }

  [UnmanagedCallersOnlyAttribute]
  public static IntPtr GetGrpcaddressNE(IntPtr ptrAddress) {
    try {
      var strAddress = Marshal.PtrToStringAnsi(ptrAddress);
      var channel = Grpc.Net.Client.GrpcChannel.ForAddress(strAddress);
    } catch (Exception ex) {
      Console.WriteLine("Exception: " + ex.Message);
    }
    return (IntPtr)0;
  }
}
