using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.Texture2D")]
	public partial class UTexture2D : UTexture, IStaticClass
	{
		public int FirstResourceMemMip
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FirstResourceMemMip, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FirstResourceMemMip, __InBuffer);
				}
			}
		}

		public bool bTemporarilyDisableStreaming
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bTemporarilyDisableStreaming, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bTemporarilyDisableStreaming, __InBuffer);
				}
			}
		}

		public bool bHasBeenPaintedInEditor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasBeenPaintedInEditor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasBeenPaintedInEditor, __InBuffer);
				}
			}
		}

		public TextureAddress AddressX
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AddressX, __ReturnBuffer);

					return *(TextureAddress*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AddressX, __InBuffer);
				}
			}
		}

		public TextureAddress AddressY
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AddressY, __ReturnBuffer);

					return *(TextureAddress*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AddressY, __InBuffer);
				}
			}
		}

		public FIntPoint ImportedSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ImportedSize, __ReturnBuffer);

					return *(FIntPoint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ImportedSize, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.Texture2D");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual int Blueprint_GetSizeY()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __Blueprint_GetSizeY, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int Blueprint_GetSizeX()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __Blueprint_GetSizeX, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __FirstResourceMemMip = 0;

		private static uint __bTemporarilyDisableStreaming = 0;

		private static uint __bHasBeenPaintedInEditor = 0;

		private static uint __AddressX = 0;

		private static uint __AddressY = 0;

		private static uint __ImportedSize = 0;

		private static uint __Blueprint_GetSizeY = 0;

		private static uint __Blueprint_GetSizeX = 0;
	}
}