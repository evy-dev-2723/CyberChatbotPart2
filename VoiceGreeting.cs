using System;
using System.IO;
using System.Media;

namespace CyberBotPart2
{
    public class VoiceGreeting
    {
        public void PlayGreeting()
        {
            try
            {
                // Try multiple possible paths
                string[] possiblePaths = {
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "audio", "greeting.wav.wav"),
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "greeting.wav.wav"),
                    @"C:\Users\PC\OneDrive\Documents\CyberBotPart2\audio\greeting.wav.wav",
                    @"C:\Users\PC\OneDrive\Documents\CyberBotPart2\bin\Debug\net10.0\audio\greeting.wav.wav"
                };

                foreach (string audioPath in possiblePaths)
                {
                    if (File.Exists(audioPath))
                    {
                        using (SoundPlayer player = new SoundPlayer(audioPath))
                        {
                            player.PlaySync();
                        }
                        Console.WriteLine("Audio played successfully");
                        return;
                    }
                }

                // If no audio file found, create a beep as fallback
                Console.Beep(1000, 500);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Audio error: {ex.Message}");
            }
        }
    }
}