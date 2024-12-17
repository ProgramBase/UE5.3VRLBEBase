using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.SubobjectDataInterface
{
	[PathName("/Script/SubobjectDataInterface.SubobjectDataSubsystem")]
	public partial class USubobjectDataSubsystem : UEngineSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SubobjectDataInterface.SubobjectDataSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="NewParentHandle">
		/// Handle of the new parent
		/// </param>
		public virtual bool ReparentSubobjects(FReparentSubobjectParams Params, TArray<FSubobjectDataHandle> HandlesToMove)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Params?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = HandlesToMove?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ReparentSubobjects, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="NewParentHandle">
		/// Handle of the new parent
		/// </param>
		/// <param name="ToReparentHandle">
		/// The handle of the subobject that will get moved
		/// </param>
		/// <returns>
		/// True if the reparent was successful, false otherwise.
		/// </returns>
		public virtual bool ReparentSubobject(FReparentSubobjectParams Params, FSubobjectDataHandle ToReparentHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Params?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ToReparentHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ReparentSubobject, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void RenameSubobjectMemberVariable(UBlueprint BPContext, FSubobjectDataHandle InHandle, FName NewName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = BPContext?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RenameSubobjectMemberVariable, __InBuffer);
			}
		}

		/// <param name="Handle">
		/// Handle to the subobject to rename
		/// </param>
		/// <param name="InNewName">
		/// The new name that is desired for the given subobject
		/// </param>
		/// <returns>
		/// True if the rename was successful, false otherwise.
		/// </returns>
		public virtual bool RenameSubobject(FSubobjectDataHandle Handle, FText InNewName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameSubobject, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool MakeNewSceneRoot(FSubobjectDataHandle Context, FSubobjectDataHandle NewSceneRoot, UBlueprint BPContext)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewSceneRoot?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BPContext?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __MakeNewSceneRoot, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Context">
		/// Object to gather subobjects for
		/// </param>
		/// <param name="OutArray">
		/// Array to populate (will be emptied first)
		/// </param>
		public virtual void K2_GatherSubobjectDataForInstance(AActor Context, ref TArray<FSubobjectDataHandle> OutArray)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutArray?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_GatherSubobjectDataForInstance, __InBuffer, __OutBuffer);

				OutArray = *(TArray<FSubobjectDataHandle>*)(__OutBuffer);

			}
		}

		/// <param name="Context">
		/// Object to gather subobjects for
		/// </param>
		/// <param name="OutArray">
		/// Array to populate (will be emptied first)
		/// </param>
		public virtual void K2_GatherSubobjectDataForBlueprint(UBlueprint Context, ref TArray<FSubobjectDataHandle> OutArray)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutArray?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __K2_GatherSubobjectDataForBlueprint, __InBuffer, __OutBuffer);

				OutArray = *(TArray<FSubobjectDataHandle>*)(__OutBuffer);

			}
		}

		/// <param name="Handle">
		/// Handle of the subobject data you want to acquire
		/// </param>
		/// <param name="OutData">
		/// Reference to the subobject data to populate
		/// </param>
		/// <returns>
		/// bool		true if the data was found
		/// </returns>
		public virtual bool K2_FindSubobjectDataFromHandle(FSubobjectDataHandle Handle, ref FSubobjectData OutData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutData?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __K2_FindSubobjectDataFromHandle, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutData = *(FSubobjectData*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="ContextHandle">
		/// The owning context of the subobjects that should be removed
		/// </param>
		/// <param name="SubobjectsToDelete">
		/// Array of subobject handles that should be deleted
		/// </param>
		/// <returns>
		/// The number of subobjects successfully deleted
		/// </returns>
		public virtual int K2_DeleteSubobjectsFromInstance(FSubobjectDataHandle ContextHandle, TArray<FSubobjectDataHandle> SubobjectsToDelete)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ContextHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SubobjectsToDelete?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_DeleteSubobjectsFromInstance, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="ContextHandle">
		/// The owning context of the subobjects that should be removed
		/// </param>
		/// <param name="SubobjectToDelete">
		/// The subobject handles that should be deleted
		/// </param>
		/// <returns>
		/// The number of subobjects successfully deleted
		/// </returns>
		public virtual int K2_DeleteSubobjectFromInstance(FSubobjectDataHandle ContextHandle, FSubobjectDataHandle SubobjectToDelete)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = ContextHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SubobjectToDelete?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __K2_DeleteSubobjectFromInstance, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Handle">
		/// Handle to the subobject that is being checked
		/// </param>
		/// <param name="InNewText">
		/// The new name that is desired
		/// </param>
		/// <param name="OutErrorMessage">
		/// The reasoning for an invalid name
		/// </param>
		/// <returns>
		/// True if the rename is valid
		/// </returns>
		public virtual bool IsValidRename(FSubobjectDataHandle Handle, FText InNewText, ref FText OutErrorMessage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InNewText?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutErrorMessage?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __IsValidRename, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutErrorMessage = *(FText*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Context">
		/// The context that the object to find is within
		/// </param>
		/// <param name="ObjectToFind">
		/// The object that you want to find the handle for within the context
		/// </param>
		/// <returns>
		/// FSubobjectDataHandle	The subobject handle for the object, Invalid handle if not found.
		/// </returns>
		public virtual FSubobjectDataHandle FindHandleForObject(FSubobjectDataHandle Context, UObject ObjectToFind, UBlueprint BPContext = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ObjectToFind?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BPContext?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindHandleForObject, __InBuffer, __ReturnBuffer);

				return *(FSubobjectDataHandle*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// True if the child was successfully removed. 
		/// </returns>
		public virtual bool DetachSubobject(FSubobjectDataHandle OwnerHandle, FSubobjectDataHandle ChildToRemove)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OwnerHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ChildToRemove?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DetachSubobject, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="ContextHandle">
		/// The owning context of the subobjects that should be removed
		/// </param>
		/// <param name="SubobjectsToDelete">
		/// Array of subobject handles that should be deleted
		/// </param>
		/// <param name="BPContext">
		/// The blueprint context for the given
		/// </param>
		/// <returns>
		/// The number of subobjects successfully deleted
		/// </returns>
		public virtual int DeleteSubobjects(FSubobjectDataHandle ContextHandle, TArray<FSubobjectDataHandle> SubobjectsToDelete, UBlueprint BPContext = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ContextHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SubobjectsToDelete?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BPContext?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DeleteSubobjects, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="ContextHandle">
		/// The owning context of the subobjects that should be removed
		/// </param>
		/// <param name="SubobjectToDelete">
		/// The subobject handles that should be deleted
		/// </param>
		/// <param name="BPContext">
		/// The blueprint context for the given 
		/// </param>
		/// <returns>
		/// The number of subobjects successfully deleted
		/// </returns>
		public virtual int DeleteSubobject(FSubobjectDataHandle ContextHandle, FSubobjectDataHandle SubobjectToDelete, UBlueprint BPContext = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ContextHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SubobjectToDelete?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BPContext?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DeleteSubobject, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The new class that was created
		/// </returns>
		public static UClass CreateNewCPPComponent(TSubclassOf<UActorComponent> ComponentClass, FString NewClassPath, FString NewClassName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ComponentClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewClassPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewClassName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateNewCPPComponent, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The new class that was created
		/// </returns>
		public static UClass CreateNewBPComponent(TSubclassOf<UActorComponent> ComponentClass, FString NewClassPath, FString NewClassName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = ComponentClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewClassPath?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewClassName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateNewBPComponent, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		public virtual void CopySubobjects(TArray<FSubobjectDataHandle> Handles, UBlueprint BpContext)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Handles?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BpContext?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CopySubobjects, __InBuffer);
			}
		}

		/// <param name="Handle">
		/// Handle to the subobject to change class of
		/// </param>
		/// <param name="NewClass">
		/// The new class that is desired for the given subobject
		/// </param>
		/// <returns>
		/// True if the class change was successful, false otherwise.
		/// </returns>
		public virtual bool ChangeSubobjectClass(FSubobjectDataHandle Handle, UClass NewClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Handle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ChangeSubobjectClass, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CanPasteSubobjects(FSubobjectDataHandle RootHandle, UBlueprint BPContext = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = RootHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BPContext?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanPasteSubobjects, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CanCopySubobjects(TArray<FSubobjectDataHandle> Handles)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Handles?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanCopySubobjects, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="OwnerHandle">
		/// The new owner to attach to
		/// </param>
		/// <param name="ChildToAddHandle">
		/// Handle to the subobject that will become a child of the owner
		/// </param>
		/// <returns>
		/// true if the child was added successfully
		/// </returns>
		public virtual bool AttachSubobject(FSubobjectDataHandle OwnerHandle, FSubobjectDataHandle ChildToAddHandle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OwnerHandle?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ChildToAddHandle?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AttachSubobject, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Params">
		/// Options to consider when adding this subobject
		/// </param>
		/// <returns>
		/// FSubobjectDataHandle		Handle to the newly created subobject, Invalid handle if creation failed
		/// </returns>
		public virtual FSubobjectDataHandle AddNewSubobject(FAddNewSubobjectParams Params, ref FText FailReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Params?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FailReason?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __AddNewSubobject, __InBuffer, __OutBuffer, __ReturnBuffer);

				FailReason = *(FText*)(__OutBuffer);

				return *(FSubobjectDataHandle*)__ReturnBuffer;
			}
		}

		private static uint __ReparentSubobjects = 0;

		private static uint __ReparentSubobject = 0;

		private static uint __RenameSubobjectMemberVariable = 0;

		private static uint __RenameSubobject = 0;

		private static uint __MakeNewSceneRoot = 0;

		private static uint __K2_GatherSubobjectDataForInstance = 0;

		private static uint __K2_GatherSubobjectDataForBlueprint = 0;

		private static uint __K2_FindSubobjectDataFromHandle = 0;

		private static uint __K2_DeleteSubobjectsFromInstance = 0;

		private static uint __K2_DeleteSubobjectFromInstance = 0;

		private static uint __IsValidRename = 0;

		private static uint __FindHandleForObject = 0;

		private static uint __DetachSubobject = 0;

		private static uint __DeleteSubobjects = 0;

		private static uint __DeleteSubobject = 0;

		private static uint __CreateNewCPPComponent = 0;

		private static uint __CreateNewBPComponent = 0;

		private static uint __CopySubobjects = 0;

		private static uint __ChangeSubobjectClass = 0;

		private static uint __CanPasteSubobjects = 0;

		private static uint __CanCopySubobjects = 0;

		private static uint __AttachSubobject = 0;

		private static uint __AddNewSubobject = 0;
	}
}