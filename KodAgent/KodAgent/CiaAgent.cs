using System;
using System.Collections.Generic;
using System.Text;

namespace KodAgent
{
    class CiaAgent
    {

        private string realName="John China";
        private string password="VoteTrump";
        public string RealName="Steve Jobs";

        public string greet;

      
        public string AgentGreeting() { if (greet == password) return realName; else  return RealName; }
    }
}
