using Script.CoreUObject;
using Script.MetasoundFrontend;
using Script.Library;

namespace Script.MetasoundEngine
{
	[PathName("/Script/MetasoundEngine.MetaSoundBuilderBase")]
	public partial class UMetaSoundBuilderBase : UObject, IStaticClass
	{
		public FMetaSoundFrontendDocumentBuilder Builder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Builder, __ReturnBuffer);

					return *(FMetaSoundFrontendDocumentBuilder*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Builder, __InBuffer);
				}
			}
		}

		public bool bIsAttached
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsAttached, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsAttached, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MetasoundEngine.MetaSoundBuilderBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetNodeInputDefault(FMetaSoundBuilderNodeInputHandle NodeInputHandle, FMetasoundFrontendLiteral Literal, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = NodeInputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Literal?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SetNodeInputDefault, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual void SetGraphInputDefault(FName InputName, FMetasoundFrontendLiteral Literal, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Literal?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __SetGraphInputDefault, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual void RemoveNodeInputDefault(FMetaSoundBuilderNodeInputHandle InputHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __RemoveNodeInputDefault, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual void RemoveNode(FMetaSoundNodeHandle NodeHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NodeHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __RemoveNode, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual void RemoveInterface(FName InterfaceName, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InterfaceName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __RemoveInterface, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual void RemoveGraphOutput(FName Name, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __RemoveGraphOutput, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual void RemoveGraphInput(FName Name, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __RemoveGraphInput, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual bool NodesAreConnected(FMetaSoundBuilderNodeOutputHandle OutputHandle, FMetaSoundBuilderNodeInputHandle InputHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OutputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InputHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __NodesAreConnected, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool NodeOutputIsConnected(FMetaSoundBuilderNodeOutputHandle OutputHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutputHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __NodeOutputIsConnected, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool NodeInputIsConnected(FMetaSoundBuilderNodeInputHandle InputHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InputHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __NodeInputIsConnected, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsPreset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsPreset, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool InterfaceIsDeclared(FName InterfaceName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InterfaceName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __InterfaceIsDeclared, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UObject GetReferencedPresetAsset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetReferencedPresetAsset, __ReturnBuffer);

				return *(UObject*)__ReturnBuffer;
			}
		}

		public virtual void GetNodeOutputData(FMetaSoundBuilderNodeOutputHandle OutputHandle, ref FName Name, ref FName DataType, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = OutputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DataType?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[17];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetNodeOutputData, __InBuffer, __OutBuffer);

				Name = *(FName*)(__OutBuffer);

				DataType = *(FName*)(__OutBuffer + 8);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer + 16);

			}
		}

		public virtual FMetasoundFrontendLiteral GetNodeInputDefault(FMetaSoundBuilderNodeInputHandle InputHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __GetNodeInputDefault, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(FMetasoundFrontendLiteral*)__ReturnBuffer;
			}
		}

		public virtual void GetNodeInputData(FMetaSoundBuilderNodeInputHandle InputHandle, ref FName Name, ref FName DataType, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = InputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DataType?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[17];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetNodeInputData, __InBuffer, __OutBuffer);

				Name = *(FName*)(__OutBuffer);

				DataType = *(FName*)(__OutBuffer + 8);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer + 16);

			}
		}

		public virtual FMetasoundFrontendLiteral GetNodeInputClassDefault(FMetaSoundBuilderNodeInputHandle InputHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __GetNodeInputClassDefault, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(FMetasoundFrontendLiteral*)__ReturnBuffer;
			}
		}

		public virtual TArray<FMetaSoundBuilderNodeOutputHandle> FindNodeOutputsByDataType(FMetaSoundNodeHandle NodeHandle, ref EMetaSoundBuilderResult OutResult, FName DataType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = NodeHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				*(nint*)(__InBuffer + 9) = DataType?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __FindNodeOutputsByDataType, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(TArray<FMetaSoundBuilderNodeOutputHandle>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FMetaSoundBuilderNodeOutputHandle> FindNodeOutputs(FMetaSoundNodeHandle NodeHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NodeHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __FindNodeOutputs, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(TArray<FMetaSoundBuilderNodeOutputHandle>*)__ReturnBuffer;
			}
		}

		public virtual FMetaSoundNodeHandle FindNodeOutputParent(FMetaSoundBuilderNodeOutputHandle OutputHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = OutputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __FindNodeOutputParent, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(FMetaSoundNodeHandle*)__ReturnBuffer;
			}
		}

		public virtual FMetaSoundBuilderNodeOutputHandle FindNodeOutputByName(FMetaSoundNodeHandle NodeHandle, FName OutputName, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = NodeHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutputName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __FindNodeOutputByName, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(FMetaSoundBuilderNodeOutputHandle*)__ReturnBuffer;
			}
		}

		public virtual TArray<FMetaSoundBuilderNodeInputHandle> FindNodeInputsByDataType(FMetaSoundNodeHandle NodeHandle, ref EMetaSoundBuilderResult OutResult, FName DataType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = NodeHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				*(nint*)(__InBuffer + 9) = DataType?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __FindNodeInputsByDataType, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(TArray<FMetaSoundBuilderNodeInputHandle>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FMetaSoundBuilderNodeInputHandle> FindNodeInputs(FMetaSoundNodeHandle NodeHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NodeHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __FindNodeInputs, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(TArray<FMetaSoundBuilderNodeInputHandle>*)__ReturnBuffer;
			}
		}

		public virtual FMetaSoundNodeHandle FindNodeInputParent(FMetaSoundBuilderNodeInputHandle InputHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __FindNodeInputParent, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(FMetaSoundNodeHandle*)__ReturnBuffer;
			}
		}

		public virtual FMetaSoundBuilderNodeInputHandle FindNodeInputByName(FMetaSoundNodeHandle NodeHandle, FName InputName, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = NodeHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __FindNodeInputByName, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(FMetaSoundBuilderNodeInputHandle*)__ReturnBuffer;
			}
		}

		public virtual FMetasoundFrontendVersion FindNodeClassVersion(FMetaSoundNodeHandle NodeHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NodeHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __FindNodeClassVersion, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(FMetasoundFrontendVersion*)__ReturnBuffer;
			}
		}

		public virtual TArray<FMetaSoundNodeHandle> FindInterfaceOutputNodes(FName InterfaceName, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InterfaceName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __FindInterfaceOutputNodes, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(TArray<FMetaSoundNodeHandle>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FMetaSoundNodeHandle> FindInterfaceInputNodes(FName InterfaceName, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InterfaceName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __FindInterfaceInputNodes, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(TArray<FMetaSoundNodeHandle>*)__ReturnBuffer;
			}
		}

		public virtual FMetaSoundNodeHandle FindGraphOutputNode(FName OutputName, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = OutputName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __FindGraphOutputNode, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(FMetaSoundNodeHandle*)__ReturnBuffer;
			}
		}

		public virtual FMetaSoundNodeHandle FindGraphInputNode(FName InputName, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InputName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __FindGraphInputNode, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(FMetaSoundNodeHandle*)__ReturnBuffer;
			}
		}

		public virtual void DisconnectNodesByInterfaceBindings(FMetaSoundNodeHandle FromNodeHandle, FMetaSoundNodeHandle ToNodeHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = FromNodeHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ToNodeHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __DisconnectNodesByInterfaceBindings, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual void DisconnectNodes(FMetaSoundBuilderNodeOutputHandle NodeOutputHandle, FMetaSoundBuilderNodeInputHandle NodeInputHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = NodeOutputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NodeInputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __DisconnectNodes, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual void DisconnectNodeOutput(FMetaSoundBuilderNodeOutputHandle NodeOutputHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NodeOutputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __DisconnectNodeOutput, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual void DisconnectNodeInput(FMetaSoundBuilderNodeInputHandle NodeInputHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NodeInputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __DisconnectNodeInput, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual void ConvertToPreset(TScriptInterface<IMetaSoundDocumentInterface> ReferencedNodeClass, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = ReferencedNodeClass?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ConvertToPreset, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual void ConvertFromPreset(ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ConvertFromPreset, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual bool ContainsNodeOutput(FMetaSoundBuilderNodeOutputHandle Output)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Output?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ContainsNodeOutput, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool ContainsNodeInput(FMetaSoundBuilderNodeInputHandle Input)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Input?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ContainsNodeInput, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool ContainsNode(FMetaSoundNodeHandle Node)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ContainsNode, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ConnectNodesByInterfaceBindings(FMetaSoundNodeHandle FromNodeHandle, FMetaSoundNodeHandle ToNodeHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = FromNodeHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ToNodeHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ConnectNodesByInterfaceBindings, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual void ConnectNodes(FMetaSoundBuilderNodeOutputHandle NodeOutputHandle, FMetaSoundBuilderNodeInputHandle NodeInputHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = NodeOutputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NodeInputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ConnectNodes, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual void ConnectNodeOutputToGraphOutput(FName GraphOutputName, FMetaSoundBuilderNodeOutputHandle NodeOutputHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = GraphOutputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NodeOutputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ConnectNodeOutputToGraphOutput, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual TArray<FMetaSoundBuilderNodeInputHandle> ConnectNodeOutputsToMatchingGraphInterfaceOutputs(FMetaSoundNodeHandle NodeHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NodeHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __ConnectNodeOutputsToMatchingGraphInterfaceOutputs, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(TArray<FMetaSoundBuilderNodeInputHandle>*)__ReturnBuffer;
			}
		}

		public virtual void ConnectNodeInputToGraphInput(FName GraphInputName, FMetaSoundBuilderNodeInputHandle NodeInputHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = GraphInputName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NodeInputHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __ConnectNodeInputToGraphInput, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual TArray<FMetaSoundBuilderNodeOutputHandle> ConnectNodeInputsToMatchingGraphInterfaceInputs(FMetaSoundNodeHandle NodeHandle, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NodeHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __ConnectNodeInputsToMatchingGraphInterfaceInputs, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(TArray<FMetaSoundBuilderNodeOutputHandle>*)__ReturnBuffer;
			}
		}

		public virtual FMetaSoundNodeHandle AddNodeByClassName(FMetasoundFrontendClassName ClassName, int MajorVersion, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = ClassName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = MajorVersion;

				*(byte*)(__InBuffer + 12) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __AddNodeByClassName, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(FMetaSoundNodeHandle*)__ReturnBuffer;
			}
		}

		public virtual FMetaSoundNodeHandle AddNode(TScriptInterface<IMetaSoundDocumentInterface> NodeClass, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NodeClass?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __AddNode, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(FMetaSoundNodeHandle*)__ReturnBuffer;
			}
		}

		public virtual void AddInterface(FName InterfaceName, ref EMetaSoundBuilderResult OutResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InterfaceName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutResult;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __AddInterface, __InBuffer, __OutBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

			}
		}

		public virtual FMetaSoundBuilderNodeInputHandle AddGraphOutputNode(FName Name, FName DataType, FMetasoundFrontendLiteral DefaultValue, ref EMetaSoundBuilderResult OutResult, bool bIsConstructorOutput)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DataType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)OutResult;

				*(bool*)(__InBuffer + 25) = bIsConstructorOutput;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __AddGraphOutputNode, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(FMetaSoundBuilderNodeInputHandle*)__ReturnBuffer;
			}
		}

		public virtual FMetaSoundBuilderNodeOutputHandle AddGraphInputNode(FName Name, FName DataType, FMetasoundFrontendLiteral DefaultValue, ref EMetaSoundBuilderResult OutResult, bool bIsConstructorInput)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[26];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DataType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = DefaultValue?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)OutResult;

				*(bool*)(__InBuffer + 25) = bIsConstructorInput;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __AddGraphInputNode, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutResult = *(EMetaSoundBuilderResult*)(__OutBuffer);

				return *(FMetaSoundBuilderNodeOutputHandle*)__ReturnBuffer;
			}
		}

		private static uint __Builder = 0;

		private static uint __bIsAttached = 0;

		private static uint __SetNodeInputDefault = 0;

		private static uint __SetGraphInputDefault = 0;

		private static uint __RemoveNodeInputDefault = 0;

		private static uint __RemoveNode = 0;

		private static uint __RemoveInterface = 0;

		private static uint __RemoveGraphOutput = 0;

		private static uint __RemoveGraphInput = 0;

		private static uint __NodesAreConnected = 0;

		private static uint __NodeOutputIsConnected = 0;

		private static uint __NodeInputIsConnected = 0;

		private static uint __IsPreset = 0;

		private static uint __InterfaceIsDeclared = 0;

		private static uint __GetReferencedPresetAsset = 0;

		private static uint __GetNodeOutputData = 0;

		private static uint __GetNodeInputDefault = 0;

		private static uint __GetNodeInputData = 0;

		private static uint __GetNodeInputClassDefault = 0;

		private static uint __FindNodeOutputsByDataType = 0;

		private static uint __FindNodeOutputs = 0;

		private static uint __FindNodeOutputParent = 0;

		private static uint __FindNodeOutputByName = 0;

		private static uint __FindNodeInputsByDataType = 0;

		private static uint __FindNodeInputs = 0;

		private static uint __FindNodeInputParent = 0;

		private static uint __FindNodeInputByName = 0;

		private static uint __FindNodeClassVersion = 0;

		private static uint __FindInterfaceOutputNodes = 0;

		private static uint __FindInterfaceInputNodes = 0;

		private static uint __FindGraphOutputNode = 0;

		private static uint __FindGraphInputNode = 0;

		private static uint __DisconnectNodesByInterfaceBindings = 0;

		private static uint __DisconnectNodes = 0;

		private static uint __DisconnectNodeOutput = 0;

		private static uint __DisconnectNodeInput = 0;

		private static uint __ConvertToPreset = 0;

		private static uint __ConvertFromPreset = 0;

		private static uint __ContainsNodeOutput = 0;

		private static uint __ContainsNodeInput = 0;

		private static uint __ContainsNode = 0;

		private static uint __ConnectNodesByInterfaceBindings = 0;

		private static uint __ConnectNodes = 0;

		private static uint __ConnectNodeOutputToGraphOutput = 0;

		private static uint __ConnectNodeOutputsToMatchingGraphInterfaceOutputs = 0;

		private static uint __ConnectNodeInputToGraphInput = 0;

		private static uint __ConnectNodeInputsToMatchingGraphInterfaceInputs = 0;

		private static uint __AddNodeByClassName = 0;

		private static uint __AddNode = 0;

		private static uint __AddInterface = 0;

		private static uint __AddGraphOutputNode = 0;

		private static uint __AddGraphInputNode = 0;
	}
}