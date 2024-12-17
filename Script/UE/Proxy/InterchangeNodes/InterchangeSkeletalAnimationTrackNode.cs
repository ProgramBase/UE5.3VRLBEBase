using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangeSkeletalAnimationTrackNode")]
	public partial class UInterchangeSkeletalAnimationTrackNode : UInterchangeAnimationTrackBaseNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeNodes.InterchangeSkeletalAnimationTrackNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetCustomSkeletonNodeUid(FString AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomSkeletonNodeUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomAnimationStopTime(double StopTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = StopTime;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomAnimationStopTime, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomAnimationStartTime(double StartTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = StartTime;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomAnimationStartTime, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomAnimationSampleRate(double SampleRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = SampleRate;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomAnimationSampleRate, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetAnimationPayloadKeyForSceneNodeUid(FString SceneNodeUid, FString InUniqueId, EInterchangeAnimationPayLoadType InType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = SceneNodeUid?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InUniqueId?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)InType;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetAnimationPayloadKeyForSceneNodeUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetAnimationPayloadKeyForMorphTargetNodeUid(FString MorphTargetNodeUid, FString InUniqueId, EInterchangeAnimationPayLoadType InType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = MorphTargetNodeUid?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InUniqueId?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)InType;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetAnimationPayloadKeyForMorphTargetNodeUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void GetSceneNodeAnimationPayloadKeys(ref TMap<FString, FString> OutSceneNodeAnimationPayloadKeyUids, ref TMap<FString, byte> OutSceneNodeAnimationPayloadKeyTypes)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OutSceneNodeAnimationPayloadKeyUids?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutSceneNodeAnimationPayloadKeyTypes?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetSceneNodeAnimationPayloadKeys, __InBuffer, __OutBuffer);

				OutSceneNodeAnimationPayloadKeyUids = *(TMap<FString, FString>*)(__OutBuffer);

				OutSceneNodeAnimationPayloadKeyTypes = *(TMap<FString, byte>*)(__OutBuffer + 8);

			}
		}

		public virtual void GetMorphTargetNodeAnimationPayloadKeys(ref TMap<FString, FString> OutMorphTargetNodeAnimationPayloadKeyUids, ref TMap<FString, byte> OutMorphTargetNodeAnimationPayloadKeyTypes)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OutMorphTargetNodeAnimationPayloadKeyUids?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutMorphTargetNodeAnimationPayloadKeyTypes?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetMorphTargetNodeAnimationPayloadKeys, __InBuffer, __OutBuffer);

				OutMorphTargetNodeAnimationPayloadKeyUids = *(TMap<FString, FString>*)(__OutBuffer);

				OutMorphTargetNodeAnimationPayloadKeyTypes = *(TMap<FString, byte>*)(__OutBuffer + 8);

			}
		}

		public virtual bool GetCustomSkeletonNodeUid(ref FString AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomSkeletonNodeUid, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomAnimationStopTime(ref double StopTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = StopTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomAnimationStopTime, __InBuffer, __OutBuffer, __ReturnBuffer);

				StopTime = *(double*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomAnimationStartTime(ref double StartTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = StartTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomAnimationStartTime, __InBuffer, __OutBuffer, __ReturnBuffer);

				StartTime = *(double*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomAnimationSampleRate(ref double SampleRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = SampleRate;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomAnimationSampleRate, __InBuffer, __OutBuffer, __ReturnBuffer);

				SampleRate = *(double*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetCustomSkeletonNodeUid = 0;

		private static uint __SetCustomAnimationStopTime = 0;

		private static uint __SetCustomAnimationStartTime = 0;

		private static uint __SetCustomAnimationSampleRate = 0;

		private static uint __SetAnimationPayloadKeyForSceneNodeUid = 0;

		private static uint __SetAnimationPayloadKeyForMorphTargetNodeUid = 0;

		private static uint __GetSceneNodeAnimationPayloadKeys = 0;

		private static uint __GetMorphTargetNodeAnimationPayloadKeys = 0;

		private static uint __GetCustomSkeletonNodeUid = 0;

		private static uint __GetCustomAnimationStopTime = 0;

		private static uint __GetCustomAnimationStartTime = 0;

		private static uint __GetCustomAnimationSampleRate = 0;
	}
}