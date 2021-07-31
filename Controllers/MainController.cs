using System.Collections.Generic;
using System.Web.Http;

namespace MessageAPI.Controllers
{
    public class MainController : ApiController
    {
        public string[] Get()
        {
            List<string> lst = new List<string>();
            foreach (Request req in messages)
            {
                lst.Add(req.Message);
            }
            return lst.ToArray();
        }
        public string Get(int id)
        {
            if (id < messages.Count && id > -1)
            {
                return messages[id].Message;
            }
            else
                return "Invalid Id.";
        }
        public Response Post([FromBody] Request request)
        {
            messages.Add(request);
            return new Response() { count = Count() };
        }
        public string Put(int id, [FromBody] string value)
        {
            if (id < messages.Count && id > -1)
            {
                messages[id].Message = value;
                return "Successfully updated Id " + id + "'s message to '" + value + "'.";
            }
            else
                return "Invalid Id.";
        }
        public string Delete(int id)
        {
            if (id < messages.Count && id > -1)
            {
                messages.RemoveAt(id);
                return "Success.";
            }
            else
                return "Invalid Id.";
        }
        private int Count()
        {
            int count = 0;
            foreach (Request req in messages)
            {
                count += req.Message.Split(' ').Length;
            }
            return count;
        }
        private static List<Request> messages = new List<Request>()
        {
            new Request() { Id=0, Message="Message 1" },
            new Request() { Id=1, Message="Message 2" }
        };
    }
    public class Request
    {
        public int Id { get; set; }
        public string Message { get; set; }
    }
    public class Response
    {
        public int count { get; set; }
    }
}
