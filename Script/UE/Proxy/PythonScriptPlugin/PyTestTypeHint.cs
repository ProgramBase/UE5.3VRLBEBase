using Script.CoreUObject;
using Script.Library;
using Script.Reflection.Property;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.PyTestTypeHint")]
	public partial class UPyTestTypeHint : UObject, IStaticClass
	{
		public bool BoolProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BoolProp, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BoolProp, __InBuffer);
				}
			}
		}

		public int IntProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IntProp, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IntProp, __InBuffer);
				}
			}
		}

		public float FloatProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FloatProp, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FloatProp, __InBuffer);
				}
			}
		}

		public EPyTestEnum EnumProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EnumProp, __ReturnBuffer);

					return *(EPyTestEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EnumProp, __InBuffer);
				}
			}
		}

		public FString StringProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StringProp, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StringProp, __InBuffer);
				}
			}
		}

		public FName NameProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NameProp, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NameProp, __InBuffer);
				}
			}
		}

		public FText TextProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextProp, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextProp, __InBuffer);
				}
			}
		}

		public TFieldPath<FProperty> FieldPathProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FieldPathProp, __ReturnBuffer);

					return *(TFieldPath<FProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FieldPathProp, __InBuffer);
				}
			}
		}

		public FPyTestStruct StructProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StructProp, __ReturnBuffer);

					return *(FPyTestStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StructProp, __InBuffer);
				}
			}
		}

		public UPyTestObject ObjectProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectProp, __ReturnBuffer);

					return *(UPyTestObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectProp, __InBuffer);
				}
			}
		}

		public TArray<FString> StrArrayProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StrArrayProp, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StrArrayProp, __InBuffer);
				}
			}
		}

		public TArray<FName> NameArrayProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NameArrayProp, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NameArrayProp, __InBuffer);
				}
			}
		}

		public TArray<FText> TextArrayProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TextArrayProp, __ReturnBuffer);

					return *(TArray<FText>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TextArrayProp, __InBuffer);
				}
			}
		}

		public TArray<UObject> ObjectArrayProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectArrayProp, __ReturnBuffer);

					return *(TArray<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectArrayProp, __InBuffer);
				}
			}
		}

		public TSet<FString> SetProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SetProp, __ReturnBuffer);

					return *(TSet<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SetProp, __InBuffer);
				}
			}
		}

		public TMap<int, FString> MapProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MapProp, __ReturnBuffer);

					return *(TMap<int, FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MapProp, __InBuffer);
				}
			}
		}

		public FPyTestDelegate DelegateProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DelegateProp, __ReturnBuffer);

					return *(FPyTestDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DelegateProp, __InBuffer);
				}
			}
		}

		public FPyTestMulticastDelegate MulticastDelegateProp
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MulticastDelegateProp, __ReturnBuffer);

					return *(FPyTestMulticastDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MulticastDelegateProp, __InBuffer);
				}
			}
		}

		public FPyTestSlateTickDelegate SlateTickDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SlateTickDelegate, __ReturnBuffer);

					return *(FPyTestSlateTickDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SlateTickDelegate, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PythonScriptPlugin.PyTestTypeHint");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FString GetStringConst()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetStringConst, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static int GetIntConst()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetIntConst, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int CheckTupleReturnType(ref FString InOutString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InOutString?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __CheckTupleReturnType, __InBuffer, __OutBuffer, __ReturnBuffer);

				InOutString = *(FString*)(__OutBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual FText CheckTextTypeHints(FText Param1, FText Param2 = null)
		{
			unsafe
			{
				Param2 ??= new FText("Hi");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Param1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Param2?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CheckTextTypeHints, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public virtual FPyTestStruct CheckStructTypeHints(FPyTestStruct Param1, FPyTestStruct Param2 = null)
		{
			unsafe
			{
				Param2 ??= new FPyTestStruct();

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Param1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Param2?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CheckStructTypeHints, __InBuffer, __ReturnBuffer);

				return *(FPyTestStruct*)__ReturnBuffer;
			}
		}

		public virtual FString CheckStringTypeHints(FString Param1, FString Param2 = null)
		{
			unsafe
			{
				Param2 ??= new FString("Hi");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Param1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Param2?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CheckStringTypeHints, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static bool CheckStaticFunction(bool Param1, int Param2, double Param3, FString Param4)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(bool*)(__InBuffer) = Param1;

				*(int*)(__InBuffer + 1) = Param2;

				*(double*)(__InBuffer + 5) = Param3;

				*(nint*)(__InBuffer + 13) = Param4?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CheckStaticFunction, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TSet<FName> CheckSetTypeHints(TSet<FString> Param1, TSet<FName> Param2, TSet<UObject> Param3)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Param1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Param2?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Param3?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CheckSetTypeHints, __InBuffer, __ReturnBuffer);

				return *(TSet<FName>*)__ReturnBuffer;
			}
		}

		public virtual UPyTestObject CheckObjectTypeHints(UPyTestObject Param1, UPyTestObject Param4 = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Param1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Param4?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CheckObjectTypeHints, __InBuffer, __ReturnBuffer);

				return *(UPyTestObject*)__ReturnBuffer;
			}
		}

		public virtual FName CheckNameTypeHints(FName Param1, FName Param2 = null)
		{
			unsafe
			{
				Param2 ??= new FName("Hi");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Param1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Param2?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CheckNameTypeHints, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual TMap<FString, UObject> CheckMapTypeHints(TMap<int, FString> Param1, TMap<int, FName> Param2, TMap<int, FText> Param3, TMap<int, UObject> Param4)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Param1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Param2?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Param3?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Param4?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CheckMapTypeHints, __InBuffer, __ReturnBuffer);

				return *(TMap<FString, UObject>*)__ReturnBuffer;
			}
		}

		public virtual int CheckIntegerTypeHints(byte Param1, int Param2 = 4, long Param3 = 5)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(byte*)(__InBuffer) = Param1;

				*(int*)(__InBuffer + 1) = Param2;

				*(long*)(__InBuffer + 5) = Param3;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CheckIntegerTypeHints, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual double CheckFloatTypeHints(float Param1, double Param2, float Param3 = -3.300000f, double Param4 = 4.400000)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(float*)(__InBuffer) = Param1;

				*(double*)(__InBuffer + 4) = Param2;

				*(float*)(__InBuffer + 12) = Param3;

				*(double*)(__InBuffer + 16) = Param4;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CheckFloatTypeHints, __InBuffer, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public virtual TFieldPath<FProperty> CheckFieldPathTypeHints(TFieldPath<FProperty> Param1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Param1?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CheckFieldPathTypeHints, __InBuffer, __ReturnBuffer);

				return *(TFieldPath<FProperty>*)__ReturnBuffer;
			}
		}

		public virtual EPyTestEnum CheckEnumTypeHints(EPyTestEnum Param1, EPyTestEnum Param2 = EPyTestEnum.One)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = (byte)Param1;

				*(byte*)(__InBuffer + 1) = (byte)Param2;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CheckEnumTypeHints, __InBuffer, __ReturnBuffer);

				return *(EPyTestEnum*)__ReturnBuffer;
			}
		}

		public virtual FPyTestDelegate CheckDelegateTypeHints(FPyTestDelegate Param1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Param1?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CheckDelegateTypeHints, __InBuffer, __ReturnBuffer);

				return *(FPyTestDelegate*)__ReturnBuffer;
			}
		}

		public virtual bool CheckBoolTypeHints(bool bParam1, bool bParam2 = true, bool bParam3 = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[3];

				*(bool*)(__InBuffer) = bParam1;

				*(bool*)(__InBuffer + 1) = bParam2;

				*(bool*)(__InBuffer + 2) = bParam3;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CheckBoolTypeHints, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TArray<FText> CheckArrayTypeHints(TArray<FString> Param1, TArray<FName> Param2, TArray<FText> Param3, TArray<UObject> Param4)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Param1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Param2?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Param3?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Param4?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CheckArrayTypeHints, __InBuffer, __ReturnBuffer);

				return *(TArray<FText>*)__ReturnBuffer;
			}
		}

		private static uint __BoolProp = 0;

		private static uint __IntProp = 0;

		private static uint __FloatProp = 0;

		private static uint __EnumProp = 0;

		private static uint __StringProp = 0;

		private static uint __NameProp = 0;

		private static uint __TextProp = 0;

		private static uint __FieldPathProp = 0;

		private static uint __StructProp = 0;

		private static uint __ObjectProp = 0;

		private static uint __StrArrayProp = 0;

		private static uint __NameArrayProp = 0;

		private static uint __TextArrayProp = 0;

		private static uint __ObjectArrayProp = 0;

		private static uint __SetProp = 0;

		private static uint __MapProp = 0;

		private static uint __DelegateProp = 0;

		private static uint __MulticastDelegateProp = 0;

		private static uint __SlateTickDelegate = 0;

		private static uint __GetStringConst = 0;

		private static uint __GetIntConst = 0;

		private static uint __CheckTupleReturnType = 0;

		private static uint __CheckTextTypeHints = 0;

		private static uint __CheckStructTypeHints = 0;

		private static uint __CheckStringTypeHints = 0;

		private static uint __CheckStaticFunction = 0;

		private static uint __CheckSetTypeHints = 0;

		private static uint __CheckObjectTypeHints = 0;

		private static uint __CheckNameTypeHints = 0;

		private static uint __CheckMapTypeHints = 0;

		private static uint __CheckIntegerTypeHints = 0;

		private static uint __CheckFloatTypeHints = 0;

		private static uint __CheckFieldPathTypeHints = 0;

		private static uint __CheckEnumTypeHints = 0;

		private static uint __CheckDelegateTypeHints = 0;

		private static uint __CheckBoolTypeHints = 0;

		private static uint __CheckArrayTypeHints = 0;
	}
}