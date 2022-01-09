using SubtitleLib;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubtitleLib
{
    public class SrtIO
    {
        public static string ReadSrt(string subtitlePath)
        {
            try
            {
                string subtitle = File.ReadAllText(subtitlePath, Encoding.Default);
                return subtitle;
            }
            catch (IOException e)
            {
                Console.WriteLine("There was an error reading the file, returned a void string");
                Console.WriteLine(e.Message);
                return "";
            }
        }

        public static void WriteSrt(ArrayList subtitles, string filename)
        {
            using (StreamWriter output = new StreamWriter($"{filename}.srt", false, Encoding.Default))
            {
                foreach (SubtitleBlock block in subtitles)
                {
                    output.Write(block.ToString());
                }
            }
            Console.WriteLine($"File \"{filename}.srt\" created successfully");
        }
    }
}
