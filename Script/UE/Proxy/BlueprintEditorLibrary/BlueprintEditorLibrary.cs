using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.BlueprintEditorLibrary
{
	[PathName("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary")]
	public partial class UBlueprintEditorLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintEditorLibrary.BlueprintEditorLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Blueprint">
		/// Blueprint to upgrade
		/// </param>
		public static void UpgradeOperatorNodes(UBlueprint Blueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Blueprint?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __UpgradeOperatorNodes, __InBuffer);
			}
		}

		/// <param name="Blueprint">
		/// The blueprint object
		/// </param>
		/// <param name="VariableName">
		/// The variable name
		/// </param>
		/// <param name="bInstanceEditable">
		/// Toggle InstanceEditable
		/// </param>
		public static void SetBlueprintVariableInstanceEditable(UBlueprint Blueprint, FName VariableName, bool bInstanceEditable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Blueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bInstanceEditable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBlueprintVariableInstanceEditable, __InBuffer);
			}
		}

		/// <param name="Blueprint">
		/// The blueprint object
		/// </param>
		/// <param name="VariableName">
		/// The variable name
		/// </param>
		/// <param name="bExposeToCinematics">
		/// Set to true to expose to cinematics
		/// </param>
		public static void SetBlueprintVariableExposeToCinematics(UBlueprint Blueprint, FName VariableName, bool bExposeToCinematics)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Blueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bExposeToCinematics;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBlueprintVariableExposeToCinematics, __InBuffer);
			}
		}

		/// <param name="Blueprint">
		/// The blueprint object
		/// </param>
		/// <param name="VariableName">
		/// The variable name
		/// </param>
		/// <param name="bExposeOnSpawn">
		/// Set to true to expose on spawn
		/// </param>
		public static void SetBlueprintVariableExposeOnSpawn(UBlueprint Blueprint, FName VariableName, bool bExposeOnSpawn)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Blueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VariableName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bExposeOnSpawn;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBlueprintVariableExposeOnSpawn, __InBuffer);
			}
		}

		/// <param name="Blueprint">
		/// Blueprint to replace the variable references on
		/// </param>
		/// <param name="OldVarName">
		/// The variable you want replaced
		/// </param>
		/// <param name="NewVarName">
		/// The new variable that will be used in the old one's place
		/// </param>
		public static void ReplaceVariableReferences(UBlueprint Blueprint, FName OldVarName, FName NewVarName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Blueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OldVarName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewVarName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReplaceVariableReferences, __InBuffer);
			}
		}

		/// <param name="Blueprint">
		/// Blueprint that you would like to reparent
		/// </param>
		/// <param name="NewParentClass">
		/// The new parent class to use
		/// </param>
		public static void ReparentBlueprint(UBlueprint Blueprint, UClass NewParentClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Blueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewParentClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReparentBlueprint, __InBuffer);
			}
		}

		/// <param name="Graph">
		/// The graph to rename
		/// </param>
		/// <param name="NewNameStr">
		/// The new name of the graph
		/// </param>
		public static void RenameGraph(UEdGraph Graph, FString NewNameStr = null)
		{
			unsafe
			{
				NewNameStr ??= new FString("NewGraph");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Graph?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewNameStr?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RenameGraph, __InBuffer);
			}
		}

		/// <param name="Blueprint">
		/// Blueprint that you would like to remove variables from
		/// </param>
		/// <returns>
		/// Number of variables removed
		/// </returns>
		public static int RemoveUnusedVariables(UBlueprint Blueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Blueprint?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveUnusedVariables, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Blueprint">
		/// The blueprint to remove the nodes from
		/// </param>
		public static void RemoveUnusedNodes(UBlueprint Blueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Blueprint?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveUnusedNodes, __InBuffer);
			}
		}

		/// <param name="Blueprint">
		/// The blueprint the graph will be removed from
		/// </param>
		/// <param name="Graph">
		/// The graph to remove
		/// </param>
		public static void RemoveGraph(UBlueprint Blueprint, UEdGraph Graph)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Blueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Graph?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveGraph, __InBuffer);
			}
		}

		/// <param name="Blueprint">
		/// The blueprint to remove the function from
		/// </param>
		/// <param name="FuncName">
		/// The name of the function to remove
		/// </param>
		public static void RemoveFunctionGraph(UBlueprint Blueprint, FName FuncName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Blueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FuncName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveFunctionGraph, __InBuffer);
			}
		}

		public static void RefreshOpenEditorsForBlueprint(UBlueprint BP)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BP?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RefreshOpenEditorsForBlueprint, __InBuffer);
			}
		}

		public static void RefreshAllOpenBlueprintEditors()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __RefreshAllOpenBlueprintEditors);
			}
		}

		/// <param name="Object">
		/// The object we need to get the UBlueprint from
		/// </param>
		/// <returns>
		/// UBlueprint*	The blueprint type of the given object, nullptr if the object is not a blueprint.
		/// </returns>
		public static UBlueprint GetBlueprintAsset(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBlueprintAsset, __InBuffer, __ReturnBuffer);

				return *(UBlueprint*)__ReturnBuffer;
			}
		}

		/// <param name="BlueprintObj">
		/// The blueprint object
		/// </param>
		/// <returns>
		/// UClass*			The generated class
		/// </returns>
		public static UClass GeneratedClass(UBlueprint BlueprintObj)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BlueprintObj?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GeneratedClass, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		/// <param name="Blueprint">
		/// Blueprint to search
		/// </param>
		/// <param name="GraphName">
		/// The name of the graph to search for 
		/// </param>
		/// <returns>
		/// UEdGraph*		Pointer to the graph with the given name, null if not found
		/// </returns>
		public static UEdGraph FindGraph(UBlueprint Blueprint, FName GraphName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Blueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = GraphName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindGraph, __InBuffer, __ReturnBuffer);

				return *(UEdGraph*)__ReturnBuffer;
			}
		}

		/// <param name="Blueprint">
		/// Blueprint to search for the event graph on
		/// </param>
		/// <returns>
		/// UEdGraph*		Event graph of the blueprint if it has one, null if it doesn't have one
		/// </returns>
		public static UEdGraph FindEventGraph(UBlueprint Blueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Blueprint?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __FindEventGraph, __InBuffer, __ReturnBuffer);

				return *(UEdGraph*)__ReturnBuffer;
			}
		}

		/// <param name="Blueprint">
		/// Blueprint to compile
		/// </param>
		public static void CompileBlueprint(UBlueprint Blueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Blueprint?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __CompileBlueprint, __InBuffer);
			}
		}

		/// <param name="Blueprint">
		/// The blueprint to add the function to
		/// </param>
		/// <param name="FuncName">
		/// Name of the function to add
		/// </param>
		/// <returns>
		/// UEdGraph*
		/// </returns>
		public static UEdGraph AddFunctionGraph(UBlueprint Blueprint, FString FuncName = null)
		{
			unsafe
			{
				FuncName ??= new FString("NewFunction");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Blueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FuncName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddFunctionGraph, __InBuffer, __ReturnBuffer);

				return *(UEdGraph*)__ReturnBuffer;
			}
		}

		private static uint __UpgradeOperatorNodes = 0;

		private static uint __SetBlueprintVariableInstanceEditable = 0;

		private static uint __SetBlueprintVariableExposeToCinematics = 0;

		private static uint __SetBlueprintVariableExposeOnSpawn = 0;

		private static uint __ReplaceVariableReferences = 0;

		private static uint __ReparentBlueprint = 0;

		private static uint __RenameGraph = 0;

		private static uint __RemoveUnusedVariables = 0;

		private static uint __RemoveUnusedNodes = 0;

		private static uint __RemoveGraph = 0;

		private static uint __RemoveFunctionGraph = 0;

		private static uint __RefreshOpenEditorsForBlueprint = 0;

		private static uint __RefreshAllOpenBlueprintEditors = 0;

		private static uint __GetBlueprintAsset = 0;

		private static uint __GeneratedClass = 0;

		private static uint __FindGraph = 0;

		private static uint __FindEventGraph = 0;

		private static uint __CompileBlueprint = 0;

		private static uint __AddFunctionGraph = 0;
	}
}