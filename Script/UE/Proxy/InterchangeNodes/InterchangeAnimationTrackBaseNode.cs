using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangeAnimationTrackBaseNode")]
	public partial class UInterchangeAnimationTrackBaseNode : UInterchangeBaseNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeNodes.InterchangeAnimationTrackBaseNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetCustomCompletionMode(int AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomCompletionMode, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomCompletionMode(ref int AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomCompletionMode, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(int*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetCustomCompletionMode = 0;

		private static uint __GetCustomCompletionMode = 0;
	}
}