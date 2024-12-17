using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeFactoryNodes
{
	[PathName("/Script/InterchangeFactoryNodes.InterchangeMaterialFunctionFactoryNode")]
	public partial class UInterchangeMaterialFunctionFactoryNode : UInterchangeBaseMaterialFactoryNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeFactoryNodes.InterchangeMaterialFunctionFactoryNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual UClass GetObjectClass()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetObjectClass, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		public virtual bool GetInputConnection(FString InputName, ref FString ExpressionNodeUid, ref FString OutputName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ExpressionNodeUid?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutputName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetInputConnection, __InBuffer, __OutBuffer, __ReturnBuffer);

				ExpressionNodeUid = *(FString*)(__OutBuffer);

				OutputName = *(FString*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __GetObjectClass = 0;

		private static uint __GetInputConnection = 0;
	}
}