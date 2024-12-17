using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;
using Script.Engine;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.LayersSubsystem")]
	public partial class ULayersSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.LayersSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="LayerThatChanged">
		/// If one layer was changed (toggled in view pop-up, etc), then we only need to modify actors that use that layer.
		/// </param>
		public virtual void UpdateAllViewVisibility(FName LayerThatChanged)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LayerThatChanged?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UpdateAllViewVisibility, __InBuffer);
			}
		}

		/// <param name="bNotifySelectionChange">
		/// If true the Editor is notified of the selection change; if false, the Editor will not be notified
		/// </param>
		/// <param name="bRedrawViewports">
		/// If true the viewports will be redrawn; if false, they will not
		/// </param>
		public virtual bool UpdateAllActorsVisibility(bool bNotifySelectionChange, bool bRedrawViewports)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bNotifySelectionChange;

				*(bool*)(__InBuffer + 1) = bRedrawViewports;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __UpdateAllActorsVisibility, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actor">
		/// Actor to update
		/// </param>
		/// <param name="bOutSelectionChanged">
		/// [OUT]	Whether the Editors selection changed
		/// </param>
		/// <param name="bOutActorModified">
		/// [OUT]		Whether the actor was modified
		/// </param>
		/// <param name="bNotifySelectionChange">
		/// If true the Editor is notified of the selection change; if false, the Editor will not be notified
		/// </param>
		/// <param name="bRedrawViewports">
		/// If true the viewports will be redrawn; if false, they will not
		/// </param>
		public virtual bool UpdateActorVisibility(AActor Actor, ref bool bOutSelectionChanged, ref bool bOutActorModified, bool bNotifySelectionChange, bool bRedrawViewports)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOutSelectionChanged;

				*(bool*)(__InBuffer + 9) = bOutActorModified;

				*(bool*)(__InBuffer + 10) = bNotifySelectionChange;

				*(bool*)(__InBuffer + 11) = bRedrawViewports;

				var __OutBuffer = stackalloc byte[2];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __UpdateActorVisibility, __InBuffer, __OutBuffer, __ReturnBuffer);

				bOutSelectionChanged = *(bool*)(__OutBuffer);

				bOutActorModified = *(bool*)(__OutBuffer + 1);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actor">
		/// Actor to update
		/// </param>
		public virtual void UpdateActorAllViewsVisibility(AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UpdateActorAllViewsVisibility, __InBuffer);
			}
		}

		/// <param name="LayerName">
		/// The name of the layer whose ULayer Object to retrieve
		/// </param>
		/// <param name="OutLayer">
		/// [OUT] 	Set to the ULayer Object of the named layer. Set to Invalid if no ULayer Object exists.
		/// </param>
		/// <returns>
		/// If true a valid ULayer Object was found and set to OutLayer; if false, a valid ULayer object was not found and invalid set to OutLayer
		/// </returns>
		public virtual bool TryGetLayer(FName LayerName, ref ULayer OutLayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = LayerName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutLayer?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __TryGetLayer, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutLayer = *(ULayer*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="LayerName">
		/// The name of the layer to affect
		/// </param>
		public virtual void ToggleLayerVisibility(FName LayerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LayerName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ToggleLayerVisibility, __InBuffer);
			}
		}

		/// <param name="LayerNames">
		/// The names of the layers to affect
		/// </param>
		public virtual void ToggleLayersVisibility(TArray<FName> LayerNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LayerNames?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ToggleLayersVisibility, __InBuffer);
			}
		}

		/// <param name="LayerName">
		/// The name of the layer to affect.
		/// </param>
		/// <param name="bIsVisible">
		/// If true the layer will be visible; if false, the layer will not be visible.
		/// </param>
		public virtual void SetLayerVisibility(FName LayerName, bool bIsVisible)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = LayerName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsVisible;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLayerVisibility, __InBuffer);
			}
		}

		/// <param name="LayerNames">
		/// The names of the layers to affect
		/// </param>
		/// <param name="bIsVisible">
		/// If true the layers will be visible; if false, the layers will not be visible
		/// </param>
		public virtual void SetLayersVisibility(TArray<FName> LayerNames, bool bIsVisible)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = LayerNames?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsVisible;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLayersVisibility, __InBuffer);
			}
		}

		/// <param name="LayerNames">
		/// A valid list of layer names.
		/// </param>
		/// <param name="bSelect">
		/// If true actors are selected; if false, actors are deselected.
		/// </param>
		/// <param name="bNotify">
		/// If true the Editor is notified of the selection change; if false, the Editor will not be notified
		/// </param>
		/// <param name="bSelectEvenIfHidden">
		/// [optional]	If true even hidden actors will be selected; if false, hidden actors won't be selected.
		/// </param>
		/// <returns>
		/// true if at least one actor was selected/deselected.
		/// </returns>
		public virtual bool SelectActorsInLayers(TArray<FName> LayerNames, bool bSelect, bool bNotify, bool bSelectEvenIfHidden = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = LayerNames?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSelect;

				*(bool*)(__InBuffer + 9) = bNotify;

				*(bool*)(__InBuffer + 10) = bSelectEvenIfHidden;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SelectActorsInLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="LayerName">
		/// A valid layer name.
		/// </param>
		/// <param name="bSelect">
		/// If true actors are selected; if false, actors are deselected.
		/// </param>
		/// <param name="bNotify">
		/// If true the Editor is notified of the selection change; if false, the Editor will not be notified.
		/// </param>
		/// <param name="bSelectEvenIfHidden">
		/// [optional]	If true even hidden actors will be selected; if false, hidden actors won't be selected.
		/// </param>
		/// <returns>
		/// true if at least one actor was selected/deselected.
		/// </returns>
		public virtual bool SelectActorsInLayer(FName LayerName, bool bSelect, bool bNotify, bool bSelectEvenIfHidden = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = LayerName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSelect;

				*(bool*)(__InBuffer + 9) = bNotify;

				*(bool*)(__InBuffer + 10) = bSelectEvenIfHidden;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SelectActorsInLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="OriginalLayerName">
		/// The name of the layer to be renamed
		/// </param>
		/// <param name="NewLayerName">
		/// The new name for the layer to be renamed
		/// </param>
		public virtual bool RenameLayer(FName OriginalLayerName, FName NewLayerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OriginalLayerName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewLayerName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="LayerNames">
		/// A valid list of layer names.
		/// </param>
		/// <returns>
		/// true if at least one actor was removed.
		/// </returns>
		public virtual bool RemoveSelectedActorsFromLayers(TArray<FName> LayerNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LayerNames?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveSelectedActorsFromLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="LayerName">
		/// A layer name.
		/// </param>
		/// <returns>
		/// true if at least one actor was added.  false is returned if all selected actors already belong to the named layer.
		/// </returns>
		public virtual bool RemoveSelectedActorsFromLayer(FName LayerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LayerName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveSelectedActorsFromLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Level">
		/// The process
		/// </param>
		public virtual void RemoveLevelLayerInformation(ULevel Level)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Level?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveLevelLayerInformation, __InBuffer);
			}
		}

		/// <param name="Actors">
		/// The actors to remove to the named layers
		/// </param>
		/// <param name="LayerNames">
		/// A valid list of layer names.
		/// </param>
		/// <returns>
		/// true if at least one actor was removed from at least one layer.  false is returned if none of the actors belonged to any of the specified layers.
		/// </returns>
		public virtual bool RemoveActorsFromLayers(TArray<AActor> Actors, TArray<FName> LayerNames, bool bUpdateStats = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LayerNames?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bUpdateStats;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveActorsFromLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actors">
		/// The actors to remove from the provided layer
		/// </param>
		/// <param name="LayerToRemove">
		/// The name of the layer to remove the actors from
		/// </param>
		/// <returns>
		/// true if at least one actor was removed from the layer.  false is returned if all the actors already belonged to the layer.
		/// </returns>
		public virtual bool RemoveActorsFromLayer(TArray<AActor> Actors, FName LayerName, bool bUpdateStats = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LayerName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bUpdateStats;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveActorsFromLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actor">
		/// The actor to remove from the provided layers
		/// </param>
		/// <param name="LayerNames">
		/// A valid list of layer names.
		/// </param>
		/// <returns>
		/// true if the actor was removed from at least one of the provided layers.
		/// </returns>
		public virtual bool RemoveActorFromLayers(AActor Actor, TArray<FName> LayerNames, bool bUpdateStats = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LayerNames?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bUpdateStats;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveActorFromLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actor">
		/// The actor to remove from the provided layer
		/// </param>
		/// <param name="LayerToRemove">
		/// The name of the layer to remove the actor from
		/// </param>
		/// <returns>
		/// true if the actor was removed from the layer.  false is returned if the actor already belonged to the layer.
		/// </returns>
		public virtual bool RemoveActorFromLayer(AActor Actor, FName LayerToRemove, bool bUpdateStats = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LayerToRemove?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bUpdateStats;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveActorFromLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void MakeAllLayersVisible()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __MakeAllLayersVisible);
			}
		}

		/// <param name="LayerName">
		/// The name of the layer whose ULayer Object to retrieve
		/// </param>
		/// <returns>
		/// If true a valid ULayer Object was found; if false, a valid ULayer object was not found
		/// </returns>
		public virtual bool IsLayer(FName LayerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LayerName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actor">
		/// The actor to validate
		/// </param>
		public virtual bool IsActorValidForLayer(AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsActorValidForLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actor">
		/// The actor to initialize
		/// </param>
		public virtual bool InitializeNewActorLayers(AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __InitializeNewActorLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The UWorld* object
		/// </returns>
		public new UWorld GetWorld()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetWorld, __ReturnBuffer);

				return *(UWorld*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The selected AActor's as a TArray.
		/// </returns>
		public virtual TArray<AActor> GetSelectedActors()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSelectedActors, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		/// <param name="LayerName">
		/// The name of the layer whose ULayer Object is returned
		/// </param>
		/// <returns>
		/// The ULayer Object of the provided layer name
		/// </returns>
		public virtual ULayer GetLayer(FName LayerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LayerName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLayer, __InBuffer, __ReturnBuffer);

				return *(ULayer*)__ReturnBuffer;
			}
		}

		/// <param name="LayerNames">
		/// The layers to find actors for.
		/// </param>
		/// <returns>
		/// The list to assign the found actors to.
		/// </returns>
		public virtual TArray<AActor> GetActorsFromLayers(TArray<FName> LayerNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LayerNames?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetActorsFromLayers, __InBuffer, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		/// <param name="LayerName">
		/// The layer to find actors for.
		/// </param>
		/// <returns>
		/// The list to assign the found actors to.
		/// </returns>
		public virtual TArray<AActor> GetActorsFromLayer(FName LayerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LayerName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetActorsFromLayer, __InBuffer, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		public virtual void EditorRefreshLayerBrowser()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EditorRefreshLayerBrowser);
			}
		}

		public virtual void EditorMapChange()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EditorMapChange);
			}
		}

		/// <param name="Actors">
		/// The actors to disassociate from the layer system
		/// </param>
		public virtual bool DisassociateActorsFromLayers(TArray<AActor> Actors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DisassociateActorsFromLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actor">
		/// The actor to disassociate from the layer system
		/// </param>
		public virtual bool DisassociateActorFromLayers(AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DisassociateActorFromLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="LayersToDelete">
		/// A valid list of layer names.
		/// </param>
		public virtual void DeleteLayers(TArray<FName> LayersToDelete)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LayersToDelete?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DeleteLayers, __InBuffer);
			}
		}

		/// <param name="LayerToDelete">
		/// A valid layer name
		/// </param>
		public virtual void DeleteLayer(FName LayerToDelete)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LayerToDelete?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DeleteLayer, __InBuffer);
			}
		}

		/// <param name="LayerName">
		/// The name of the layer to create
		/// </param>
		/// <returns>
		/// The newly created ULayer Object for the named layer
		/// </returns>
		public virtual ULayer CreateLayer(FName LayerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LayerName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateLayer, __InBuffer, __ReturnBuffer);

				return *(ULayer*)__ReturnBuffer;
			}
		}

		/// <param name="LayerNames">
		/// The layers to find actors for.
		/// </param>
		/// <param name="InOutActors">
		/// The list to append the found actors to.
		/// </param>
		public virtual void AppendActorsFromLayers(TArray<FName> LayerNames, ref TArray<AActor> InOutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = LayerNames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InOutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __AppendActorsFromLayers, __InBuffer, __OutBuffer);

				InOutActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		/// <param name="LayerName">
		/// The layer to find actors for.
		/// </param>
		/// <param name="InOutActors">
		/// The list to append the found actors to.
		/// </param>
		public virtual void AppendActorsFromLayer(FName LayerName, ref TArray<AActor> InOutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = LayerName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InOutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __AppendActorsFromLayer, __InBuffer, __OutBuffer);

				InOutActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		/// <param name="LayerNames">
		/// A valid list of layer names.
		/// </param>
		/// <returns>
		/// true if at least one actor was added.  false is returned if all selected actors already belong to the named layers.
		/// </returns>
		public virtual bool AddSelectedActorsToLayers(TArray<FName> LayerNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LayerNames?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddSelectedActorsToLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="LayerName">
		/// A layer name.
		/// </param>
		/// <returns>
		/// true if at least one actor was added.  false is returned if all selected actors already belong to the named layer.
		/// </returns>
		public virtual bool AddSelectedActorsToLayer(FName LayerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = LayerName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddSelectedActorsToLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Level">
		/// The process
		/// </param>
		public virtual void AddLevelLayerInformation(ULevel Level)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Level?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddLevelLayerInformation, __InBuffer);
			}
		}

		/// <param name="OutLayers">
		/// [OUT] Output array to store all known layers
		/// </param>
		public virtual void AddAllLayersTo(ref TArray<ULayer> OutLayers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutLayers?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __AddAllLayersTo, __InBuffer, __OutBuffer);

				OutLayers = *(TArray<ULayer>*)(__OutBuffer);

			}
		}

		/// <param name="OutLayers">
		/// [OUT] Output array to store all known layers
		/// </param>
		public virtual void AddAllLayerNamesTo(ref TArray<FName> OutLayerNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutLayerNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __AddAllLayerNamesTo, __InBuffer, __OutBuffer);

				OutLayerNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		/// <param name="Actor">
		/// The actor to add to the provided layers
		/// </param>
		/// <param name="LayerNames">
		/// A valid list of layer names.
		/// </param>
		/// <returns>
		/// true if the actor was added to at least one of the provided layers.
		/// </returns>
		public virtual bool AddActorToLayers(AActor Actor, TArray<FName> LayerNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LayerNames?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddActorToLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actor">
		/// The actor to add to the named layer
		/// </param>
		/// <param name="LayerName">
		/// The name of the layer to add the actor to
		/// </param>
		/// <returns>
		/// true if the actor was added.  false is returned if the actor already belongs to the layer.
		/// </returns>
		public virtual bool AddActorToLayer(AActor Actor, FName LayerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LayerName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddActorToLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actors">
		/// The actors to add to the named layers
		/// </param>
		/// <param name="LayerNames">
		/// A valid list of layer names.
		/// </param>
		/// <returns>
		/// true if at least one actor was added to at least one layer.  false is returned if all the actors already belonged to all specified layers.
		/// </returns>
		public virtual bool AddActorsToLayers(TArray<AActor> Actors, TArray<FName> LayerNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LayerNames?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddActorsToLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actors">
		/// The actors to add to the named layer
		/// </param>
		/// <param name="LayerName">
		/// The name of the layer to add to
		/// </param>
		/// <returns>
		/// true if at least one actor was added to the layer.  false is returned if all the actors already belonged to the layer.
		/// </returns>
		public virtual bool AddActorsToLayer(TArray<AActor> Actors, FName LayerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = LayerName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddActorsToLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __UpdateAllViewVisibility = 0;

		private static uint __UpdateAllActorsVisibility = 0;

		private static uint __UpdateActorVisibility = 0;

		private static uint __UpdateActorAllViewsVisibility = 0;

		private static uint __TryGetLayer = 0;

		private static uint __ToggleLayerVisibility = 0;

		private static uint __ToggleLayersVisibility = 0;

		private static uint __SetLayerVisibility = 0;

		private static uint __SetLayersVisibility = 0;

		private static uint __SelectActorsInLayers = 0;

		private static uint __SelectActorsInLayer = 0;

		private static uint __RenameLayer = 0;

		private static uint __RemoveSelectedActorsFromLayers = 0;

		private static uint __RemoveSelectedActorsFromLayer = 0;

		private static uint __RemoveLevelLayerInformation = 0;

		private static uint __RemoveActorsFromLayers = 0;

		private static uint __RemoveActorsFromLayer = 0;

		private static uint __RemoveActorFromLayers = 0;

		private static uint __RemoveActorFromLayer = 0;

		private static uint __MakeAllLayersVisible = 0;

		private static uint __IsLayer = 0;

		private static uint __IsActorValidForLayer = 0;

		private static uint __InitializeNewActorLayers = 0;

		private static uint __GetWorld = 0;

		private static uint __GetSelectedActors = 0;

		private static uint __GetLayer = 0;

		private static uint __GetActorsFromLayers = 0;

		private static uint __GetActorsFromLayer = 0;

		private static uint __EditorRefreshLayerBrowser = 0;

		private static uint __EditorMapChange = 0;

		private static uint __DisassociateActorsFromLayers = 0;

		private static uint __DisassociateActorFromLayers = 0;

		private static uint __DeleteLayers = 0;

		private static uint __DeleteLayer = 0;

		private static uint __CreateLayer = 0;

		private static uint __AppendActorsFromLayers = 0;

		private static uint __AppendActorsFromLayer = 0;

		private static uint __AddSelectedActorsToLayers = 0;

		private static uint __AddSelectedActorsToLayer = 0;

		private static uint __AddLevelLayerInformation = 0;

		private static uint __AddAllLayersTo = 0;

		private static uint __AddAllLayerNamesTo = 0;

		private static uint __AddActorToLayers = 0;

		private static uint __AddActorToLayer = 0;

		private static uint __AddActorsToLayers = 0;

		private static uint __AddActorsToLayer = 0;
	}
}