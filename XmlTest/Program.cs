using System;

namespace XmlTest
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
                            <Child name='JJ'/>
                        </Children>
                    </Person>";
        }
    }
}
