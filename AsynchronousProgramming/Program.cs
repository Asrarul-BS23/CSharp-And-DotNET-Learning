//MakeTea(); // Synchronous Function Calling for Making Tea


/* ============ How It Works ===================
In synchronous programming the function calls are linear. Each functions are runned in single
thread one after another. i.e. in this example at first it prints
Start the kettle
waiting for the kettle
--Wait for 2 sec for finishing boiling--
kettle finished boiling
take the cups out
put tea in cups
pour water in cups 
*/
await MakeTeaAsync(); // Asynchronous Function Calling for Making Tea
/* ============ How It Works ===================
In asynchronous  programming multiple tasks can be executed in multiple 
thread so the tasks can be performed in parallel. There are nothing to wait 
for the completion of one task to start another task.
1. Start the kettle
2. waiting for the kettle
3. take the cups out
4. put tea in cups
5. kettle finished boiling
6. pour water in cups 
--- Here the cups are out and putting the tea in cups before boiling finished
because the BoilWaterAsync() is executing in separate thread. So while the BoilWaterAsync()
is waiting for 3 sec for boiling, the cups and tea are getting ready.---
====== 
To be more clear about it we can add a 3 sec wait time in the MakeTeaAsync() also by 
lessening the wait time in BoilWaterAsync() to 0.3 sec the output modified to the following:
======
Start the kettle
waiting for the kettle
take the cups out
kettle finished boiling
put tea in cups
pour water in cups  
---- Here the kettle finished boiling in 0.3 sec and before boiling the "take the cups out" 
step finished and the "kettle finished boiling" as the MakeTeaAsync() is waiting for 3 sec
before performing the "put tea in cups" step. ----
*/
static async Task<string> MakeTeaAsync()
{
    Task<string> boilingWater = BoilWaterAsync();

    Console.WriteLine("take the cups out");

    await Task.Delay(3000);

    Console.WriteLine("put tea in cups");

    string water = await boilingWater;

    string tea = $"pour {water} in cups";
    Console.WriteLine(tea);

    return tea;
}

static async Task<string> BoilWaterAsync()
{
    Console.WriteLine("Start the kettle");

    Console.WriteLine("waiting for the kettle");
    await Task.Delay(300);

    Console.WriteLine("kettle finished boiling");

    return "water";
}

static string MakeTea()
{
    string water = BoilWater();

    Console.WriteLine("take the cups out");

    Console.WriteLine("put tea in cups");

    string tea = $"pour {water} in cups";
    Console.WriteLine(tea);

    return tea;
}

static string BoilWater()
{
    Console.WriteLine("Start the kettle");

    Console.WriteLine("waiting for the kettle");
    Task.Delay(2000).GetAwaiter().GetResult();

    Console.WriteLine("kettle finished boiling");

    return "water";
}