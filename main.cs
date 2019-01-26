static void Main(string[] args)
{
    RunMultiHandlers()
}

private static void RunMultiHandlers()
{
    Console.WriteLine("Combined 1");
    string strRunDate = DateTime.Now.ToString("yyyyMMdd");

    Console.WriteLine("Combined 2");        
    string strWatchPath850s = @"C:\Users\User1\Desktop\850s";
    string strWatchPath855s = @"C:\Users\User1\Desktop\855s";

    Console.WriteLine("Combined 3");    
    FileSystemWatcher watcher850s = new FileSystemWatcher();

    Console.WriteLine("Combined 4");        
    watcher850s.Path = strWatchPath850s;

    Console.WriteLine("Combined 5");        
    watcher850s.Created += new FileSystemEventHandler((sender, e) => OnChanged("850s"));

    Console.WriteLine("Combined 6");        
    watcher850s.EnableRaisingEvents = true;

    Console.WriteLine("Combined 7");        
    FileSystemWatcher watcher855s = new FileSystemWatcher();

    Console.WriteLine("Combined 8");    
    watcher850s.Path = strWatchPath855s;

    Console.WriteLine("Combined 9");        
    watcher850s.Created += new FileSystemEventHandler((sender, e) => OnChanged("855s"));

    Console.WriteLine("Combined 10");       
    watcher850s.EnableRaisingEvents = true;

    Console.WriteLine("Combined 11");    
    while (DateTime.Now.ToString("yyyyMMdd") == strRunDate) ;   
}

private static async Task OnChanged(string strCaller)
{
    Console.WriteLine("caller " + strCaller);
}  
