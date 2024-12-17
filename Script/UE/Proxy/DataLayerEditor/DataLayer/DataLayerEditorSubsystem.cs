using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;
using Script.Engine;

namespace Script.DataLayerEditor
{
	[PathName("/Script/DataLayerEditor.DataLayerEditorSubsystem")]
	public partial class UDataLayerEditorSubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DataLayerEditor.DataLayerEditorSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UpdateAllViewVisibility(UDEPRECATED_DataLayer DataLayerThatChanged)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DataLayerThatChanged?.GarbageCollectionHandle ?? nint.Zero;

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

		public virtual void UpdateActorAllViewsVisibility(AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UpdateActorAllViewsVisibility, __InBuffer);
			}
		}

		/// <param name="DataLayer">
		/// The DataLayer to affect
		/// </param>
		public virtual void ToggleDataLayerVisibility(UDataLayerInstance DataLayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ToggleDataLayerVisibility, __InBuffer);
			}
		}

		/// <param name="DataLayers">
		/// The DataLayers to affect
		/// </param>
		public virtual void ToggleDataLayersVisibility(TArray<UDataLayerInstance> DataLayers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DataLayers?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ToggleDataLayersVisibility, __InBuffer);
			}
		}

		/// <param name="DataLayers">
		/// The DataLayers to affect
		/// </param>
		/// <param name="bIsFromUserChange">
		/// If this change originates from a user change or not.
		/// </param>
		public virtual bool ToggleDataLayersIsLoadedInEditor(TArray<UDataLayerInstance> DataLayers, bool bIsFromUserChange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = DataLayers?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsFromUserChange;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ToggleDataLayersIsLoadedInEditor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool ToggleDataLayersIsDynamicallyLoadedInEditor(TArray<UDEPRECATED_DataLayer> DataLayers, bool bIsFromUserChange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = DataLayers?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsFromUserChange;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ToggleDataLayersIsDynamicallyLoadedInEditor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DataLayer">
		/// The DataLayer to affect
		/// </param>
		/// <param name="bIsFromUserChange">
		/// If this change originates from a user change or not.
		/// </param>
		public virtual bool ToggleDataLayerIsLoadedInEditor(UDataLayerInstance DataLayer, bool bIsFromUserChange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsFromUserChange;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ToggleDataLayerIsLoadedInEditor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool ToggleDataLayerIsDynamicallyLoadedInEditor(UDEPRECATED_DataLayer DataLayer, bool bIsFromUserChange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsFromUserChange;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ToggleDataLayerIsDynamicallyLoadedInEditor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DataLayer">
		/// The child DataLayer.
		/// </param>
		/// <param name="ParentDataLayer">
		/// The parent DataLayer.
		/// </param>
		/// <returns>
		/// true if succeeded, false if failed.
		/// </returns>
		public virtual bool SetParentDataLayer(UDataLayerInstance DataLayer, UDataLayerInstance ParentDataLayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParentDataLayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetParentDataLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DataLayer">
		/// The DataLayer to affect.
		/// </param>
		/// <param name="bIsVisible">
		/// If true the DataLayer will be visible; if false, the DataLayer will not be visible.
		/// </param>
		public virtual void SetDataLayerVisibility(UDataLayerInstance DataLayer, bool bIsVisible)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsVisible;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDataLayerVisibility, __InBuffer);
			}
		}

		/// <param name="DataLayers">
		/// The DataLayers to affect
		/// </param>
		/// <param name="bIsVisible">
		/// If true the DataLayers will be visible; if false, the DataLayers will not be visible
		/// </param>
		public virtual void SetDataLayersVisibility(TArray<UDataLayerInstance> DataLayers, bool bIsVisible)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = DataLayers?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsVisible;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDataLayersVisibility, __InBuffer);
			}
		}

		/// <param name="DataLayers">
		/// The DataLayers to affect
		/// </param>
		/// <param name="bIsLoadedInEditor">
		/// The new value of the flag IsLoadedInEditor.
		/// If True, the Editor loading will consider this DataLayer to load or not an Actor part of this DataLayer.
		/// An Actor will not be loaded in the Editor if all its DataLayers are not LoadedInEditor.
		/// </param>
		/// <param name="bIsFromUserChange">
		/// If this change originates from a user change or not.
		/// </param>
		public virtual bool SetDataLayersIsLoadedInEditor(TArray<UDataLayerInstance> DataLayers, bool bIsLoadedInEditor, bool bIsFromUserChange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = DataLayers?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsLoadedInEditor;

				*(bool*)(__InBuffer + 9) = bIsFromUserChange;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetDataLayersIsLoadedInEditor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetDataLayersIsDynamicallyLoadedInEditor(TArray<UDEPRECATED_DataLayer> DataLayers, bool bIsLoadedInEditor, bool bIsFromUserChange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = DataLayers?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsLoadedInEditor;

				*(bool*)(__InBuffer + 9) = bIsFromUserChange;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetDataLayersIsDynamicallyLoadedInEditor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DataLayer">
		/// The DataLayer to affect.
		/// </param>
		/// <param name="bIsLoadedInEditor">
		/// The new value of the flag IsLoadedInEditor.
		/// If True, the Editor loading will consider this DataLayer to load or not an Actor part of this DataLayer.
		/// An Actor will not be loaded in the Editor if all its DataLayers are not LoadedInEditor.
		/// </param>
		/// <param name="bIsFromUserChange">
		/// If this change originates from a user change or not.
		/// </param>
		public virtual bool SetDataLayerIsLoadedInEditor(UDataLayerInstance DataLayer, bool bIsLoadedInEditor, bool bIsFromUserChange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsLoadedInEditor;

				*(bool*)(__InBuffer + 9) = bIsFromUserChange;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetDataLayerIsLoadedInEditor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetDataLayerIsDynamicallyLoadedInEditor(UDEPRECATED_DataLayer DataLayer, bool bIsLoadedInEditor, bool bIsFromUserChange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bIsLoadedInEditor;

				*(bool*)(__InBuffer + 9) = bIsFromUserChange;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetDataLayerIsDynamicallyLoadedInEditor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DataLayers">
		/// A valid list of DataLayers.
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
		public virtual bool SelectActorsInDataLayers(TArray<UDataLayerInstance> DataLayers, bool bSelect, bool bNotify, bool bSelectEvenIfHidden = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = DataLayers?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSelect;

				*(bool*)(__InBuffer + 9) = bNotify;

				*(bool*)(__InBuffer + 10) = bSelectEvenIfHidden;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SelectActorsInDataLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DataLayer">
		/// A valid DataLayer.
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
		public virtual bool SelectActorsInDataLayer(UDataLayerInstance DataLayer, bool bSelect, bool bNotify, bool bSelectEvenIfHidden = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSelect;

				*(bool*)(__InBuffer + 9) = bNotify;

				*(bool*)(__InBuffer + 10) = bSelectEvenIfHidden;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SelectActorsInDataLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RenameDataLayer(UDataLayerInstance DataLayer, FName NewDataLayerLabel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewDataLayerLabel?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameDataLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DataLayers">
		/// A valid list of DataLayers.
		/// </param>
		/// <returns>
		/// true if at least one actor was removed.
		/// </returns>
		public virtual bool RemoveSelectedActorsFromDataLayers(TArray<UDataLayerInstance> DataLayers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DataLayers?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveSelectedActorsFromDataLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DataLayer">
		/// A DataLayer.
		/// </param>
		/// <returns>
		/// true if at least one actor was added.  false is returned if all selected actors already belong to the DataLayer.
		/// </returns>
		public virtual bool RemoveSelectedActorsFromDataLayer(UDataLayerInstance DataLayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveSelectedActorsFromDataLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actors">
		/// The actors to remove to the DataLayers
		/// </param>
		/// <param name="DataLayers">
		/// A valid list of DataLayers.
		/// </param>
		/// <returns>
		/// true if at least one actor was removed from at least one DataLayer.  false is returned if none of the actors belonged to any of the specified DataLayers.
		/// </returns>
		public virtual bool RemoveActorsFromDataLayers(TArray<AActor> Actors, TArray<UDataLayerInstance> DataLayers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DataLayers?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveActorsFromDataLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actors">
		/// The actors to remove from the provided DataLayer
		/// </param>
		/// <param name="DataLayerToRemove">
		/// The DataLayer to remove the actors from
		/// </param>
		/// <returns>
		/// true if at least one actor was removed from the DataLayer.  false is returned if all the actors already belonged to the DataLayer.
		/// </returns>
		public virtual bool RemoveActorsFromDataLayer(TArray<AActor> Actors, UDataLayerInstance DataLayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveActorsFromDataLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actor">
		/// The actors to modify
		/// </param>
		/// <returns>
		/// true if any actor was changed.
		/// </returns>
		public virtual bool RemoveActorsFromAllDataLayers(TArray<AActor> Actors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveActorsFromAllDataLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actor">
		/// The actor to remove from the provided DataLayers
		/// </param>
		/// <param name="DataLayers">
		/// A valid list of DataLayers.
		/// </param>
		/// <returns>
		/// true if the actor was removed from at least one of the provided DataLayers.
		/// </returns>
		public virtual bool RemoveActorFromDataLayers(AActor Actor, TArray<UDataLayerInstance> DataLayers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DataLayers?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveActorFromDataLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actor">
		/// The actor to remove from the provided DataLayer
		/// </param>
		/// <param name="DataLayerToRemove">
		/// The DataLayer to remove the actor from
		/// </param>
		/// <returns>
		/// true if the actor was removed from the DataLayer.  false is returned if the actor already belonged to the DataLayer.
		/// </returns>
		public virtual bool RemoveActorFromDataLayer(AActor Actor, UDataLayerInstance DataLayerToRemove)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DataLayerToRemove?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveActorFromDataLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actor">
		/// The actor to modify
		/// </param>
		/// <returns>
		/// true if the actor was changed.
		/// </returns>
		public virtual bool RemoveActorFromAllDataLayers(AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveActorFromAllDataLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void MakeAllDataLayersVisible()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __MakeAllDataLayersVisible);
			}
		}

		/// <param name="Actor">
		/// The actor to validate
		/// </param>
		public virtual bool IsActorValidForDataLayer(AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsActorValidForDataLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DataLayerAssets">
		/// The array of DataLayerAssets associated to UDataLayerInstances
		/// </param>
		/// <returns>
		/// The array of UDataLayerInstances corresponding to a DataLayerAsset in the DataLayerAssets array
		/// </returns>
		public virtual TArray<UDataLayerInstance> GetDataLayerInstances(TArray<UDataLayerAsset> DataLayerAssets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DataLayerAssets?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDataLayerInstances, __InBuffer, __ReturnBuffer);

				return *(TArray<UDataLayerInstance>*)__ReturnBuffer;
			}
		}

		/// <param name="DataLayerAsset">
		/// The DataLayerAsset associated to the UDataLayerInstance
		/// </param>
		/// <returns>
		/// The UDataLayerInstance of the provided DataLayerAsset
		/// </returns>
		public virtual UDataLayerInstance GetDataLayerInstance(UDataLayerAsset DataLayerAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DataLayerAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDataLayerInstance, __InBuffer, __ReturnBuffer);

				return *(UDataLayerInstance*)__ReturnBuffer;
			}
		}

		public virtual UDataLayerInstance GetDataLayerFromLabel(FName DataLayerLabel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DataLayerLabel?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDataLayerFromLabel, __InBuffer, __ReturnBuffer);

				return *(UDataLayerInstance*)__ReturnBuffer;
			}
		}

		public virtual UDataLayerInstance GetDataLayer(FActorDataLayer ActorDataLayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActorDataLayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDataLayer, __InBuffer, __ReturnBuffer);

				return *(UDataLayerInstance*)__ReturnBuffer;
			}
		}

		public virtual TArray<UDataLayerInstance> GetAllDataLayers()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAllDataLayers, __ReturnBuffer);

				return *(TArray<UDataLayerInstance>*)__ReturnBuffer;
			}
		}

		/// <param name="DataLayers">
		/// The DataLayers to find actors for.
		/// </param>
		/// <returns>
		/// The list to assign the found actors to.
		/// </returns>
		public virtual TArray<AActor> GetActorsFromDataLayers(TArray<UDataLayerInstance> DataLayers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DataLayers?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetActorsFromDataLayers, __InBuffer, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		/// <param name="DataLayer">
		/// The DataLayer to find actors for.
		/// </param>
		/// <returns>
		/// The list to assign the found actors to.
		/// </returns>
		public virtual TArray<AActor> GetActorsFromDataLayer(UDataLayerInstance DataLayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetActorsFromDataLayer, __InBuffer, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		/// <param name="DataLayersToDelete">
		/// A valid list of DataLayer.
		/// </param>
		public virtual void DeleteDataLayers(TArray<UDataLayerInstance> DataLayersToDelete)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DataLayersToDelete?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DeleteDataLayers, __InBuffer);
			}
		}

		/// <param name="DataLayerToDelete">
		/// A valid DataLayer
		/// </param>
		public virtual void DeleteDataLayer(UDataLayerInstance DataLayerToDelete)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DataLayerToDelete?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DeleteDataLayer, __InBuffer);
			}
		}

		/// <param name="Parameters">
		/// The Data Layer Instance creation parameters
		/// </param>
		/// <returns>
		/// The newly created UDataLayerInstance Object
		/// </returns>
		public virtual UDataLayerInstance CreateDataLayerInstance(FDataLayerCreationParameters Parameters)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Parameters?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateDataLayerInstance, __InBuffer, __ReturnBuffer);

				return *(UDataLayerInstance*)__ReturnBuffer;
			}
		}

		public virtual UDataLayerInstance CreateDataLayer(UDataLayerInstance ParentDataLayer = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ParentDataLayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __CreateDataLayer, __InBuffer, __ReturnBuffer);

				return *(UDataLayerInstance*)__ReturnBuffer;
			}
		}

		/// <param name="DataLayers">
		/// The DataLayers to find actors for.
		/// </param>
		/// <param name="InOutActors">
		/// The list to append the found actors to.
		/// </param>
		public virtual void AppendActorsFromDataLayers(TArray<UDataLayerInstance> DataLayers, ref TArray<AActor> InOutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = DataLayers?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InOutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __AppendActorsFromDataLayers, __InBuffer, __OutBuffer);

				InOutActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		/// <param name="DataLayer">
		/// The DataLayer to find actors for.
		/// </param>
		/// <param name="InOutActors">
		/// The list to append the found actors to.
		/// </param>
		public virtual void AppendActorsFromDataLayer(UDataLayerInstance DataLayer, ref TArray<AActor> InOutActors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InOutActors?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __AppendActorsFromDataLayer, __InBuffer, __OutBuffer);

				InOutActors = *(TArray<AActor>*)(__OutBuffer);

			}
		}

		/// <param name="DataLayers">
		/// A valid list of DataLayers.
		/// </param>
		/// <returns>
		/// true if at least one actor was added.  false is returned if all selected actors already belong to the DataLayers.
		/// </returns>
		public virtual bool AddSelectedActorsToDataLayers(TArray<UDataLayerInstance> DataLayers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DataLayers?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddSelectedActorsToDataLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="DataLayer">
		/// A DataLayer.
		/// </param>
		/// <returns>
		/// true if at least one actor was added.  false is returned if all selected actors already belong to the DataLayer.
		/// </returns>
		public virtual bool AddSelectedActorsToDataLayer(UDataLayerInstance DataLayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddSelectedActorsToDataLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actor">
		/// The actor to add to the provided DataLayers
		/// </param>
		/// <param name="DataLayers">
		/// A valid list of DataLayers.
		/// </param>
		/// <returns>
		/// true if the actor was added to at least one of the provided DataLayers.
		/// </returns>
		public virtual bool AddActorToDataLayers(AActor Actor, TArray<UDataLayerInstance> DataLayers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DataLayers?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddActorToDataLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actor">
		/// The actor to add to the DataLayer
		/// </param>
		/// <param name="DataLayer">
		/// The DataLayer to add the actor to
		/// </param>
		/// <returns>
		/// true if the actor was added.  false is returned if the actor already belongs to the DataLayer.
		/// </returns>
		public virtual bool AddActorToDataLayer(AActor Actor, UDataLayerInstance DataLayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddActorToDataLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actors">
		/// The actors to add to the DataLayers
		/// </param>
		/// <param name="DataLayers">
		/// A valid list of DataLayers.
		/// </param>
		/// <returns>
		/// true if at least one actor was added to at least one DataLayer.  false is returned if all the actors already belonged to all specified DataLayers.
		/// </returns>
		public virtual bool AddActorsToDataLayers(TArray<AActor> Actors, TArray<UDataLayerInstance> DataLayers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DataLayers?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddActorsToDataLayers, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Actors">
		/// The actors to add to the DataLayer
		/// </param>
		/// <param name="DataLayer">
		/// The DataLayer to add to
		/// </param>
		/// <returns>
		/// true if at least one actor was added to the DataLayer.  false is returned if all the actors already belonged to the DataLayer.
		/// </returns>
		public virtual bool AddActorsToDataLayer(TArray<AActor> Actors, UDataLayerInstance DataLayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DataLayer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddActorsToDataLayer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __UpdateAllViewVisibility = 0;

		private static uint __UpdateAllActorsVisibility = 0;

		private static uint __UpdateActorVisibility = 0;

		private static uint __UpdateActorAllViewsVisibility = 0;

		private static uint __ToggleDataLayerVisibility = 0;

		private static uint __ToggleDataLayersVisibility = 0;

		private static uint __ToggleDataLayersIsLoadedInEditor = 0;

		private static uint __ToggleDataLayersIsDynamicallyLoadedInEditor = 0;

		private static uint __ToggleDataLayerIsLoadedInEditor = 0;

		private static uint __ToggleDataLayerIsDynamicallyLoadedInEditor = 0;

		private static uint __SetParentDataLayer = 0;

		private static uint __SetDataLayerVisibility = 0;

		private static uint __SetDataLayersVisibility = 0;

		private static uint __SetDataLayersIsLoadedInEditor = 0;

		private static uint __SetDataLayersIsDynamicallyLoadedInEditor = 0;

		private static uint __SetDataLayerIsLoadedInEditor = 0;

		private static uint __SetDataLayerIsDynamicallyLoadedInEditor = 0;

		private static uint __SelectActorsInDataLayers = 0;

		private static uint __SelectActorsInDataLayer = 0;

		private static uint __RenameDataLayer = 0;

		private static uint __RemoveSelectedActorsFromDataLayers = 0;

		private static uint __RemoveSelectedActorsFromDataLayer = 0;

		private static uint __RemoveActorsFromDataLayers = 0;

		private static uint __RemoveActorsFromDataLayer = 0;

		private static uint __RemoveActorsFromAllDataLayers = 0;

		private static uint __RemoveActorFromDataLayers = 0;

		private static uint __RemoveActorFromDataLayer = 0;

		private static uint __RemoveActorFromAllDataLayers = 0;

		private static uint __MakeAllDataLayersVisible = 0;

		private static uint __IsActorValidForDataLayer = 0;

		private static uint __GetDataLayerInstances = 0;

		private static uint __GetDataLayerInstance = 0;

		private static uint __GetDataLayerFromLabel = 0;

		private static uint __GetDataLayer = 0;

		private static uint __GetAllDataLayers = 0;

		private static uint __GetActorsFromDataLayers = 0;

		private static uint __GetActorsFromDataLayer = 0;

		private static uint __DeleteDataLayers = 0;

		private static uint __DeleteDataLayer = 0;

		private static uint __CreateDataLayerInstance = 0;

		private static uint __CreateDataLayer = 0;

		private static uint __AppendActorsFromDataLayers = 0;

		private static uint __AppendActorsFromDataLayer = 0;

		private static uint __AddSelectedActorsToDataLayers = 0;

		private static uint __AddSelectedActorsToDataLayer = 0;

		private static uint __AddActorToDataLayers = 0;

		private static uint __AddActorToDataLayer = 0;

		private static uint __AddActorsToDataLayers = 0;

		private static uint __AddActorsToDataLayer = 0;
	}
}