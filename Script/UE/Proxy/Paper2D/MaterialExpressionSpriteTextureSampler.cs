using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Paper2D
{
	[PathName("/Script/Paper2D.MaterialExpressionSpriteTextureSampler")]
	public partial class UMaterialExpressionSpriteTextureSampler : UMaterialExpressionTextureSampleParameter2D, IStaticClass
	{
		public bool bSampleAdditionalTextures
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSampleAdditionalTextures, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSampleAdditionalTextures, __InBuffer);
				}
			}
		}

		public int AdditionalSlotIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AdditionalSlotIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AdditionalSlotIndex, __InBuffer);
				}
			}
		}

		public FText SlotDisplayName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SlotDisplayName, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SlotDisplayName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Paper2D.MaterialExpressionSpriteTextureSampler");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bSampleAdditionalTextures = 0;

		private static uint __AdditionalSlotIndex = 0;

		private static uint __SlotDisplayName = 0;
	}
}