using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BTFunctionLibrary")]
	public partial class UBTFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BTFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void StopUsingExternalEvent(UBTNode NodeOwner)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __StopUsingExternalEvent, __InBuffer);
			}
		}

		public static void StartUsingExternalEvent(UBTNode NodeOwner, AActor OwningActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OwningActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __StartUsingExternalEvent, __InBuffer);
			}
		}

		public static void SetBlackboardValueAsVector(UBTNode NodeOwner, FBlackboardKeySelector Key, FVector Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBlackboardValueAsVector, __InBuffer);
			}
		}

		public static void SetBlackboardValueAsString(UBTNode NodeOwner, FBlackboardKeySelector Key, FString Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBlackboardValueAsString, __InBuffer);
			}
		}

		public static void SetBlackboardValueAsRotator(UBTNode NodeOwner, FBlackboardKeySelector Key, FRotator Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBlackboardValueAsRotator, __InBuffer);
			}
		}

		public static void SetBlackboardValueAsObject(UBTNode NodeOwner, FBlackboardKeySelector Key, UObject Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBlackboardValueAsObject, __InBuffer);
			}
		}

		public static void SetBlackboardValueAsName(UBTNode NodeOwner, FBlackboardKeySelector Key, FName Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBlackboardValueAsName, __InBuffer);
			}
		}

		public static void SetBlackboardValueAsInt(UBTNode NodeOwner, FBlackboardKeySelector Key, int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBlackboardValueAsInt, __InBuffer);
			}
		}

		public static void SetBlackboardValueAsFloat(UBTNode NodeOwner, FBlackboardKeySelector Key, float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBlackboardValueAsFloat, __InBuffer);
			}
		}

		public static void SetBlackboardValueAsEnum(UBTNode NodeOwner, FBlackboardKeySelector Key, byte Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBlackboardValueAsEnum, __InBuffer);
			}
		}

		public static void SetBlackboardValueAsClass(UBTNode NodeOwner, FBlackboardKeySelector Key, UClass Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBlackboardValueAsClass, __InBuffer);
			}
		}

		public static void SetBlackboardValueAsBool(UBTNode NodeOwner, FBlackboardKeySelector Key, bool Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBlackboardValueAsBool, __InBuffer);
			}
		}

		public static UBlackboardComponent GetOwnersBlackboard(UBTNode NodeOwner)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetOwnersBlackboard, __InBuffer, __ReturnBuffer);

				return *(UBlackboardComponent*)__ReturnBuffer;
			}
		}

		public static UBehaviorTreeComponent GetOwnerComponent(UBTNode NodeOwner)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetOwnerComponent, __InBuffer, __ReturnBuffer);

				return *(UBehaviorTreeComponent*)__ReturnBuffer;
			}
		}

		public static FVector GetBlackboardValueAsVector(UBTNode NodeOwner, FBlackboardKeySelector Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBlackboardValueAsVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public static FString GetBlackboardValueAsString(UBTNode NodeOwner, FBlackboardKeySelector Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBlackboardValueAsString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FRotator GetBlackboardValueAsRotator(UBTNode NodeOwner, FBlackboardKeySelector Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBlackboardValueAsRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public static UObject GetBlackboardValueAsObject(UBTNode NodeOwner, FBlackboardKeySelector Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBlackboardValueAsObject, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public static FName GetBlackboardValueAsName(UBTNode NodeOwner, FBlackboardKeySelector Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBlackboardValueAsName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public static int GetBlackboardValueAsInt(UBTNode NodeOwner, FBlackboardKeySelector Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBlackboardValueAsInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static float GetBlackboardValueAsFloat(UBTNode NodeOwner, FBlackboardKeySelector Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBlackboardValueAsFloat, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static byte GetBlackboardValueAsEnum(UBTNode NodeOwner, FBlackboardKeySelector Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBlackboardValueAsEnum, __InBuffer, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		public static UClass GetBlackboardValueAsClass(UBTNode NodeOwner, FBlackboardKeySelector Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBlackboardValueAsClass, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		public static bool GetBlackboardValueAsBool(UBTNode NodeOwner, FBlackboardKeySelector Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBlackboardValueAsBool, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static AActor GetBlackboardValueAsActor(UBTNode NodeOwner, FBlackboardKeySelector Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBlackboardValueAsActor, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public static void ClearBlackboardValueAsVector(UBTNode NodeOwner, FBlackboardKeySelector Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ClearBlackboardValueAsVector, __InBuffer);
			}
		}

		public static void ClearBlackboardValue(UBTNode NodeOwner, FBlackboardKeySelector Key)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeOwner?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ClearBlackboardValue, __InBuffer);
			}
		}

		private static uint __StopUsingExternalEvent = 0;

		private static uint __StartUsingExternalEvent = 0;

		private static uint __SetBlackboardValueAsVector = 0;

		private static uint __SetBlackboardValueAsString = 0;

		private static uint __SetBlackboardValueAsRotator = 0;

		private static uint __SetBlackboardValueAsObject = 0;

		private static uint __SetBlackboardValueAsName = 0;

		private static uint __SetBlackboardValueAsInt = 0;

		private static uint __SetBlackboardValueAsFloat = 0;

		private static uint __SetBlackboardValueAsEnum = 0;

		private static uint __SetBlackboardValueAsClass = 0;

		private static uint __SetBlackboardValueAsBool = 0;

		private static uint __GetOwnersBlackboard = 0;

		private static uint __GetOwnerComponent = 0;

		private static uint __GetBlackboardValueAsVector = 0;

		private static uint __GetBlackboardValueAsString = 0;

		private static uint __GetBlackboardValueAsRotator = 0;

		private static uint __GetBlackboardValueAsObject = 0;

		private static uint __GetBlackboardValueAsName = 0;

		private static uint __GetBlackboardValueAsInt = 0;

		private static uint __GetBlackboardValueAsFloat = 0;

		private static uint __GetBlackboardValueAsEnum = 0;

		private static uint __GetBlackboardValueAsClass = 0;

		private static uint __GetBlackboardValueAsBool = 0;

		private static uint __GetBlackboardValueAsActor = 0;

		private static uint __ClearBlackboardValueAsVector = 0;

		private static uint __ClearBlackboardValue = 0;
	}
}