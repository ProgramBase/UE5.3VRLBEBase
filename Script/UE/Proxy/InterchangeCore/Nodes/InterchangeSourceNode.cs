using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.InterchangeSourceNode")]
	public partial class UInterchangeSourceNode : UInterchangeBaseNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeCore.InterchangeSourceNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetCustomSourceTimelineStart(double AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomSourceTimelineStart, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomSourceTimelineEnd(double AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomSourceTimelineEnd, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomSourceFrameRateNumerator(int AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomSourceFrameRateNumerator, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomSourceFrameRateDenominator(int AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomSourceFrameRateDenominator, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomImportUnusedMaterial(bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomImportUnusedMaterial, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomAnimatedTimeStart(double AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomAnimatedTimeStart, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomAnimatedTimeEnd(double AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomAnimatedTimeEnd, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="UniqueID">
		/// - The uniqueId for this node
		/// </param>
		/// <param name="DisplayLabel">
		/// - The name of the node
		/// </param>
		public virtual void InitializeSourceNode(FString UniqueID, FString DisplayLabel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = UniqueID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DisplayLabel?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __InitializeSourceNode, __InBuffer);
			}
		}

		public virtual bool GetCustomSourceTimelineStart(ref double AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomSourceTimelineStart, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(double*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomSourceTimelineEnd(ref double AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomSourceTimelineEnd, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(double*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomSourceFrameRateNumerator(ref int AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomSourceFrameRateNumerator, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(int*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomSourceFrameRateDenominator(ref int AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomSourceFrameRateDenominator, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(int*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomImportUnusedMaterial(ref bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomImportUnusedMaterial, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomAnimatedTimeStart(ref double AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomAnimatedTimeStart, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(double*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomAnimatedTimeEnd(ref double AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomAnimatedTimeEnd, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(double*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetCustomSourceTimelineStart = 0;

		private static uint __SetCustomSourceTimelineEnd = 0;

		private static uint __SetCustomSourceFrameRateNumerator = 0;

		private static uint __SetCustomSourceFrameRateDenominator = 0;

		private static uint __SetCustomImportUnusedMaterial = 0;

		private static uint __SetCustomAnimatedTimeStart = 0;

		private static uint __SetCustomAnimatedTimeEnd = 0;

		private static uint __InitializeSourceNode = 0;

		private static uint __GetCustomSourceTimelineStart = 0;

		private static uint __GetCustomSourceTimelineEnd = 0;

		private static uint __GetCustomSourceFrameRateNumerator = 0;

		private static uint __GetCustomSourceFrameRateDenominator = 0;

		private static uint __GetCustomImportUnusedMaterial = 0;

		private static uint __GetCustomAnimatedTimeStart = 0;

		private static uint __GetCustomAnimatedTimeEnd = 0;
	}
}