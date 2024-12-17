using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FInt32Interval
	{
		public FInt32Interval(int InMin, int InMax)
		{
			if (GetType() == typeof(FInt32Interval))
			{
				FInt32IntervalImplementation.FInt32Interval_FInt32IntervalImplementation(this, InMin, InMax);
			}
		}

		public int Size()
		{
			return (int)FInt32IntervalImplementation.FInt32Interval_SizeImplementation(GarbageCollectionHandle);
		}

		public bool IsValid()
		{
			return (bool)FInt32IntervalImplementation.FInt32Interval_IsValidImplementation(GarbageCollectionHandle);
		}

		public bool Contains(int Element)
		{
			return (bool)FInt32IntervalImplementation.FInt32Interval_ContainsImplementation(GarbageCollectionHandle, Element);
		}

		public void Expand(int ExpandAmount)
		{
			FInt32IntervalImplementation.FInt32Interval_ExpandImplementation(GarbageCollectionHandle, ExpandAmount);
		}

		public void Include(int X)
		{
			FInt32IntervalImplementation.FInt32Interval_IncludeImplementation(GarbageCollectionHandle, X);
		}

		public int Interpolate(float Alpha)
		{
			return (int)FInt32IntervalImplementation.FInt32Interval_InterpolateImplementation(GarbageCollectionHandle, Alpha);
		}
	}
}