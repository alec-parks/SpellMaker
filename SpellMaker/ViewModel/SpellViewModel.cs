using System;
namespace SpellMaker
{
	public class SpellViewModel
	{
		private readonly Spell _spell;

		public Spell Spell
		{
			get { return _spell;}
		}

		public string Name
		{
			get { return _spell.Name; }
		}



		public SpellViewModel(Spell spell)
		{
			_spell = spell;
		}


	}
}
