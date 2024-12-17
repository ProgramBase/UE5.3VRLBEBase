using Script.CoreUObject;
using Script.Library;

namespace Script.SequenceRecorderSections
{
	[PathName("/Script/SequenceRecorderSections.MovieSceneVisibilitySectionRecorderSettings")]
	public partial class UMovieSceneVisibilitySectionRecorderSettings : UObject, IStaticClass
	{
		public bool bRecordVisibility
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRecordVisibility, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRecordVisibility, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequenceRecorderSections.MovieSceneVisibilitySectionRecorderSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bRecordVisibility = 0;
	}
}