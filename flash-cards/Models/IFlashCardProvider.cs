using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flash_cards.Models
{
    public interface IFlashCardProvider
    {
        public List<FlashCard> FlashCards { get; }

        public FlashCard? GetFlashCard();

        public void ProcessFlashCard(FlashCard flashCard);

        public void AddFlashCard(FlashCard flashCard);
    }
}
