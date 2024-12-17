using Script.CoreUObject;
using Script.Library;
using Script.InterchangeCore;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangeShaderPortsAPI")]
	public partial class UInterchangeShaderPortsAPI : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeNodes.InterchangeShaderPortsAPI");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FString MakeInputValueKey(FString InputName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeInputValueKey, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString MakeInputName(FString InputKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InputKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeInputName, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static FString MakeInputConnectionKey(FString InputName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __MakeInputConnectionKey, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static bool IsAnInput(FString AttributeKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsAnInput, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool HasInput(UInterchangeBaseNode InterchangeNode, FName InInputName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InInputName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __HasInput, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GetInputConnection(UInterchangeBaseNode InterchangeNode, FString InputName, ref FString OutExpressionUid, ref FString OutputName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutExpressionUid?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutputName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetInputConnection, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutExpressionUid = *(FString*)(__OutBuffer);

				OutputName = *(FString*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void GatherInputs(UInterchangeBaseNode InterchangeNode, ref TArray<FString> OutInputNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutInputNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GatherInputs, __InBuffer, __OutBuffer);

				OutInputNames = *(TArray<FString>*)(__OutBuffer);

			}
		}

		/// <param name="InterchangeNode">
		/// The Node to create the input on.
		/// </param>
		/// <param name="InputName">
		/// The name to give to the input.
		/// </param>
		/// <param name="ExpressionUid">
		/// The unique id of the node to connect to the input.
		/// </param>
		/// <param name="OutputName">
		/// The name of the output from ExpressionUid to connect to the input.
		/// </param>
		/// <returns>
		/// true if the input connection was successfully added to the node.
		/// </returns>
		public static bool ConnectOuputToInputByName(UInterchangeBaseNode InterchangeNode, FString InputName, FString ExpressionUid, FString OutputName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ExpressionUid?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutputName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConnectOuputToInputByName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InterchangeNode">
		/// The Node to create the input on.
		/// </param>
		/// <param name="InputName">
		/// The name to give to the input.
		/// </param>
		/// <param name="ExpressionUid">
		/// The unique id of the node to connect to the input.
		/// </param>
		/// <param name="OutputIndex">
		/// The index of the output from ExpressionUid to connect to the input.
		/// </param>
		/// <returns>
		/// true if the input connection was successfully added to the node.
		/// OutputIndex is encoded in a string in the following pattern  ExpressionUid:OutputByIndex:FString::FromInt(OutputIndex)
		/// The index should be retrieved using UInterchangeShaderPortsAPI::GetOutputIndexFromName
		/// </returns>
		public static bool ConnectOuputToInputByIndex(UInterchangeBaseNode InterchangeNode, FString InputName, FString ExpressionUid, int OutputIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ExpressionUid?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = OutputIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConnectOuputToInputByIndex, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="InterchangeNode">
		/// The Node to create the input on.
		/// </param>
		/// <param name="InputName">
		/// The name to give to the input.
		/// </param>
		/// <param name="ExpressionUid">
		/// The unique id of the node to connect to the input.
		/// </param>
		/// <returns>
		/// true if the input connection was successfully added to the node.
		/// </returns>
		public static bool ConnectDefaultOuputToInput(UInterchangeBaseNode InterchangeNode, FString InputName, FString ExpressionUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ExpressionUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ConnectDefaultOuputToInput, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __MakeInputValueKey = 0;

		private static uint __MakeInputName = 0;

		private static uint __MakeInputConnectionKey = 0;

		private static uint __IsAnInput = 0;

		private static uint __HasInput = 0;

		private static uint __GetInputConnection = 0;

		private static uint __GatherInputs = 0;

		private static uint __ConnectOuputToInputByName = 0;

		private static uint __ConnectOuputToInputByIndex = 0;

		private static uint __ConnectDefaultOuputToInput = 0;
	}
}