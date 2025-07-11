List<int> scores = [35, 25, 85, 70, 98, 84, 100, 60, 80];

IEnumerable<int> scoreQuery =
        from score in scores
        where score > 80
        orderby score descending
        select score;

List<int> myScores = scoreQuery.ToList();

foreach (var score in myScores)
{
    Console.WriteLine(score);
}