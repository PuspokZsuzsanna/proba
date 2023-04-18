class films
{
    public string title;
    public int length;
    public string genre;
    public List<string> actors;
    public int release_date;

    public List<int> score;

    public films(string t, int l, string g, List<string> a, int rd)
    {
        this.title = t;
        this.length = l;
        this.genre = g;
        this.actors = a;
        this.release_date = rd;
        this.score = score;
    }
    public void rate(int x)
    {
        this.score.Add(x);
        int avg = 0;
        for (int i = 0; i < this.score.Count; i++)
        {
            avg += this.score[i];
        }
        Console.WriteLine(avg / this.score.Count);
    }
}