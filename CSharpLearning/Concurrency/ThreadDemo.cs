using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpLearning.Concurrency
{
    public class ThreadDemo
    {
        // Use the Thread class to create a new thread.
        // Call the Start() method to start executing the thread.
        // Call the Join() method to wait for the thread to complete. 

        // set thread object's foreground to background by "<thread's obj>.IsBackground = true"

        public void DoWork()
        {
            Console.WriteLine("Doing the work...");
            Thread.Sleep(2000);
            Console.WriteLine("Done");
        }
        
        // this parameter passed by threads on threads call
        public void SendEmail(object arg = null)
        {
            if (arg == null) { return; }
            string message = (string)arg;
            Console.WriteLine($"{message}");
            Thread.Sleep(2000);
            Console.WriteLine("Sending done!");
        }

        public void Run()
        {

            // primary solution that takes 4 secconds to complete.
            // single threading example
            var watch = Stopwatch.StartNew();

            DoWork();
            DoWork();

            watch.Stop();
            Console.WriteLine($"Time taken to complete: {watch.Elapsed.Seconds} \n\n");


            // another solution that takes 2 seconds to complete
            // Optimal solution
            // multi-threading example

            watch = Stopwatch.StartNew();

            var t1 = new Thread(DoWork);
            var t2 = new Thread(DoWork);

            // starts both threads
            t1.Start();
            t2.Start();

            // wait for both threads to complete
            t1.Join();
            t2.Join();

            Console.WriteLine($"Time taken for optimal solution: {watch.Elapsed.Seconds} \n\n");


            // passing args by threads
            // another multi-threading example
            var t3 = new Thread(SendEmail);
            
            // If you want to set a thread to background from foreground.
            // Background thread will be terminated after the main thread termination.
            t3.IsBackground = true;

            /** 
             * Can pass a anonymous functions as well like following...
             *** Use lambda expressions to pass arguments to threads...
             * var t3 = new Thread(() => SendEmail("Sending email to abc@email.com")); 
            */
            var t4 = new Thread(() => SendEmail("Sending email to secondUser@email.com"));

            t3.Start("Sending email to abc@email.com");
            t4.Start();

            t3.Join();
            t4.Join();
        } 
    }


    // This is a complete thread example.
    // This class represent multi-threading only.
    public class CheckHttpUrl
    {
        private List<string> urls = new List<string>
        {
            "https://www.google.com/", "https://www.yahoo.com/", "https://www.bing.com/"
        };

        private static void CheckHttpStatus(string url)
        {
            HttpClient client = new();
            var response = client.GetAsync(url).Result;
            Console.WriteLine($"Status code of URL : {url} is {response.StatusCode} \n");
        }

        public void Run()
        {
            List<Thread> threads = new();
            urls.ForEach(url => threads.Add(new Thread(() => CheckHttpStatus(url))));

            var watch = Stopwatch.StartNew();

            // starts each thread
            threads.ForEach(t => t.Start());

            // wait until threads is complete
            threads.ForEach(t => t.Join());

            watch.Stop();
            Console.WriteLine($"Time taken to complete: {watch.Elapsed.Seconds} seconds");
        }
    }
}
