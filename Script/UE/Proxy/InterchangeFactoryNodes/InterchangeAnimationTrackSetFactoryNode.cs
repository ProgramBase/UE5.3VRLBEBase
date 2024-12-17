using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeFactoryNodes
{
	[PathName("/Script/InterchangeFactoryNodes.InterchangeAnimationTrackSetFactoryNode")]
	public partial class UInterchangeAnimationTrackSetFactoryNode : UInterchangeFactoryBaseNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeFactoryNodes.InterchangeAnimationTrackSetFactoryNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetCustomFrameRate(float AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomFrameRate, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveCustomAnimationTrackUid(FString AnimationTrackUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AnimationTrackUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveCustomAnimationTrackUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UClass GetObjectClass()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetObjectClass, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomFrameRate(ref float AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomFrameRate, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(float*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void GetCustomAnimationTrackUids(ref TArray<FString> OutAnimationTrackUids)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutAnimationTrackUids?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetCustomAnimationTrackUids, __InBuffer, __OutBuffer);

				OutAnimationTrackUids = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual int GetCustomAnimationTrackUidCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCustomAnimationTrackUidCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void GetCustomAnimationTrackUid(int Index, ref FString OutAnimationTrackUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Index;

				*(nint*)(__InBuffer + 4) = OutAnimationTrackUid?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetCustomAnimationTrackUid, __InBuffer, __OutBuffer);

				OutAnimationTrackUid = *(FString*)(__OutBuffer);

			}
		}

		public virtual bool AddCustomAnimationTrackUid(FString AnimationTrackUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AnimationTrackUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddCustomAnimationTrackUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetCustomFrameRate = 0;

		private static uint __RemoveCustomAnimationTrackUid = 0;

		private static uint __GetObjectClass = 0;

		private static uint __GetCustomFrameRate = 0;

		private static uint __GetCustomAnimationTrackUids = 0;

		private static uint __GetCustomAnimationTrackUidCount = 0;

		private static uint __GetCustomAnimationTrackUid = 0;

		private static uint __AddCustomAnimationTrackUid = 0;
	}
}