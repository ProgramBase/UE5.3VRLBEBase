using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.PaperTerrainMaterial")]
	public partial class UPaperTerrainMaterial : UDataAsset, IStaticClass
	{
		public TArray<FPaperTerrainMaterialRule> Rules
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Rules, __ReturnBuffer);

					return *(TArray<FPaperTerrainMaterialRule>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Rules, __InBuffer);
				}
			}
		}

		public UPaperSprite InteriorFill
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InteriorFill, __ReturnBuffer);

					return *(UPaperSprite*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InteriorFill, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2D.PaperTerrainMaterial");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Rules = 0;

		private static uint __InteriorFill = 0;
	}
}