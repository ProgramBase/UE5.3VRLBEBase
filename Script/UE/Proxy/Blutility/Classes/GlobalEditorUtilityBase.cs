using Script.CoreUObject;
using Script.Library;
using Script.Engine;
using Script.UnrealEd;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.GlobalEditorUtilityBase")]
	public partial class UDEPRECATED_GlobalEditorUtilityBase : UObject, IStaticClass
	{
		public FString HelpText
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HelpText, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HelpText, __InBuffer);
				}
			}
		}

		public bool bDirtiedSelectionSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDirtiedSelectionSet, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDirtiedSelectionSet, __InBuffer);
				}
			}
		}

		public bool bAutoRunDefaultAction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoRunDefaultAction, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoRunDefaultAction, __InBuffer);
				}
			}
		}

		public FForEachActorIteratorSignature OnEachSelectedActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnEachSelectedActor, __ReturnBuffer);

					return *(FForEachActorIteratorSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnEachSelectedActor, __InBuffer);
				}
			}
		}

		public FForEachAssetIteratorSignature OnEachSelectedAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnEachSelectedAsset, __ReturnBuffer);

					return *(FForEachAssetIteratorSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnEachSelectedAsset, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.GlobalEditorUtilityBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetActorSelectionState(AActor Actor, bool bShouldBeSelected)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldBeSelected;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetActorSelectionState, __InBuffer);
			}
		}

		public virtual void SelectNothing()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SelectNothing);
			}
		}

		public virtual void RenameAsset(UObject Asset, FString NewName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Asset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RenameAsset, __InBuffer);
			}
		}

		public virtual void OnDefaultActionClicked()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __OnDefaultActionClicked);
			}
		}

		public virtual TArray<AActor> GetSelectionSet()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSelectionSet, __ReturnBuffer);

				return *(TArray<AActor>*)__ReturnBuffer;
			}
		}

		public virtual void GetSelectionBounds(ref FVector Origin, ref FVector BoxExtent, ref float SphereRadius)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Origin?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoxExtent?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = SphereRadius;

				var __OutBuffer = stackalloc byte[20];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetSelectionBounds, __InBuffer, __OutBuffer);

				Origin = *(FVector*)(__OutBuffer);

				BoxExtent = *(FVector*)(__OutBuffer + 8);

				SphereRadius = *(float*)(__OutBuffer + 16);

			}
		}

		public virtual TArray<UObject> GetSelectedAssets()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSelectedAssets, __ReturnBuffer);

				return *(TArray<UObject>*)__ReturnBuffer;
			}
		}

		public virtual UEditorPerProjectUserSettings GetEditorUserSettings()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetEditorUserSettings, __ReturnBuffer);

				return *(UEditorPerProjectUserSettings*)__ReturnBuffer;
			}
		}

		/// <param name="PathToActor">
		/// The path to the actor (e.g. PersistentLevel.PlayerStart)
		/// </param>
		/// <returns>
		/// A reference to the actor, or none if it wasn't found
		/// </returns>
		public virtual AActor GetActorReference(FString PathToActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PathToActor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetActorReference, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public virtual void ForEachSelectedAsset()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ForEachSelectedAsset);
			}
		}

		public virtual void ForEachSelectedActor()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ForEachSelectedActor);
			}
		}

		public virtual void ClearActorSelectionSet()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearActorSelectionSet);
			}
		}

		private static uint __HelpText = 0;

		private static uint __bDirtiedSelectionSet = 0;

		private static uint __bAutoRunDefaultAction = 0;

		private static uint __OnEachSelectedActor = 0;

		private static uint __OnEachSelectedAsset = 0;

		private static uint __SetActorSelectionState = 0;

		private static uint __SelectNothing = 0;

		private static uint __RenameAsset = 0;

		private static uint __OnDefaultActionClicked = 0;

		private static uint __GetSelectionSet = 0;

		private static uint __GetSelectionBounds = 0;

		private static uint __GetSelectedAssets = 0;

		private static uint __GetEditorUserSettings = 0;

		private static uint __GetActorReference = 0;

		private static uint __ForEachSelectedAsset = 0;

		private static uint __ForEachSelectedActor = 0;

		private static uint __ClearActorSelectionSet = 0;
	}
}