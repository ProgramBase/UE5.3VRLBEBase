using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangeBaseLightNode")]
	public partial class UInterchangeBaseLightNode : UInterchangeBaseNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeNodes.InterchangeBaseLightNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetCustomUseTemperature(bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomUseTemperature, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomTemperature(float AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomTemperature, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomLightColor(FLinearColor AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomLightColor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomIntensity(float AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomIntensity, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomUseTemperature(ref bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomUseTemperature, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomTemperature(ref float AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomTemperature, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(float*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomLightColor(ref FLinearColor AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomLightColor, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(FLinearColor*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomIntensity(ref float AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomIntensity, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(float*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetCustomUseTemperature = 0;

		private static uint __SetCustomTemperature = 0;

		private static uint __SetCustomLightColor = 0;

		private static uint __SetCustomIntensity = 0;

		private static uint __GetCustomUseTemperature = 0;

		private static uint __GetCustomTemperature = 0;

		private static uint __GetCustomLightColor = 0;

		private static uint __GetCustomIntensity = 0;
	}
}