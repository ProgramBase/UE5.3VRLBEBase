using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeFactoryNodes
{
	[PathName("/Script/InterchangeFactoryNodes.InterchangeMaterialExpressionFactoryNode")]
	public partial class UInterchangeMaterialExpressionFactoryNode : UInterchangeFactoryBaseNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeFactoryNodes.InterchangeMaterialExpressionFactoryNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetCustomExpressionClassName(FString AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomExpressionClassName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomExpressionClassName(ref FString AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomExpressionClassName, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetCustomExpressionClassName = 0;

		private static uint __GetCustomExpressionClassName = 0;
	}
}