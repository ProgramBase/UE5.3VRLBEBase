using Script.CoreUObject;
using Script.Reflection.Property;
using Script.Library;

namespace Script.PythonScriptPlugin
{
	[PathName("/Script/PythonScriptPlugin.PyTestObject")]
	public partial class UPyTestObject : UObject, IStaticClass, IPyTestChildInterface, IPyTestOtherInterface
	{
		public bool Bool
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Bool, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Bool, __InBuffer);
				}
			}
		}

		public int Int
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Int, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Int, __InBuffer);
				}
			}
		}

		public float Float
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Float, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Float, __InBuffer);
				}
			}
		}

		public EPyTestEnum Enum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Enum, __ReturnBuffer);

					return *(EPyTestEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Enum, __InBuffer);
				}
			}
		}

		public FString String
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __String, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __String, __InBuffer);
				}
			}
		}

		public FName Name
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Name, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Name, __InBuffer);
				}
			}
		}

		public FText Text
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Text, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Text, __InBuffer);
				}
			}
		}

		public TFieldPath<FProperty> FieldPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FieldPath, __ReturnBuffer);

					return *(TFieldPath<FProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FieldPath, __InBuffer);
				}
			}
		}

		public TFieldPath<FStructProperty> StructFieldPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StructFieldPath, __ReturnBuffer);

					return *(TFieldPath<FStructProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StructFieldPath, __InBuffer);
				}
			}
		}

		public TArray<FString> StringArray
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StringArray, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StringArray, __InBuffer);
				}
			}
		}

		public TSet<FString> StringSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StringSet, __ReturnBuffer);

					return *(TSet<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StringSet, __InBuffer);
				}
			}
		}

		public TMap<FString, int> StringIntMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StringIntMap, __ReturnBuffer);

					return *(TMap<FString, int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StringIntMap, __InBuffer);
				}
			}
		}

		public FPyTestDelegate Delegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Delegate, __ReturnBuffer);

					return *(FPyTestDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Delegate, __InBuffer);
				}
			}
		}

		public FPyTestMulticastDelegate MulticastDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MulticastDelegate, __ReturnBuffer);

					return *(FPyTestMulticastDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MulticastDelegate, __InBuffer);
				}
			}
		}

		public FPyTestStruct Struct
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Struct, __ReturnBuffer);

					return *(FPyTestStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Struct, __InBuffer);
				}
			}
		}

		public TArray<FPyTestStruct> StructArray
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StructArray, __ReturnBuffer);

					return *(TArray<FPyTestStruct>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StructArray, __InBuffer);
				}
			}
		}

		public FPyTestChildStruct ChildStruct
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChildStruct, __ReturnBuffer);

					return *(FPyTestChildStruct*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChildStruct, __InBuffer);
				}
			}
		}

		public bool BoolInstanceOnly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BoolInstanceOnly, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BoolInstanceOnly, __InBuffer);
				}
			}
		}

		public bool BoolDefaultsOnly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BoolDefaultsOnly, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BoolDefaultsOnly, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PythonScriptPlugin.PyTestObject");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual int FuncInterfaceChild(int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InValue;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __FuncInterfaceChild, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int FuncInterface(int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InValue;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __FuncInterface, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual int FuncInterfaceOther(int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InValue;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __FuncInterfaceOther, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static TSet<int> ReturnSet()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ReturnSet, __ReturnBuffer);

				return *(TSet<int>*)__ReturnBuffer;
			}
		}

		public static TMap<int, bool> ReturnMap()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ReturnMap, __ReturnBuffer);

				return *(TMap<int, bool>*)__ReturnBuffer;
			}
		}

		public static TFieldPath<FProperty> ReturnFieldPath()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ReturnFieldPath, __ReturnBuffer);

				return *(TFieldPath<FProperty>*)__ReturnBuffer;
			}
		}

		public static TArray<int> ReturnArray()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __ReturnArray, __ReturnBuffer);

				return *(TArray<int>*)__ReturnBuffer;
			}
		}

		public virtual void MulticastDelegatePropertyCallback(FString InStr)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStr?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __MulticastDelegatePropertyCallback, __InBuffer);
			}
		}

		public virtual void LegacyFuncTakingPyTestStruct(FPyTestStruct InStruct)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStruct?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __LegacyFuncTakingPyTestStruct, __InBuffer);
			}
		}

		public static int GetConstantValue()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetConstantValue, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void FuncTakingPyTestStructDefault(FPyTestStruct InStruct = null)
		{
			unsafe
			{
				InStruct ??= new FPyTestStruct();

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStruct?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __FuncTakingPyTestStructDefault, __InBuffer);
			}
		}

		public virtual void FuncTakingPyTestStruct(FPyTestStruct InStruct)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStruct?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __FuncTakingPyTestStruct, __InBuffer);
			}
		}

		public virtual int FuncTakingPyTestDelegate(FPyTestDelegate InDelegate, int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InDelegate?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InValue;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __FuncTakingPyTestDelegate, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void FuncTakingPyTestChildStruct(FPyTestChildStruct InStruct)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStruct?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __FuncTakingPyTestChildStruct, __InBuffer);
			}
		}

		public virtual void FuncTakingFieldPath(TFieldPath<FProperty> InFieldPath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InFieldPath?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __FuncTakingFieldPath, __InBuffer);
			}
		}

		public virtual void FuncBlueprintNativeRef(ref FPyTestStruct InOutStruct)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InOutStruct?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __FuncBlueprintNativeRef, __InBuffer, __OutBuffer);

				InOutStruct = *(FPyTestStruct*)(__OutBuffer);

			}
		}

		public virtual int FuncBlueprintNative(int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InValue;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __FuncBlueprintNative, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int FuncBlueprintImplementable(int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InValue;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall3Implementation(GarbageCollectionHandle, __FuncBlueprintImplementable, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static void EmitScriptWarning()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __EmitScriptWarning);
			}
		}

		public static void EmitScriptError()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __EmitScriptError);
			}
		}

		public virtual int DelegatePropertyCallback(int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InValue;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DelegatePropertyCallback, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void CallFuncBlueprintNativeRef(ref FPyTestStruct InOutStruct)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InOutStruct?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __CallFuncBlueprintNativeRef, __InBuffer, __OutBuffer);

				InOutStruct = *(FPyTestStruct*)(__OutBuffer);

			}
		}

		public virtual int CallFuncBlueprintNative(int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InValue;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CallFuncBlueprintNative, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int CallFuncBlueprintImplementable(int InValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InValue;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CallFuncBlueprintImplementable, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		private static uint __Bool = 0;

		private static uint __Int = 0;

		private static uint __Float = 0;

		private static uint __Enum = 0;

		private static uint __String = 0;

		private static uint __Name = 0;

		private static uint __Text = 0;

		private static uint __FieldPath = 0;

		private static uint __StructFieldPath = 0;

		private static uint __StringArray = 0;

		private static uint __StringSet = 0;

		private static uint __StringIntMap = 0;

		private static uint __Delegate = 0;

		private static uint __MulticastDelegate = 0;

		private static uint __Struct = 0;

		private static uint __StructArray = 0;

		private static uint __ChildStruct = 0;

		private static uint __BoolInstanceOnly = 0;

		private static uint __BoolDefaultsOnly = 0;

		private static uint __FuncInterfaceChild = 0;

		private static uint __FuncInterface = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __FuncInterfaceOther = 0;

		private static uint __ReturnSet = 0;

		private static uint __ReturnMap = 0;

		private static uint __ReturnFieldPath = 0;

		private static uint __ReturnArray = 0;

		private static uint __MulticastDelegatePropertyCallback = 0;

		private static uint __LegacyFuncTakingPyTestStruct = 0;

		private static uint __GetConstantValue = 0;

		private static uint __FuncTakingPyTestStructDefault = 0;

		private static uint __FuncTakingPyTestStruct = 0;

		private static uint __FuncTakingPyTestDelegate = 0;

		private static uint __FuncTakingPyTestChildStruct = 0;

		private static uint __FuncTakingFieldPath = 0;

		private static uint __FuncBlueprintNativeRef = 0;

		private static uint __FuncBlueprintNative = 0;

		private static uint __FuncBlueprintImplementable = 0;

		private static uint __EmitScriptWarning = 0;

		private static uint __EmitScriptError = 0;

		private static uint __DelegatePropertyCallback = 0;

		private static uint __CallFuncBlueprintNativeRef = 0;

		private static uint __CallFuncBlueprintNative = 0;

		private static uint __CallFuncBlueprintImplementable = 0;
	}
}