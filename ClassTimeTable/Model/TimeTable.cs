using SQLite;

public class TimeTable
{
    [PrimaryKey,AutoIncrement]
    public string ID{get;set;}

    public string CourseName { get; set; }
    public string CourseLocation { get; set; }
    public string Time { get; set; }
    public string Date { get; set; }

    public override string ToString()
    {
        return string.Format("[Person: Id={0},CourseName={1},CourseLocation={2},Time={3},Date={4}]", ID, CourseName, CourseLocation,Time, Date);
    }

}