using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flash_cards.Models
{
    internal class PimsleurFlashCardProvider : IFlashCardProvider
    {
        public string Name => "Pimsleur";

        public string Description => "Based on the Pimsleur language learning system, published by Paul Pimsleur in 1967.";

        //5 seconds, 25 seconds, 2 minutes, 10 minutes, 1 hour, 5 hours, 1 day, 5 days, 25 days, 4 months, and 2 years
        private static TimeSpan[] Intervals => new[] 
        { 
            TimeSpan.FromSeconds(5),
            TimeSpan.FromSeconds(25),
            TimeSpan.FromMinutes(2),
            TimeSpan.FromMinutes(10),
            TimeSpan.FromHours(1),
            TimeSpan.FromHours(5),
            TimeSpan.FromDays(1),
            TimeSpan.FromDays(5),
            TimeSpan.FromDays(25),
            TimeSpan.FromDays(120),
            TimeSpan.FromDays(730)
        };

        public FlashCard? GetNextFlashCard(IEnumerable<FlashCard> flashCards)
        {
            throw new NotImplementedException();
        }

        public void ProcessFlashCard(FlashCard flashCard)
        {
            throw new NotImplementedException();
        }
    }
}
