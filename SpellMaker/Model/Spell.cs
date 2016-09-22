using System.Collections.Generic;
using Assisticant.Collections;
using Assisticant.Fields;
using Newtonsoft.Json;

namespace SpellMaker
{
	public class Spell
	{

		private Observable<int> _power = new Observable<int>();
		private Observable<int> _range = new Observable<int>();
		private Observable<int> _area = new Observable<int>();
		private ObservableList<ElementType> _elements = new ObservableList<ElementType>();
		private Observable<string> _damageType = new Observable<string>();
		private Observable<string> _name = new Observable<string>();

		[JsonProperty]
		public int Power { get { return _power.Value; } protected set { _power.Value = value; } }

		[JsonProperty]
		public int Range { get { return _range.Value; } protected set { _range.Value = value; } }

		[JsonProperty]
		public int Area { get { return _range.Value; } protected set { _area.Value = value; } }

		[JsonProperty]
		public IEnumerable<ElementType> Elements { get { return _elements; } }

		[JsonProperty]
		public string DamageType { get { return _damageType.Value; } 
			set { _damageType.Value = value; } }

		[JsonProperty]
		public string Name { get { return _name.Value; } set { _name.Value = value; } }

		public Spell()
		{
			Power = 1;
			Range = 1;
			Area = 1;
		}

		public void AddElement(ElementType element)
		{
			_elements.Add(element);
		}

		public void RemoveElement(ElementType element)
		{
			_elements.Remove(element);
		}

		public override int GetHashCode()
		{
			var toHash = Name + Elements + Range + DamageType + Power;
			
			return toHash.GetHashCode();
		}

		public override bool Equals(object obj)
		{
			if (this == obj)
			{
				return true;
			}

			var that = obj as Spell;
			if (that == null)
			{
				return false;
			}

			return GetHashCode() == that.GetHashCode();
			
		}

	}
}

