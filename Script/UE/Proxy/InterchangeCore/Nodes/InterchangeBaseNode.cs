using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangeCore
{
	[PathName("/Script/InterchangeCore.InterchangeBaseNode")]
	public partial class UInterchangeBaseNode : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeCore.InterchangeBaseNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetParentUid(FString ParentUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParentUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetParentUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="bIsEnabled">
		/// - The enabled state we want to set this node. True will import/export the node, fals will not.
		/// </param>
		/// <returns>
		/// true if it was able to set the attribute, false otherwise.
		/// </returns>
		public virtual bool SetEnabled(bool bIsEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsEnabled;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetEnabled, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetDisplayLabel(FString DisplayName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DisplayName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetDisplayLabel, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetAssetName(FString AssetName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetAssetName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveTargetNodeUid(FString AssetUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveTargetNodeUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveAttribute(FString NodeAttributeKey)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAttribute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="UniqueID">
		/// - The uniqueId for this node
		/// </param>
		/// <param name="DisplayLabel">
		/// - The name of the node
		/// </param>
		public virtual void InitializeNode(FString UniqueID, FString DisplayLabel, EInterchangeNodeContainerType NodeContainerType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = UniqueID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DisplayLabel?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)NodeContainerType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __InitializeNode, __InBuffer);
			}
		}

		public virtual bool GetVector2Attribute(FString NodeAttributeKey, ref FVector2f OutValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetVector2Attribute, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(FVector2f*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FString GetUniqueID()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetUniqueID, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual void GetTargetNodeUids(ref TArray<FString> OutTargetAssets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutTargetAssets?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetTargetNodeUids, __InBuffer, __OutBuffer);

				OutTargetAssets = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual int GetTargetNodeCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTargetNodeCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual bool GetStringAttribute(FString NodeAttributeKey, ref FString OutValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetStringAttribute, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FString GetParentUid()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetParentUid, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual EInterchangeNodeContainerType GetNodeContainerType()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNodeContainerType, __ReturnBuffer);

				return *(EInterchangeNodeContainerType*)__ReturnBuffer;
			}
		}

		public virtual bool GetLinearColorAttribute(FString NodeAttributeKey, ref FLinearColor OutValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetLinearColorAttribute, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(FLinearColor*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetInt32Attribute(FString NodeAttributeKey, ref int OutValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = OutValue;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetInt32Attribute, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(int*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetGuidAttribute(FString NodeAttributeKey, ref FGuid OutValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetGuidAttribute, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(FGuid*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetFloatAttribute(FString NodeAttributeKey, ref float OutValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = OutValue;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetFloatAttribute, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(float*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetDoubleAttribute(FString NodeAttributeKey, ref double OutValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = OutValue;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetDoubleAttribute, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(double*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FString GetDisplayLabel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDisplayLabel, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual bool GetBooleanAttribute(FString NodeAttributeKey, ref bool OutValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = OutValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetBooleanAttribute, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutValue = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FString GetAssetName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAssetName, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual bool AddVector2Attribute(FString NodeAttributeKey, FVector2f Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddVector2Attribute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool AddTargetNodeUid(FString AssetUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddTargetNodeUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool AddStringAttribute(FString NodeAttributeKey, FString Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddStringAttribute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool AddLinearColorAttribute(FString NodeAttributeKey, FLinearColor Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddLinearColorAttribute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool AddInt32Attribute(FString NodeAttributeKey, int Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Value;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddInt32Attribute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool AddGuidAttribute(FString NodeAttributeKey, FGuid Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Value?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddGuidAttribute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool AddFloatAttribute(FString NodeAttributeKey, float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Value;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddFloatAttribute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool AddDoubleAttribute(FString NodeAttributeKey, double Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = Value;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddDoubleAttribute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool AddBooleanAttribute(FString NodeAttributeKey, bool Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NodeAttributeKey?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = Value;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddBooleanAttribute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetParentUid = 0;

		private static uint __SetEnabled = 0;

		private static uint __SetDisplayLabel = 0;

		private static uint __SetAssetName = 0;

		private static uint __RemoveTargetNodeUid = 0;

		private static uint __RemoveAttribute = 0;

		private static uint __IsEnabled = 0;

		private static uint __InitializeNode = 0;

		private static uint __GetVector2Attribute = 0;

		private static uint __GetUniqueID = 0;

		private static uint __GetTargetNodeUids = 0;

		private static uint __GetTargetNodeCount = 0;

		private static uint __GetStringAttribute = 0;

		private static uint __GetParentUid = 0;

		private static uint __GetNodeContainerType = 0;

		private static uint __GetLinearColorAttribute = 0;

		private static uint __GetInt32Attribute = 0;

		private static uint __GetGuidAttribute = 0;

		private static uint __GetFloatAttribute = 0;

		private static uint __GetDoubleAttribute = 0;

		private static uint __GetDisplayLabel = 0;

		private static uint __GetBooleanAttribute = 0;

		private static uint __GetAssetName = 0;

		private static uint __AddVector2Attribute = 0;

		private static uint __AddTargetNodeUid = 0;

		private static uint __AddStringAttribute = 0;

		private static uint __AddLinearColorAttribute = 0;

		private static uint __AddInt32Attribute = 0;

		private static uint __AddGuidAttribute = 0;

		private static uint __AddFloatAttribute = 0;

		private static uint __AddDoubleAttribute = 0;

		private static uint __AddBooleanAttribute = 0;
	}
}