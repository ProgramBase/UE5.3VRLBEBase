using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangePointLightNode")]
	public partial class UInterchangePointLightNode : UInterchangeLightNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeNodes.InterchangePointLightNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetCustomUseInverseSquaredFalloff(bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomUseInverseSquaredFalloff, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomLightFalloffExponent(float AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomLightFalloffExponent, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomUseInverseSquaredFalloff(ref bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomUseInverseSquaredFalloff, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomLightFalloffExponent(ref float AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomLightFalloffExponent, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(float*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetCustomUseInverseSquaredFalloff = 0;

		private static uint __SetCustomLightFalloffExponent = 0;

		private static uint __GetCustomUseInverseSquaredFalloff = 0;

		private static uint __GetCustomLightFalloffExponent = 0;
	}
}