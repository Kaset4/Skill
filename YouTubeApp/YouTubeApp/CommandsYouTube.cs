using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoLibrary;

namespace YouTubeApp
{
    class CommandsYouTube : Command
    {
        public override void Download(string url, string path)
        {
            Console.WriteLine("Начало скачивание видео...");
            try
            {
                var youtube = YouTube.Default;
                var video = youtube.GetVideo(url);
                File.WriteAllBytes(path + video.FullName, video.GetBytes());
                Console.WriteLine("Видео успешно скачано.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при скачивании видео: {ex.Message}");
            }
            
        }

        public override void GetInfo(string url)
        {
            Console.WriteLine("Получение информации...");
            try
            {
                var youtube = YouTube.Default;
                var video = youtube.GetVideo(url);
                Console.WriteLine($"Полноме наименование видео: {video.FullName} \nАвтор: {video.Info.Author}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка при получении информации: {ex.Message}");
            }
            
        }
    }
}
