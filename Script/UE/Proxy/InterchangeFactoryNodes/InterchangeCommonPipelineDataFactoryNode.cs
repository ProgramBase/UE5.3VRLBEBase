using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeFactoryNodes
{
	[PathName("/Script/InterchangeFactoryNodes.InterchangeCommonPipelineDataFactoryNode")]
	public partial class UInterchangeCommonPipelineDataFactoryNode : UInterchangeFactoryBaseNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeFactoryNodes.InterchangeCommonPipelineDataFactoryNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetCustomGlobalOffsetTransform(UInterchangeBaseNodeContainer NodeContainer, FTransform AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomGlobalOffsetTransform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetBakeMeshes(UInterchangeBaseNodeContainer NodeContainer, bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NodeContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetBakeMeshes, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomGlobalOffsetTransform(ref FTransform AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomGlobalOffsetTransform, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(FTransform*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetBakeMeshes(ref bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetBakeMeshes, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetCustomGlobalOffsetTransform = 0;

		private static uint __SetBakeMeshes = 0;

		private static uint __GetCustomGlobalOffsetTransform = 0;

		private static uint __GetBakeMeshes = 0;
	}
}