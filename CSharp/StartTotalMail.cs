//Copyright 2017 Paul Hill
//
//Licensed under the Apache License, Version 2.0 (the "License");
//you may not use this file except in compliance with the License.
//You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
//Unless required by applicable law or agreed to in writing, software
//distributed under the License is distributed on an "AS IS" BASIS,
//WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//See the License for the specific language governing permissions and
//limitations under the License.

using System.Diagnostics;
using System.Threading;

namespace StartTotalMail
{
    class Program
    {

        static void Main(string[] args)
        {
            Process.Start(Program.ProcessInfo(@"C:\Program Files (x86)\TMW Systems, Inc\TotalMail\Delivery.exe"));
            Process.Start(Program.ProcessInfo(@"C:\Program Files (x86)\TMW Systems, Inc\TotalMail\tmxactui.exe"));
            Process.Start(Program.ProcessInfo(@"C:\Program Files (x86)\TMW Systems, Inc\TotalMail\tmEmail.exe"));
            Process.Start(Program.ProcessInfo(@"C:\Program Files (x86)\TMW Systems, Inc\TotalMail\TMWMPoll.exe", 
                "/M /A TmwSystems.TotalMail.PeopleNet.PeopleNetMobcXfc /N1"));
            Process.Start(Program.ProcessInfo(@"C:\Program Files (x86)\TMW Systems, Inc\TotalMail\TMWMPoll.exe", 
                "/M /A TmwSystems.TotalMail.PeopleNet.PeopleNetMobcXfc /N2"));
            Process.Start(Program.ProcessInfo(@"C:\Program Files (x86)\TMW Systems, Inc\TotalMail\TMWMPoll.exe", 
                "/M /A TmwSystems.TotalMail.PeopleNet.PeopleNetMobcXfc /N3"));
        }

        static ProcessStartInfo ProcessInfo(string fileName, string arguments)
        {
            var output = new ProcessStartInfo();
            if (arguments != null) { output.Arguments = arguments; }
            output.FileName = fileName;

            Thread.Sleep(1000);

            return output;
        }
        static ProcessStartInfo ProcessInfo(string fileName)
        {
            return Program.ProcessInfo(fileName, null);
        }
    }
}
