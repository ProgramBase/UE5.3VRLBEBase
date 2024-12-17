using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BillboardComponent")]
	public partial class UBillboardComponent : UPrimitiveComponent, IStaticClass
	{
		public UTexture2D Sprite
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Sprite, __ReturnBuffer);

					return *(UTexture2D*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Sprite, __InBuffer);
				}
			}
		}

		public bool bIsScreenSizeScaled
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsScreenSizeScaled, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsScreenSizeScaled, __InBuffer);
				}
			}
		}

		public float ScreenSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ScreenSize, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ScreenSize, __InBuffer);
				}
			}
		}

		public float U
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __U, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __U, __InBuffer);
				}
			}
		}

		public float UL
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UL, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UL, __InBuffer);
				}
			}
		}

		public float V
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __V, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __V, __InBuffer);
				}
			}
		}

		public float VL
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VL, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VL, __InBuffer);
				}
			}
		}

		public float OpacityMaskRefVal
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OpacityMaskRefVal, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OpacityMaskRefVal, __InBuffer);
				}
			}
		}

		public FSpriteCategoryInfo SpriteInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpriteInfo, __ReturnBuffer);

					return *(FSpriteCategoryInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpriteInfo, __InBuffer);
				}
			}
		}

		public bool bUseInEditorScaling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseInEditorScaling, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseInEditorScaling, __InBuffer);
				}
			}
		}

		public bool bShowLockedLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowLockedLocation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowLockedLocation, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.BillboardComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetUV(int NewU, int NewUL, int NewV, int NewVL)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = NewU;

				*(int*)(__InBuffer + 4) = NewUL;

				*(int*)(__InBuffer + 8) = NewV;

				*(int*)(__InBuffer + 12) = NewVL;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUV, __InBuffer);
			}
		}

		public virtual void SetSpriteAndUV(UTexture2D NewSprite, int NewU, int NewUL, int NewV, int NewVL)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NewSprite?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = NewU;

				*(int*)(__InBuffer + 12) = NewUL;

				*(int*)(__InBuffer + 16) = NewV;

				*(int*)(__InBuffer + 20) = NewVL;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSpriteAndUV, __InBuffer);
			}
		}

		public virtual void SetSprite(UTexture2D NewSprite)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewSprite?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSprite, __InBuffer);
			}
		}

		public virtual void SetOpacityMaskRefVal(float RefVal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = RefVal;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOpacityMaskRefVal, __InBuffer);
			}
		}

		private static uint __Sprite = 0;

		private static uint __bIsScreenSizeScaled = 0;

		private static uint __ScreenSize = 0;

		private static uint __U = 0;

		private static uint __UL = 0;

		private static uint __V = 0;

		private static uint __VL = 0;

		private static uint __OpacityMaskRefVal = 0;

		private static uint __SpriteInfo = 0;

		private static uint __bUseInEditorScaling = 0;

		private static uint __bShowLockedLocation = 0;

		private static uint __SetUV = 0;

		private static uint __SetSpriteAndUV = 0;

		private static uint __SetSprite = 0;

		private static uint __SetOpacityMaskRefVal = 0;
	}
}