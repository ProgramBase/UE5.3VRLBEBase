using Script.CoreUObject;
using Script.Library;

namespace Script.PropertyEditor
{
	[PathName("/Script/PropertyEditor.EditConditionTestObject")]
	public partial class UEditConditionTestObject : UObject, IStaticClass
	{
		public bool BoolProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BoolProperty, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BoolProperty, __InBuffer);
				}
			}
		}

		public EditConditionTestEnum EnumProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EnumProperty, __ReturnBuffer);

					return *(EditConditionTestEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = (int)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EnumProperty, __InBuffer);
				}
			}
		}

		public EditConditionByteEnum ByteEnumProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ByteEnumProperty, __ReturnBuffer);

					return *(EditConditionByteEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ByteEnumProperty, __InBuffer);
				}
			}
		}

		public double DoubleProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DoubleProperty, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DoubleProperty, __InBuffer);
				}
			}
		}

		public int IntegerProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __IntegerProperty, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __IntegerProperty, __InBuffer);
				}
			}
		}

		public bool UintBitfieldProperty
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UintBitfieldProperty, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UintBitfieldProperty, __InBuffer);
				}
			}
		}

		public UObject UObjectPtr
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UObjectPtr, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UObjectPtr, __InBuffer);
				}
			}
		}

		public TSoftClassPtr<UObject> SoftClassPtr
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SoftClassPtr, __ReturnBuffer);

					return *(TSoftClassPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SoftClassPtr, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UObject> WeakObjectPtr
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WeakObjectPtr, __ReturnBuffer);

					return *(TWeakObjectPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WeakObjectPtr, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PropertyEditor.EditConditionTestObject");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void VoidFunction()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __VoidFunction);
			}
		}

		public virtual void StaticVoidFunction()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StaticVoidFunction);
			}
		}

		public static TWeakObjectPtr<UObject> StaticGetWeakObjectPtrFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __StaticGetWeakObjectPtrFunction, __ReturnBuffer);

				return *(TWeakObjectPtr<UObject>*)__ReturnBuffer;
			}
		}

		public static UObject StaticGetUObjectPtrFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __StaticGetUObjectPtrFunction, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public static byte StaticGetUintBitfieldFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __StaticGetUintBitfieldFunction, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		public static TSoftClassPtr<UObject> StaticGetSoftClassPtrFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __StaticGetSoftClassPtrFunction, __ReturnBuffer);

				return *(TSoftClassPtr<UObject>*)__ReturnBuffer;
			}
		}

		public static int StaticGetIntegerFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __StaticGetIntegerFunction, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static EditConditionTestEnum StaticGetEnumFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __StaticGetEnumFunction, __ReturnBuffer);

				return *(EditConditionTestEnum*)__ReturnBuffer;
			}
		}

		public static double StaticGetDoubleFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __StaticGetDoubleFunction, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public static EditConditionByteEnum StaticGetByteEnumFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __StaticGetByteEnumFunction, __ReturnBuffer);

				return *(EditConditionByteEnum*)__ReturnBuffer;
			}
		}

		public static bool StaticGetBoolFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __StaticGetBoolFunction, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual TWeakObjectPtr<UObject> GetWeakObjectPtrFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetWeakObjectPtrFunction, __ReturnBuffer);

				return *(TWeakObjectPtr<UObject>*)__ReturnBuffer;
			}
		}

		public virtual UObject GetUObjectPtrFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetUObjectPtrFunction, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public virtual byte GetUintBitfieldFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetUintBitfieldFunction, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		public virtual TSoftClassPtr<UObject> GetSoftClassPtrFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSoftClassPtrFunction, __ReturnBuffer);

				return *(TSoftClassPtr<UObject>*)__ReturnBuffer;
			}
		}

		public virtual int GetIntegerFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetIntegerFunction, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual EditConditionTestEnum GetEnumFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetEnumFunction, __ReturnBuffer);

				return *(EditConditionTestEnum*)__ReturnBuffer;
			}
		}

		public virtual double GetDoubleFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDoubleFunction, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public virtual EditConditionByteEnum GetByteEnumFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetByteEnumFunction, __ReturnBuffer);

				return *(EditConditionByteEnum*)__ReturnBuffer;
			}
		}

		public virtual bool GetBoolFunction()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetBoolFunction, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __BoolProperty = 0;

		private static uint __EnumProperty = 0;

		private static uint __ByteEnumProperty = 0;

		private static uint __DoubleProperty = 0;

		private static uint __IntegerProperty = 0;

		private static uint __UintBitfieldProperty = 0;

		private static uint __UObjectPtr = 0;

		private static uint __SoftClassPtr = 0;

		private static uint __WeakObjectPtr = 0;

		private static uint __VoidFunction = 0;

		private static uint __StaticVoidFunction = 0;

		private static uint __StaticGetWeakObjectPtrFunction = 0;

		private static uint __StaticGetUObjectPtrFunction = 0;

		private static uint __StaticGetUintBitfieldFunction = 0;

		private static uint __StaticGetSoftClassPtrFunction = 0;

		private static uint __StaticGetIntegerFunction = 0;

		private static uint __StaticGetEnumFunction = 0;

		private static uint __StaticGetDoubleFunction = 0;

		private static uint __StaticGetByteEnumFunction = 0;

		private static uint __StaticGetBoolFunction = 0;

		private static uint __GetWeakObjectPtrFunction = 0;

		private static uint __GetUObjectPtrFunction = 0;

		private static uint __GetUintBitfieldFunction = 0;

		private static uint __GetSoftClassPtrFunction = 0;

		private static uint __GetIntegerFunction = 0;

		private static uint __GetEnumFunction = 0;

		private static uint __GetDoubleFunction = 0;

		private static uint __GetByteEnumFunction = 0;

		private static uint __GetBoolFunction = 0;
	}
}