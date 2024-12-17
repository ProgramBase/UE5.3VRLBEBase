using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FBox2D
	{
		public FVector2D this[int Index]
		{
			get => FBox2DImplementation.FBox2D_GetSubscriptImplementation(GarbageCollectionHandle, Index) as FVector2D;

			set => FBox2DImplementation.FBox2D_SetSubscriptImplementation(GarbageCollectionHandle, Index, value);
		}

		public FBox2D(EForceInit InValue0)
		{
			if (GetType() == typeof(FBox2D))
			{
				FBox2DImplementation.FBox2D_FBox2DImplementation(this, InValue0);
			}
		}

		public FBox2D(FVector2D InMin, FVector2D InMax)
		{
			if (GetType() == typeof(FBox2D))
			{
				FBox2DImplementation.FBox2D_FBox2D1Implementation(this, InMin?.GarbageCollectionHandle ?? nint.Zero, InMax?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public FBox2D(FVector2D Points, int Count)
		{
			if (GetType() == typeof(FBox2D))
			{
				FBox2DImplementation.FBox2D_FBox2D2Implementation(this, Points?.GarbageCollectionHandle ?? nint.Zero, Count);
			}
		}

		public FBox2D(TArray<FVector2D> Points)
		{
			if (GetType() == typeof(FBox2D))
			{
				FBox2DImplementation.FBox2D_FBox2D3Implementation(this, Points?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public static FBox2D operator +(FBox2D InValue0, FBox2D InValue1)
		{
			return FBox2DImplementation.FBox2D_PlusImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FBox2D;
		}

		public static FBox2D operator +(FBox2D InValue0, FVector2D InValue1)
		{
			return FBox2DImplementation.FBox2D_Plus1Implementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero) as FBox2D;
		}

		public double ComputeSquaredDistanceToPoint(FVector2D Point)
		{
			return (double)FBox2DImplementation.FBox2D_ComputeSquaredDistanceToPointImplementation(GarbageCollectionHandle, Point?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FBox2D ExpandBy(double W)
		{
			return FBox2DImplementation.FBox2D_ExpandByImplementation(GarbageCollectionHandle, W) as FBox2D;
		}

		public FBox2D ExpandBy(FVector2D V)
		{
			return FBox2DImplementation.FBox2D_ExpandBy1Implementation(GarbageCollectionHandle, V?.GarbageCollectionHandle ?? nint.Zero) as FBox2D;
		}

		public double GetArea()
		{
			return (double)FBox2DImplementation.FBox2D_GetAreaImplementation(GarbageCollectionHandle);
		}

		public FVector2D GetCenter()
		{
			return FBox2DImplementation.FBox2D_GetCenterImplementation(GarbageCollectionHandle) as FVector2D;
		}

		public void GetCenterAndExtents(FVector2D center, FVector2D Extents)
		{
			FBox2DImplementation.FBox2D_GetCenterAndExtentsImplementation(GarbageCollectionHandle, center?.GarbageCollectionHandle ?? nint.Zero, Extents?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FVector2D GetClosestPointTo(FVector2D Point)
		{
			return FBox2DImplementation.FBox2D_GetClosestPointToImplementation(GarbageCollectionHandle, Point?.GarbageCollectionHandle ?? nint.Zero) as FVector2D;
		}

		public FVector2D GetExtent()
		{
			return FBox2DImplementation.FBox2D_GetExtentImplementation(GarbageCollectionHandle) as FVector2D;
		}

		public FVector2D GetSize()
		{
			return FBox2DImplementation.FBox2D_GetSizeImplementation(GarbageCollectionHandle) as FVector2D;
		}

		public void Init()
		{
			FBox2DImplementation.FBox2D_InitImplementation(GarbageCollectionHandle);
		}

		public FBox2D Overlap(FBox2D Other)
		{
			return FBox2DImplementation.FBox2D_OverlapImplementation(GarbageCollectionHandle, Other?.GarbageCollectionHandle ?? nint.Zero) as FBox2D;
		}

		public bool Intersect(FBox2D other)
		{
			return (bool)FBox2DImplementation.FBox2D_IntersectImplementation(GarbageCollectionHandle, other?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool IsInside(FVector2D TestPoint)
		{
			return (bool)FBox2DImplementation.FBox2D_IsInsideImplementation(GarbageCollectionHandle, TestPoint?.GarbageCollectionHandle ?? nint.Zero);
		}

		public bool IsInside(FBox2D Other)
		{
			return (bool)FBox2DImplementation.FBox2D_IsInside1Implementation(GarbageCollectionHandle, Other?.GarbageCollectionHandle ?? nint.Zero);
		}

		public FBox2D ShiftBy(FVector2D Offset)
		{
			return FBox2DImplementation.FBox2D_ShiftByImplementation(GarbageCollectionHandle, Offset?.GarbageCollectionHandle ?? nint.Zero) as FBox2D;
		}

		public new FString ToString()
		{
			return FBox2DImplementation.FBox2D_ToStringImplementation(GarbageCollectionHandle) as FString;
		}
	}
}