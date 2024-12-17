using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.PackedRGB10A2N")]
	public partial class FPackedRGB10A2N : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.PackedRGB10A2N");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPackedRGB10A2N() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPackedRGB10A2N() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPackedRGB10A2N A, FPackedRGB10A2N B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPackedRGB10A2N A, FPackedRGB10A2N B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPackedRGB10A2N;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int Packed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Packed, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Packed, __InBuffer);
				}
			}
		}

		private static uint __Packed = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}