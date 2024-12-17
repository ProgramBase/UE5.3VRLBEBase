using Script.CoreUObject;
using Script.Library;

namespace Script.SequenceRecorder
{
	[PathName("/Script/SequenceRecorder.MovieScene3DTransformSectionRecorderSettings")]
	public partial class UMovieScene3DTransformSectionRecorderSettings : UObject, IStaticClass
	{
		public bool bRecordTransforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRecordTransforms, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRecordTransforms, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequenceRecorder.MovieScene3DTransformSectionRecorderSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bRecordTransforms = 0;
	}
}