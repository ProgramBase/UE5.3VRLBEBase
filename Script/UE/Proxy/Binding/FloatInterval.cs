using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FFloatInterval
	{
		public FFloatInterval(float InMin, float InMax)
		{
			if (GetType() == typeof(FFloatInterval))
			{
				FFloatIntervalImplementation.FFloatInterval_FFloatIntervalImplementation(this, InMin, InMax);
			}
		}

		public float Size()
		{
			return (float)FFloatIntervalImplementation.FFloatInterval_SizeImplementation(GarbageCollectionHandle);
		}

		public bool IsValid()
		{
			return (bool)FFloatIntervalImplementation.FFloatInterval_IsValidImplementation(GarbageCollectionHandle);
		}

		public bool Contains(float Element)
		{
			return (bool)FFloatIntervalImplementation.FFloatInterval_ContainsImplementation(GarbageCollectionHandle, Element);
		}

		public void Expand(float ExpandAmount)
		{
			FFloatIntervalImplementation.FFloatInterval_ExpandImplementation(GarbageCollectionHandle, ExpandAmount);
		}

		public void Include(float X)
		{
			FFloatIntervalImplementation.FFloatInterval_IncludeImplementation(GarbageCollectionHandle, X);
		}

		public float Interpolate(float Alpha)
		{
			return (float)FFloatIntervalImplementation.FFloatInterval_InterpolateImplementation(GarbageCollectionHandle, Alpha);
		}
	}
}