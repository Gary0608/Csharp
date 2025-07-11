List<int> scores = [35, 25, 85, 70, 98, 84, 100, 60, 80];

IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80
    orderby score descending
    select score;

var scoreQuery2 = scores.Where(s => s > 80).OrderByDescending(s => s);

List<int> myScores = scoreQuery.ToList();

List<int> myScores2 = scoreQuery.ToList();

foreach (var score in myScores)
{
    Console.WriteLine(score);
}

foreach (var score in myScores2)
{
    Console.WriteLine(score);
}