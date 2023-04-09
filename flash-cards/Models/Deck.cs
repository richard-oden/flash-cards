using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flash_cards.Models
{
    public class Deck
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public List<FlashCard> FlashCards { get; set; }

        public IFlashCardProvider FlashCardProvider { get; set; }

        public Deck(string name, string description, IFlashCardProvider flashCardProvider)
        { 
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            FlashCards = new();
            FlashCardProvider = flashCardProvider;
        }
    }
}
