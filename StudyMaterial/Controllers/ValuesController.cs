using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace StudyMaterial.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            CancellationTokenSource token = new CancellationTokenSource();
            token.CancelAfter(1000);

            var task = AsyncFactory.GetIntAsync(token.Token);

            var newTask = task.ContinueWith<string>(t =>
             {
                 if (t.Status == TaskStatus.Canceled)
                 {
                     return "Task cancelled";
                 }
                 else
                 {
                     return "Task cancelled";
                 }
             });

            return newTask.Result;
            return task.Status == TaskStatus.Canceled ? "Task Cancelled" : "Task not cancelled";

            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }


    }

    public class AsyncFactory
    {
        public static Task<int> GetIntAsync(CancellationToken token = default(CancellationToken))
        {
            var tcs = new TaskCompletionSource<int>();

            if (token.IsCancellationRequested)
            {
                tcs.SetCanceled();
                return tcs.Task;
            }


            var timer = new System.Timers.Timer(2000);
            timer.AutoReset = false;

            timer.Elapsed += (s, e) =>
            {
                tcs.TrySetResult(10);
                timer.Dispose();
            };

            if (token.CanBeCanceled)
            {
                token.Register(() =>
                {
                    tcs.TrySetCanceled();
                    timer.Dispose();
                });
            }

            timer.Start();
            return tcs.Task;
        }
    }
}
