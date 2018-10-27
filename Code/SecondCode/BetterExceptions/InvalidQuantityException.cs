using System;
using System.Runtime.Serialization;

namespace SecondCode.BetterExceptions
{
	[Serializable]
	public class InvalidQuantityException : Exception
	{
		public int Quantity { get; }

		public InvalidQuantityException() { }

		public InvalidQuantityException(string message) : base(message) { }

		public InvalidQuantityException(string message, Exception innerException) : base(message, innerException) { }

		public InvalidQuantityException(int quantity) : base($"Invalid Quantity: {quantity}")
		{
			Quantity = quantity;
		}

		protected InvalidQuantityException(SerializationInfo info, StreamingContext context) : base(info, context)
		{
			Quantity = info.GetInt32(nameof(Quantity));
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue(nameof(Quantity), Quantity);
			base.GetObjectData(info, context);
		}
	}
}
