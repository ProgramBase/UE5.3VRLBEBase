using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.UMGSequencePlayer")]
	public partial class UUMGSequencePlayer : UObject, IStaticClass
	{
		public UWidgetAnimation Animation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Animation, __ReturnBuffer);

					return *(UWidgetAnimation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Animation, __InBuffer);
				}
			}
		}

		public FMovieSceneRootEvaluationTemplateInstance RootTemplateInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RootTemplateInstance, __ReturnBuffer);

					return *(FMovieSceneRootEvaluationTemplateInstance*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RootTemplateInstance, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.UMGSequencePlayer");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetUserTag(FName InUserTag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InUserTag?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetUserTag, __InBuffer);
			}
		}

		/// <returns>
		/// </returns>
		public virtual FName GetUserTag()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetUserTag, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		private static uint __Animation = 0;

		private static uint __RootTemplateInstance = 0;

		private static uint __SetUserTag = 0;

		private static uint __GetUserTag = 0;
	}
}