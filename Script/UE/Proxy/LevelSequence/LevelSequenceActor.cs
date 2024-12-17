using Script.CoreUObject;
using Script.Engine;
using Script.MovieScene;
using Script.Library;

namespace Script.LevelSequence
{
	[PathName("/Script/LevelSequence.LevelSequenceActor")]
	public partial class ALevelSequenceActor : AActor, IStaticClass, IMovieScenePlaybackClient, IMovieSceneBindingOwnerInterface, IWorldPartitionObjectResolver
	{
		public FMovieSceneSequencePlaybackSettings PlaybackSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlaybackSettings, __ReturnBuffer);

					return *(FMovieSceneSequencePlaybackSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlaybackSettings, __InBuffer);
				}
			}
		}

		public ULevelSequencePlayer SequencePlayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SequencePlayer, __ReturnBuffer);

					return *(ULevelSequencePlayer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SequencePlayer, __InBuffer);
				}
			}
		}

		public ULevelSequence LevelSequenceAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LevelSequenceAsset, __ReturnBuffer);

					return *(ULevelSequence*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LevelSequenceAsset, __InBuffer);
				}
			}
		}

		public FLevelSequenceCameraSettings CameraSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CameraSettings, __ReturnBuffer);

					return *(FLevelSequenceCameraSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CameraSettings, __InBuffer);
				}
			}
		}

		public ULevelSequenceBurnInOptions BurnInOptions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BurnInOptions, __ReturnBuffer);

					return *(ULevelSequenceBurnInOptions*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BurnInOptions, __InBuffer);
				}
			}
		}

		public UMovieSceneBindingOverrides BindingOverrides
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BindingOverrides, __ReturnBuffer);

					return *(UMovieSceneBindingOverrides*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BindingOverrides, __InBuffer);
				}
			}
		}

		public bool bOverrideInstanceData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideInstanceData, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideInstanceData, __InBuffer);
				}
			}
		}

		public bool bReplicatePlayback
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReplicatePlayback, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReplicatePlayback, __InBuffer);
				}
			}
		}

		public UObject DefaultInstanceData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultInstanceData, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultInstanceData, __InBuffer);
				}
			}
		}

		public ULevelSequenceBurnIn BurnInInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BurnInInstance, __ReturnBuffer);

					return *(ULevelSequenceBurnIn*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BurnInInstance, __InBuffer);
				}
			}
		}

		public bool bShowBurnin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowBurnin, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowBurnin, __InBuffer);
				}
			}
		}

		public FWorldPartitionResolveData WorldPartitionResolveData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WorldPartitionResolveData, __ReturnBuffer);

					return *(FWorldPartitionResolveData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WorldPartitionResolveData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelSequence.LevelSequenceActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual void ShowBurnin()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ShowBurnin);
			}
		}

		/// <param name="InSequence">
		/// The sequence object to set.
		/// </param>
		/// <see>
		/// GetSequence
		/// </see>
		public virtual void SetSequence(ULevelSequence InSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSequence, __InBuffer);
			}
		}

		public virtual void SetReplicatePlayback(bool ReplicatePlayback)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = ReplicatePlayback;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetReplicatePlayback, __InBuffer);
			}
		}

		/// <param name="BindingTag">
		/// The unique tag name to lookup bindings with
		/// </param>
		/// <param name="Actors">
		/// The actors to assign to all the tagged bindings
		/// </param>
		/// <param name="bAllowBindingsFromAsset">
		/// If false the new bindings being supplied here will replace the bindings set in the level sequence asset, meaning the original object animated by 
		/// Sequencer will no longer be animated. Bindings set to spawnables will not spawn if false. If true, new bindings will be in addition to ones set
		/// set in Sequencer UI. This function will not modify the original asset.
		/// </param>
		public virtual void SetBindingByTag(FName BindingTag, TArray<AActor> Actors, bool bAllowBindingsFromAsset = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = BindingTag?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bAllowBindingsFromAsset;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBindingByTag, __InBuffer);
			}
		}

		/// <param name="Binding">
		/// Binding to modify
		/// </param>
		/// <param name="Actors">
		/// Actors to bind
		/// </param>
		/// <param name="bAllowBindingsFromAsset">
		/// If false the new bindings being supplied here will replace the bindings set in the level sequence asset, meaning the original object animated by 
		/// Sequencer will no longer be animated. Bindings set to spawnables will not spawn if false. If true, new bindings will be in addition to ones set
		/// set in Sequencer UI. This function will not modify the original asset.
		/// </param>
		public virtual void SetBinding(FMovieSceneObjectBindingID Binding, TArray<AActor> Actors, bool bAllowBindingsFromAsset = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Binding?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actors?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bAllowBindingsFromAsset;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBinding, __InBuffer);
			}
		}

		public virtual void ResetBindings()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetBindings);
			}
		}

		public virtual void ResetBinding(FMovieSceneObjectBindingID Binding)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Binding?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResetBinding, __InBuffer);
			}
		}

		public virtual void RemoveBindingByTag(FName Tag, AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveBindingByTag, __InBuffer);
			}
		}

		public virtual void RemoveBinding(FMovieSceneObjectBindingID Binding, AActor Actor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Binding?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveBinding, __InBuffer);
			}
		}

		public virtual void HideBurnin()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __HideBurnin);
			}
		}

		public virtual ULevelSequencePlayer GetSequencePlayer()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSequencePlayer, __ReturnBuffer);

				return *(ULevelSequencePlayer*)__ReturnBuffer;
			}
		}

		/// <see>
		/// SetSequence
		/// </see>
		/// <returns>
		/// Level sequence, or nullptr if not assigned or if it cannot be loaded.
		/// </returns>
		public virtual ULevelSequence GetSequence()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSequence, __ReturnBuffer);

				return *(ULevelSequence*)__ReturnBuffer;
			}
		}

		/// <param name="Tag">
		/// The unique tag name to lookup bindings with. Object Bindings can be tagged within the sequence UI by RMB -> Tags... on the object binding in the tree.
		/// </param>
		/// <returns>
		/// An array containing all the bindings that are tagged with this name, potentially empty.
		/// </returns>
		public virtual TArray<FMovieSceneObjectBindingID> FindNamedBindings(FName Tag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindNamedBindings, __InBuffer, __ReturnBuffer);

				return *(TArray<FMovieSceneObjectBindingID>*)__ReturnBuffer;
			}
		}

		public virtual FMovieSceneObjectBindingID FindNamedBinding(FName Tag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Tag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindNamedBinding, __InBuffer, __ReturnBuffer);

				return *(FMovieSceneObjectBindingID*)__ReturnBuffer;
			}
		}

		/// <param name="BindingTag">
		/// The unique tag name to lookup bindings with
		/// </param>
		/// <param name="Actor">
		/// The actor to assign to all the tagged bindings
		/// </param>
		/// <param name="bAllowBindingsFromAsset">
		/// If false the new bindings being supplied here will replace the bindings set in the level sequence asset, meaning the original object animated by 
		/// Sequencer will no longer be animated. Bindings set to spawnables will not spawn if false. If true, new bindings will be in addition to ones set
		/// set in Sequencer UI. This function will not modify the original asset.
		/// </param>
		public virtual void AddBindingByTag(FName BindingTag, AActor Actor, bool bAllowBindingsFromAsset = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = BindingTag?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bAllowBindingsFromAsset;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddBindingByTag, __InBuffer);
			}
		}

		/// <param name="Binding">
		/// Binding to modify
		/// </param>
		/// <param name="Actor">
		/// Actor to bind
		/// </param>
		/// <param name="bAllowBindingsFromAsset">
		/// If false the new bindings being supplied here will replace the bindings set in the level sequence asset, meaning the original object animated by 
		/// Sequencer will no longer be animated. Bindings set to spawnables will not spawn if false. If true, new bindings will be in addition to ones set
		/// set in Sequencer UI. This function will not modify the original asset.
		/// </param>
		public virtual void AddBinding(FMovieSceneObjectBindingID Binding, AActor Actor, bool bAllowBindingsFromAsset = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Binding?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bAllowBindingsFromAsset;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddBinding, __InBuffer);
			}
		}

		private static uint __PlaybackSettings = 0;

		private static uint __SequencePlayer = 0;

		private static uint __LevelSequenceAsset = 0;

		private static uint __CameraSettings = 0;

		private static uint __BurnInOptions = 0;

		private static uint __BindingOverrides = 0;

		private static uint __bOverrideInstanceData = 0;

		private static uint __bReplicatePlayback = 0;

		private static uint __DefaultInstanceData = 0;

		private static uint __BurnInInstance = 0;

		private static uint __bShowBurnin = 0;

		private static uint __WorldPartitionResolveData = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __ShowBurnin = 0;

		private static uint __SetSequence = 0;

		private static uint __SetReplicatePlayback = 0;

		private static uint __SetBindingByTag = 0;

		private static uint __SetBinding = 0;

		private static uint __ResetBindings = 0;

		private static uint __ResetBinding = 0;

		private static uint __RemoveBindingByTag = 0;

		private static uint __RemoveBinding = 0;

		private static uint __HideBurnin = 0;

		private static uint __GetSequencePlayer = 0;

		private static uint __GetSequence = 0;

		private static uint __FindNamedBindings = 0;

		private static uint __FindNamedBinding = 0;

		private static uint __AddBindingByTag = 0;

		private static uint __AddBinding = 0;
	}
}