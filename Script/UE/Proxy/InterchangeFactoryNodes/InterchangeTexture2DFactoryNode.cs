using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.InterchangeFactoryNodes
{
	[PathName("/Script/InterchangeFactoryNodes.InterchangeTexture2DFactoryNode")]
	public partial class UInterchangeTexture2DFactoryNode : UInterchangeTextureFactoryNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeFactoryNodes.InterchangeTexture2DFactoryNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InSourceBlocks">
		/// The blocks and their source image that compose the whole texture.
		/// The textures must be of the same format and use the same pixel format
		/// The first block in the map is used to determine the accepted texture format and pixel format
		/// </param>
		public virtual void SetSourceBlocks(TMap<int, FString> InSourceBlocks)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSourceBlocks?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSourceBlocks, __InBuffer);
			}
		}

		/// <param name="X">
		/// The X coordinate of the block
		/// </param>
		/// <param name="Y">
		/// The Y coordinate of the block
		/// </param>
		/// <param name="InSourceFile">
		/// The source file for that block
		/// The textures must be of the same format and use the same pixel format
		/// The first block in the map is used to determine the accepted texture format and pixel format
		/// </param>
		public virtual void SetSourceBlockByCoordinates(int X, int Y, FString InSourceFile)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = X;

				*(int*)(__InBuffer + 4) = Y;

				*(nint*)(__InBuffer + 8) = InSourceFile?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSourceBlockByCoordinates, __InBuffer);
			}
		}

		/// <param name="BlockIndex">
		/// The UDIM Index of the block
		/// </param>
		/// <param name="InSourceFile">
		/// The source file for that block
		/// The textures must be of the same format and use the same pixel format
		/// The first block in the map is used to determine the accepted texture format and pixel format
		/// </param>
		public virtual void SetSourceBlock(int BlockIndex, FString InSourceFile)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = BlockIndex;

				*(nint*)(__InBuffer + 4) = InSourceFile?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSourceBlock, __InBuffer);
			}
		}

		public virtual bool SetCustomAddressY(TextureAddress AttributeValue, bool bAddApplyDelegate = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = (byte)AttributeValue;

				*(bool*)(__InBuffer + 1) = bAddApplyDelegate;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomAddressY, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomAddressX(TextureAddress AttributeValue, bool bAddApplyDelegate = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = (byte)AttributeValue;

				*(bool*)(__InBuffer + 1) = bAddApplyDelegate;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomAddressX, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TMap<int, FString> GetSourceBlocks()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSourceBlocks, __ReturnBuffer);

				return *(TMap<int, FString>*)__ReturnBuffer;
			}
		}

		/// <param name="X">
		/// The X coordinate of the block
		/// </param>
		/// <param name="Y">
		/// The Y coordinate of the block
		/// </param>
		/// <param name="OutSourceFile">
		/// The source file for that block if found
		/// </param>
		/// <returns>
		/// True if the source file for the block was found
		/// </returns>
		public virtual bool GetSourceBlockByCoordinates(int X, int Y, ref FString OutSourceFile)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(int*)(__InBuffer) = X;

				*(int*)(__InBuffer + 4) = Y;

				*(nint*)(__InBuffer + 8) = OutSourceFile?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetSourceBlockByCoordinates, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutSourceFile = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BlockIndex">
		/// The UDIM Index of the block
		/// </param>
		/// <param name="OutSourceFile">
		/// The source file for that block if found
		/// </param>
		/// <returns>
		/// True if the source file for the block was found
		/// </returns>
		public virtual bool GetSourceBlock(int BlockIndex, ref FString OutSourceFile)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = BlockIndex;

				*(nint*)(__InBuffer + 4) = OutSourceFile?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetSourceBlock, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutSourceFile = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomAddressY(ref TextureAddress AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomAddressY, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(TextureAddress*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomAddressX(ref TextureAddress AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomAddressX, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(TextureAddress*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetSourceBlocks = 0;

		private static uint __SetSourceBlockByCoordinates = 0;

		private static uint __SetSourceBlock = 0;

		private static uint __SetCustomAddressY = 0;

		private static uint __SetCustomAddressX = 0;

		private static uint __GetSourceBlocks = 0;

		private static uint __GetSourceBlockByCoordinates = 0;

		private static uint __GetSourceBlock = 0;

		private static uint __GetCustomAddressY = 0;

		private static uint __GetCustomAddressX = 0;
	}
}