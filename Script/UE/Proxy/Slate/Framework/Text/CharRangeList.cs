using Script.CoreUObject;
using Script.Library;

namespace Script.Slate
{
	[PathName("/Script/Slate.CharRangeList")]
	public partial class FCharRangeList : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Slate.CharRangeList");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCharRangeList() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCharRangeList() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCharRangeList A, FCharRangeList B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCharRangeList A, FCharRangeList B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCharRangeList;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FCharRange> Ranges
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Ranges, __ReturnBuffer);

					return *(TArray<FCharRange>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Ranges, __InBuffer);
				}
			}
		}

		private static uint __Ranges = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}