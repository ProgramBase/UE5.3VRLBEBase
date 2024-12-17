using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangeTexture2DNode")]
	public partial class UInterchangeTexture2DNode : UInterchangeTextureNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeNodes.InterchangeTexture2DNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetCustomWrapV(EInterchangeTextureWrapMode AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomWrapV, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomWrapU(EInterchangeTextureWrapMode AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomWrapU, __InBuffer, __ReturnBuffer);

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

		public virtual bool GetCustomWrapV(ref EInterchangeTextureWrapMode AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomWrapV, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(EInterchangeTextureWrapMode*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomWrapU(ref EInterchangeTextureWrapMode AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomWrapU, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(EInterchangeTextureWrapMode*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetCustomWrapV = 0;

		private static uint __SetCustomWrapU = 0;

		private static uint __GetSourceBlocks = 0;

		private static uint __GetCustomWrapV = 0;

		private static uint __GetCustomWrapU = 0;
	}
}