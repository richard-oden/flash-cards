using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flash_cards.Models
{
    public interface IFlashCardProvider
    {
        public string Name { get; }

        public string Description { get; }

        public List<FlashCard> GetTodaysFlashCards(IEnumerable<FlashCard> allFlashCards);

        public FlashCard? GetNextFlashCard(IEnumerable<FlashCard> todaysFlashCards);

        public void ProcessFlashCard(FlashCard flashCard);
    }
}
