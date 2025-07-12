// ╔═══════════════════════════════════╗
// ║   .*.*. Created by ChienNV .*.*.  ║
// ╚═══════════════════════════════════╝
using System.Text;
namespace Extension.Share.Helpers;

public static class IdHelper
{
    public static string NewId()
    {
        return Guid.NewGuid().ToString("N");
    }

    public static string GeneratePassword(int length = 8,
                                      bool useLower = true,
                                      bool useUpper = true,
                                      bool useDigits = true,
                                      bool useSpecial = false)
    {
        const string LOWER = "abcdefghijklmnopqrstuvwxyz";
        const string UPPER = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        const string DIGITS = "0123456789";
        const string SPECIAL = "!@#$%^&*()-_=+[]{};:,.<>?";

        var charPool = new StringBuilder();
        if (useLower) charPool.Append(LOWER);
        if (useUpper) charPool.Append(UPPER);
        if (useDigits) charPool.Append(DIGITS);
        if (useSpecial) charPool.Append(SPECIAL);

        if (charPool.Length == 0)
            throw new ArgumentException("Phải chọn ít nhất một loại ký tự!");

        var password = new StringBuilder();
        var rnd = new Random();

        for (int i = 0; i < length; i++)
        {
            int index = rnd.Next(charPool.Length);
            password.Append(charPool[index]);
        }

        return password.ToString();
    }
}
