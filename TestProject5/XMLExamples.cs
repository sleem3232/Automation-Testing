using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject5
{
    internal class XMLExamples
    {
        public static string GetPersonXML()
        {
            return @"<Person>
                        <FirstName>Joe</FirstName>
                        <SurName>Smith</SurName>
                        <Children>
                            <Child name='Jane'/>
                            <Child name='Jim'/>
                            <Child name='Jim'/>
                        </Children>
                    </Person>";
        }
    }
}
