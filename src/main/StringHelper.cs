using System;
using System.Runtime.InteropServices;
using System.Text;

namespace NWN.Native.API
{
  /// <summary>
  /// Helper utilities for converting between native and managed strings.
  /// </summary>
  public static unsafe class StringHelper
  {
    /// <summary>
    /// Gets or sets the encoding to use for native/managed string conversion.<br/>
    /// Defaults to windows-1252.
    /// </summary>
    public static Encoding Encoding { get; set; }

    static StringHelper()
    {
      Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
      Encoding = Encoding.GetEncoding("windows-1252");
    }

    /// <summary>
    /// Copies the specified C# string and allocates a null-terminated string in unmanaged memory with cp1252 encoding.
    /// </summary>
    /// <param name="value">The managed string to encode.</param>
    /// <returns>The pointer to the unmanaged char array.</returns>
    public static byte* GetNullTerminatedString(this string value)
    {
      byte[] bytes = Encoding.GetBytes(value);
      IntPtr buffer = Marshal.AllocHGlobal(bytes.Length + 1);
      Marshal.Copy(bytes, 0, buffer, bytes.Length);

      // Write null terminator
      Marshal.WriteByte(buffer + bytes.Length, 0);
      return (byte*)buffer;
    }

    /// <summary>
    /// Copies the specified C# string and allocates a string in unmanaged memory with cp1252 encoding.
    /// </summary>
    /// <param name="value">The managed string to encode.</param>
    /// <param name="length">The max length of the string. If specified, and the specified string is smaller than the length, it will be null terminated.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the string value is larger than the length.</exception>
    /// <returns>The pointer to the unmanaged char array.</returns>
    public static byte* GetFixedLengthString(this string value, int? length = null)
    {
      if (length.HasValue)
      {
        if (value.Length > length)
        {
          throw new ArgumentOutOfRangeException(nameof(value), "value must be smaller than length.");
        }

        if (value.Length < length)
        {
          return GetNullTerminatedString(value);
        }
      }

      byte[] bytes = Encoding.GetBytes(value);
      IntPtr buffer = Marshal.AllocHGlobal(bytes.Length);
      Marshal.Copy(bytes, 0, buffer, bytes.Length);

      return (byte*)buffer;
    }

    /// <summary>
    /// Copies the specified C# string into a native array with cp1252 encoding.
    /// </summary>
    /// <param name="nativeArray">The array to be written to.</param>
    /// <param name="value">The new string value.</param>
    /// <exception cref="ArgumentOutOfRangeException">Thrown if the length of the string exceeds the length of the array.</exception>
    public static void WriteFixedLengthString(this NativeArray<byte> nativeArray, string value)
    {
      byte[] bytes = Encoding.GetBytes(value);
      if (bytes.Length > nativeArray.Length)
      {
        throw new ArgumentOutOfRangeException(nameof(value), "The length of the string exceeds the length of the array.");
      }

      Marshal.Copy(bytes, 0, (IntPtr)nativeArray.Pointer, bytes.Length);

      if (bytes.Length < nativeArray.Length - 1)
      {
        // Write null terminator
        Marshal.WriteByte((IntPtr)(nativeArray.Pointer + bytes.Length), 0);
      }
    }

    /// <summary>
    /// Reads a null-terminated string from the specified pointer with cp1252 encoding.
    /// </summary>
    /// <param name="cString">A pointer to a C string.</param>
    /// <returns>The converted managed string.</returns>
    public static string ReadNullTerminatedString(byte* cString)
    {
      return Encoding.GetString(cString, GetStringLength(cString));
    }

    /// <inheritdoc cref="ReadNullTerminatedString(byte*)"/>
    public static string ReadNullTerminatedString(this IntPtr cString)
    {
      return ReadNullTerminatedString((byte*)cString);
    }

    /// <summary>
    /// Reads a string from the specified pointer with the specified length with cp1252 encoding.
    /// </summary>
    /// <param name="cString">A pointer to a C string.</param>
    /// <param name="length">The length of the string.</param>
    /// <returns>The converted managed string.</returns>
    public static string ReadFixedLengthString(byte* cString, int length)
    {
      return Encoding.GetString(cString, GetStringLength(cString, length));
    }

    /// <summary>
    /// Reads a string from the specified array structure with cp1252 encoding.
    /// </summary>
    /// <param name="cString">A native array structure of a fixed sizedC string.</param>
    /// <returns>The converted managed string.</returns>
    public static string ReadFixedLengthString(this NativeArray<byte> cString)
    {
      return ReadFixedLengthString(cString.Pointer, cString.Length);
    }

    public static int GetStringLength(byte* cString, int? maxLength = null)
    {
      byte* walk = cString;
      while (*walk != 0 && (maxLength == null || walk - cString < maxLength))
      {
        walk++;
      }

      return (int)(walk - cString);
    }
  }
}
