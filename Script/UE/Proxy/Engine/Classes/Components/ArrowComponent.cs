using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ArrowComponent")]
	public partial class UArrowComponent : UPrimitiveComponent, IStaticClass
	{
		public FColor ArrowColor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ArrowColor, __ReturnBuffer);

					return *(FColor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ArrowColor, __InBuffer);
				}
			}
		}

		public float ArrowSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ArrowSize, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ArrowSize, __InBuffer);
				}
			}
		}

		public float ArrowLength
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ArrowLength, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ArrowLength, __InBuffer);
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

		public bool bTreatAsASprite
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bTreatAsASprite, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bTreatAsASprite, __InBuffer);
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

		public bool bLightAttachment
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLightAttachment, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLightAttachment, __InBuffer);
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

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ArrowComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetUseInEditorScaling(bool bNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUseInEditorScaling, __InBuffer);
			}
		}

		public virtual void SetTreatAsASprite(bool bNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTreatAsASprite, __InBuffer);
			}
		}

		public virtual void SetScreenSize(float NewScreenSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewScreenSize;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetScreenSize, __InBuffer);
			}
		}

		public virtual void SetIsScreenSizeScaled(bool bNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetIsScreenSizeScaled, __InBuffer);
			}
		}

		public virtual void SetArrowSize(float NewSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewSize;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetArrowSize, __InBuffer);
			}
		}

		public virtual void SetArrowLength(float NewLength)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewLength;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetArrowLength, __InBuffer);
			}
		}

		public virtual void SetArrowFColor(FColor NewColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetArrowFColor, __InBuffer);
			}
		}

		public virtual void SetArrowColor(FLinearColor NewColor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetArrowColor, __InBuffer);
			}
		}

		private static uint __ArrowColor = 0;

		private static uint __ArrowSize = 0;

		private static uint __ArrowLength = 0;

		private static uint __ScreenSize = 0;

		private static uint __bIsScreenSizeScaled = 0;

		private static uint __bTreatAsASprite = 0;

		private static uint __SpriteInfo = 0;

		private static uint __bLightAttachment = 0;

		private static uint __bUseInEditorScaling = 0;

		private static uint __SetUseInEditorScaling = 0;

		private static uint __SetTreatAsASprite = 0;

		private static uint __SetScreenSize = 0;

		private static uint __SetIsScreenSizeScaled = 0;

		private static uint __SetArrowSize = 0;

		private static uint __SetArrowLength = 0;

		private static uint __SetArrowFColor = 0;

		private static uint __SetArrowColor = 0;
	}
}