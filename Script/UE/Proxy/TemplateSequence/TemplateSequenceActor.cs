using Script.CoreUObject;
using Script.Engine;
using Script.MovieScene;
using Script.Library;

namespace Script.TemplateSequence
{
	[PathName("/Script/TemplateSequence.TemplateSequenceActor")]
	public partial class ATemplateSequenceActor : AActor, IStaticClass, IMovieScenePlaybackClient
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

		public UTemplateSequencePlayer SequencePlayer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SequencePlayer, __ReturnBuffer);

					return *(UTemplateSequencePlayer*)__ReturnBuffer;
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

		public FSoftObjectPath TemplateSequence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TemplateSequence, __ReturnBuffer);

					return *(FSoftObjectPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TemplateSequence, __InBuffer);
				}
			}
		}

		public FTemplateSequenceBindingOverrideData BindingOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BindingOverride, __ReturnBuffer);

					return *(FTemplateSequenceBindingOverrideData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BindingOverride, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequence.TemplateSequenceActor");
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

		public virtual void SetSequence(UTemplateSequence InSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSequence?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSequence, __InBuffer);
			}
		}

		public virtual void SetBinding(AActor Actor, bool bOverridesDefault = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Actor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOverridesDefault;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBinding, __InBuffer);
			}
		}

		/// <returns>
		/// the template sequence, or nullptr if it is not assigned or cannot be loaded
		/// </returns>
		public virtual UTemplateSequence LoadSequence()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __LoadSequence, __ReturnBuffer);

				return *(UTemplateSequence*)__ReturnBuffer;
			}
		}

		public virtual UTemplateSequencePlayer GetSequencePlayer()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSequencePlayer, __ReturnBuffer);

				return *(UTemplateSequencePlayer*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the template sequence, or nullptr if it is not assigned or cannot be loaded
		/// </returns>
		public virtual UTemplateSequence GetSequence()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSequence, __ReturnBuffer);

				return *(UTemplateSequence*)__ReturnBuffer;
			}
		}

		private static uint __PlaybackSettings = 0;

		private static uint __SequencePlayer = 0;

		private static uint __TemplateSequence = 0;

		private static uint __BindingOverride = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetSequence = 0;

		private static uint __SetBinding = 0;

		private static uint __LoadSequence = 0;

		private static uint __GetSequencePlayer = 0;

		private static uint __GetSequence = 0;
	}
}