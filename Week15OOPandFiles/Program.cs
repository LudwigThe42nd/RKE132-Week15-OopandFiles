

List<Movie> myMovies = new List<Movie>();

string[] data = GetDataFromMyFile();
//ReadDataFromArray(data);

foreach(string line in data)
{
    string[] tempArray = line.Split(new char[] {';'}, StringSplitOptions.RemoveEmptyEntries);
    Movie newMovie = new Movie(tempArray[0], tempArray[2]);
    myMovies.Add(newMovie);
   // Console.WriteLine("Temp array");
    //ReadDataFromArray(tempArray);
}

foreach (Movie movie in myMovies)
{
    Console.WriteLine($"one of my favourite movies {movie.Title} was released in {movie.Year}");
}

static string[] GetDataFromMyFile()
{
    string filepile = @"C:\Users\User\source\movies.txt";
    //string[] dataFromFile = File.ReadAllLines(filepile);

    return File.ReadAllLines(filepile);

}

static void ReadDataFromArray(string[] someArray)
{
    foreach (string line in someArray)
    {
        Console.WriteLine(line);
    }
}

class Movie
{
    string title;
    string year;

    public string Title
    {
        get { return title; }
    }

    public string Year
    {
        get { return year; }
    }

    public Movie(string _title, string _year)
    {
        title = _title;
        year = _year;
    }
}
