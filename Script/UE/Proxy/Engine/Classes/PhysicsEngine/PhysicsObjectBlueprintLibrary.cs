using Script.CoreUObject;
using Script.Library;
using Script.Chaos;
using Script.PhysicsCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.PhysicsObjectBlueprintLibrary")]
	public partial class UPhysicsObjectBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PhysicsObjectBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FTransform GetPhysicsObjectWorldTransform(UPrimitiveComponent Component, FName BoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetPhysicsObjectWorldTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public static FClosestPhysicsObjectResult GetClosestPhysicsObjectFromWorldLocation(UPrimitiveComponent Component, FVector WorldLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = WorldLocation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetClosestPhysicsObjectFromWorldLocation, __InBuffer, __ReturnBuffer);

				return *(FClosestPhysicsObjectResult*)__ReturnBuffer;
			}
		}

		public static bool ExtractClosestPhysicsObjectResults(FClosestPhysicsObjectResult Result, ref FName OutName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Result?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __ExtractClosestPhysicsObjectResults, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutName = *(FName*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void ApplyRadialImpulse(UPrimitiveComponent Component, FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bApplyStrain)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Radius;

				*(float*)(__InBuffer + 20) = Strength;

				*(byte*)(__InBuffer + 24) = (byte)Falloff;

				*(bool*)(__InBuffer + 25) = bApplyStrain;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ApplyRadialImpulse, __InBuffer);
			}
		}

		private static uint __GetPhysicsObjectWorldTransform = 0;

		private static uint __GetClosestPhysicsObjectFromWorldLocation = 0;

		private static uint __ExtractClosestPhysicsObjectResults = 0;

		private static uint __ApplyRadialImpulse = 0;
	}
}