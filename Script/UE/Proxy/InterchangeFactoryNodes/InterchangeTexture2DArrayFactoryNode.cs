using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeFactoryNodes
{
	[PathName("/Script/InterchangeFactoryNodes.InterchangeTexture2DArrayFactoryNode")]
	public partial class UInterchangeTexture2DArrayFactoryNode : UInterchangeTextureFactoryNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeFactoryNodes.InterchangeTexture2DArrayFactoryNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetCustomAddressZ(byte AttributeValue, bool bAddApplyDelegate = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = AttributeValue;

				*(bool*)(__InBuffer + 1) = bAddApplyDelegate;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomAddressZ, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomAddressZ(ref byte AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomAddressZ, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(byte*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomAddressY(ref byte AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomAddressY, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(byte*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomAddressX(ref byte AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomAddressX, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(byte*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetCustomAddressZ = 0;

		private static uint __GetCustomAddressZ = 0;

		private static uint __GetCustomAddressY = 0;

		private static uint __GetCustomAddressX = 0;
	}
}