using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.InterchangeUserDefinedAttributesAPI")]
	public partial class UInterchangeUserDefinedAttributesAPI : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeCore.InterchangeUserDefinedAttributesAPI");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool RemoveUserDefinedAttribute(UInterchangeBaseNode InterchangeNode, FString UserDefinedAttributeName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UserDefinedAttributeName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveUserDefinedAttribute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void GetUserDefinedAttributeInfos(UInterchangeBaseNode InterchangeNode, ref TArray<FInterchangeUserDefinedAttributeInfo> UserDefinedAttributeInfos)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UserDefinedAttributeInfos?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetUserDefinedAttributeInfos, __InBuffer, __OutBuffer);

				UserDefinedAttributeInfos = *(TArray<FInterchangeUserDefinedAttributeInfo>*)(__OutBuffer);

			}
		}

		public static bool GetUserDefinedAttribute_Int32(UInterchangeBaseNode InterchangeNode, FString UserDefinedAttributeName, ref int OutValue, ref FString OutPayloadKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UserDefinedAttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = OutValue;

				*(nint*)(__InBuffer + 20) = OutPayloadKey?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[12];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetUserDefinedAttribute_Int32, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(int*)(__OutBuffer);

				OutPayloadKey = *(FString*)(__OutBuffer + 4);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GetUserDefinedAttribute_FString(UInterchangeBaseNode InterchangeNode, FString UserDefinedAttributeName, ref FString OutValue, ref FString OutPayloadKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UserDefinedAttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutValue?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutPayloadKey?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetUserDefinedAttribute_FString, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(FString*)(__OutBuffer);

				OutPayloadKey = *(FString*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GetUserDefinedAttribute_Float(UInterchangeBaseNode InterchangeNode, FString UserDefinedAttributeName, ref float OutValue, ref FString OutPayloadKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UserDefinedAttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = OutValue;

				*(nint*)(__InBuffer + 20) = OutPayloadKey?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[12];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetUserDefinedAttribute_Float, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(float*)(__OutBuffer);

				OutPayloadKey = *(FString*)(__OutBuffer + 4);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GetUserDefinedAttribute_Double(UInterchangeBaseNode InterchangeNode, FString UserDefinedAttributeName, ref double OutValue, ref FString OutPayloadKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UserDefinedAttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 16) = OutValue;

				*(nint*)(__InBuffer + 24) = OutPayloadKey?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetUserDefinedAttribute_Double, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(double*)(__OutBuffer);

				OutPayloadKey = *(FString*)(__OutBuffer + 8);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool GetUserDefinedAttribute_Boolean(UInterchangeBaseNode InterchangeNode, FString UserDefinedAttributeName, ref bool OutValue, ref FString OutPayloadKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UserDefinedAttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = OutValue;

				*(nint*)(__InBuffer + 17) = OutPayloadKey?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[9];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetUserDefinedAttribute_Boolean, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(bool*)(__OutBuffer);

				OutPayloadKey = *(FString*)(__OutBuffer + 1);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void DuplicateAllUserDefinedAttribute(UInterchangeBaseNode InterchangeSourceNode, UInterchangeBaseNode InterchangeDestinationNode, bool bAddSourceNodeName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InterchangeSourceNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InterchangeDestinationNode?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bAddSourceNodeName;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DuplicateAllUserDefinedAttribute, __InBuffer);
			}
		}

		public static bool CreateUserDefinedAttribute_Int32(UInterchangeBaseNode InterchangeNode, FString UserDefinedAttributeName, int Value, FString PayloadKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UserDefinedAttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Value;

				*(nint*)(__InBuffer + 20) = PayloadKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateUserDefinedAttribute_Int32, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool CreateUserDefinedAttribute_FString(UInterchangeBaseNode InterchangeNode, FString UserDefinedAttributeName, FString Value, FString PayloadKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UserDefinedAttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = PayloadKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateUserDefinedAttribute_FString, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool CreateUserDefinedAttribute_Float(UInterchangeBaseNode InterchangeNode, FString UserDefinedAttributeName, float Value, FString PayloadKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UserDefinedAttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Value;

				*(nint*)(__InBuffer + 20) = PayloadKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateUserDefinedAttribute_Float, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool CreateUserDefinedAttribute_Double(UInterchangeBaseNode InterchangeNode, FString UserDefinedAttributeName, double Value, FString PayloadKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UserDefinedAttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 16) = Value;

				*(nint*)(__InBuffer + 24) = PayloadKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateUserDefinedAttribute_Double, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool CreateUserDefinedAttribute_Boolean(UInterchangeBaseNode InterchangeNode, FString UserDefinedAttributeName, bool Value, FString PayloadKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = InterchangeNode?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = UserDefinedAttributeName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = Value;

				*(nint*)(__InBuffer + 17) = PayloadKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateUserDefinedAttribute_Boolean, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __RemoveUserDefinedAttribute = 0;

		private static uint __GetUserDefinedAttributeInfos = 0;

		private static uint __GetUserDefinedAttribute_Int32 = 0;

		private static uint __GetUserDefinedAttribute_FString = 0;

		private static uint __GetUserDefinedAttribute_Float = 0;

		private static uint __GetUserDefinedAttribute_Double = 0;

		private static uint __GetUserDefinedAttribute_Boolean = 0;

		private static uint __DuplicateAllUserDefinedAttribute = 0;

		private static uint __CreateUserDefinedAttribute_Int32 = 0;

		private static uint __CreateUserDefinedAttribute_FString = 0;

		private static uint __CreateUserDefinedAttribute_Float = 0;

		private static uint __CreateUserDefinedAttribute_Double = 0;

		private static uint __CreateUserDefinedAttribute_Boolean = 0;
	}
}