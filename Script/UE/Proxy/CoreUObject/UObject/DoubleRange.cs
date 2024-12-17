using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.DoubleRange")]
	public partial class FDoubleRange : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.DoubleRange");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDoubleRange() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDoubleRange() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDoubleRange A, FDoubleRange B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDoubleRange A, FDoubleRange B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDoubleRange;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FDoubleRangeBound LowerBound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LowerBound, __ReturnBuffer);

					return *(FDoubleRangeBound*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LowerBound, __InBuffer);
				}
			}
		}

		public FDoubleRangeBound UpperBound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UpperBound, __ReturnBuffer);

					return *(FDoubleRangeBound*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __UpperBound, __InBuffer);
				}
			}
		}

		private static uint __LowerBound = 0;

		private static uint __UpperBound = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}