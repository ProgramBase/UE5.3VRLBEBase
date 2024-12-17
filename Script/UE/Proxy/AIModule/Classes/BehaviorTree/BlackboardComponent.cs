using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.BlackboardComponent")]
	public partial class UBlackboardComponent : UActorComponent, IStaticClass
	{
		public UBrainComponent BrainComp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BrainComp, __ReturnBuffer);

					return *(UBrainComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BrainComp, __InBuffer);
				}
			}
		}

		public UBlackboardData DefaultBlackboardAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultBlackboardAsset, __ReturnBuffer);

					return *(UBlackboardData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultBlackboardAsset, __InBuffer);
				}
			}
		}

		public UBlackboardData BlackboardAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BlackboardAsset, __ReturnBuffer);

					return *(UBlackboardData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BlackboardAsset, __InBuffer);
				}
			}
		}

		public TArray<UBlackboardKeyType> KeyInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __KeyInstances, __ReturnBuffer);

					return *(TArray<UBlackboardKeyType>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __KeyInstances, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.BlackboardComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetValueAsVector(FName KeyName, FVector VectorValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VectorValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetValueAsVector, __InBuffer);
			}
		}

		public virtual void SetValueAsString(FName KeyName, FString StringValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StringValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetValueAsString, __InBuffer);
			}
		}

		public virtual void SetValueAsRotator(FName KeyName, FRotator VectorValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VectorValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetValueAsRotator, __InBuffer);
			}
		}

		public virtual void SetValueAsObject(FName KeyName, UObject ObjectValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ObjectValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetValueAsObject, __InBuffer);
			}
		}

		public virtual void SetValueAsName(FName KeyName, FName NameValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NameValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetValueAsName, __InBuffer);
			}
		}

		public virtual void SetValueAsInt(FName KeyName, int IntValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = IntValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetValueAsInt, __InBuffer);
			}
		}

		public virtual void SetValueAsFloat(FName KeyName, float FloatValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = FloatValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetValueAsFloat, __InBuffer);
			}
		}

		public virtual void SetValueAsEnum(FName KeyName, byte EnumValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = EnumValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetValueAsEnum, __InBuffer);
			}
		}

		public virtual void SetValueAsClass(FName KeyName, UClass ClassValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ClassValue?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetValueAsClass, __InBuffer);
			}
		}

		public virtual void SetValueAsBool(FName KeyName, bool BoolValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = BoolValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetValueAsBool, __InBuffer);
			}
		}

		public virtual bool IsVectorValueSet(FName KeyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsVectorValueSet, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FVector GetValueAsVector(FName KeyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetValueAsVector, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual FString GetValueAsString(FName KeyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetValueAsString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual FRotator GetValueAsRotator(FName KeyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetValueAsRotator, __InBuffer, __ReturnBuffer);

				return *(FRotator*)__ReturnBuffer;
			}
		}

		public virtual UObject GetValueAsObject(FName KeyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetValueAsObject, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public virtual FName GetValueAsName(FName KeyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetValueAsName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual int GetValueAsInt(FName KeyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetValueAsInt, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual float GetValueAsFloat(FName KeyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetValueAsFloat, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual byte GetValueAsEnum(FName KeyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetValueAsEnum, __InBuffer, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		public virtual UClass GetValueAsClass(FName KeyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetValueAsClass, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		public virtual bool GetValueAsBool(FName KeyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetValueAsBool, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetRotationFromEntry(FName KeyName, ref FRotator ResultRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ResultRotation?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetRotationFromEntry, __InBuffer, __OutBuffer, __ReturnBuffer);

				ResultRotation = *(FRotator*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetLocationFromEntry(FName KeyName, ref FVector ResultLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ResultLocation?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetLocationFromEntry, __InBuffer, __OutBuffer, __ReturnBuffer);

				ResultLocation = *(FVector*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ClearValue(FName KeyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = KeyName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ClearValue, __InBuffer);
			}
		}

		private static uint __BrainComp = 0;

		private static uint __DefaultBlackboardAsset = 0;

		private static uint __BlackboardAsset = 0;

		private static uint __KeyInstances = 0;

		private static uint __SetValueAsVector = 0;

		private static uint __SetValueAsString = 0;

		private static uint __SetValueAsRotator = 0;

		private static uint __SetValueAsObject = 0;

		private static uint __SetValueAsName = 0;

		private static uint __SetValueAsInt = 0;

		private static uint __SetValueAsFloat = 0;

		private static uint __SetValueAsEnum = 0;

		private static uint __SetValueAsClass = 0;

		private static uint __SetValueAsBool = 0;

		private static uint __IsVectorValueSet = 0;

		private static uint __GetValueAsVector = 0;

		private static uint __GetValueAsString = 0;

		private static uint __GetValueAsRotator = 0;

		private static uint __GetValueAsObject = 0;

		private static uint __GetValueAsName = 0;

		private static uint __GetValueAsInt = 0;

		private static uint __GetValueAsFloat = 0;

		private static uint __GetValueAsEnum = 0;

		private static uint __GetValueAsClass = 0;

		private static uint __GetValueAsBool = 0;

		private static uint __GetRotationFromEntry = 0;

		private static uint __GetLocationFromEntry = 0;

		private static uint __ClearValue = 0;
	}
}