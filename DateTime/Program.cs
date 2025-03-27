var now = DateTime.Now;
var today = DateTime.Today;
var dateTime = new DateTime(2015, 1, 1);
Console.WriteLine(dateTime +" "+ now + " "+ today);
Console.WriteLine(now.Hour);
Console.WriteLine(now.Minute);
Console.WriteLine(now.Second);
Console.WriteLine(today.Date);

var tomorrow = now.AddDays(1);
Console.WriteLine(tomorrow.Date);
Console.WriteLine(now.ToLongDateString());
Console.WriteLine(now.ToLongTimeString());
Console.WriteLine(now.ToShortTimeString());
Console.WriteLine(now.ToShortDateString());