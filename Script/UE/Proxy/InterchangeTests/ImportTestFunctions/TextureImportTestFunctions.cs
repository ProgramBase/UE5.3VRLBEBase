using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.InterchangeTests
{
	[PathName("/Script/InterchangeTests.TextureImportTestFunctions")]
	public partial class UTextureImportTestFunctions : UImportTestFunctionsBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeTests.TextureImportTestFunctions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FInterchangeTestFunctionResult CheckTextureFilter(UTexture Texture, TextureFilter ExpectedTextureFilter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)ExpectedTextureFilter;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckTextureFilter, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckTextureAddressZ(UTexture Texture, TextureAddress ExpectedTextureAddressZ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)ExpectedTextureAddressZ;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckTextureAddressZ, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckTextureAddressY(UTexture Texture, TextureAddress ExpectedTextureAddressY)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)ExpectedTextureAddressY;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckTextureAddressY, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckTextureAddressX(UTexture Texture, TextureAddress ExpectedTextureAddressX)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Texture?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)ExpectedTextureAddressX;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckTextureAddressX, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		public static FInterchangeTestFunctionResult CheckImportedTextureCount(TArray<UTexture> Textures, int ExpectedNumberOfImportedTextures)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Textures?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = ExpectedNumberOfImportedTextures;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckImportedTextureCount, __InBuffer, __ReturnBuffer);

				return *(FInterchangeTestFunctionResult*)__ReturnBuffer;
			}
		}

		private static uint __CheckTextureFilter = 0;

		private static uint __CheckTextureAddressZ = 0;

		private static uint __CheckTextureAddressY = 0;

		private static uint __CheckTextureAddressX = 0;

		private static uint __CheckImportedTextureCount = 0;
	}
}