using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockSize
{
    public class Reporter
    {
        public Action<string> Total_Files;
        public Action<string> Mean_File_Size;
        public Action<string> Median_File_Size;
        public Action<string> Best_Block_File_Size;
        public Action<string> Update_Status;

        private string Path;
        private List<long> File_Sizes;
        private DateTime Start_Time;
        private DateTime Last_Update_Time;
        public Reporter(string path)
        {
            Path = path;
            File_Sizes = new List<long>();
        }
        public bool Start()
        {
            System.IO.DirectoryInfo dir;
            try
            {
                dir = new System.IO.DirectoryInfo(Path);

            }
            catch (Exception e)
            {
                Update_Status(e.Message);
                return false;
            }
            Last_Update_Time = Start_Time = DateTime.Now;
            Gather_File_Sizes(dir);
            UpdateUI(true);
            Update_Status("Finished scan in " + (DateTime.Now - Start_Time).TotalSeconds + " seconds . . .");
            return true;
        }
        private void Gather_File_Sizes(System.IO.DirectoryInfo dir)
        {
            UpdateUI();
            try
            {
                foreach (var item in dir.EnumerateDirectories())
                {
                    Gather_File_Sizes(item);
                }
                File_Sizes.AddRange(dir.EnumerateFiles().Select(a => a.Length));
            }
            catch (Exception e)
            {
                Update_Status(e.Message);
            }
        }
        private void UpdateUI(bool forceupdate = false)
        {
            var totalseconds = (DateTime.Now - Last_Update_Time).TotalSeconds;
            if (totalseconds > 1.0 || forceupdate)
            {
                Last_Update_Time = DateTime.Now;
                var totalfiles = (long)File_Sizes.Count;
                Total_Files(totalfiles.ToString());
                var filesizesum = File_Sizes.Sum(a => a) / totalfiles;
                Mean_File_Size(filesizesum.ToString());
                var r = File_Sizes.OrderBy(a => a).ElementAt((int)(totalfiles / 2));
                Median_File_Size(r.ToString());
                var median = smaller_pow2(r);
                Best_Block_File_Size(median.ToString());
            }
        }
        long smaller_pow2(long n)
        {
            long x = 1;
            while (x < n) x *= 2;
            if (x > 1) x /= 2;
            return x;
        } 
    }
}
