using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class DataSets
    {
        public DataSets()
        {
            EnterModels();
        }

        public List<string> MvxModels = new List<string>();
        
        void EnterModels()
        {                                           // Index
            MvxModels.Add("DM-VVX-350");            // 0
            MvxModels.Add("DM-VVX-350C");           // 1
            MvxModels.Add("DM-VVX-351");            // 2
            MvxModels.Add("DM-VVX-351C");           // 3
            MvxModels.Add("DM-VVX-352");            // 4
            MvxModels.Add("DM-VVX-352C");           // 5
            MvxModels.Add("DM-VVX-360");            // 6
            MvxModels.Add("DM-VVX-360C");           // 7
            MvxModels.Add("DM-VVX-363");            // 8
            MvxModels.Add("DM-VVX-363C");           // 9
            MvxModels.Add("DM-VVX-E760");           // 10
            MvxModels.Add("DM-VVX-E760C");          // 11
            MvxModels.Add("DM-VVX-D30");            // 12
            MvxModels.Add("DM-VVX-D30C");           // 13
            MvxModels.Add("DM-VVX-E30");            // 14
            MvxModels.Add("DM-VVX-E30C");           // 15
            MvxModels.Add("DM-VVX-D80-IOAV");       // 16

        }
    }
}
