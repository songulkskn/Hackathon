using Hackathon.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon.Repositories
{
    class TimeRepository
    {
        private HashSet<RecordedData> _datas= new HashSet<RecordedData>();
        private HashSet<BreakTime> _breaktimes = new HashSet<BreakTime>();


        public List<RecordedData> GetData()
        {
        
            RecordedData rd1 = new RecordedData(1, new DateTime(2020, 12, 12, 7, 30, 00), new DateTime(2020, 12, 12, 18, 50, 00),"URETIM", GetBreakTimes());

            RecordedData rd2 = new RecordedData(2, new DateTime(2020, 12, 12, 8, 30, 00), new DateTime(2020, 12, 12, 10, 30, 00), "URETIM", GetBreakTimes());
            RecordedData rd3 = new RecordedData(2, new DateTime(2020, 12, 12, 10, 00, 00), new DateTime(2020, 12, 12, 10, 15, 00), "DURUS", GetBreakTimes());
            RecordedData rd4 = new RecordedData(2, new DateTime(2020, 12, 12, 10, 15, 00), new DateTime(2020, 12, 12, 12, 00, 00), "DURUS", GetBreakTimes());

            RecordedData rd5 = new RecordedData(3, new DateTime(2020, 12, 12, 12, 00, 00), new DateTime(2020, 12, 12, 12, 30, 00), "DURUS", GetBreakTimes());
            RecordedData rd6 = new RecordedData(3, new DateTime(2020, 12, 12, 12, 30, 00), new DateTime(2020, 12, 12, 13, 00, 00), "DURUS", GetBreakTimes());
            RecordedData rd7 = new RecordedData(4, new DateTime(2020, 12, 12, 13, 00, 00), new DateTime(2020, 12, 12, 13, 45, 00), "DURUS", GetBreakTimes());
            RecordedData rd8 = new RecordedData(5, new DateTime(2020, 12, 12, 13, 45, 00), new DateTime(2020, 12, 12, 15, 00, 00), "DURUS", GetBreakTimes());
            RecordedData rd9 = new RecordedData(5, new DateTime(2020, 12, 12, 15, 00, 00), new DateTime(2020, 12, 12, 15, 15, 00), "DURUS", GetBreakTimes());
            RecordedData rd10 = new RecordedData(5, new DateTime(2020, 12, 12, 15, 15, 00), new DateTime(2020, 12, 12, 17, 30, 00), "DURUS", GetBreakTimes());





            _datas.Add(rd1);
            _datas.Add(rd2);
            _datas.Add(rd3);
            _datas.Add(rd4);
            _datas.Add(rd5);
            _datas.Add(rd6);
            _datas.Add(rd7);
            _datas.Add(rd8);
            _datas.Add(rd9);
            _datas.Add(rd10);


            return _datas.ToList();

        }

   

        public List<BreakTime> GetBreakTimes()
        {

            BreakTime rd = new BreakTime("10:00", "10:15", "ÇAY MOLASI");
            BreakTime rd1 = new BreakTime("12:00", "12:30", "YEMEK MOLASI");
            BreakTime rd2 = new BreakTime("15:00", "15:15", "ÇAY MOLASI");

            _breaktimes.Add(rd1);
            _breaktimes.Add(rd2);
            _breaktimes.Add(rd);

            return _breaktimes.ToList();

        }
    }
}
