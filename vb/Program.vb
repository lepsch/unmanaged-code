Imports System
Imports System.Runtime.InteropServices

Module Program
    Private Const DllName As String = "TestLibrary1NE.dll"

    Class Utils
        <DllImport(DllName)>
        Shared Function AddNE(ByVal a As IntPtr) As IntPtr
        End Function

        <DllImport(DllName)>
        Shared Function GetGrpcaddressNE(ByVal a As IntPtr) As IntPtr
        End Function

    End Class

    Sub Main(args As String())
        Console.WriteLine("Hello World!")
        Try
            Dim ptrAddress As IntPtr = Marshal.StringToHGlobalAnsi("txtAddress")
            Dim ptrResponse As IntPtr = Utils.AddNE(ptrAddress)
            Dim strResponse As String = Marshal.PtrToStringAnsi(ptrResponse)
            Utils.GetGrpcaddressNE(ptrAddress)
            Console.WriteLine(strResponse)
        Catch e As EntryPointNotFoundException
            Console.WriteLine(e.ToString())
        End Try
    End Sub
End Module
