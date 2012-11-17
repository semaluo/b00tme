using System;
using System.Text;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace B00tme
{
    //I took this class from the OpenSuSe Imagewriter project and edited some, sorry for the shameless stealing, but it was so convenient! :(
    public class DriveAccess
    {
        public const uint FSCTL_LOCK_VOLUME = 0x00090018;
        public const uint FSCTL_UNLOCK_VOLUME = 0x0009001C;
        public const uint FSCTL_DISMOUNT_VOLUME = 0x00090020;
        const uint GENERIC_READ = 0x80000000;
        const uint GENERIC_WRITE = 0x40000000;
        const uint FILE_FLAG_NO_BUFFERING = 0x20000000;
        const uint FILE_FLAG_WRITE_THROUGH = 0x80000000;
        const uint OPEN_EXISTING = 3;
        System.IntPtr handle;

        public void Open(string fileName)
        {
            handle = CreateFile
            (
                fileName,
                GENERIC_WRITE, // Need write access
                0,  // Don't let other processes touch the device
                0,  // Security attributes, ignore
                OPEN_EXISTING,
                FILE_FLAG_NO_BUFFERING | FILE_FLAG_WRITE_THROUGH, // Flags - TODO: do we want to disable buffering?
                0 // Template file, ignore
            );

            if (handle.ToInt32() == -1)
                throw new Win32Exception(Marshal.GetLastWin32Error());
        }

        public bool Close()
        {
            return CloseHandle(handle);
        }

        public unsafe uint Write(byte[] buffer, uint len)
        {
            uint written = 0;
            if (!WriteFile(handle, buffer, len, ref written, IntPtr.Zero))
                throw new Win32Exception(Marshal.GetLastWin32Error());

            return written;
        }

        public int DeviceIO(uint accessType)
        {
            int ret;
            uint bytesReturned = 0;
            ret = DeviceIoControl
            (
                handle,
                accessType,
                IntPtr.Zero,
                0,
                IntPtr.Zero,
                0,
                ref bytesReturned,
                IntPtr.Zero
            );
            if (ret == 0)
                throw new Win32Exception(Marshal.GetLastWin32Error());
            return ret;
        }

        // Win32 wrappers
        [DllImport("kernel32", SetLastError = true)]
        static extern unsafe IntPtr CreateFile
        (
            string lpFileName,
            uint dwDesiredAccess,
            uint dwShareMode,
            uint lpSecurityAttributes,
            uint dwCreationDisposition,
            uint dwFlagsAndAttributes,
            int hTemplateFile
        );

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern unsafe bool WriteFile
        (
            IntPtr hFile,
            Byte[] lpBuffer,
            UInt32 nNumberOfBytesToWrite,
            ref UInt32 lpNumberOfBytesWritten,
            IntPtr lpOverlapped
        );

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern unsafe int DeviceIoControl
        (
            IntPtr hDevice,
            uint IoControlCode,
            IntPtr lpInBuffer,
            uint InBufferSize,
            IntPtr lpOutBuffer,
            uint nOutBufferSize,
            ref uint lpBytesReturned,
            IntPtr lpOverlapped
        );

        [DllImport("kernel32", SetLastError = true)]
        static extern unsafe bool CloseHandle(IntPtr hObject);
    }
}
