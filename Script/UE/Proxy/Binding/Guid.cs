using Script.Binding;

namespace Script.CoreUObject
{
	public partial class FGuid
	{
		public uint this[int Index]
		{
			get => (uint)FGuidImplementation.FGuid_GetSubscriptImplementation(GarbageCollectionHandle, Index);

			set => FGuidImplementation.FGuid_SetSubscriptImplementation(GarbageCollectionHandle, Index, value);
		}

		public FGuid(uint InA, uint InB, uint InC, uint InD)
		{
			if (GetType() == typeof(FGuid))
			{
				FGuidImplementation.FGuid_FGuidImplementation(this, InA, InB, InC, InD);
			}
		}

		public FGuid(FString InGuidStr)
		{
			if (GetType() == typeof(FGuid))
			{
				FGuidImplementation.FGuid_FGuid1Implementation(this, InGuidStr?.GarbageCollectionHandle ?? nint.Zero);
			}
		}

		public static bool operator <(FGuid InValue0, FGuid InValue1)
		{
			return (bool)FGuidImplementation.FGuid_LessImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool operator >(FGuid InValue0, FGuid InValue1)
		{
			return (bool)FGuidImplementation.FGuid_GreaterImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static FString LexToString(FGuid Value)
		{
			return FGuidImplementation.FGuid_LexToStringImplementation(nint.Zero, Value?.GarbageCollectionHandle ?? nint.Zero) as FString;
		}

		public void Invalidate()
		{
			FGuidImplementation.FGuid_InvalidateImplementation(GarbageCollectionHandle);
		}

		public bool IsValid()
		{
			return (bool)FGuidImplementation.FGuid_IsValidImplementation(GarbageCollectionHandle);
		}

		public FString ToString(EGuidFormats Format)
		{
			return FGuidImplementation.FGuid_ToStringImplementation(GarbageCollectionHandle, Format) as FString;
		}

		public static FGuid NewGuid()
		{
			return FGuidImplementation.FGuid_NewGuidImplementation(nint.Zero) as FGuid;
		}

		public static bool Parse(FString InValue0, FGuid InValue1)
		{
			return (bool)FGuidImplementation.FGuid_ParseImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1?.GarbageCollectionHandle ?? nint.Zero);
		}

		public static bool ParseExact(FString InValue0, EGuidFormats InValue1, FGuid InValue2)
		{
			return (bool)FGuidImplementation.FGuid_ParseExactImplementation(nint.Zero, InValue0?.GarbageCollectionHandle ?? nint.Zero, InValue1, InValue2?.GarbageCollectionHandle ?? nint.Zero);
		}
	}
}