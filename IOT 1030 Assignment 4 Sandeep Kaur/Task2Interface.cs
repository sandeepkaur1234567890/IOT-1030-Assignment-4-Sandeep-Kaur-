using System;

// Make sure to uncomment the ToString methods when you are ready!

namespace A4.Task2Interface
{
	interface ICarryPassengers
	{
		// TODO: IMPLEMENT THIS
		int NumPassengers { get; }
		string CarryPassenger();
	}
	class Ship
	{
		// TODO: IMPLEMENT THIS CLASS

		public double Displacement { get; }
		public Ship(double displacement)
		{
			Displacement = displacement;
		}
		public string CarryPassenger()
		{
			return " This type of ship does not carry passengers";
		}
		public override string ToString() => $" A ship that displaces (Displacement) tons of water";


	}

	class CruiseShip : Ship, ICarryPassengers
	{
		// TODO: IMPLEMENT THIS CLASS (it should inherit from Ship as well as extend ICarryPassenger)
		private int numPassengers;
		public int NumPassengers => throw new NotImplementedException();
		public string CarryPassengers()
		{
			return $"{base.ToString()} and is carrying {numPassengers} passengers on a Carribbean Cruise";

		}

		public CruiseShip(double displacement, int numPassengers) : base(displacement)
		{
			this.numPassengers = numPassengers;
		}
		public override string ToString() => CarryPassengers();
    }

	class BigRig
	{
		// TODO: IMPLEMENT THIS CLASS
		public int NumTires;

		public BigRig(int numTires)
		{
			NumTires = numTires;
		}
		public string CarryPassenger()
		{
			return " This type of vehicle does not carry passengers";
		}

		public override string ToString() => $"A vehicle with {NumTires} tires";
	}
 
		class TourBus : BigRig, ICarryPassengers
		{
		// TODO: IMPLEMENT THIS CLASS (it should inherit from BigRig as well as extend ICarryPassenger)
		private int numPassengers;

		public int NumPassengers => throw new NotImplementedException();

		public TourBus(int numTires, int numPassengers) : base(numTires)
		{
			this.numPassengers = numPassengers;
		}

        public string CarryPassengers()
		{
			return $"{base.ToString()} and is carrying {numPassengers} passengers on a cross country tour.";
		}

		public override string ToString() => CarryPassengers();
	}
	}




	

