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

        public FlashCard? GetNextFlashCard(IEnumerable<FlashCard> flashCards);

        public void ProcessFlashCard(FlashCard flashCard);
    }
}
