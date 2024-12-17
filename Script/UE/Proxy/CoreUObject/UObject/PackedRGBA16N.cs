using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.PackedRGBA16N")]
	public partial class FPackedRGBA16N : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.PackedRGBA16N");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPackedRGBA16N() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPackedRGBA16N() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPackedRGBA16N A, FPackedRGBA16N B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPackedRGBA16N A, FPackedRGBA16N B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPackedRGBA16N;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int XY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __XY, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __XY, __InBuffer);
				}
			}
		}

		public int ZW
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ZW, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ZW, __InBuffer);
				}
			}
		}

		private static uint __XY = 0;

		private static uint __ZW = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}