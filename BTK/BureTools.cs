using System;

namespace BureTools
{
    /// <summary>
    /// Unity style printer and supports filling your memory :D
    /// </summary>
    public static class Debug
    {
        public static void Log(dynamic s)
        {
            Console.WriteLine(s.ToString());
        }
        public static void Log(string s)
        {
            Console.WriteLine(s);
        }
        public static void Info(string content, string tag = "Info")
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"  {tag}  ");
            Console.ResetColor();
            Console.WriteLine("| " + content);
        }
        
        public static void Info(dynamic content, string tag = "Info")
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"  {tag}  ");
            Console.ResetColor();
            Console.WriteLine("| " + content);
        }

        public static void Logs(this string s)
        {
            Console.WriteLine(s);
        }
        public static void Log<T>(this T s)
        {
            Console.WriteLine(s.ToString());
        }
        public static void Infos(this string s, string tag = "Info")
        {
            Info(s, tag);
        }
        public static void Info<T>(this T t)
        {
            Info(t.ToString(),t.GetType().Name);
        }

        //public static void Info<T>(this T t,string tag = "",string content = "")
        //{
        //    if(content != string.Empty) Info(content, t.GetType().Name);
        //    else if(tag != string.Empty) Info(t.ToString(), tag);
        //    else if(tag != string.Empty && content != string.Empty) Info(content, tag);
        //    else Info(t.ToString(), t.GetType().Name);
        //}
    }

    public static class ExtensionUtil
    {
        /// <summary>
        /// 如果集合为null，则改为空的Enumerable
        /// </summary>
        /// <returns>空的Enumerable</returns>
        public static IEnumerable<T> AsNullable<T>(this IEnumerable<T> source)
        {
            return source ?? Enumerable.Empty<T>();
        }
    }
}