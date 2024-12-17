using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.WidgetAnimation")]
	public partial class UWidgetAnimation : UMovieSceneSequence, IStaticClass
	{
		public UMovieScene MovieScene
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MovieScene, __ReturnBuffer);

					return *(UMovieScene*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MovieScene, __InBuffer);
				}
			}
		}

		public TArray<FWidgetAnimationBinding> AnimationBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationBindings, __ReturnBuffer);

					return *(TArray<FWidgetAnimationBinding>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationBindings, __InBuffer);
				}
			}
		}

		public bool bLegacyFinishOnStop
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bLegacyFinishOnStop, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bLegacyFinishOnStop, __InBuffer);
				}
			}
		}

		public FString DisplayLabel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DisplayLabel, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DisplayLabel, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.WidgetAnimation");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UnbindFromAnimationStarted(UUserWidget Widget, FWidgetAnimationDynamicEvent Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnbindFromAnimationStarted, __InBuffer);
			}
		}

		public virtual void UnbindFromAnimationFinished(UUserWidget Widget, FWidgetAnimationDynamicEvent Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnbindFromAnimationFinished, __InBuffer);
			}
		}

		public virtual void UnbindAllFromAnimationStarted(UUserWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnbindAllFromAnimationStarted, __InBuffer);
			}
		}

		public virtual void UnbindAllFromAnimationFinished(UUserWidget Widget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnbindAllFromAnimationFinished, __InBuffer);
			}
		}

		/// <see>
		/// GetEndTime
		/// </see>
		/// <returns>
		/// Start time in seconds.
		/// </returns>
		public virtual float GetStartTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetStartTime, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <see>
		/// GetStartTime
		/// </see>
		/// <returns>
		/// End time in seconds.
		/// </returns>
		public virtual float GetEndTime()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetEndTime, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual void BindToAnimationStarted(UUserWidget Widget, FWidgetAnimationDynamicEvent Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BindToAnimationStarted, __InBuffer);
			}
		}

		public virtual void BindToAnimationFinished(UUserWidget Widget, FWidgetAnimationDynamicEvent Delegate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Widget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Delegate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BindToAnimationFinished, __InBuffer);
			}
		}

		private static uint __MovieScene = 0;

		private static uint __AnimationBindings = 0;

		private static uint __bLegacyFinishOnStop = 0;

		private static uint __DisplayLabel = 0;

		private static uint __UnbindFromAnimationStarted = 0;

		private static uint __UnbindFromAnimationFinished = 0;

		private static uint __UnbindAllFromAnimationStarted = 0;

		private static uint __UnbindAllFromAnimationFinished = 0;

		private static uint __GetStartTime = 0;

		private static uint __GetEndTime = 0;

		private static uint __BindToAnimationStarted = 0;

		private static uint __BindToAnimationFinished = 0;
	}
}