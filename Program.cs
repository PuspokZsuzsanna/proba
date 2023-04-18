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


void bubble_sort(ref List<int> arr){
    int n = arr.Count;
    
    for (int i = 0; i<n-1; i++){
        for (int j = 0; j<n-i-1; j++){
            if (arr[j] < arr[j+1]){
                int c = arr[j];
                arr[j] = arr[j+1];
                arr[j+1] = c;
            }
        }
    }
}