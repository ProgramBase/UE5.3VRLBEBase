using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.VirtualTextureBuildSettings")]
	public partial class FVirtualTextureBuildSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.VirtualTextureBuildSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FVirtualTextureBuildSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FVirtualTextureBuildSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FVirtualTextureBuildSettings A, FVirtualTextureBuildSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FVirtualTextureBuildSettings A, FVirtualTextureBuildSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FVirtualTextureBuildSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int TileSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TileSize, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TileSize, __InBuffer);
				}
			}
		}

		public int TileBorderSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TileBorderSize, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TileBorderSize, __InBuffer);
				}
			}
		}

		private static uint __TileSize = 0;

		private static uint __TileBorderSize = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}