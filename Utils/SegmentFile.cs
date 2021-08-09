using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace propclip_grinding_tracker.Utils
{
    class SegmentFile
    {
        public string Name { get; set; }
        public string FilePath { get; set; }
        public DemoParseResult DemoInfo { get; set; }
        public DateTime AchievementDate { get; set; }
        public SegmentFile(string name, string path, DemoParseResult demoInfo, DateTime achievementDate)
        {
            Name = name;
            FilePath = path;
            DemoInfo = demoInfo;
            AchievementDate = achievementDate;
        }
        public void Copy(string newPath)
        {
            if (!Directory.Exists(newPath))
                return;

            File.Copy(Path.Combine(FilePath, Name + ".sav"), Path.Combine(newPath, Name + ".sav"));
            File.Copy(Path.Combine(FilePath, Name + ".dem"), Path.Combine(newPath, Name + ".dem"));
        }

        public void Remove()
        {
            File.Delete(Path.Combine(FilePath, Name + ".sav"));
            File.Delete(Path.Combine(FilePath, Name + ".dem"));
        }
    }
}
