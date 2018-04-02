using Android.Util;
using SQLite;
using System.Collections.Generic;
using System.Linq;

namespace ClassTimeTable.Services
{
    public class TimeTableDBServices
    {

        private string folder;
        private string dataPath;
        private static TimeTableDBServices dataBase;

        private TimeTableDBServices(string folder)
        {
            this.folder = folder;
            dataPath = System.IO.Path.Combine(folder, "TimeTable`.db");
        }

        public static TimeTableDBServices getInstance(string folder)
        {
            if (dataBase == null)
            {
                dataBase = new TimeTableDBServices(folder);
            }
            return dataBase;
        }

        public bool CreateTable()
        {
            try
            {
                using (var connection = new SQLiteConnection(dataPath))
                {
                    connection.CreateTable<TimeTable>();
                    return true;
                }
            }
            catch (SQLiteException e)
            {
                Log.Info("SQLiteEX", e.Message);
                return false;
            }
        }

        public bool InsertIntoTable(TimeTable timetable)
        {
            try
            {
                using (var connection = new SQLiteConnection(dataPath))
                {
                    connection.Insert(timetable);
                    return false;
                }
            }
            catch (SQLiteException e)
            {
                Log.Info("SQLiteEX", e.Message);
                return false;
            }
        }

        public bool Delete(TimeTable timeTable)
        {
            try
            {
                using (var connection = new SQLiteConnection(dataPath))
                {
                    connection.Delete(timeTable);
                    return false;
                }
            }
            catch (SQLiteException e)
            {
                Log.Info("SQLiteEX", e.Message);
                return false;
            }
            
        }

        public List<TimeTable> Select(TimeTable time)
        {
            try
            {
                using (var connection=new SQLiteConnection(dataPath))
                {
                    return connection.Table<TimeTable>().ToList();
                }
            }catch(SQLiteException e)
            {
                Log.Info("SQLiteEX", e.Message);
                return null;
            }
        }




    }



}