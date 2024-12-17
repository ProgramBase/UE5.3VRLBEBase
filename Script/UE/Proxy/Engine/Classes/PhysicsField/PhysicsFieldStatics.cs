using Script.CoreUObject;
using Script.Library;
using Script.Chaos;

namespace Script.Engine
{
	[PathName("/Script/Engine.PhysicsFieldStatics")]
	public partial class UPhysicsFieldStatics : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PhysicsFieldStatics");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FVector EvalPhysicsVectorField(UObject WorldContextObject, FVector WorldPosition, EFieldVectorType VectorType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = WorldPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)VectorType;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __EvalPhysicsVectorField, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static float EvalPhysicsScalarField(UObject WorldContextObject, FVector WorldPosition, EFieldScalarType ScalarType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = WorldPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)ScalarType;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EvalPhysicsScalarField, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static int EvalPhysicsIntegerField(UObject WorldContextObject, FVector WorldPosition, EFieldIntegerType IntegerType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = WorldPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)IntegerType;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __EvalPhysicsIntegerField, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __EvalPhysicsVectorField = 0;

		private static uint __EvalPhysicsScalarField = 0;

		private static uint __EvalPhysicsIntegerField = 0;
	}
}