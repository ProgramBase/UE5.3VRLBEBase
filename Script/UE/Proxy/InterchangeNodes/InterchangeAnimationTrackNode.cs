using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangeAnimationTrackNode")]
	public partial class UInterchangeAnimationTrackNode : UInterchangeAnimationTrackBaseNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeNodes.InterchangeAnimationTrackNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetCustomTargetedProperty(int TargetedProperty)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = TargetedProperty;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomTargetedProperty, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomFrameCount(int AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomFrameCount, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomAnimationPayloadKey(FString InUniqueId, EInterchangeAnimationPayLoadType InType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InUniqueId?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InType;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomAnimationPayloadKey, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomActorDependencyUid(FString DependencyUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DependencyUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomActorDependencyUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomTargetedProperty(ref int TargetedProperty)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = TargetedProperty;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomTargetedProperty, __InBuffer, __OutBuffer, __ReturnBuffer);

				TargetedProperty = *(int*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomFrameCount(ref int AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomFrameCount, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(int*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomAnimationPayloadKey(ref FInterchangeAnimationPayLoadKey AnimationPayLoadKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AnimationPayLoadKey?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomAnimationPayloadKey, __InBuffer, __OutBuffer, __ReturnBuffer);

				AnimationPayLoadKey = *(FInterchangeAnimationPayLoadKey*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomActorDependencyUid(ref FString DependencyUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DependencyUid?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomActorDependencyUid, __InBuffer, __OutBuffer, __ReturnBuffer);

				DependencyUid = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetCustomTargetedProperty = 0;

		private static uint __SetCustomFrameCount = 0;

		private static uint __SetCustomAnimationPayloadKey = 0;

		private static uint __SetCustomActorDependencyUid = 0;

		private static uint __GetCustomTargetedProperty = 0;

		private static uint __GetCustomFrameCount = 0;

		private static uint __GetCustomAnimationPayloadKey = 0;

		private static uint __GetCustomActorDependencyUid = 0;
	}
}