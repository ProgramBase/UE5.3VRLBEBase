using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimationAttributeIdentifierExtensions")]
	public partial class UAnimationAttributeIdentifierExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimationAttributeIdentifierExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <returns>
		/// Whether or not the Attribute Identifier is valid
		/// </returns>
		public static bool IsValid(ref FAnimationAttributeIdentifier Identifier)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Identifier?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __IsValid, __InBuffer, __OutBuffer, __ReturnBuffer);

				Identifier = *(FAnimationAttributeIdentifier*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AnimationAsset">
		/// Animation asset to retrieve Skeleton from
		/// </param>
		/// <param name="AttributeName">
		/// Name of the attribute 
		/// </param>
		/// <param name="BoneName">
		/// Name of the bone this attribute should be attributed to
		/// </param>
		/// <param name="AttributeType">
		/// Type of the underlying data (to-be) stored by this attribute
		/// </param>
		/// <param name="bValidateExistsOnAsset">
		/// Whether or not the attribute should exist on the AnimationAsset. False by default.
		/// </param>
		/// <returns>
		/// Valid FAnimationCurveIdentifier if the operation was successful
		/// </returns>
		public static FAnimationAttributeIdentifier CreateAttributeIdentifier(UAnimationAsset AnimationAsset, FName AttributeName, FName BoneName, UScriptStruct AttributeType, bool bValidateExistsOnAsset = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = AnimationAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = AttributeType?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bValidateExistsOnAsset;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateAttributeIdentifier, __InBuffer, __ReturnBuffer);

				return *(FAnimationAttributeIdentifier*)__ReturnBuffer;
			}
		}

		private static uint __IsValid = 0;

		private static uint __CreateAttributeIdentifier = 0;
	}
}