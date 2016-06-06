using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinCan;

namespace ConsoleTest2
{
    class Program
    {
        static void Main(string[] args)
        {
            ILRS lrs = new RemoteLRS("http://192.168.100.114", "GURqOTJUwyGlJcbF3D5ToMJsHUxeGywTuniZ1YfY",
                "s7gOpOse0V0Y6zj4lBWdrQ5rFT3atyTYiERgQCyX");

            var query = new StatementsQuery();
            //query.agent = new Agent();
            //query.agent.mbox = "mailto:tincancsharp@tincanapi.com";
            //query.relatedAgents = true;

            query.verbId = new Uri("http://adlnet.gov/expapi/verbs/completed");

            var result = lrs.QueryStatements(query);
            if (result.success)
            {
                Console.WriteLine(result.content.statements.Count);
                foreach (var statement in result.content.statements)
                {
                    Console.WriteLine(statement.id);
                }
            }
            Console.ReadLine();
        }
    }
}
