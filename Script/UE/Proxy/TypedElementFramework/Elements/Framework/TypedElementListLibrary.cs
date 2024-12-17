using Script.CoreUObject;
using Script.Library;

namespace Script.TypedElementFramework
{
	[PathName("/Script/TypedElementFramework.TypedElementListLibrary")]
	public partial class UTypedElementListLibrary : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TypedElementFramework.TypedElementListLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void Shrink(FScriptTypedElementListProxy ElementList)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Shrink, __InBuffer);
			}
		}

		public static void Reset(FScriptTypedElementListProxy ElementList)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Reset, __InBuffer);
			}
		}

		public static void Reserve(FScriptTypedElementListProxy ElementList, int Size)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Size;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Reserve, __InBuffer);
			}
		}

		/// <returns>
		/// True if the element handle was removed, false if it isn't in the list.
		/// </returns>
		public static bool Remove(FScriptTypedElementListProxy ElementList, FScriptTypedElementHandle ElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Remove, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static int Num(FScriptTypedElementListProxy ElementList)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Num, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static bool IsValidIndex(FScriptTypedElementListProxy ElementList, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValidIndex, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool HasElementsOfType(FScriptTypedElementListProxy ElementList, FName ElementTypeName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ElementTypeName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasElementsOfType, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool HasElements(FScriptTypedElementListProxy ElementList, TSubclassOf<UInterface> BaseInterfaceType = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BaseInterfaceType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasElements, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static UObject GetElementInterface(FScriptTypedElementListProxy ElementList, FScriptTypedElementHandle ElementHandle, TSubclassOf<UInterface> BaseInterfaceType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BaseInterfaceType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetElementInterface, __InBuffer, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public static TArray<FScriptTypedElementHandle> GetElementHandles(FScriptTypedElementListProxy ElementList, TSubclassOf<UInterface> BaseInterfaceType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BaseInterfaceType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetElementHandles, __InBuffer, __ReturnBuffer);

				return *(TArray<FScriptTypedElementHandle>*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Use IsValidIndex to test for validity.
		/// </note>
		public static FScriptTypedElementHandle GetElementHandleAt(FScriptTypedElementListProxy ElementList, int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetElementHandleAt, __InBuffer, __ReturnBuffer);

				return *(FScriptTypedElementHandle*)__ReturnBuffer;
			}
		}

		public static void Empty(FScriptTypedElementListProxy ElementList, int Slack = 0)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Slack;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Empty, __InBuffer);
			}
		}

		public static FScriptTypedElementListProxy CreateScriptElementList(UTypedElementRegistry Registry)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Registry?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateScriptElementList, __InBuffer, __ReturnBuffer);

				return *(FScriptTypedElementListProxy*)__ReturnBuffer;
			}
		}

		public static int CountElementsOfType(FScriptTypedElementListProxy ElementList, FName ElementTypeName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ElementTypeName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CountElementsOfType, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int CountElements(FScriptTypedElementListProxy ElementList, TSubclassOf<UInterface> BaseInterfaceType = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BaseInterfaceType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CountElements, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static bool Contains(FScriptTypedElementListProxy ElementList, FScriptTypedElementHandle ElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Contains, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <note>
		/// Only copies elements; does not copy any bindings!
		/// </note>
		public static FScriptTypedElementListProxy Clone(FScriptTypedElementListProxy ElementList)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Clone, __InBuffer, __ReturnBuffer);

				return *(FScriptTypedElementListProxy*)__ReturnBuffer;
			}
		}

		public static void AppendList(FScriptTypedElementListProxy ElementList, FScriptTypedElementListProxy OtherElementList)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OtherElementList?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AppendList, __InBuffer);
			}
		}

		public static void Append(FScriptTypedElementListProxy ElementList, TArray<FScriptTypedElementHandle> ElementHandles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ElementHandles?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __Append, __InBuffer);
			}
		}

		/// <returns>
		/// True if the element handle was added, false if it is already in the list.
		/// </returns>
		public static bool Add(FScriptTypedElementListProxy ElementList, FScriptTypedElementHandle ElementHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ElementList?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ElementHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __Add, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __Shrink = 0;

		private static uint __Reset = 0;

		private static uint __Reserve = 0;

		private static uint __Remove = 0;

		private static uint __Num = 0;

		private static uint __IsValidIndex = 0;

		private static uint __HasElementsOfType = 0;

		private static uint __HasElements = 0;

		private static uint __GetElementInterface = 0;

		private static uint __GetElementHandles = 0;

		private static uint __GetElementHandleAt = 0;

		private static uint __Empty = 0;

		private static uint __CreateScriptElementList = 0;

		private static uint __CountElementsOfType = 0;

		private static uint __CountElements = 0;

		private static uint __Contains = 0;

		private static uint __Clone = 0;

		private static uint __AppendList = 0;

		private static uint __Append = 0;

		private static uint __Add = 0;
	}
}