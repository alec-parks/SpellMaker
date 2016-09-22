using System;
using Assisticant;

namespace SpellMaker
{
	public class ViewModelLocator: ViewModelLocatorBase
	{
		private readonly Spell _spell;
		
		public ViewModelLocator()
		{
		}

		public Object SpellViewModel
		{
			get { return ViewModel(() => new SpellViewModel(_spell));}
		}
	}
}
