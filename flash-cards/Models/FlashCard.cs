using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flash_cards.Models
{
    public class FlashCard
    {
        public Guid Id { get; set; }

        public string Prompt { get; set; }

        public string Solution { get; set; }

        public int LastReportedDifficulty { get; set; }

        public DateTime LastStudied { get; set; }

        public FlashCard(string prompt, string solution)
        {
            Id = Guid.NewGuid();
            Prompt = prompt;
            Solution = solution;
        }
    }
}
