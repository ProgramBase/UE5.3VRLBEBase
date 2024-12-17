using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.FrameNumberRange")]
	public partial class FFrameNumberRange : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.FrameNumberRange");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FFrameNumberRange() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FFrameNumberRange() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FFrameNumberRange A, FFrameNumberRange B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FFrameNumberRange A, FFrameNumberRange B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FFrameNumberRange;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FFrameNumberRangeBound LowerBound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LowerBound, __ReturnBuffer);

					return *(FFrameNumberRangeBound*)__ReturnBuffer;
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

		public FFrameNumberRangeBound UpperBound
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __UpperBound, __ReturnBuffer);

					return *(FFrameNumberRangeBound*)__ReturnBuffer;
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